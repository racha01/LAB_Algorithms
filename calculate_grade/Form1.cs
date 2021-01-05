using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculate_grade
{
    public partial class โปรแกรมคำนวณเกรด : Form
    {
        public โปรแกรมคำนวณเกรด()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            int score;
            string[] grade = new string[] { "A", "B", "C", "D", "F", "N"};
            score = int.Parse(inputgrade.Text);

            if (score >= 80 && score < 101)
                outputgrade.Text = "A";
            else if (score >= 70)
                outputgrade.Text = "B";
            else if (score >= 60)
                outputgrade.Text = "C";
            else if (score >= 50)
                outputgrade.Text = "D";
            else if (score < 50 && score >= 0)
                outputgrade.Text = "F";
            else
                outputgrade.Text = "N";
                
        }
    }
}
