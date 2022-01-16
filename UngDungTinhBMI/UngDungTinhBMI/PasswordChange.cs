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
    public partial class PasswordChange : Form
    {
        string PCUserName;
        public PasswordChange(string MainUsername)
        {
            InitializeComponent();
            PCUserName = MainUsername;
        }

        private void txtOldPassword_Enter(object sender, EventArgs e)
        {
            if (txtOldPassword.Text == "Old Password")
            {
                txtOldPassword.Text = "";
                txtOldPassword.ForeColor = Color.FromArgb(34, 36, 49);
                txtOldPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtOldPassword_Leave(object sender, EventArgs e)
        {
            if (txtOldPassword.Text == "")
            {
                txtOldPassword.Text = "Old Password";
                txtOldPassword.ForeColor = Color.DimGray;
                txtOldPassword.UseSystemPasswordChar = false;
                pbShowPass.BringToFront();
            }
        }

        private void txtNewPassword_Enter(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == "New Password")
            {
                txtNewPassword.Text = "";
                txtNewPassword.ForeColor = Color.FromArgb(34, 36, 49);
                txtNewPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtNewPassword_Leave(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == "")
            {
                txtNewPassword.Text = "New Password";
                txtNewPassword.ForeColor = Color.DimGray;
                txtNewPassword.UseSystemPasswordChar = false;
                pbShowNewPass.BringToFront();
                
            }
        }

        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == "Confirm Password")
            {
                txtConfirmPassword.Text = "";
                txtConfirmPassword.ForeColor = Color.FromArgb(34, 36, 49);
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == "")
            {
                txtConfirmPassword.Text = "Confirm Password";
                txtConfirmPassword.ForeColor = Color.DimGray;
                txtConfirmPassword.UseSystemPasswordChar = false;
                pbShowCfPass.BringToFront();
            }
        }

        private void btChange_Click(object sender, EventArgs e)
        {
           if (txtOldPassword.Text == "Old Password")
            {
                MessageBox.Show("Please enter your Old Password", "Change Password Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOldPassword.Focus();
            }
            else if (txtNewPassword.Text == "New Password")
            {
                MessageBox.Show("Please enter your New Password", "Change Password Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewPassword.Focus();
            }
            else if (txtConfirmPassword.Text == "Confirm Password")
            {
                MessageBox.Show("Please enter your Confirm Password", "Change Password Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPassword.Focus();
            }
            else if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Confirm Password does not match, Please Re-entry", "Change Password Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPassword.Focus();
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=NHUPHAN;Initial Catalog=User;Integrated Security=True");
                string user = PCUserName;
                string oldpass = txtOldPassword.Text;
                SqlDataAdapter adt = new SqlDataAdapter("select count(*) from Login where UserName= '" + user + "' and Password= '" + oldpass + "'", conn);
                DataTable checktb = new DataTable();
                adt.Fill(checktb);
                if (checktb.Rows[0][0].ToString() == "1")
                {
                    if (txtNewPassword.Text == txtConfirmPassword.Text)
                    {
                        try
                        {
                            conn.Open();
                            string newpassword = txtNewPassword.Text;
                            string usernames = PCUserName;
                            string oldpassword = PCUserName;
                            SqlCommand cmd = new SqlCommand("update Login set Password ='" + newpassword + "' where UserName ='"+usernames+"' and Password ='"+oldpass+"'", conn);
                            cmd.ExecuteNonQuery();
                            this.Hide();
                            Main f = new Main(PCUserName);
                            f.Show();
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("There is an Error");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Your old password does not correct!", "Worng old password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main f = new Main(PCUserName);
            f.ShowDialog();
        }

        private void pbShowPass_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text == "")
            {
                txtOldPassword.UseSystemPasswordChar = true;
            }
            else if (txtOldPassword.UseSystemPasswordChar == true)
            {
                txtOldPassword.UseSystemPasswordChar = false;
                pbHidePass.BringToFront();
            }
        }

        private void pbHidePass_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.UseSystemPasswordChar == false)
            {
                txtOldPassword.UseSystemPasswordChar = true;
                pbShowPass.BringToFront();
            }
        }

        private void pbShowNewPass_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == "")
            {
                txtNewPassword.UseSystemPasswordChar = true;
            }
            else if (txtNewPassword.UseSystemPasswordChar == true)
            {
                txtNewPassword.UseSystemPasswordChar = false;
                pbHideNewPass.BringToFront();
            }
        }

        private void pbHideNewPass_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.UseSystemPasswordChar == false)
            {
                txtNewPassword.UseSystemPasswordChar = true;
                pbShowNewPass.BringToFront();
            }
        }

        private void pbShowCfPass_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == "")
            {
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
            else if (txtConfirmPassword.UseSystemPasswordChar == true)
            {
                txtConfirmPassword.UseSystemPasswordChar = false;
                pbHideCfPass.BringToFront();
            }
        }

        private void pbHideCfPass_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.UseSystemPasswordChar == false)
            {
                txtConfirmPassword.UseSystemPasswordChar = true;
                pbShowCfPass.BringToFront();
            }
        }

        private void PasswordChange_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PasswordChange_Load(object sender, EventArgs e)
        {
            label1.ForeColor = Properties.Settings.Default.Background;
            btChange.ForeColor = Properties.Settings.Default.Background;
            btExit.ForeColor = Properties.Settings.Default.Background;
        }
    }
}
