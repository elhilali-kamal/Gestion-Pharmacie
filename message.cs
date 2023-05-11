using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Control_2
{
    public partial class message : Form
    {
        public static bool check;
        public static string log;
        Timer t1 = new Timer();
        Timer t2 = new Timer();
        public message()
        {
            InitializeComponent();
        }

        private void buttonClick_Click(object sender, EventArgs e)
        {
            check = true;
            log = "logout";
            this.Close();
        }

        private void message_Load(object sender, EventArgs e)
        {
            log = "";
            Opacity = 0;
            t1.Interval = 10;
            t1.Tick += new EventHandler(fadeIn);
            t2.Interval = 2000;
            t2.Tick += new EventHandler(show);
            t1.Start();
           
        }
        public void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                t1.Stop();
                t2.Start();
            }
            else Opacity += 0.0125;
        }

        public void show(object sender, EventArgs e)
        {
            t2.Stop();
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
            label1.Visible = true;
            buttonClick.Visible = true;
        }

        void hide(object sender,EventArgs e)
        {
            t2.Stop();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            check = false;
            log = "quit";
            this.Close();
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
