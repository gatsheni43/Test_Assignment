using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internship_PRJ
{
    public partial class Screen_1 : Form
    {
        public Screen_1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Fill_Survey_Click(object sender, EventArgs e)
        {
            Screen_2 screen_2 = new Screen_2();
            screen_2.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void View_Survey_Click(object sender, EventArgs e)
        {
            
        }

        private void Survey_data_Click(object sender, EventArgs e)
        {

            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=M-NDLOVU;Initial Catalog=Tablesurvey;Integrated Security=True"))
                {
                    string countQuery = "SELECT COUNT(*) FROM surveyData";
                    string avgAgeQuery = "SELECT AVG([Age]) FROM surveyData";
                    string maxAgeQuery = "SELECT MAX([Age]) FROM surveyData";
                    string minAgeQuery = "SELECT MIN([Age]) FROM surveyData";
                    string pizzaPercentageQuery = "SELECT (COUNT(*) * 100.0) / (SELECT COUNT(*) FROM surveyData) FROM surveyData WHERE [Pizza] = 1";
                    string pastaPercentageQuery = "SELECT (COUNT(*) * 100.0) / (SELECT COUNT(*) FROM surveyData) FROM surveyData WHERE [Pasta] = 1";
                    string papWorsPercentageQuery = "SELECT (COUNT(*) * 100.0) / (SELECT COUNT(*) FROM surveyData) FROM surveyData WHERE [Pap] = 1";
                    string avgEatOutQuery = "SELECT AVG([EatOut]) FROM surveyData";
                    string avgMoviesQuery = "SELECT AVG([WatchMovies]) FROM surveyData";
                    string avgRadioQuery = "SELECT AVG([ListenRadio]) FROM surveyData";

                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = countQuery;
                        int surveyCount = (int)cmd.ExecuteScalar();
                        cmd.CommandText = avgAgeQuery;
                        object averageAgeObject = cmd.ExecuteScalar();
                        decimal averageAgeValue = averageAgeObject != DBNull.Value ? Convert.ToDecimal(averageAgeObject) : 0;
                        double averageAge = Convert.ToDouble(averageAgeValue);
                        cmd.CommandText = maxAgeQuery;
                        int maxAge = (int)cmd.ExecuteScalar();
                        cmd.CommandText = minAgeQuery;
                        int minAge = (int)cmd.ExecuteScalar();
                        cmd.CommandText = pizzaPercentageQuery;
                        object pizzaPercentageObject = cmd.ExecuteScalar();
                        decimal pizzaPercentageValue = pizzaPercentageObject != DBNull.Value ? Convert.ToDecimal(pizzaPercentageObject) : 0;
                        double pizzaPercentage = Convert.ToDouble(pizzaPercentageValue) / 100.0;
                        cmd.CommandText = pastaPercentageQuery;
                        object pastaPercentageObject = cmd.ExecuteScalar();
                        decimal pastaPercentageValue = pastaPercentageObject != DBNull.Value ? Convert.ToDecimal(pastaPercentageObject) : 0;
                        double pastaPercentage = Convert.ToDouble(pastaPercentageValue) / 100.0;
                        cmd.CommandText = papWorsPercentageQuery;
                        object papWorsPercentageObject = cmd.ExecuteScalar();
                        decimal papWorsPercentageValue = papWorsPercentageObject != DBNull.Value ? Convert.ToDecimal(papWorsPercentageObject) : 0;
                        double papWorsPercentage = Convert.ToDouble(papWorsPercentageValue) / 100.0;
                        cmd.CommandText = avgEatOutQuery;
                        object avgEatOutRatingObject = cmd.ExecuteScalar();
                        int avgEatOutRating = avgEatOutRatingObject != DBNull.Value ? Convert.ToInt32(avgEatOutRatingObject) : 0;
                        cmd.CommandText = avgMoviesQuery;
                        object avgMoviesRatingObject = cmd.ExecuteScalar();
                        int avgMoviesRating = avgMoviesRatingObject != DBNull.Value ? Convert.ToInt32(avgMoviesRatingObject) : 0;
                        //cmd.CommandText = avgTVQuery;
                        //double avgTVRating = (double)cmd.ExecuteScalar();
                        cmd.CommandText = avgRadioQuery;
                        object avgRadioRatingObject = cmd.ExecuteScalar();
                        int avgRadioRating = avgRadioRatingObject != DBNull.Value ? Convert.ToInt32(avgRadioRatingObject) : 0;

                        string summary = "Survey Summary:\n\n" +
                            "Total number of surveys: " + surveyCount + "\n" +
                            "Average age: " + averageAge + "\n" +
                            "Oldest person who participated in the survey: " + maxAge + "\n" +
                            "Youngest person who participated in the survey: " + minAge + "\n" +
                            "Percentage of people who like Pizza: " + pizzaPercentage + "%\n" +
                            "Percentage of people who like Pasta: " + pastaPercentage + "%\n" +
                            "Percentage of people who like Pap and Wors: " + papWorsPercentage + "%\n" +
                            "People like to eat out: " + avgEatOutRating + "\n" +
                            "People like to watch movies: " + avgMoviesRating + "\n" +
                          //  "People like to watch TV: " + avgTVRating + "\n" +
                            "People like to listen to the radio: " + avgRadioRating;

                        MessageBox.Show(summary, "Survey Summary");





                    }
                }
            }
        }

    }
}
