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
    public partial class HomeClient : Form
    {
        bool clicked = true;
        public HomeClient()
        {
            InitializeComponent();
        }

        private void HomeClient_Load(object sender, EventArgs e)
        {
            mediaplayer.URL = @"C:\Users\fouad\Downloads\2000 Years.mp4";
            mediaplayer.settings.mute = false;
            mediaplayer.settings.autoStart = false;
            mediaplayer.Ctlcontrols.stop();
            
            
        }

        private void PictureBoxStart_Click(object sender, EventArgs e)
        {
            if (clicked)
            {
                PictureBoxStart.Image = Properties.Resources.start;
                clicked = false;
                mediaplayer.Ctlcontrols.play();

            }
            else
            {
                PictureBoxStart.Image = Properties.Resources.pause;
                clicked = true;
                mediaplayer.settings.autoStart = false;
                mediaplayer.Ctlcontrols.pause();
                

            }
           
            
        }

    }
}
