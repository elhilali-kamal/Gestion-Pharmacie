using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Control_2
{
    public partial class contact : Form
    {
        public contact()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void contact_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.v870_mynt_14;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelFacebook_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\fouad\AppData\Local\Programs\Opera GX\launcher.exe", "https://www.facebook.com");

        }

        

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
