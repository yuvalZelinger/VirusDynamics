using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirusDynamic_Logic
{
    public class Patient
    {
        private List<Virus> virusPopulation;
        private int totalCellsNumber;
        private int stage;



        public Patient(int VirusNumber, int totalCellsNumber, double cleanProbability, double reproductionProbability)
        {
            this.stage = 1;
            this.totalCellsNumber = totalCellsNumber;
            this.virusPopulation = new List<Virus>();
            for(int i = 0; i < VirusNumber; i++)
            {
                virusPopulation.Add(new Virus(cleanProbability, reproductionProbability));
            }
        }

        public void SimulateStage()
        {
                stage++;
                updatePatientState();
        }

        private void updatePatientState()
        {
            simulateVirusesClean();
            simulateVirusesreproduction();
        }

        private void simulateVirusesreproduction()
        {
            double occupancyPercentage = ((double)virusPopulation.Count / totalCellsNumber);
            List<Virus> virusPopulationCopy = new List<Virus>(virusPopulation);
            foreach (Virus virus in virusPopulationCopy)
            {
                if (virus.isReproduce(occupancyPercentage))
                {
                    virusPopulation.Add(new Virus(virus.CleanProbability, virus.ReproductionProbability));
                }
            }
        }

        private void simulateVirusesClean()
        {
            List<Virus> virusPopulationCopy = new List<Virus>(virusPopulation);
            foreach (Virus virus in virusPopulationCopy)
            {
                if (!virus.isSurvive())
                {
                    virusPopulation.Remove(virus);
                }
            }
        }

        public double VirusSpreadPercent
        {
            get { return ((double)virusPopulation.Count/totalCellsNumber)*100; }
        }

        public int Stage
        {
            get { return stage; }
        }

        public int TotalCellsNumber
        {
            get { return totalCellsNumber; }
        }

        public int VirusNumber
        {
            get { return virusPopulation.Count; }
        }
    }
}
