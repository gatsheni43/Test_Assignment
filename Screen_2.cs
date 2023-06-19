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
    public partial class Screen_2 : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=M-NDLOVU;Initial Catalog=Tablesurvey;Integrated Security=True");

        public Screen_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO surveyData ([Surname], [Names], [Contact], [Age], [Pizza], [Pasta], [Pap], [Chicken], [Beef], [Other]) VALUES (@Surname, @Names, @Contact, @Age, @Pizza, @Pasta, @Pap, @Chicken, @Beef, @Other)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Surname", textBox_Surname.Text);
                    cmd.Parameters.AddWithValue("@Names", textBox_FirstName.Text);
                    cmd.Parameters.AddWithValue("@Contact", textBox_Contact.Text);
                    cmd.Parameters.AddWithValue("@Age", textBox_Age.Text);
                    cmd.Parameters.AddWithValue("@Pizza", GetLikertScaleValue(groupBox1));
                    cmd.Parameters.AddWithValue("@Pasta", GetLikertScaleValue(groupBox2));
                    cmd.Parameters.AddWithValue("@Pap", GetLikertScaleValue(groupBox3));
                    cmd.Parameters.AddWithValue("@Chicken", GetLikertScaleValue(groupBox4));
                    cmd.Parameters.AddWithValue("@Beef", GetLikertScaleValue(groupBox5));
                    cmd.Parameters.AddWithValue("@Other", GetLikertScaleValue(groupBox6));

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Data Saved Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private int GetLikertScaleValue(GroupBox groupBox)
        {
            foreach (RadioButton radioButton in groupBox.Controls.OfType<RadioButton>())
            {
                if (radioButton.Checked && radioButton.Tag != null)
                {
                    if (int.TryParse(radioButton.Tag.ToString(), out int value))
                    {
                        // Return the selected Likert scale value (1 to 4)
                        return value;
                    }
                }
            }
            return 0; // Return 0 if no option is selected or value is not valid
        
        }
    }
}






