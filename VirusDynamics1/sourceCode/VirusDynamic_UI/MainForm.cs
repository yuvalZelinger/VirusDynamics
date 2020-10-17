using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using VirusDynamic_Logic;

namespace VirusDynamic_UI
{
    public partial class MainForm : Form
    {
        private Patient patient;

        public MainForm()
        {
            InitializeComponent();
        }


        private void Start_Click(object sender, EventArgs e)
        {
            //this.chart1.Series["Virus Spread"].Points.AddXY(patient.Stage, patient.VirusSpreadPercent);
            this.reproduceProbLabel.Visible = true;
            this.cleanProbLabel.Visible = true;
            this.reproduceProbTextBox.Visible = true;
            this.cleanProbTextBox.Visible = true;
            this.stageLabel.Visible = true;
            this.spreadLabel.Visible = true;
            this.totalCellsLabel.Visible = true;
            this.totalCellsTextBox.Visible = true;
            this.totalVirusTextBox.Visible = true;
            this.totalVirusLabel.Visible = true;
            this.simulateStagesButton.Visible = true;
            this.stagesToSimulalateNumber.Visible = true;
            this.changeGraphButton.Visible = true;
            this.label4.Visible = true;
            //updateInfoLabels();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.patient == null)
            {
                this.cleanProbTextBox.ReadOnly = true;
                this.reproduceProbTextBox.ReadOnly = true;
                this.totalCellsTextBox.ReadOnly = true;
                this.totalVirusTextBox.ReadOnly = true;
                double cleanProb = Double.Parse(this.cleanProbTextBox.Text);
                double reproduceProb = Double.Parse(this.reproduceProbTextBox.Text);
                int totalCells = Int32.Parse(this.totalCellsTextBox.Text);
                int totalVirus = Int32.Parse(this.totalVirusTextBox.Text);
                patient = new Patient(totalVirus, totalCells, cleanProb, reproduceProb);
                this.chart1.Series["Virus Spread"].Points.AddXY(patient.Stage, patient.VirusSpreadPercent);
            }
            else
            {
                for (int i = 0; i < (int)stagesToSimulalateNumber.Value; i++)
                {
                    patient.SimulateStage();
                    this.chart1.Series["Virus Spread"].Points.AddXY(patient.Stage, patient.VirusSpreadPercent);
                }
            }
            updateInfoLabels();
        }

        private void updateInfoLabels()
        {
            this.stageLabel.Text = "Stage: "+ patient.Stage;
            this.spreadLabel.Text = "Spread: " + patient.VirusSpreadPercent+"%";
            this.totalCellsTextBox.Text = patient.TotalCellsNumber.ToString();
            this.totalVirusTextBox.Text = patient.VirusNumber.ToString();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Title = "Stage";
            chart1.ChartAreas[0].AxisY.Title = "Virus spread in the body (%)";
        }

        private void totalCellsLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalVirusLabel_Click(object sender, EventArgs e)
        {

        }

        private void cleanProbLabel_Click(object sender, EventArgs e)
        {

        }

        private void reproduceProbLabel_Click(object sender, EventArgs e)
        {

        }

        private void stagesToSimulalateNumber_ValueChanged(object sender, EventArgs e)
        {

        }

        private void changeGraphButton_Click(object sender, EventArgs e)
        {
            if (chart1.Series[0].ChartType == SeriesChartType.Spline)
            {
                chart1.Series[0].ChartType = SeriesChartType.Column;
            }
            else
            {
                chart1.Series[0].ChartType = SeriesChartType.Spline;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
