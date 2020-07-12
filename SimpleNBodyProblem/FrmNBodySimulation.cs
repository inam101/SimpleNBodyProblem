using AForge;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallGames.NBodySimulation
{
    public partial class FrmNBodySimulation : Form
    {
        // command for stopping a process running in bg via PowerShell as Admin
        // Stop-Process -id 20396

        private KnownUniverse universe;
        long counting = 0;
        long lastDisplayedCounting = 0;
        long ticked = 0;
        long defaultMass = 0;
        bool IsRunning = false;
        bool IsRefreshing = true;
        double xTranslate = 0;
        double yTranslate = 0;
        double Scaling = 1;
        private SimulationStartUpData simData;
        long timeSpeed = 2;
        bool pauseAtNextMerge = false;
        private bool displaying = false;
        readonly Brush[] massColors = new Brush[] { Brushes.White, Brushes.Green, Brushes.Yellow, Brushes.Red, Brushes.Orange,
            Brushes.LightBlue, Brushes.LightPink, Brushes.LightCyan, Brushes.Gold, Brushes.Purple };

        List<Partical> visibleParticles = new List<Partical>();
        bool pickVisibleParticles = false;

        public FrmNBodySimulation()
        {
            InitializeComponent();


        }

        private void FrmNBodySimulation_Load(object sender, EventArgs e)
        {
            distributionBindingSource.DataSource = Distribution.SomeDistributions();
            cmbDistribution.SelectedIndex = 0;
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            defaultMass = (long)txtbxMass.Value;
            counting = 0;
            ticked = 0;
            xTranslate = 0;
            yTranslate = 0;

            IsRunning = true;
            btnStartStop_Click(sender, e);
            universe = null;


            if (sender != btnInitFromPrev || simData == null)
            {
                simData = new SimulationStartUpData
                {
                    MaxParticals = (long)txtbxNoOfParticals.Value,
                    MaxMass = defaultMass,
                    Width = (long)txtbxUnivWidth.Value,
                    Height = (long)txtbxUnivHeight.Value,
                    ParticleMassDensity = (long)txtbxDensity.Value,
                    Distribution = cmbDistribution.SelectedItem as Distribution
                };

                SetSimParticlesData(simData);
            }

            universe = new KnownUniverse();
            universe.TwoParticlesMerged += Universe_TwoParticlesMerged;
            universe.Init(simData);
            DisplayUniverse(true);
        }

        private void Universe_TwoParticlesMerged(object sender, EventArgs e)
        {
            if (pauseAtNextMerge)
                btnStartStop_Click(this, e);
        }

        private void SetSimParticlesData(SimulationStartUpData simData)
        {
            var allMasses = simData.Distribution.GetDistributionMassValues(simData.MaxParticals, simData.MaxMass, 10).ToArray();
            var minMass = allMasses.Min();
            var positionPoints = simData.Distribution.GetPositionDistributionValues(simData.MaxParticals, simData.Height).ToArray();
            simData.ParticlesDatas = new List<SimParticleData>();
            for (long i = 0; i < simData.MaxParticals; i++)
            {
                simData.ParticlesDatas.Add(new SimParticleData
                { Mass = allMasses[i], MultipleOfMass = allMasses[i] / minMass, position = positionPoints[i] });
            }
        }

        private void DisplayUniverse(bool forced = false)
        {
            if (!forced)
            {
                // don't draw a new display unless the last display is finished.
                if (displaying) return;

                // don't draw a new display unless the particles are processed to the next time.
                if (lastDisplayedCounting == counting) return;
            }

            lastDisplayedCounting = counting;

            displaying = true;

            if (pickVisibleParticles) visibleParticles.Clear();

            var cw = convas.Width;
            var ch = convas.Height;
            Bitmap img = new Bitmap(cw, ch);
            Graphics g = Graphics.FromImage(img);
            g.Clear(Color.Black);

            g.DrawString("Particles: " + universe.CurrentParticles, SystemFonts.DefaultFont, Brushes.White, 10, 10);
            g.DrawString(ticked + "-" + lastDisplayedCounting + " s", SystemFonts.DefaultFont, Brushes.White, 90, 10);

            var current = universe.AllParticals.ToList();
            foreach (var item in current)
            {
                if (item == null) continue;
                var y = (double)((yTranslate + item.Position.Y * Scaling));
                var x = (double)((xTranslate + item.Position.X * Scaling));
                if (x > cw || x < 0 || x < 0 || x > ch) continue;

                if (pickVisibleParticles) visibleParticles.Add(item);
                var sizeIndex = (item.MultipleOfMass) % massColors.Length;
                g.FillEllipse(massColors[sizeIndex], (float)(x + item.VisualPositionToCenterDifference), (float)(y + item.VisualPositionToCenterDifference), (float)item.VisualSize, (float)item.VisualSize);

            }
            convas.Image = img;
            if (pickVisibleParticles)
            {
                lvParticlesData.Items.Clear();
                foreach (var item in visibleParticles)
                {
                    var li = lvParticlesData.Items.Add(item.Id.ToString());
                    li.SubItems.Add(item.VelocityVector.Magnitude().ToString());
                    li.SubItems.Add(item.MultipleOfMass.ToString());
                }
                pickVisibleParticles = false;
            }
            displaying = false;

        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (IsRunning)
            {
                timer1.Enabled = refresher.Enabled = false;
            }
            else
            {
                timer1.Enabled = refresher.Enabled = true;
            }
            IsRunning = !IsRunning;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (universe == null) return;
            Thread th = new Thread(new ThreadStart(() =>
            {
                for (long t = 0; t < timeSpeed; t++)
                {
                    if (universe == null) return;
                    universe.NextSecond();

                    counting++;
                }
                ticked++;
                this.BeginInvoke(new ThreadStart(() => { timer1.Start(); }));
            }
                ));

            th.Start();
        }

        private void refresher_Tick(object sender, EventArgs e)
        {
            if (universe == null || universe.AllParticals.Count == 0) return;
            if (IsRefreshing)
                DisplayUniverse();
        }

        private void btnShiftFrameOfReference_Click(object sender, EventArgs e)
        {
            var beforeTimeSpeed = timeSpeed;
            timeSpeed = 2;
            btnStartStop_Click(sender, e);

            var position = universe.ShiftFrameOfReferenceToHeaviestObject();
            xTranslate = (position.X + (convas.Width / 2));
            yTranslate = (position.Y + (convas.Height / 2));

            btnStartStop_Click(sender, e);
            timeSpeed = beforeTimeSpeed;
        }

        private void chkScreenRefresh_CheckedChanged(object sender, EventArgs e)
        {
            IsRefreshing = !IsRefreshing;
        }

        private void btnZoomOut5x_Click(object sender, EventArgs e)
        {
            Scaling /= 2.0;
        }

        private void btnZoomIn5x_Click(object sender, EventArgs e)
        {
            Scaling *= 2.0;
        }

        private void btnZoomInNormal_Click(object sender, EventArgs e)
        {
            Scaling = 1;
        }

        private void btnZoomOutMax_Click(object sender, EventArgs e)
        {
            if (universe == null) return;
            var xmin = universe.AllParticals.Min(a => a.Position.X);
            var xmax = universe.AllParticals.Max(a => a.Position.X);
            var ymin = universe.AllParticals.Min(a => a.Position.Y);
            var ymax = universe.AllParticals.Max(a => a.Position.Y);

            var xdiff = xmax - xmin;
            var ydiff = ymax - ymin;
            Scaling = universe.Width / Math.Abs(Math.Max(xdiff, ydiff));
            //xTranslate = yTranslate = Math.Min(xmin, ymin);
        }

        private void tbarTimeSpeed_Scroll(object sender, EventArgs e)
        {
            timeSpeed = (long)Math.Pow(2, tbarTimeSpeed.Value);
            lbTimeSpeed.Text = timeSpeed.ToString();
        }

        private void btnExportParams_Click(object sender, EventArgs e)
        {
            SaveFileDialog dg = new SaveFileDialog();
            if (dg.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dg.FileName, JsonConvert.SerializeObject(simData, Formatting.Indented));
            }
        }

        private void btnImportParams_Click(object sender, EventArgs e)
        {
            OpenFileDialog dg = new OpenFileDialog();
            if (dg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    simData = JsonConvert.DeserializeObject<SimulationStartUpData>(File.ReadAllText(dg.FileName));
                    btnInit_Click(btnInitFromPrev, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    simData = null;
                }
            }
        }

        private void chkBxPauseAtNextMerge_CheckedChanged(object sender, EventArgs e)
        {
            pauseAtNextMerge = chkBxPauseAtNextMerge.Checked;
        }

        private void FrmNBodySimulation_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void btnLoadVisibleParticlesData_Click(object sender, EventArgs e)
        {
            pickVisibleParticles = true;
        }

        private void convas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // zoom in on the mouse click position
        }

        private void convas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // zoom out from the mouse click position
            }
            else if (e.Button == MouseButtons.Left)
            {
                xTranslate += (e.Location.X < (convas.Size.Width / 2) ? 10 : -10);
                yTranslate += (e.Location.Y < (convas.Size.Height / 2) ? 10 : -10);
            }
        }

    }
}
