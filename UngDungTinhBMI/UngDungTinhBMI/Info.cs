using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungTinhBMI
{
    public partial class Info : Form
    {
        string InfoUserName;
        public Info(string MainUserName)
        {
            InitializeComponent();
            InfoUserName = MainUserName;
        }

        private void Info_Load(object sender, EventArgs e)
        {
            this.BackColor = Properties.Settings.Default.Background;
        }

        private void Info_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Main f = new Main(InfoUserName);
            f.ShowDialog();
        }
    }
}
