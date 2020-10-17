using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirusDynamic_Logic
{
    public class Virus
    {
        private const int MAX_DRUG_NUMBER = 20;
        private static Random r = new Random();
        private readonly double cleanProbability;
        private readonly double reproductionProbability;
        private readonly double mutationEvolveProbability;
        private bool [] drugResistance;
        private int drugsNumber;

        public Virus(double cleanProbability, double reproductionProbability, double mutationEvolveProbability,int drugsNumber)
        {
            this.cleanProbability = cleanProbability;
            this.reproductionProbability = reproductionProbability;
            this.mutationEvolveProbability = mutationEvolveProbability;
            this.drugResistance = new bool[MAX_DRUG_NUMBER];
            for(int i= 0;i<drugResistance.Length;i++)
            {
                drugResistance[i] = true;
            }
            this.drugsNumber = drugsNumber;
        }

        public Virus(double cleanProbability, double reproductionProbability, double mutationEvolveProbability, bool[] drugResistance , int drugsNumber)
        {
            this.cleanProbability = cleanProbability;
            this.reproductionProbability = reproductionProbability;
            this.mutationEvolveProbability = mutationEvolveProbability;
            this.drugResistance = new bool[MAX_DRUG_NUMBER];
            this.drugResistance = (bool[])drugResistance.Clone();
            this.drugsNumber = drugsNumber;

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
            if (drugResistant())
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
            else
            {
                return false;
            }
        }

        public void developDrugResistant()
        {
            for (int i = 0; i < drugsNumber; i++)
            {
                double randomNumber = r.NextDouble();
                if (randomNumber <= mutationEvolveProbability)
                {
                    drugResistance[i] = !drugResistance[i];
                }
            }
        }

        private bool drugResistant()
        {
            foreach(bool b in drugResistance)
            {
                if (b == false)
                {
                    return false;
                }
            }
            return true;
        }


        public void addDrug()
        {
            drugResistance[drugsNumber] = false;
            drugsNumber++;
        }

        public double CleanProbability
        {
            get { return cleanProbability; }
        }

        public double ReproductionProbability
        {
            get { return reproductionProbability; }
        }

        public double MutationEvolveProbability
        {
            get { return mutationEvolveProbability; }
        }

        public bool [] DrugResistance
        {
            get { return drugResistance; }
        }

        public int DrugsNumber
        {
            get { return drugsNumber; }
        }
    }
}
