using System.Data;
using System.Windows.Forms;

namespace GPAUX
{
    public partial class Form1 : Form
    {
        double weighted = 0;
        double unweighted = 0;

        // mapping letter grades to points
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

        public Form1()
        {
            InitializeComponent();
        }

        // add new semester grid
        private void addSemesterButton_Click(object sender, EventArgs e)
        {
            // create a new semester grid and add it to UI panel
            DataGridView gridView = new DataGridView();
            gridView.Size = semesterDataGridView.Size;
            foreach (DataGridViewColumn column in semesterDataGridView.Columns)
            {  
                gridView.Columns.Add((DataGridViewColumn)column.Clone());
            }
            tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutPanel1.Controls.Add(gridView, 1, tableLayoutPanel1.RowCount - 1);
            // add label for semester text
            Label label= new Label();
            label.Text = "Semester" + tableLayoutPanel1.RowCount;
            label.Font = semesterLabel.Font;
            tableLayoutPanel1.Controls.Add(label, 0, tableLayoutPanel1.RowCount - 1);

        }

        // calculate GPA button callback
        private void calculateGPAButton_Click(object sender, EventArgs e)
        {
            double totalWeightedGPA = 0;
            double totalUnweightedGPA = 0;


            int semester = 0;
            resultsDataGridView.Rows.Clear();
            // for each grid/semester, calculate GPAs
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
            if (semester > 0)
            {
                totalWeightedGPA /= semester;
                totalUnweightedGPA /= semester;

                totalWeightedGPA = Math.Round(totalWeightedGPA, 2);
                totalUnweightedGPA = Math.Round(totalUnweightedGPA, 2);

                cumulativeUnweightedGPA.Text = totalUnweightedGPA.ToString();
                cumulativeWeightedGPA.Text = totalWeightedGPA.ToString();
            }
        }

        // calculate both weighted and unweigted GPAs for the given semester
        private void calculateGPA(DataGridView grid, int semester)
        {
            int gradeIndex = 1;
            int creditsIndex = 2;
            int courseTypeIndex = 3;

            double totalCredits = 0;

            for (int j = 0; j < grid.RowCount - 1; j++)
            {
                String grade = grid.Rows[j].Cells[gradeIndex].Value.ToString();
                String credits = grid.Rows[j].Cells[creditsIndex].Value.ToString();
                String courseType = grid.Rows[j].Cells[courseTypeIndex].Value.ToString();

                double actualCredits = double.Parse(credits);
                totalCredits += actualCredits;

                weighted += getWeightedScore(courseType, grade, actualCredits);
                unweighted += getUnweightedScore(grade);
            }
            if (totalCredits > 0)
            {
                unweighted /= grid.RowCount - 1;
                weighted /= totalCredits;

                // Rounding them so they look good in the grid
                weighted = Math.Round(weighted, 2);
                unweighted = Math.Round(unweighted, 2);

                int index = resultsDataGridView.Rows.Add();
                resultsDataGridView.Rows[index].Cells[0].Value = "Semester" + semester;
                resultsDataGridView.Rows[index].Cells[1].Value = weighted;
                resultsDataGridView.Rows[index].Cells[2].Value = unweighted;
            }
        }

        private double getUnweightedScore(String grade)
        {
            return gradesMapping[grade];
        }

        // calculate weighted score for specific courses 
        private double getWeightedScore(String courseType, String grade, double credits)
        {
            if (courseType.Equals("AP") || courseType.Equals("IB"))
            {
                return (gradesMapping[grade] + 1) * credits;
            }
            else if (courseType.Equals("Honors"))
            {
                return (gradesMapping[grade] + 0.5) * credits;
            }

            return gradesMapping[grade] * credits;
        }
    }
}