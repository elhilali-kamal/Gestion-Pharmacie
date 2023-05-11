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

namespace Projet_Control_2
{
    public partial class Form1 : Form
    {
        string cs = "Data source = . ; Initial catalog = pharmacy ; Integrated security = True";
        SqlConnection con;
        Timer t1 = new Timer();
        message msg;
        public static string name;
        public static int id;
        public static string permission;
        public static string password;
        
        public Form1()
        {
            InitializeComponent();
        }
            
       
        private void Form1_Load(object sender, EventArgs e)
        {
            //Opacity = 0;
            t1.Interval = 10;
            t1.Tick += new EventHandler(fadeIn);
            t1.Start();
            this.BackgroundImage = Properties.Resources.welcome_2;
            pictureBox1.Select();
            
        }

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1) t1.Stop();
            else Opacity += 0.0100;
        }

        void clear()
        {
            foreach(Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).Clear();
                }
            }
        }

        private void textBoxUserName_Enter(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "Username")
            {
                textBoxUserName.Text = "";
            }
        }

        private void textBoxUserName_Leave(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "")
            {
                textBoxUserName.Text = "Username";
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Text = "";
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Password";
            }
        }

        private void buttonClick_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text.Trim() != "Username" && textBoxPassword.Text.Trim() != "Password")
            {
                try
                {
                    using(con = new SqlConnection(cs))
                    {
                        SqlCommand cmd = new SqlCommand("select userid,username,permission,password from login where username = @username and password = @password", con);
                        cmd.Parameters.AddWithValue("@username", textBoxUserName.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", textBoxPassword.Text.Trim());
                        con.Open();
                        SqlDataReader dr =  cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                //name = dr[0].ToString() + " " + dr[1].ToString();
                                id = int.Parse(dr[0].ToString());
                                name = dr[1].ToString().ToUpper();
                                password = dr[3].ToString();
                                msg = new message();
                                msg.label1.Text = "Connected !";
                                msg.ShowDialog();
                                pictureBox1.Select();
                                this.Hide();
                                textBoxUserName.Text = "Username";
                                textBoxPassword.Text = "Password";
                                if (dr["permission"].ToString() != "user")
                                {
                                    permission = "admin";
                                    home home = new home();
                                    home.Closed += (s, args) => this.Show();
                                    home.Show();

                                }
                                else
                                {
                                    permission = "user";
                                    home home = new home();
                                    home.Closed += (s, args) => this.Show();
                                    home.Show();

                                }
                            }
                            dr.Close();
                        }
                        else
                        {
                            msg = new message();
                            msg.label1.Text = "Username or password is wrong ! ";
                            msg.Show();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    msg = new message();
                    msg.label1.Text = ex.Message;
                    msg.label1.TextAlign = ContentAlignment.MiddleCenter;
                    msg.ShowDialog();
                }
            }
            else
            {
                msg = new message();
                msg.label1.Text = "Please fill all empty information !";
                msg.ShowDialog(); 
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            buttonClick.Select();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxEye_Click(object sender, EventArgs e)
        {
            if (pictureBoxEye.Tag == null)
            {
                pictureBoxEye.Tag = "toogled";
                textBoxPassword.PasswordChar = '\0';
                pictureBoxEye.Image = Properties.Resources.Not_Eye_green;
            }
            else
            {
                pictureBoxEye.Tag = null;
                textBoxPassword.PasswordChar = '•';
                pictureBoxEye.Image = Properties.Resources.Eye_green;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
            contact contact = new contact();
            contact.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            contact contact = new contact();
            contact.ShowDialog();
        }
    }
}
