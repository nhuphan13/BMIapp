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
    public partial class History : Form
    {
        string Username;
        public History(string UserName)
        {
            InitializeComponent();
            Username = UserName;
            lbName.Text = string.Format("               Hello {0} Welcome to BMI Calculate !!!", UserName);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbName.Text = lbName.Text.Substring(1) + lbName.Text.Substring(0, 1);
        }

        private void backToCalculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult bck = MessageBox.Show("Do you want to go back to Main?", "back to Calculate", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (bck == DialogResult.Yes)
            {
                this.Hide();
                Main f = new Main(Username);
                f.ShowDialog();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Logout = MessageBox.Show("Do you want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Logout == DialogResult.Yes)
            {
                this.Hide();
                Login f = new Login();
                f.ShowDialog();
            }
        }

        private void History_Load(object sender, EventArgs e)
        {
            this.BackColor = Properties.Settings.Default.Background;
            dataGridView1.BackgroundColor = Properties.Settings.Default.Background;
            SqlConnection conn = new SqlConnection(@"Data Source=NHUPHAN;Initial Catalog=User;Integrated Security=True");
            try
            {
                conn.Open();
                string username = Username;
                SqlDataAdapter da = new SqlDataAdapter("select History.BMIResult, BMRResult, TDEEResult, DateTime from History Where UserName = '" + username + "'", conn);
                DataTable dttb = new DataTable();
                da.Fill(dttb);
                dataGridView1.DataSource = dttb;
            }
            catch (SqlException)
            {
                MessageBox.Show("There is an Error");
            }
        }

        private void History_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
