// Our GPAUX namespace
namespace GPAUX
{
    partial class GPAHarbor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GPAHarbor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.semesterDataGridView = new System.Windows.Forms.DataGridView();
            this.CourseNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CreditsColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CourseTypeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.semesterLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.bugReportEmail = new System.Windows.Forms.LinkLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
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
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.ResetButton);
            this.splitContainer1.Panel2.Controls.Add(this.bugReportEmail);
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.cumulativeWeightedGPA);
            this.splitContainer1.Panel2.Controls.Add(this.cumulativeUnweightedGPA);
            this.splitContainer1.Panel2.Controls.Add(this.calculateGPAButton);
            this.splitContainer1.Panel2.Controls.Add(this.resultsDataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.addSemesterButton);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.splitContainer1.Size = new System.Drawing.Size(1552, 917);
            this.splitContainer1.SplitterDistance = 769;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.semesterDataGridView, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.semesterLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(769, 917);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // semesterDataGridView
            // 
            this.semesterDataGridView.AllowUserToResizeColumns = false;
            this.semesterDataGridView.AllowUserToResizeRows = false;
            this.semesterDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.semesterDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.semesterDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.semesterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.semesterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseNameColumn,
            this.GradeColumn,
            this.CreditsColumn,
            this.CourseTypeColumn});
            this.semesterDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.semesterDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.semesterDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.semesterDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.semesterDataGridView.Location = new System.Drawing.Point(98, 4);
            this.semesterDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.semesterDataGridView.Name = "semesterDataGridView";
            this.semesterDataGridView.RowTemplate.Height = 25;
            this.semesterDataGridView.ShowCellErrors = false;
            this.semesterDataGridView.ShowCellToolTips = false;
            this.semesterDataGridView.Size = new System.Drawing.Size(668, 911);
            this.semesterDataGridView.TabIndex = 6;
            this.semesterDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.semesterDataGridView_CellContentClick);
            // 
            // CourseNameColumn
            // 
            this.CourseNameColumn.HeaderText = "Course Name";
            this.CourseNameColumn.Name = "CourseNameColumn";
            this.CourseNameColumn.ToolTipText = "Enter your course name.";
            this.CourseNameColumn.Width = 156;
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
            this.GradeColumn.ToolTipText = "Click the dropdown for your letter grade.";
            this.GradeColumn.Width = 71;
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
            this.CreditsColumn.ToolTipText = "Click the dropdown and click on your credit count for the course.";
            this.CreditsColumn.Width = 78;
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
            this.CourseTypeColumn.ToolTipText = "Choose the type of course you took.";
            this.CourseTypeColumn.Width = 126;
            // 
            // semesterLabel
            // 
            this.semesterLabel.AutoSize = true;
            this.semesterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.semesterLabel.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.semesterLabel.Location = new System.Drawing.Point(3, 0);
            this.semesterLabel.Name = "semesterLabel";
            this.semesterLabel.Size = new System.Drawing.Size(89, 919);
            this.semesterLabel.TabIndex = 8;
            this.semesterLabel.Text = "Semester 1";
            // 
            // ResetButton
            // 
            this.ResetButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ResetButton.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResetButton.Location = new System.Drawing.Point(0, 314);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(779, 33);
            this.ResetButton.TabIndex = 10;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // bugReportEmail
            // 
            this.bugReportEmail.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.bugReportEmail.AutoSize = true;
            this.bugReportEmail.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bugReportEmail.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.bugReportEmail.Location = new System.Drawing.Point(3, 539);
            this.bugReportEmail.Name = "bugReportEmail";
            this.bugReportEmail.Size = new System.Drawing.Size(136, 28);
            this.bugReportEmail.TabIndex = 9;
            this.bugReportEmail.TabStop = true;
            this.bugReportEmail.Text = "Report a Bug?";
            this.bugReportEmail.VisitedLinkColor = System.Drawing.Color.Purple;
            this.bugReportEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.bugReportEmail_LinkClicked);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(0, 582);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(779, 335);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(-1, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cumulative Unweighted GPA - ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-2, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cumulative Weighted GPA - ";
            // 
            // cumulativeWeightedGPA
            // 
            this.cumulativeWeightedGPA.Font = new System.Drawing.Font("Quicksand Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cumulativeWeightedGPA.Location = new System.Drawing.Point(399, 422);
            this.cumulativeWeightedGPA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cumulativeWeightedGPA.Name = "cumulativeWeightedGPA";
            this.cumulativeWeightedGPA.ReadOnly = true;
            this.cumulativeWeightedGPA.Size = new System.Drawing.Size(100, 44);
            this.cumulativeWeightedGPA.TabIndex = 4;
            // 
            // cumulativeUnweightedGPA
            // 
            this.cumulativeUnweightedGPA.Font = new System.Drawing.Font("Quicksand Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cumulativeUnweightedGPA.Location = new System.Drawing.Point(399, 482);
            this.cumulativeUnweightedGPA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cumulativeUnweightedGPA.Name = "cumulativeUnweightedGPA";
            this.cumulativeUnweightedGPA.ReadOnly = true;
            this.cumulativeUnweightedGPA.Size = new System.Drawing.Size(100, 44);
            this.cumulativeUnweightedGPA.TabIndex = 3;
            // 
            // calculateGPAButton
            // 
            this.calculateGPAButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateGPAButton.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calculateGPAButton.Location = new System.Drawing.Point(3, 354);
            this.calculateGPAButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.calculateGPAButton.Name = "calculateGPAButton";
            this.calculateGPAButton.Size = new System.Drawing.Size(198, 64);
            this.calculateGPAButton.TabIndex = 2;
            this.calculateGPAButton.Text = "Calculate GPA";
            this.calculateGPAButton.UseVisualStyleBackColor = true;
            this.calculateGPAButton.Click += new System.EventHandler(this.calculateGPAButton_Click);
            // 
            // resultsDataGridView
            // 
            this.resultsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.resultsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.resultsDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.resultsDataGridView.ColumnHeadersHeight = 80;
            this.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.resultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SemesterColumn,
            this.GPAWeightedColumn,
            this.GPAUnWeightedColumn});
            this.resultsDataGridView.Cursor = System.Windows.Forms.Cursors.No;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.resultsDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.resultsDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.resultsDataGridView.Location = new System.Drawing.Point(0, 88);
            this.resultsDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resultsDataGridView.Name = "resultsDataGridView";
            this.resultsDataGridView.RowHeadersWidth = 50;
            this.resultsDataGridView.RowTemplate.Height = 25;
            this.resultsDataGridView.ShowCellErrors = false;
            this.resultsDataGridView.ShowCellToolTips = false;
            this.resultsDataGridView.ShowRowErrors = false;
            this.resultsDataGridView.Size = new System.Drawing.Size(779, 226);
            this.resultsDataGridView.TabIndex = 1;
            // 
            // SemesterColumn
            // 
            this.SemesterColumn.HeaderText = "Semester";
            this.SemesterColumn.Name = "SemesterColumn";
            this.SemesterColumn.ReadOnly = true;
            this.SemesterColumn.Width = 105;
            // 
            // GPAWeightedColumn
            // 
            this.GPAWeightedColumn.HeaderText = "GPA Weighted";
            this.GPAWeightedColumn.Name = "GPAWeightedColumn";
            this.GPAWeightedColumn.ReadOnly = true;
            this.GPAWeightedColumn.Width = 127;
            // 
            // GPAUnWeightedColumn
            // 
            this.GPAUnWeightedColumn.HeaderText = "GPA Unweighted";
            this.GPAUnWeightedColumn.Name = "GPAUnWeightedColumn";
            this.GPAUnWeightedColumn.ReadOnly = true;
            this.GPAUnWeightedColumn.Width = 142;
            // 
            // addSemesterButton
            // 
            this.addSemesterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSemesterButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addSemesterButton.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addSemesterButton.Location = new System.Drawing.Point(0, 0);
            this.addSemesterButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addSemesterButton.Name = "addSemesterButton";
            this.addSemesterButton.Size = new System.Drawing.Size(779, 88);
            this.addSemesterButton.TabIndex = 0;
            this.addSemesterButton.Text = "Add Semester";
            this.addSemesterButton.UseVisualStyleBackColor = true;
            this.addSemesterButton.Click += new System.EventHandler(this.addSemesterButton_Click);
            // 
            // GPAHarbor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1552, 917);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GPAHarbor";
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

        // Initializing all of our visual elements
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
        private RichTextBox richTextBox1;
        private LinkLabel bugReportEmail;
        private Button ResetButton;
    }
}