namespace GPAUX
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.semesterDataGridView = new System.Windows.Forms.DataGridView();
            this.semesterLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cumulativeWeightedGPA = new System.Windows.Forms.TextBox();
            this.cumulativeUnweightedGPA = new System.Windows.Forms.TextBox();
            this.calculateGPAButton = new System.Windows.Forms.Button();
            this.resultsDataGridView = new System.Windows.Forms.DataGridView();
            this.SemesterColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPAWeightedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPAUnWeightedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addSemesterButton = new System.Windows.Forms.Button();
            this.CourseNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CreditsColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CourseTypeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.semesterDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.cumulativeWeightedGPA);
            this.splitContainer1.Panel2.Controls.Add(this.cumulativeUnweightedGPA);
            this.splitContainer1.Panel2.Controls.Add(this.calculateGPAButton);
            this.splitContainer1.Panel2.Controls.Add(this.resultsDataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.addSemesterButton);
            this.splitContainer1.Size = new System.Drawing.Size(1260, 697);
            this.splitContainer1.SplitterDistance = 625;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.semesterDataGridView, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.semesterLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(625, 697);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // semesterDataGridView
            // 
            this.semesterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.semesterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseNameColumn,
            this.GradeColumn,
            this.CreditsColumn,
            this.CourseTypeColumn});
            this.semesterDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.semesterDataGridView.Location = new System.Drawing.Point(123, 3);
            this.semesterDataGridView.Name = "semesterDataGridView";
            this.semesterDataGridView.RowTemplate.Height = 25;
            this.semesterDataGridView.Size = new System.Drawing.Size(499, 691);
            this.semesterDataGridView.TabIndex = 6;
            // 
            // semesterLabel
            // 
            this.semesterLabel.AutoSize = true;
            this.semesterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.semesterLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.semesterLabel.Location = new System.Drawing.Point(3, 0);
            this.semesterLabel.Name = "semesterLabel";
            this.semesterLabel.Size = new System.Drawing.Size(114, 697);
            this.semesterLabel.TabIndex = 8;
            this.semesterLabel.Text = "Semester1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cumulative Unweighted GPA - ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cumulative Weighted GPA - ";
            // 
            // cumulativeWeightedGPA
            // 
            this.cumulativeWeightedGPA.Location = new System.Drawing.Point(175, 387);
            this.cumulativeWeightedGPA.Name = "cumulativeWeightedGPA";
            this.cumulativeWeightedGPA.ReadOnly = true;
            this.cumulativeWeightedGPA.Size = new System.Drawing.Size(100, 23);
            this.cumulativeWeightedGPA.TabIndex = 4;
            // 
            // cumulativeUnweightedGPA
            // 
            this.cumulativeUnweightedGPA.Location = new System.Drawing.Point(175, 416);
            this.cumulativeUnweightedGPA.Name = "cumulativeUnweightedGPA";
            this.cumulativeUnweightedGPA.ReadOnly = true;
            this.cumulativeUnweightedGPA.Size = new System.Drawing.Size(100, 23);
            this.cumulativeUnweightedGPA.TabIndex = 3;
            // 
            // calculateGPAButton
            // 
            this.calculateGPAButton.Location = new System.Drawing.Point(93, 270);
            this.calculateGPAButton.Name = "calculateGPAButton";
            this.calculateGPAButton.Size = new System.Drawing.Size(198, 60);
            this.calculateGPAButton.TabIndex = 2;
            this.calculateGPAButton.Text = "Calculate GPA";
            this.calculateGPAButton.UseVisualStyleBackColor = true;
            this.calculateGPAButton.Click += new System.EventHandler(this.calculateGPAButton_Click);
            // 
            // resultsDataGridView
            // 
            this.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SemesterColumn,
            this.GPAWeightedColumn,
            this.GPAUnWeightedColumn});
            this.resultsDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.resultsDataGridView.Location = new System.Drawing.Point(0, 57);
            this.resultsDataGridView.Name = "resultsDataGridView";
            this.resultsDataGridView.RowTemplate.Height = 25;
            this.resultsDataGridView.Size = new System.Drawing.Size(631, 188);
            this.resultsDataGridView.TabIndex = 1;
            // 
            // SemesterColumn
            // 
            this.SemesterColumn.HeaderText = "Semester";
            this.SemesterColumn.Name = "SemesterColumn";
            this.SemesterColumn.ReadOnly = true;
            // 
            // GPAWeightedColumn
            // 
            this.GPAWeightedColumn.HeaderText = "GPA Weighted";
            this.GPAWeightedColumn.Name = "GPAWeightedColumn";
            this.GPAWeightedColumn.ReadOnly = true;
            // 
            // GPAUnWeightedColumn
            // 
            this.GPAUnWeightedColumn.HeaderText = "GPA Unweighted";
            this.GPAUnWeightedColumn.Name = "GPAUnWeightedColumn";
            this.GPAUnWeightedColumn.ReadOnly = true;
            // 
            // addSemesterButton
            // 
            this.addSemesterButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addSemesterButton.Location = new System.Drawing.Point(0, 0);
            this.addSemesterButton.Name = "addSemesterButton";
            this.addSemesterButton.Size = new System.Drawing.Size(631, 57);
            this.addSemesterButton.TabIndex = 0;
            this.addSemesterButton.Text = "Add Semester";
            this.addSemesterButton.UseVisualStyleBackColor = true;
            this.addSemesterButton.Click += new System.EventHandler(this.addSemesterButton_Click);
            // 
            // CourseNameColumn
            // 
            this.CourseNameColumn.HeaderText = "Course Name";
            this.CourseNameColumn.Name = "CourseNameColumn";
            // 
            // GradeColumn
            // 
            this.GradeColumn.HeaderText = "Grade";
            this.GradeColumn.Items.AddRange(new object[] {
            "A",
            "A-",
            "B+",
            "B",
            "B-",
            "C+",
            "C",
            "C-",
            "D+",
            "D",
            "F"});
            this.GradeColumn.Name = "GradeColumn";
            // 
            // CreditsColumn
            // 
            this.CreditsColumn.HeaderText = "Credits";
            this.CreditsColumn.Items.AddRange(new object[] {
            "0.5",
            "1",
            "1.5",
            "2",
            "2.5",
            "3",
            "3.5",
            "4",
            "4.5",
            "5",
            "5.5"});
            this.CreditsColumn.Name = "CreditsColumn";
            // 
            // CourseTypeColumn
            // 
            this.CourseTypeColumn.HeaderText = "Course Type";
            this.CourseTypeColumn.Items.AddRange(new object[] {
            "Regular",
            "AP",
            "IB",
            "Honors"});
            this.CourseTypeColumn.Name = "CourseTypeColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1260, 697);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "GPAHarbor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.semesterDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Button addSemesterButton;
        private DataGridView resultsDataGridView;
        private DataGridViewTextBoxColumn SemesterColumn;
        private DataGridViewTextBoxColumn GPAWeightedColumn;
        private DataGridViewTextBoxColumn GPAUnWeightedColumn;
        private Button calculateGPAButton;
        private Label label1;
        private TextBox cumulativeWeightedGPA;
        private TextBox cumulativeUnweightedGPA;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView semesterDataGridView;
        private Label semesterLabel;
        private DataGridViewTextBoxColumn CourseNameColumn;
        private DataGridViewComboBoxColumn GradeColumn;
        private DataGridViewComboBoxColumn CreditsColumn;
        private DataGridViewComboBoxColumn CourseTypeColumn;
    }
}