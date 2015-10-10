namespace NewOSEKGen
{
    partial class AnalysisForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalysisForm));
            this.AnalysisData = new System.Windows.Forms.DataGridView();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskPrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CyclePeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scheduling = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinExecTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AveExecTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxExecutionTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Utilization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WRT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Analyze = new System.Windows.Forms.Button();
            this.MaximumExec = new System.Windows.Forms.RadioButton();
            this.AverageExec = new System.Windows.Forms.RadioButton();
            this.MinimumExec = new System.Windows.Forms.RadioButton();
            this.ExecutionLoad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RMS_OK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ScheduleRT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.AnalysisData)).BeginInit();
            this.SuspendLayout();
            // 
            // AnalysisData
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AnalysisData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AnalysisData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AnalysisData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AnalysisData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AnalysisData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskName,
            this.TaskPrio,
            this.CyclePeriod,
            this.Scheduling,
            this.MinExecTime,
            this.AveExecTime,
            this.MaxExecutionTime,
            this.Utilization,
            this.WRT});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AnalysisData.DefaultCellStyle = dataGridViewCellStyle3;
            this.AnalysisData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnalysisData.Location = new System.Drawing.Point(0, 0);
            this.AnalysisData.Name = "AnalysisData";
            this.AnalysisData.RowHeadersWidth = 35;
            this.AnalysisData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AnalysisData.Size = new System.Drawing.Size(961, 405);
            this.AnalysisData.TabIndex = 0;
            // 
            // TaskName
            // 
            this.TaskName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TaskName.HeaderText = "Task Name";
            this.TaskName.Name = "TaskName";
            this.TaskName.Width = 80;
            // 
            // TaskPrio
            // 
            this.TaskPrio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TaskPrio.HeaderText = "Task Priority";
            this.TaskPrio.Name = "TaskPrio";
            this.TaskPrio.Width = 83;
            // 
            // CyclePeriod
            // 
            this.CyclePeriod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CyclePeriod.HeaderText = "Cycle Period [us]";
            this.CyclePeriod.Name = "CyclePeriod";
            this.CyclePeriod.ToolTipText = "The cyclic execution period for the tasks in micro seconds";
            this.CyclePeriod.Width = 87;
            // 
            // Scheduling
            // 
            this.Scheduling.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Scheduling.HeaderText = "Scheduling Type";
            this.Scheduling.Name = "Scheduling";
            this.Scheduling.Width = 103;
            // 
            // MinExecTime
            // 
            this.MinExecTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MinExecTime.HeaderText = "Min Execution Time";
            this.MinExecTime.Name = "MinExecTime";
            this.MinExecTime.Width = 115;
            // 
            // AveExecTime
            // 
            this.AveExecTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.AveExecTime.HeaderText = "Average Execution Time";
            this.AveExecTime.Name = "AveExecTime";
            this.AveExecTime.Width = 115;
            // 
            // MaxExecutionTime
            // 
            this.MaxExecutionTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MaxExecutionTime.HeaderText = "Max Execution Time";
            this.MaxExecutionTime.Name = "MaxExecutionTime";
            this.MaxExecutionTime.Width = 117;
            // 
            // Utilization
            // 
            this.Utilization.HeaderText = "Utilization [C/T]";
            this.Utilization.Name = "Utilization";
            this.Utilization.Width = 97;
            // 
            // WRT
            // 
            this.WRT.HeaderText = "Worst Response Time [us]";
            this.WRT.Name = "WRT";
            this.WRT.Width = 128;
            // 
            // Analyze
            // 
            this.Analyze.Location = new System.Drawing.Point(771, 370);
            this.Analyze.Name = "Analyze";
            this.Analyze.Size = new System.Drawing.Size(75, 23);
            this.Analyze.TabIndex = 1;
            this.Analyze.Text = "Analyze";
            this.Analyze.UseVisualStyleBackColor = true;
            this.Analyze.Click += new System.EventHandler(this.Analyze_Click);
            // 
            // MaximumExec
            // 
            this.MaximumExec.AutoSize = true;
            this.MaximumExec.Location = new System.Drawing.Point(49, 248);
            this.MaximumExec.Name = "MaximumExec";
            this.MaximumExec.Size = new System.Drawing.Size(234, 17);
            this.MaximumExec.TabIndex = 2;
            this.MaximumExec.TabStop = true;
            this.MaximumExec.Text = "Use maximum execution time for the analysis";
            this.MaximumExec.UseVisualStyleBackColor = true;
            // 
            // AverageExec
            // 
            this.AverageExec.AutoSize = true;
            this.AverageExec.Location = new System.Drawing.Point(49, 279);
            this.AverageExec.Name = "AverageExec";
            this.AverageExec.Size = new System.Drawing.Size(230, 17);
            this.AverageExec.TabIndex = 3;
            this.AverageExec.TabStop = true;
            this.AverageExec.Text = "Use average execution time for the analysis";
            this.AverageExec.UseVisualStyleBackColor = true;
            // 
            // MinimumExec
            // 
            this.MinimumExec.AutoSize = true;
            this.MinimumExec.Location = new System.Drawing.Point(48, 312);
            this.MinimumExec.Name = "MinimumExec";
            this.MinimumExec.Size = new System.Drawing.Size(231, 17);
            this.MinimumExec.TabIndex = 4;
            this.MinimumExec.TabStop = true;
            this.MinimumExec.Text = "Use minimum execution time for the analysis";
            this.MinimumExec.UseVisualStyleBackColor = true;
            // 
            // ExecutionLoad
            // 
            this.ExecutionLoad.Location = new System.Drawing.Point(342, 279);
            this.ExecutionLoad.Name = "ExecutionLoad";
            this.ExecutionLoad.ReadOnly = true;
            this.ExecutionLoad.Size = new System.Drawing.Size(100, 20);
            this.ExecutionLoad.TabIndex = 5;
            this.ExecutionLoad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Scheduling load with priority RMS in %";
            // 
            // RMS_OK
            // 
            this.RMS_OK.Location = new System.Drawing.Point(342, 245);
            this.RMS_OK.Name = "RMS_OK";
            this.RMS_OK.ReadOnly = true;
            this.RMS_OK.Size = new System.Drawing.Size(100, 20);
            this.RMS_OK.TabIndex = 7;
            this.RMS_OK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tasks priorities are assigned in accordance with Priority Rate Monotonic (RMS)";
            // 
            // ScheduleRT
            // 
            this.ScheduleRT.Location = new System.Drawing.Point(342, 312);
            this.ScheduleRT.Name = "ScheduleRT";
            this.ScheduleRT.ReadOnly = true;
            this.ScheduleRT.Size = new System.Drawing.Size(100, 20);
            this.ScheduleRT.TabIndex = 9;
            this.ScheduleRT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "The task set can be schedule in real-time (< 69.31%)";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 147);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Analysis Settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(323, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(635, 147);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Analysis Results";
            // 
            // AnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(961, 405);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ScheduleRT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExecutionLoad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RMS_OK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.MinimumExec);
            this.Controls.Add(this.AverageExec);
            this.Controls.Add(this.MaximumExec);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Analyze);
            this.Controls.Add(this.AnalysisData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AnalysisForm";
            this.Text = "Kristian\'s OS Analyst";
            ((System.ComponentModel.ISupportInitialize)(this.AnalysisData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView AnalysisData;
        private System.Windows.Forms.Button Analyze;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskPrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CyclePeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scheduling;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinExecTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AveExecTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxExecutionTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Utilization;
        private int TaskCounter;
        private System.Windows.Forms.DataGridViewTextBoxColumn WRT;
        private Analysis[] TaskAnal = new Analysis[16];
        private System.Windows.Forms.RadioButton MaximumExec;
        private System.Windows.Forms.RadioButton AverageExec;
        private System.Windows.Forms.RadioButton MinimumExec;
        private System.Windows.Forms.TextBox ExecutionLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RMS_OK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ScheduleRT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}