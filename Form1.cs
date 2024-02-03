using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

// Our main namespace GPAUX
namespace GPAUX
{
    // Inheriting the Form class
    public partial class GPAHarbor : Form
    {
        // Setting up our weighted and unweighted GPA variables
        double weighted = 0;
        double unweighted = 0;

        // Mapping letter grades to points
        public static Dictionary<String, double> gradesMapping = new Dictionary<String, double>(){
            {"A", 4.0},
            {"A-", 3.7},
            {"B+", 3.3},
            {"B", 3.0},
            {"B-", 2.7},
            {"C+", 2.3},
            {"C", 2.0},
            {"C-", 1.7},
            {"D+", 1.3},
            {"D", 1.0},
            {"F", 0.0}
        };

        int height = 0;

        // Initializing the Form1 component
        public GPAHarbor()
        {
            InitializeComponent();
            //tableLayoutPanel1.RowStyles.RemoveAt(0);
            semesterDataGridView.DefaultCellStyle.Font = new Font("Quicksand", 14);
            this.AutoScroll = false;
            this.tableLayoutPanel1.AutoScroll = false;

        }

        // Adding a new semester grid
        private void addSemesterButton_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.SuspendLayout();
            this.AutoScroll = true;
            this.tableLayoutPanel1.AutoScroll = true;

            // Create a new semester grid and add it to UI panel
            DataGridView gridView = new DataGridView();
            gridView.Size = semesterDataGridView.Size;
            gridView.AutoSizeColumnsMode = semesterDataGridView.AutoSizeColumnsMode;
            gridView.AutoSizeRowsMode = semesterDataGridView.AutoSizeRowsMode;
            gridView.ColumnHeadersHeight = semesterDataGridView.ColumnHeadersHeight;
            gridView.DefaultCellStyle.Font = new Font("Quicksand", 14);

            foreach (DataGridViewColumn column in semesterDataGridView.Columns)
            {  
                // Adding each column from the original semester to our new semester grid.
                gridView.Columns.Add((DataGridViewColumn)column.Clone());
            }

            // Setting up our table layout panel on the left side,
            // which allows us to have the input grid and
            // the semester label next to each other, unlike a flow layout panel
            tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutPanel1.Controls.Add(gridView, 1, tableLayoutPanel1.RowCount - 1);
            tableLayoutPanel1.Font = semesterLabel.Font;

            // Add label for the semester text
            Label label= new Label();
            label.Text = "Semester " + tableLayoutPanel1.RowCount;
            label.Font = semesterLabel.Font;
            tableLayoutPanel1.Controls.Add(label, 0, tableLayoutPanel1.RowCount - 1);
            tableLayoutPanel1.ResumeLayout(true);
        }

        // Calculate the GPA button callback
        private void calculateGPAButton_Click(object sender, EventArgs e)
        {
            // Our initial totals for unweighted and weighted GPA.
            double totalWeightedGPA = 0;
            double totalUnweightedGPA = 0;


            int semester = 0;
            resultsDataGridView.Rows.Clear();

            // For each grid/semester, calculate GPAs
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is DataGridView)
                {
                    unweighted = 0;
                    weighted = 0;

                    DataGridView grid = (DataGridView)control;

                    semester++;
                    calculateGPA(grid, semester);
                    totalWeightedGPA += weighted;
                    totalUnweightedGPA += unweighted;
                }
            }
            // So long as there's more than 0 semesters, we calculated the cumulative unweighted GPA
            if (semester > 0)
            {
                totalWeightedGPA /= semester;
                totalUnweightedGPA /= semester;
                
                // Rounding for visual simplicity
                totalWeightedGPA = Math.Round(totalWeightedGPA, 2);
                totalUnweightedGPA = Math.Round(totalUnweightedGPA, 2);

                // Displaying our cumulative GPAs
                cumulativeUnweightedGPA.Text = totalUnweightedGPA.ToString();
                cumulativeWeightedGPA.Text = totalWeightedGPA.ToString();
            }
        }

        // calculate both weighted and unweigted GPAs for the given semester
        private void calculateGPA(DataGridView grid, int semester)
        {
            // Our grade, credits, and course type locations are initialized
            // alongside our total credit count.
            int gradeIndex = 1;
            int creditsIndex = 2;
            int courseTypeIndex = 3;
            double totalCredits = 0;

            // Looping through each class and getting the grade,
            // credits, course type, and credit count which we use to calculate
            // each GPA
            for (int j = 0; j < grid.RowCount - 1; j++)
            {
                // Getting the grade, credits, and courseType values from the input grid.
                String grade = grid.Rows[j].Cells[gradeIndex].Value.ToString();
                String credits = grid.Rows[j].Cells[creditsIndex].Value.ToString();
                String courseType = grid.Rows[j].Cells[courseTypeIndex].Value.ToString();

                // Getting the credit count as a double and adding it to the total credits.
                double actualCredits = double.Parse(credits);
                totalCredits += actualCredits;

                // Adding the weighted and unweighted scores to each GPA
                weighted += getWeightedScore(courseType, grade, actualCredits);
                unweighted += getUnweightedScore(grade);
            }
            // If the credit count is above zero, we get our final weighted and unweighted
            // results and display them for the semester block
            if (totalCredits > 0)
            {
                // Dividing unweighted by total classes and weighted by credit count total
                unweighted /= grid.RowCount - 1;
                weighted /= totalCredits;

                // Rounding them so they look good in the grid
                weighted = Math.Round(weighted, 2);
                unweighted = Math.Round(unweighted, 2);

                // Displaying the semester number and weighted and unweighted GPAs
                // In our results table
                int index = resultsDataGridView.Rows.Add();
                resultsDataGridView.Rows[index].Cells[0].Value = "Semester " + semester;
                resultsDataGridView.Rows[index].Cells[1].Value = weighted;
                resultsDataGridView.Rows[index].Cells[2].Value = unweighted;
            }
        }

        private double getUnweightedScore(String grade)
        {
            // Returning our mapped grade point scores.
            return gradesMapping[grade];
        }

        // Calculating our weighted score for specific courses 
        private double getWeightedScore(String courseType, String grade, double credits)
        {
            // If AP or IB, the course is worth more grade points.
            if (courseType.Equals("AP") || courseType.Equals("IB"))
            {
                return (gradesMapping[grade] + 1) * credits;
            }
            // If Honors, it's worth half as much extra points.
            else if (courseType.Equals("Honors"))
            {
                return (gradesMapping[grade] + 0.5) * credits;
            }

            // If neither are true, we just return our mapped grade points by the credit count for the course.
            return gradesMapping[grade] * credits;
        }

        // Initializing our semester data grid
        private void semesterDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            InitializeComponent();
        }

        // Initializing our text box
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        // Sending the user to their mail application allowing them to report bugs to us
        // through an email request link
        private void bugReportEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo("mailto:gradeharbor123@gmail.com?subject=GPA%20Harbor%20Bug%20Report&body=Start%20here:%20") { UseShellExecute = true });    
        }

        // Resetting all of our user's data with our reset button
        private void ResetButton_Click(object sender, EventArgs e)
        {
            // Using a pop-up window to check if the user wishes to reset their data
            if (MessageBox.Show("Are you sure you want to clear your data?", "Clear Data?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                // Clearing the results table and semester grid table, as well as resetting
                // the left-hand side of the screen
                tableLayoutPanel1.SuspendLayout();

                resultsDataGridView.Rows.Clear();
                semesterDataGridView.Rows.Clear();

                // Resetting the weighted and unweighted GPAs
                unweighted = 0;
                weighted = 0;

                // Going through each semester grid and removing it (except for the first, which is just cleared)
                int rowCount = tableLayoutPanel1.RowCount-1;
                while(rowCount >= 1 ) {
                    for (int i = 0; i < tableLayoutPanel1.ColumnCount; i++)
                    {
                        // Removing the data from each row in each column of the left hand table
                        Control Control = tableLayoutPanel1.GetControlFromPosition(i, rowCount);
                        tableLayoutPanel1.Controls.Remove(Control);
                    }

                    // Removing the row from the table on the left
                    tableLayoutPanel1.RowStyles.RemoveAt(rowCount - 1);
                    rowCount--;
                    tableLayoutPanel1.RowCount--;

                }

                // Disabling the table auto scroll and allowing
                // the table panel to resume usual layout logic
                this.AutoScroll = false;
                this.tableLayoutPanel1.AutoScroll= false;
                tableLayoutPanel1.ResumeLayout(true);

                // Displaying our cumulative GPAs
                cumulativeUnweightedGPA.Text = "0";
                cumulativeWeightedGPA.Text = "0";

            }
        }
    }
}