using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerrassingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTeam1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btnTeam2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "ging viel een eekhoorn uit de boom";
        }

        private void btnTeam3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void btnTeam4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }
    }
}
