namespace VirusDynamic_UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.simulateStagesButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.stageLabel = new System.Windows.Forms.Label();
            this.spreadLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stagesToSimulalateNumber = new System.Windows.Forms.NumericUpDown();
            this.totalCellsLabel = new System.Windows.Forms.Label();
            this.totalVirusLabel = new System.Windows.Forms.Label();
            this.cleanProbLabel = new System.Windows.Forms.Label();
            this.reproduceProbLabel = new System.Windows.Forms.Label();
            this.totalCellsTextBox = new System.Windows.Forms.TextBox();
            this.totalVirusTextBox = new System.Windows.Forms.TextBox();
            this.cleanProbTextBox = new System.Windows.Forms.TextBox();
            this.reproduceProbTextBox = new System.Windows.Forms.TextBox();
            this.changeGraphButton = new System.Windows.Forms.Button();
            this.drugsNumberLabel = new System.Windows.Forms.Label();
            this.addDrugButton = new System.Windows.Forms.Button();
            this.drugImmunityLabel = new System.Windows.Forms.Label();
            this.immunityTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stagesToSimulalateNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Virus Dynamic";
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(29, 430);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(268, 61);
            this.StartButton.TabIndex = 9;
            this.StartButton.Text = "Start Simulation";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.Start_Click);
            // 
            // simulateStagesButton
            // 
            this.simulateStagesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simulateStagesButton.Location = new System.Drawing.Point(680, 431);
            this.simulateStagesButton.Name = "simulateStagesButton";
            this.simulateStagesButton.Size = new System.Drawing.Size(246, 61);
            this.simulateStagesButton.TabIndex = 10;
            this.simulateStagesButton.Text = "Simulate Stages";
            this.simulateStagesButton.UseVisualStyleBackColor = true;
            this.simulateStagesButton.Visible = false;
            this.simulateStagesButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 40);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.Black;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Virus Spread";
            series1.XValueMember = "saasas";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1064, 384);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // stageLabel
            // 
            this.stageLabel.AutoSize = true;
            this.stageLabel.Font = new System.Drawing.Font("Miriam Fixed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stageLabel.Location = new System.Drawing.Point(882, 109);
            this.stageLabel.Name = "stageLabel";
            this.stageLabel.Size = new System.Drawing.Size(102, 28);
            this.stageLabel.TabIndex = 12;
            this.stageLabel.Text = "stage";
            this.stageLabel.Visible = false;
            // 
            // spreadLabel
            // 
            this.spreadLabel.AutoSize = true;
            this.spreadLabel.Font = new System.Drawing.Font("Miriam Fixed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spreadLabel.Location = new System.Drawing.Point(883, 149);
            this.spreadLabel.Name = "spreadLabel";
            this.spreadLabel.Size = new System.Drawing.Size(160, 24);
            this.spreadLabel.TabIndex = 13;
            this.spreadLabel.Text = "Spread (%)";
            this.spreadLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(830, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Click \"Start Simulation\" then select a number of stages simulate and then click \"" +
    "Simulate Stages\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(417, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Stages To Simullate:";
            this.label4.Visible = false;
            // 
            // stagesToSimulalateNumber
            // 
            this.stagesToSimulalateNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stagesToSimulalateNumber.Location = new System.Drawing.Point(624, 431);
            this.stagesToSimulalateNumber.Name = "stagesToSimulalateNumber";
            this.stagesToSimulalateNumber.Size = new System.Drawing.Size(50, 28);
            this.stagesToSimulalateNumber.TabIndex = 16;
            this.stagesToSimulalateNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stagesToSimulalateNumber.Visible = false;
            this.stagesToSimulalateNumber.ValueChanged += new System.EventHandler(this.stagesToSimulalateNumber_ValueChanged);
            // 
            // totalCellsLabel
            // 
            this.totalCellsLabel.AutoSize = true;
            this.totalCellsLabel.Font = new System.Drawing.Font("Miriam Fixed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCellsLabel.Location = new System.Drawing.Point(884, 218);
            this.totalCellsLabel.Name = "totalCellsLabel";
            this.totalCellsLabel.Size = new System.Drawing.Size(127, 15);
            this.totalCellsLabel.TabIndex = 17;
            this.totalCellsLabel.Text = "Total cells:";
            this.totalCellsLabel.Visible = false;
            this.totalCellsLabel.Click += new System.EventHandler(this.totalCellsLabel_Click);
            // 
            // totalVirusLabel
            // 
            this.totalVirusLabel.AutoSize = true;
            this.totalVirusLabel.Font = new System.Drawing.Font("Miriam Fixed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalVirusLabel.Location = new System.Drawing.Point(884, 250);
            this.totalVirusLabel.Name = "totalVirusLabel";
            this.totalVirusLabel.Size = new System.Drawing.Size(127, 15);
            this.totalVirusLabel.TabIndex = 18;
            this.totalVirusLabel.Text = "Total Virus:";
            this.totalVirusLabel.Visible = false;
            this.totalVirusLabel.Click += new System.EventHandler(this.totalVirusLabel_Click);
            // 
            // cleanProbLabel
            // 
            this.cleanProbLabel.AutoSize = true;
            this.cleanProbLabel.Font = new System.Drawing.Font("Miriam Fixed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cleanProbLabel.Location = new System.Drawing.Point(884, 277);
            this.cleanProbLabel.Name = "cleanProbLabel";
            this.cleanProbLabel.Size = new System.Drawing.Size(187, 15);
            this.cleanProbLabel.TabIndex = 19;
            this.cleanProbLabel.Text = "Clean Probability:";
            this.cleanProbLabel.Visible = false;
            this.cleanProbLabel.Click += new System.EventHandler(this.cleanProbLabel_Click);
            // 
            // reproduceProbLabel
            // 
            this.reproduceProbLabel.AutoSize = true;
            this.reproduceProbLabel.Font = new System.Drawing.Font("Miriam Fixed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reproduceProbLabel.Location = new System.Drawing.Point(884, 321);
            this.reproduceProbLabel.Name = "reproduceProbLabel";
            this.reproduceProbLabel.Size = new System.Drawing.Size(217, 15);
            this.reproduceProbLabel.TabIndex = 20;
            this.reproduceProbLabel.Text = "Reproduce Probability";
            this.reproduceProbLabel.Visible = false;
            this.reproduceProbLabel.Click += new System.EventHandler(this.reproduceProbLabel_Click);
            // 
            // totalCellsTextBox
            // 
            this.totalCellsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCellsTextBox.Location = new System.Drawing.Point(1017, 211);
            this.totalCellsTextBox.Name = "totalCellsTextBox";
            this.totalCellsTextBox.Size = new System.Drawing.Size(84, 24);
            this.totalCellsTextBox.TabIndex = 21;
            this.totalCellsTextBox.Text = "1000";
            this.totalCellsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalCellsTextBox.Visible = false;
            // 
            // totalVirusTextBox
            // 
            this.totalVirusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalVirusTextBox.Location = new System.Drawing.Point(1017, 250);
            this.totalVirusTextBox.Name = "totalVirusTextBox";
            this.totalVirusTextBox.Size = new System.Drawing.Size(84, 24);
            this.totalVirusTextBox.TabIndex = 22;
            this.totalVirusTextBox.Text = "100";
            this.totalVirusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalVirusTextBox.Visible = false;
            // 
            // cleanProbTextBox
            // 
            this.cleanProbTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cleanProbTextBox.Location = new System.Drawing.Point(944, 295);
            this.cleanProbTextBox.Name = "cleanProbTextBox";
            this.cleanProbTextBox.Size = new System.Drawing.Size(84, 24);
            this.cleanProbTextBox.TabIndex = 23;
            this.cleanProbTextBox.Text = "0.03";
            this.cleanProbTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cleanProbTextBox.Visible = false;
            // 
            // reproduceProbTextBox
            // 
            this.reproduceProbTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reproduceProbTextBox.Location = new System.Drawing.Point(944, 339);
            this.reproduceProbTextBox.Name = "reproduceProbTextBox";
            this.reproduceProbTextBox.Size = new System.Drawing.Size(84, 24);
            this.reproduceProbTextBox.TabIndex = 24;
            this.reproduceProbTextBox.Text = "0.1";
            this.reproduceProbTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.reproduceProbTextBox.Visible = false;
            // 
            // changeGraphButton
            // 
            this.changeGraphButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeGraphButton.Location = new System.Drawing.Point(376, 462);
            this.changeGraphButton.Name = "changeGraphButton";
            this.changeGraphButton.Size = new System.Drawing.Size(257, 30);
            this.changeGraphButton.TabIndex = 25;
            this.changeGraphButton.Text = "Change Graph Design";
            this.changeGraphButton.UseVisualStyleBackColor = true;
            this.changeGraphButton.Visible = false;
            this.changeGraphButton.Click += new System.EventHandler(this.changeGraphButton_Click);
            // 
            // drugsNumberLabel
            // 
            this.drugsNumberLabel.AutoSize = true;
            this.drugsNumberLabel.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drugsNumberLabel.Location = new System.Drawing.Point(883, 185);
            this.drugsNumberLabel.Name = "drugsNumberLabel";
            this.drugsNumberLabel.Size = new System.Drawing.Size(178, 20);
            this.drugsNumberLabel.TabIndex = 27;
            this.drugsNumberLabel.Text = "Drugs number:";
            this.drugsNumberLabel.Visible = false;
            // 
            // addDrugButton
            // 
            this.addDrugButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDrugButton.Location = new System.Drawing.Point(963, 433);
            this.addDrugButton.Name = "addDrugButton";
            this.addDrugButton.Size = new System.Drawing.Size(138, 41);
            this.addDrugButton.TabIndex = 28;
            this.addDrugButton.Text = "Add Drug";
            this.addDrugButton.UseVisualStyleBackColor = true;
            this.addDrugButton.Visible = false;
            this.addDrugButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // drugImmunityLabel
            // 
            this.drugImmunityLabel.AutoSize = true;
            this.drugImmunityLabel.Font = new System.Drawing.Font("Miriam Fixed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drugImmunityLabel.Location = new System.Drawing.Point(884, 366);
            this.drugImmunityLabel.Name = "drugImmunityLabel";
            this.drugImmunityLabel.Size = new System.Drawing.Size(217, 15);
            this.drugImmunityLabel.TabIndex = 29;
            this.drugImmunityLabel.Text = "Immunity Probability:";
            this.drugImmunityLabel.Visible = false;
            // 
            // immunityTextBox
            // 
            this.immunityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.immunityTextBox.Location = new System.Drawing.Point(944, 384);
            this.immunityTextBox.Name = "immunityTextBox";
            this.immunityTextBox.Size = new System.Drawing.Size(84, 24);
            this.immunityTextBox.TabIndex = 30;
            this.immunityTextBox.Text = "0.005";
            this.immunityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.immunityTextBox.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1128, 523);
            this.Controls.Add(this.immunityTextBox);
            this.Controls.Add(this.drugImmunityLabel);
            this.Controls.Add(this.addDrugButton);
            this.Controls.Add(this.drugsNumberLabel);
            this.Controls.Add(this.changeGraphButton);
            this.Controls.Add(this.reproduceProbTextBox);
            this.Controls.Add(this.cleanProbTextBox);
            this.Controls.Add(this.totalVirusTextBox);
            this.Controls.Add(this.totalCellsTextBox);
            this.Controls.Add(this.reproduceProbLabel);
            this.Controls.Add(this.cleanProbLabel);
            this.Controls.Add(this.totalVirusLabel);
            this.Controls.Add(this.totalCellsLabel);
            this.Controls.Add(this.stagesToSimulalateNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spreadLabel);
            this.Controls.Add(this.stageLabel);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.simulateStagesButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "MainForm";
            this.Text = "Virus Dynamic";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stagesToSimulalateNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button simulateStagesButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label stageLabel;
        private System.Windows.Forms.Label spreadLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown stagesToSimulalateNumber;
        private System.Windows.Forms.Label totalCellsLabel;
        private System.Windows.Forms.Label totalVirusLabel;
        private System.Windows.Forms.Label cleanProbLabel;
        private System.Windows.Forms.Label reproduceProbLabel;
        private System.Windows.Forms.TextBox totalCellsTextBox;
        private System.Windows.Forms.TextBox totalVirusTextBox;
        private System.Windows.Forms.TextBox cleanProbTextBox;
        private System.Windows.Forms.TextBox reproduceProbTextBox;
        private System.Windows.Forms.Button changeGraphButton;
        private System.Windows.Forms.Label drugsNumberLabel;
        private System.Windows.Forms.Button addDrugButton;
        private System.Windows.Forms.Label drugImmunityLabel;
        private System.Windows.Forms.TextBox immunityTextBox;
    }
}

