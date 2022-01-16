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
using System.Drawing.Drawing2D;

namespace UngDungTinhBMI
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void txtRUsername_Enter(object sender, EventArgs e)
        {
            if (txtRUsername.Text == "UserName")
            {
                txtRUsername.Text = "";
                txtRUsername.ForeColor = Color.FromArgb(124, 192, 204);
            }
        }

        private void txtRUsername_Leave(object sender, EventArgs e)
        {
            if (txtRUsername.Text == "")
            {
                txtRUsername.Text = "UserName";
                txtRUsername.ForeColor = Color.DimGray;
            }
        }

        private void txtRPassword_Enter(object sender, EventArgs e)
        {
            if (txtRPassword.Text == "Password")
            {
                txtRPassword.Text = "";
                txtRPassword.ForeColor = Color.FromArgb(124, 192, 204);
                txtRPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtRPassword_Leave(object sender, EventArgs e)
        {
            if (txtRPassword.Text == "")
            {
                txtRPassword.Text = "Password";
                txtRPassword.ForeColor = Color.DimGray;
                txtRPassword.UseSystemPasswordChar = false;
                pbShowPass.BringToFront();
            }
        }

        private void txtConfirm_Enter(object sender, EventArgs e)
        {
            if (txtConfirm.Text == "Confirm Password")
            {
                txtConfirm.Text = "";
                txtConfirm.ForeColor = Color.FromArgb(124, 192, 204);
                txtConfirm.UseSystemPasswordChar = true;
            }
        }

        private void txtConfirm_Leave(object sender, EventArgs e)
        {
            if (txtConfirm.Text == "")
            {
                txtConfirm.Text = "Confirm Password";
                txtConfirm.ForeColor = Color.DimGray;
                txtConfirm.UseSystemPasswordChar = false;
                pbShowCfPass.BringToFront();
            }
        }

        private void pbShowPass_Click(object sender, EventArgs e)
        {
            if (txtRPassword.Text == "")
            {
                txtRPassword.UseSystemPasswordChar = true;
            }
            else if (txtRPassword.UseSystemPasswordChar == true)
            {
                txtRPassword.UseSystemPasswordChar = false;
                pbHidePass.BringToFront();
            }
        }

        private void pbHidePass_Click(object sender, EventArgs e)
        {
            if (txtRPassword.UseSystemPasswordChar == false)
            {
                txtRPassword.UseSystemPasswordChar = true;
                pbShowPass.BringToFront();
            }
        }

        private void pbShowConfPass_Click(object sender, EventArgs e)
        {
            if (txtConfirm.Text == "")
            {
                txtConfirm.UseSystemPasswordChar = true;
            }
            else if (txtConfirm.UseSystemPasswordChar == true)
            {
                txtConfirm.UseSystemPasswordChar = false;
                pbHideCfPass.BringToFront();
            }
        }

        private void pbHideConfPass_Click(object sender, EventArgs e)
        {
            if (txtConfirm.UseSystemPasswordChar == false)
            {
                txtConfirm.UseSystemPasswordChar = true;
                pbShowCfPass.BringToFront();
            }
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=NHUPHAN;Initial Catalog=User;Integrated Security=True");
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select UserName from Login where UserName ='" + txtRUsername.Text + "'", conn);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            if (dtb.Rows.Count >= 1)
            {
                MessageBox.Show("Account already exist");
            }
            else
            {
                if (txtRUsername.Text == "UserName")
                {
                    MessageBox.Show("Please enter your Username", "Registation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRUsername.Focus();
                }
                else if (txtRPassword.Text == "Password")
                {
                    MessageBox.Show("Please enter your Password", "Registation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRPassword.Focus();
                }
                else if (txtConfirm.Text == "Confirm Password")
                {
                    MessageBox.Show("Please enter your Confirm Password", "Registation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConfirm.Focus();
                }
                else 
                {
                    if (txtConfirm.Text == txtRPassword.Text)
                        try
                        {
                            string username = txtRUsername.Text;
                            string password = txtRPassword.Text;
                            SqlCommand cmd = new SqlCommand("insert into Login(UserName, Password) values('" + username + "','" + password + "')", conn);
                            cmd.ExecuteNonQuery();
                            this.Hide();
                            Main f = new Main(username);
                            f.Show();
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("There is an Error");
                        }
                    else
                    {
                        MessageBox.Show("Confirm Password does not match, Please Re-entry", "Registation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtConfirm.Focus();
                    }
                }
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f = new Login();
            f.ShowDialog();
        }

        private void Register_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1); 
            LinearGradientBrush linGrBrush2 = new LinearGradientBrush(area,
               Color.FromArgb(43, 44, 170), Color.FromArgb(150, 54, 148), 45);
            graphics.FillRectangle(linGrBrush2, area);
            
        }
    }
}
