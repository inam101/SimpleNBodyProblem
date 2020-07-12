using AForge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallGames.NBodySimulation
{
    public class SimulationStartUpData
    {
        public Distribution Distribution;
        public long MaxParticals;
        public long MaxMass;
        public long Width;
        public long Height;
        public long ParticleMassDensity;

        public List<SimParticleData> ParticlesDatas;
    }

    public class SimParticleData
    {
        public DoublePoint position;
        public long Mass;
        public long MultipleOfMass;
    }
}
