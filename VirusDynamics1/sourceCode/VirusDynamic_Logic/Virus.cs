using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirusDynamic_Logic
{
    public class Virus
    {
        private static Random r = new Random();
        private readonly double cleanProbability;
        private readonly double reproductionProbability;

        public Virus(double cleanProbability, double reproductionProbability)
        {
            this.cleanProbability = cleanProbability;
            this.reproductionProbability = reproductionProbability;
        }

        public Boolean isSurvive()
        {
            //Random r = new Random();
            double randomNumber = r.NextDouble();
            if (randomNumber   <= cleanProbability)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Boolean isReproduce(double occupancyPercentage)
        {
            double reproduceChance = (1 - occupancyPercentage) * reproductionProbability;
            //Random r = new Random();
            double randomNumber = r.NextDouble();
            if (randomNumber <= reproduceChance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double CleanProbability
        {
            get { return cleanProbability; }
        }

        public double ReproductionProbability
        {
            get { return reproductionProbability; }
        }
    }
}
