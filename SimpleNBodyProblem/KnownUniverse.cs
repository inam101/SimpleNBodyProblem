using AForge;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SmallGames.NBodySimulation
{
    class KnownUniverse
    {
        public List<Partical> AllParticals = new List<Partical>();
        List<Pair> AllPairs = new List<Pair>();

        public long CurrentParticles { get; private set; } = 0;
        public long Width { get; set; } = 300;
        public long Height { get; set; } = 300;

        public long MaxParticals { get; set; } = 30;

        public long MaxMass { get; set; } = 10;
        public Distribution Distribution { get; set; } = new Distribution();

        public long ParticleMassDensity;

        public event EventHandler TwoParticlesMerged;

        public void Init(SimulationStartUpData simData)
        {
            AllParticals = new List<Partical>();

            MaxParticals = simData.MaxParticals;
            MaxMass = simData.MaxMass;
            Width = simData.Width;
            Height = simData.Height;
            Distribution = simData.Distribution;
            ParticleMassDensity = simData.ParticleMassDensity;
            CurrentParticles = MaxParticals;

            populateParticals(simData.ParticlesDatas.ToArray());
        }

        private void populateParticals(SimParticleData[] simParticleData)
        {
            List<long> existingIds = new List<long>();
            for(long i=0; i < simParticleData.Length; i++)
            {
                var id = Tools.GetKindOfUniqueId();
                if (existingIds.Contains(id))
                {
                    i--;
                    continue;
                }
                existingIds.Add(id);
                AllParticals.Add(new Partical(id, simParticleData[i].Mass, simParticleData[i].MultipleOfMass, simParticleData[i].position, ParticleMassDensity));
            }
            MakePairs();
        }

        private void MakePairs()
        {
            AllPairs.Clear();
            var array = AllParticals.ToArray();
            for (long i = 0; i < array.Length; i++)
            {
                for (long j = i + 1; j < array.Length; j++)
                {
                    AllPairs.Add(new Pair (array[i], array[j]));
                }
            }
        }

        public void NextSecond()
        {
            if (AllPairs.Count == 0) return;
            // Recalculate the forces between all particles
            AllParticals.ToList().ForEach(p => p.InitForceVector());
            AllPairs.ToList().ForEach(p => p.CalculateForceVector());

            AllParticals.ToList().ForEach(p => p.CalculateNextPosition());

            var toCombine = AllPairs.ToList().Where(p => p.combine).ToList();
            if (toCombine.Count >= 1)
            {
                var group = toCombine.First();
                AllParticals.Remove(group.first);
                AllParticals.Remove(group.second);
                var remainder = group.first.MergeWith(group.second);
                AllParticals.Add(remainder);
                CurrentParticles--;
                TwoParticlesMerged?.Invoke(this, EventArgs.Empty);
                MakePairs();
            }
            else if (toCombine.Count > 1)
            {
                // it becomes more complex, so I will skip it.
            }
        }

        public DoublePoint ShiftFrameOfReferenceToHeaviestObject()
        {
            var mass = AllParticals.Max(p => p.Mass);
            var heaviest = AllParticals.First(p => p.Mass == mass);
            var velocity = heaviest.VelocityVector.Reverse();
            AllParticals.ToList().ForEach(p => p.VelocityVector += velocity);
            var rPosition = heaviest.Position.Reverse();
            AllParticals.ToList().ForEach(p => p.Position += rPosition);
            return heaviest.Position;
        }
    }
}
