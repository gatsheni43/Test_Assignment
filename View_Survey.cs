using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Internship_PRJ
{
    public partial class View_Survey : Form
    {/*
        public int SurveyCount { get; set; }
        public double AverageAge { get; set; }
        public int MaxAge { get; set; }
        public int MinAge { get; set; }
        public double PizzaPercentage { get; set; }
        public double PastaPercentage { get; set; }
        public double PapWorsPercentage { get; set; }
        public double AvgEatOutRating { get; set; }
        public double AvgMoviesRating { get; set; }
        public double AvgTVRating { get; set; }
        public double AvgRadioRating { get; set; }*/

        public View_Survey()
        {
            InitializeComponent();
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
