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

namespace UngDungTinhBMI
{
    public partial class Main : Form
    {
        double height, weight, idealWeight, heightInM, bmi, bmr, tdee;
        int age;
        string MainUserName;
        public Main(string txtUsername)
        {
            InitializeComponent();
            MainUserName = txtUsername;
            lbName.Text = string.Format("               Hello {0} Welcome to BMI Calculate !!!", MainUserName);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbName.Text = lbName.Text.Substring(1) + lbName.Text.Substring(0, 1);
        }

        private void changeBackGroundColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.Background = colorDialog.Color;
                Properties.Settings.Default.Save();
                this.BackColor = colorDialog.Color;
                lbResult.BackColor = colorDialog.Color;
                txtResult.BackColor = colorDialog.Color;

            }
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            PasswordChange pwc = new PasswordChange(MainUserName);
            pwc.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.BackColor = Properties.Settings.Default.Background;
            lbResult.BackColor = Properties.Settings.Default.Background;
            txtResult.BackColor = Properties.Settings.Default.Background;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void infor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Info f = new Info(MainUserName);
            f.Show();
        }

        private void historyWatch_Click(object sender, EventArgs e)
        {
            this.Hide();
            History f = new History(MainUserName);
            f.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult Logout = MessageBox.Show("Do you want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Logout == DialogResult.Yes)
            {
                this.Hide();
                Login f = new Login();
                f.ShowDialog();
            }
        }

        private void btIdealWeight_Click(object sender, EventArgs e)
        {
            if (cbSex.Text == "" || txtHeight.Text == "")
            {
                MessageBox.Show("Please enter your height and sex value!", "Your Ideal Weight Calculate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    height = int.Parse(txtHeight.Text);
                    if (cbSex.Text == "Man")
                    {
                        idealWeight = height - 100 - (height - 150) / 4;
                        txtResult.Text = string.Format("Your Ideal Weight is {0}Kg", idealWeight);
                    }
                    else if (cbSex.Text == "Woman")
                    {
                        idealWeight = height - 100 - (height - 150) / 2;
                        txtResult.Text = string.Format("Your Ideal Weight is {0}Kg", idealWeight);
                    }

                    lbResult.Text = "Your IdealWeight:";
                }
                catch (Exception)
                {
                    MessageBox.Show("Please provide your valid height value!", "FormatException", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btBMI_Click(object sender, EventArgs e)
        {

            if (txtWeight.Text == "" || txtHeight.Text == "") 
            {
                MessageBox.Show("Please enter your height and weight value!", "Your BMI Calculate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    height = int.Parse(txtHeight.Text);
                    weight = int.Parse(txtWeight.Text);
                    heightInM = height / 100;
                    bmi = weight / (Math.Pow((heightInM), 2));
                    if (bmi < 18.5)
                    {
                        txtResult.Text = string.Format("Your BMI is {0:0.0}, you are in underweight range!", bmi);
                    }
                    else if (bmi <= 18.5 && bmi <= 24.9)
                    {
                        txtResult.Text = string.Format("Your BMI is {0:0.0}, you are in normal range!", bmi);
                    }
                    else if (bmi >= 25 && bmi <= 29.9)
                    {
                        txtResult.Text = string.Format("Your BMI is {0:0.0}, you are in overweight range!", bmi);
                    }
                    else if (bmi >= 30 && bmi <= 34.9)
                    {
                        txtResult.Text = string.Format("Your BMI is {0:0.0}, you are in obese range!", bmi);
                    }
                    else if (bmi >= 35)
                    {
                        txtResult.Text = string.Format("Your BMI is {0:0.0}, you are in extremly obese range!", bmi);
                    }

                    lbResult.Text = "Your BMI:";

                    SqlConnection conn = new SqlConnection(@"Data Source=NHUPHAN;Initial Catalog=User;Integrated Security=True");
                    try
                    {
                        conn.Open();
                        string bmi = txtResult.Text;
                        string username = MainUserName;
                        SqlCommand cmd = new SqlCommand("insert into History(UserName, BMIResult) values('" + username + "','" + bmi + "')", conn);
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Can't connect to database");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please provide your valid height and weight value!", "FormatException", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                 
            }
        }

        private void btBMR_Click(object sender, EventArgs e)
        {
            if (txtHeight.Text == "" || txtWeight.Text == "" || txtAge.Text == "" || cbSex.Text == "") 
            {
                MessageBox.Show("Please enter your height, weight, age and sex value!", "Your BMR Calculate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    height = int.Parse(txtHeight.Text);
                    weight = int.Parse(txtWeight.Text);
                    age = int.Parse(txtAge.Text);
                    if (cbSex.Text == "Man")
                    {
                        bmr = (10 * weight) + (6.25 * height) - (5 * age) + 5;
                        txtResult.Text = String.Format("Your BMR is {0:0}Calo/day", bmr);
                    }
                    else if (cbSex.Text == "Woman")
                    {
                        bmr = (10 * weight) + (6.25 * height) - (5 * age) - 161;
                        txtResult.Text = String.Format("Your BMR is {0:0}Calo/day", bmr);
                    }

                    lbResult.Text = "Your BMR:";

                    SqlConnection conn = new SqlConnection(@"Data Source=NHUPHAN;Initial Catalog=User;Integrated Security=True");
                    try
                    {
                        conn.Open();
                        string bmr = txtResult.Text;
                        string username = MainUserName;
                        SqlCommand cmd = new SqlCommand("insert into History(UserName, BMRResult) values('" + username + "','" + bmr + "')", conn);
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Can't connect to database");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please provide your valid height, weight and age value!", "FormatException", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
            }
        }

        private void btTDEE_Click(object sender, EventArgs e)
        {
            if (txtHeight.Text == "" || txtWeight.Text == "" || txtAge.Text == ""  || cbActivity.Text == "" || cbSex.Text == "") 
            {
                MessageBox.Show("Please enter your height, weight, age, sex and activity factor value!", "Your TDEE Calculate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    height = int.Parse(txtHeight.Text);
                    weight = int.Parse(txtWeight.Text);
                    age = int.Parse(txtAge.Text);
                    if (cbSex.Text == "Man")
                    {
                        bmr = (10 * weight) + (6.25 * height) - (5 * age) + 5;
                    }
                    else if (cbSex.Text == "Woman")
                    {
                        bmr = (10 * weight) + (6.25 * height) - (5 * age) - 161;
                    }
                    if (cbActivity.Text == "Sedentary (little to no exercise + work a desk job)")
                    {
                        tdee = bmr * 1.2;
                    }
                    else if (cbActivity.Text == "Lightly Active (light exercise 1-3 days / week)")
                    {
                        tdee = bmr * 1.375;
                    }
                    else if (cbActivity.Text == "Moderately Active (moderate exercise 3-5 days / week)")
                    {
                        tdee = bmr * 1.375;
                    }
                    else if (cbActivity.Text == "Very Active (heavy exercise 6-7 days / week)")
                    {
                        tdee = bmr * 1.725;
                    }
                    else if (cbActivity.Text == "Extremely Active (very heavy exercise, training 2x / day)")
                    {
                        tdee = bmr * 1.9;
                    }

                    txtResult.Text = String.Format("Your TDEE is {0:0}Calo/day", tdee);

                    lbResult.Text = "Your TDEE:";

                    SqlConnection conn = new SqlConnection(@"Data Source=NHUPHAN;Initial Catalog=User;Integrated Security=True");
                    try
                    {
                        conn.Open();
                        string tdee = txtResult.Text;
                        string username = MainUserName;
                        SqlCommand cmd = new SqlCommand("insert into History(UserName, TDEEResult) values('" + username + "','" + tdee + "')", conn);
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Can't connect to database");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please provide your valid height, weight and age value!", "FormatException", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                 
            }
        }
    }
}
