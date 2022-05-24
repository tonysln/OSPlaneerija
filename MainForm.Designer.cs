namespace OSPlaneerija
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.algoInput = new System.Windows.Forms.GroupBox();
            this.customAlgoTextbox = new System.Windows.Forms.TextBox();
            this.customAlgo = new System.Windows.Forms.RadioButton();
            this.sampleAlgo3 = new System.Windows.Forms.RadioButton();
            this.sampleAlgo2 = new System.Windows.Forms.RadioButton();
            this.sampleAlgo1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.FCFSButton = new System.Windows.Forms.Button();
            this.SRTFButton = new System.Windows.Forms.Button();
            this.RR3Button = new System.Windows.Forms.Button();
            this.DoubleFCFSButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.chosenAlgoLabel = new System.Windows.Forms.Label();
            this.averageTimeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ganttField = new System.Windows.Forms.PictureBox();
            this.taskListGrid = new System.Windows.Forms.DataGridView();
            this.taskListGridPanel = new System.Windows.Forms.Panel();
            this.algoInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ganttField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskListGrid)).BeginInit();
            this.taskListGridPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // algoInput
            // 
            this.algoInput.Controls.Add(this.customAlgoTextbox);
            this.algoInput.Controls.Add(this.customAlgo);
            this.algoInput.Controls.Add(this.sampleAlgo3);
            this.algoInput.Controls.Add(this.sampleAlgo2);
            this.algoInput.Controls.Add(this.sampleAlgo1);
            this.algoInput.Location = new System.Drawing.Point(27, 14);
            this.algoInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.algoInput.Name = "algoInput";
            this.algoInput.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.algoInput.Size = new System.Drawing.Size(473, 192);
            this.algoInput.TabIndex = 0;
            this.algoInput.TabStop = false;
            this.algoInput.Text = "Vali või sisesta järjend (kujul 1,10;4,2;12,3;13,2)";
            // 
            // customAlgoTextbox
            // 
            this.customAlgoTextbox.Font = new System.Drawing.Font("Consolas", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customAlgoTextbox.Location = new System.Drawing.Point(126, 139);
            this.customAlgoTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customAlgoTextbox.Name = "customAlgoTextbox";
            this.customAlgoTextbox.Size = new System.Drawing.Size(219, 25);
            this.customAlgoTextbox.TabIndex = 4;
            this.customAlgoTextbox.Click += new System.EventHandler(this.customAlgoTextbox_Click);
            this.customAlgoTextbox.TextChanged += new System.EventHandler(this.customAlgoTextbox_TextChanged);
            this.customAlgoTextbox.Enter += new System.EventHandler(this.customAlgoTextbox_Enter);
            // 
            // customAlgo
            // 
            this.customAlgo.AutoSize = true;
            this.customAlgo.Location = new System.Drawing.Point(22, 140);
            this.customAlgo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customAlgo.Name = "customAlgo";
            this.customAlgo.Size = new System.Drawing.Size(94, 24);
            this.customAlgo.TabIndex = 3;
            this.customAlgo.Text = "Enda oma";
            this.customAlgo.UseVisualStyleBackColor = true;
            // 
            // sampleAlgo3
            // 
            this.sampleAlgo3.AutoSize = true;
            this.sampleAlgo3.Font = new System.Drawing.Font("Consolas", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sampleAlgo3.Location = new System.Drawing.Point(22, 104);
            this.sampleAlgo3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sampleAlgo3.Name = "sampleAlgo3";
            this.sampleAlgo3.Size = new System.Drawing.Size(210, 22);
            this.sampleAlgo3.TabIndex = 2;
            this.sampleAlgo3.Text = "0,4;1,5;2,2;3,1;4,6;6,3";
            this.sampleAlgo3.UseVisualStyleBackColor = true;
            // 
            // sampleAlgo2
            // 
            this.sampleAlgo2.AutoSize = true;
            this.sampleAlgo2.Font = new System.Drawing.Font("Consolas", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sampleAlgo2.Location = new System.Drawing.Point(22, 70);
            this.sampleAlgo2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sampleAlgo2.Name = "sampleAlgo2";
            this.sampleAlgo2.Size = new System.Drawing.Size(210, 22);
            this.sampleAlgo2.TabIndex = 1;
            this.sampleAlgo2.Text = "0,2;0,4;12,4;15,5;21,10";
            this.sampleAlgo2.UseVisualStyleBackColor = true;
            // 
            // sampleAlgo1
            // 
            this.sampleAlgo1.AutoSize = true;
            this.sampleAlgo1.Checked = true;
            this.sampleAlgo1.Font = new System.Drawing.Font("Consolas", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sampleAlgo1.Location = new System.Drawing.Point(22, 38);
            this.sampleAlgo1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sampleAlgo1.Name = "sampleAlgo1";
            this.sampleAlgo1.Size = new System.Drawing.Size(210, 22);
            this.sampleAlgo1.TabIndex = 0;
            this.sampleAlgo1.TabStop = true;
            this.sampleAlgo1.Text = "0,7;1,5;2,3;3,1;4,2;5,1";
            this.sampleAlgo1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Algoritmi käivitamiseks tee valik ja klõpsa nupule";
            // 
            // FCFSButton
            // 
            this.FCFSButton.Location = new System.Drawing.Point(27, 261);
            this.FCFSButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FCFSButton.Name = "FCFSButton";
            this.FCFSButton.Size = new System.Drawing.Size(85, 29);
            this.FCFSButton.TabIndex = 2;
            this.FCFSButton.Text = "FCFS";
            this.FCFSButton.UseVisualStyleBackColor = true;
            this.FCFSButton.Click += new System.EventHandler(this.FCFSButton_Click);
            // 
            // SRTFButton
            // 
            this.SRTFButton.Location = new System.Drawing.Point(127, 261);
            this.SRTFButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SRTFButton.Name = "SRTFButton";
            this.SRTFButton.Size = new System.Drawing.Size(85, 29);
            this.SRTFButton.TabIndex = 3;
            this.SRTFButton.Text = "SRTF";
            this.SRTFButton.UseVisualStyleBackColor = true;
            this.SRTFButton.Click += new System.EventHandler(this.SRTFButton_Click);
            // 
            // RR3Button
            // 
            this.RR3Button.Location = new System.Drawing.Point(228, 261);
            this.RR3Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RR3Button.Name = "RR3Button";
            this.RR3Button.Size = new System.Drawing.Size(85, 29);
            this.RR3Button.TabIndex = 4;
            this.RR3Button.Text = "RR3";
            this.RR3Button.UseVisualStyleBackColor = true;
            this.RR3Button.Click += new System.EventHandler(this.RR4Button_Click);
            // 
            // DoubleFCFSButton
            // 
            this.DoubleFCFSButton.Location = new System.Drawing.Point(330, 261);
            this.DoubleFCFSButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DoubleFCFSButton.Name = "DoubleFCFSButton";
            this.DoubleFCFSButton.Size = new System.Drawing.Size(85, 29);
            this.DoubleFCFSButton.TabIndex = 5;
            this.DoubleFCFSButton.Text = "2xFCFS";
            this.DoubleFCFSButton.UseVisualStyleBackColor = true;
            this.DoubleFCFSButton.Click += new System.EventHandler(this.DoubleFCFSButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(915, 261);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(85, 29);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Puhasta";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // chosenAlgoLabel
            // 
            this.chosenAlgoLabel.AutoSize = true;
            this.chosenAlgoLabel.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chosenAlgoLabel.Location = new System.Drawing.Point(27, 311);
            this.chosenAlgoLabel.Name = "chosenAlgoLabel";
            this.chosenAlgoLabel.Size = new System.Drawing.Size(27, 20);
            this.chosenAlgoLabel.TabIndex = 7;
            this.chosenAlgoLabel.Text = "---";
            // 
            // averageTimeLabel
            // 
            this.averageTimeLabel.AutoSize = true;
            this.averageTimeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.averageTimeLabel.Location = new System.Drawing.Point(162, 332);
            this.averageTimeLabel.Name = "averageTimeLabel";
            this.averageTimeLabel.Size = new System.Drawing.Size(29, 20);
            this.averageTimeLabel.TabIndex = 8;
            this.averageTimeLabel.Text = "0.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(27, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Keskmine ooteaeg: ";
            // 
            // ganttField
            // 
            this.ganttField.Location = new System.Drawing.Point(27, 367);
            this.ganttField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ganttField.Name = "ganttField";
            this.ganttField.Size = new System.Drawing.Size(973, 73);
            this.ganttField.TabIndex = 12;
            this.ganttField.TabStop = false;
            // 
            // taskListGrid
            // 
            this.taskListGrid.AllowUserToAddRows = false;
            this.taskListGrid.AllowUserToDeleteRows = false;
            this.taskListGrid.AllowUserToResizeColumns = false;
            this.taskListGrid.AllowUserToResizeRows = false;
            this.taskListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.taskListGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.taskListGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.taskListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskListGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskListGrid.Location = new System.Drawing.Point(0, 0);
            this.taskListGrid.MultiSelect = false;
            this.taskListGrid.Name = "taskListGrid";
            this.taskListGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.taskListGrid.RowHeadersVisible = false;
            this.taskListGrid.RowHeadersWidth = 45;
            this.taskListGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.taskListGrid.ShowCellErrors = false;
            this.taskListGrid.ShowEditingIcon = false;
            this.taskListGrid.Size = new System.Drawing.Size(475, 211);
            this.taskListGrid.TabIndex = 13;
            this.taskListGrid.Text = "dataGridView1";
            // 
            // taskListGridPanel
            // 
            this.taskListGridPanel.Controls.Add(this.taskListGrid);
            this.taskListGridPanel.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.taskListGridPanel.Location = new System.Drawing.Point(525, 21);
            this.taskListGridPanel.Name = "taskListGridPanel";
            this.taskListGridPanel.Size = new System.Drawing.Size(475, 211);
            this.taskListGridPanel.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1026, 472);
            this.Controls.Add(this.taskListGridPanel);
            this.Controls.Add(this.ganttField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.averageTimeLabel);
            this.Controls.Add(this.chosenAlgoLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DoubleFCFSButton);
            this.Controls.Add(this.RR3Button);
            this.Controls.Add(this.SRTFButton);
            this.Controls.Add(this.FCFSButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.algoInput);
            this.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Protsessoriaja planeerimise algoritmide töö visualiseerimine";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.algoInput.ResumeLayout(false);
            this.algoInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ganttField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskListGrid)).EndInit();
            this.taskListGridPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox algoInput;
        private System.Windows.Forms.TextBox customAlgoTextbox;
        private System.Windows.Forms.RadioButton customAlgo;
        private System.Windows.Forms.RadioButton sampleAlgo3;
        private System.Windows.Forms.RadioButton sampleAlgo2;
        private System.Windows.Forms.RadioButton sampleAlgo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FCFSButton;
        private System.Windows.Forms.Button SRTFButton;
        private System.Windows.Forms.Button RR3Button;
        private System.Windows.Forms.Button DoubleFCFSButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label chosenAlgoLabel;
        private System.Windows.Forms.Label averageTimeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox ganttField;
        private System.Windows.Forms.DataGridView taskListGrid;
        private System.Windows.Forms.Panel taskListGridPanel;
    }
}

