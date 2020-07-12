using AForge;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallGames.NBodySimulation
{
    class Partical
    {
        public long Id;
        public DoublePoint Position;
        /// <summary>
        /// Depending on Visual Size, the Visual position should be adjsuted for Posision.
        /// </summary>
        public double VisualPositionToCenterDifference;
        public long Mass;
        public DoublePoint ForceVector = new DoublePoint(0, 0);
        public DoublePoint VelocityVector = new DoublePoint(0, 0);
        public double VisualSize = 1.5f;
        public long MultipleOfMass = 1;
        public double Density = 22570.0f; // kg/m3
        public double Radius { get; private set; } = 0.001f;

        public Partical(long id, long mass, long multipleOfMass, DoublePoint position, long MassDensity)
        {
            Id = id;
            this.Mass = mass;
            this.MultipleOfMass = multipleOfMass;
            this.Position = position;
            this.Density = MassDensity;

            this.VisualSize = multipleOfMass > 1 ? (double)Math.Sqrt(multipleOfMass + 2.0f) : 1.5f;
            this.VisualPositionToCenterDifference = -VisualSize / 2;
            calculateRadius();
        }

        private void calculateRadius()
        {
            // V = 4/3 * π * r³
            // m / d * 3/4 * 1/Pi
            var r3 = Mass / Density * 3.0 / 4.0 * 1 / Math.PI;
            //Radius = Math.Pow(r3, 1 / 3.0);
            // the radius calculating formula is not correct. 
            // I have decreased the power factor from 1/3.0 to 1/5.50 to make the object more compact as its mass increases.
            Radius = Math.Pow(r3, 1 / 5.50);
        }

        public void InitForceVector()
        {
            ForceVector = new DoublePoint(0, 0);
        }

        public void AddToForceVector(DoublePoint another)
        {
            ForceVector += another;
        }

        public void CalculateNextPosition()
        {
            // calculate the acceleration from mass and force: a = F / m
            var acceleration = ForceVector / (double)Mass;

            // first calculate the final velocity from initial after having the acceleration for one second:
            // vf = vi + a*t when t = 1 then vi + a
            var vf = VelocityVector + acceleration;

            // Final Position (initial positin + distance covered) given the initial and final velocities for a fixed time
            // r = r0 + vi*t + (1/2)*a*t^2 => r = r0 + vi + a/2 when t = 1
            var nPosition = Position + VelocityVector + (acceleration / 2.0f);

            // make final position as the position for display and next calculations
            Position = nPosition;

            // loose some momentum.
            var magnitude = vf.Magnitude();
            //var endMagnitude =  magnitude * 0.9999999999;
            vf = vf.Normalize() * magnitude;

            // make the final velocity as initial velocity for next calculation.
            VelocityVector = vf;
        }

        public Partical MergeWith(Partical partical)
        {
            // The final position of the merged particle will depend on positions and mass of initials particles. 
            var postion = (this.Position * this.MultipleOfMass + partical.Position * partical.MultipleOfMass) / (this.MultipleOfMass + partical.MultipleOfMass);

            var totalMomentum = this.VelocityVector * this.Mass + partical.VelocityVector * partical.Mass;
            var totalMass = this.Mass + partical.Mass;
            var mulitpleMass = this.MultipleOfMass + partical.MultipleOfMass;

            this.Mass = totalMass;
            this.MultipleOfMass = mulitpleMass;
            this.VelocityVector = totalMomentum / totalMass;
            this.Position = postion;
            this.VisualSize = mulitpleMass > 1 ? (double)Math.Sqrt(mulitpleMass + 2.0f) : 1.5f;
            this.VisualPositionToCenterDifference = -VisualSize / 2;
            calculateRadius();

            return this;
        }
    }

    class Pair
    {
        public Partical first;
        public Partical second;

        private double minDistance = 0;
        public Pair(Partical f, Partical s)
        {
            first = f;
            second = s;

            minDistance = f.Radius + s.Radius;
        }
        public bool combine { get; private set; } = false;

        public void CalculateForceVector()
        {
            var secondToFirst = first.Position.DirectionVector(second.Position);
            var firstToSecond = secondToFirst.Reverse();
            var r = first.Position.DistanceBetween(second.Position);
            if (r < minDistance)
            {
                combine = true;
                return;
            }
            // F = G * m1 * m2 / (r*r)
            var force = (double)(Tools.G * first.Mass * second.Mass / (r * r));

            first.AddToForceVector(firstToSecond.Multiply(force));
            second.AddToForceVector(secondToFirst.Multiply(force));
        }
    }
}
