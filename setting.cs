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
using System.IO;

namespace Projet_Control_2
{
    public partial class setting : Form
    {
        string cs = "Data source = .; Initial catalog = pharmacy ; Integrated security = True";
        SqlConnection con;
        home home;
        string imglocation = null;
        byte[] picture;

        public setting()
        {
            InitializeComponent();
        }

        public setting(home home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void setting_Load(object sender, EventArgs e)
        {
            GetUserPicture();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text.Trim() == "" && textBoxNewPass.Text.Trim() == "" && textBoxConfirm.Text.Trim() == "")
            {
                using (con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("update login set picture = @picture where userid=@id", con);
                    cmd.Parameters.AddWithValue("@id", Form1.id);
                    if ( imglocation != null )
                    {
                        FileStream fs = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        byte[] img = br.ReadBytes((int)fs.Length);
                        cmd.Parameters.AddWithValue("@picture",img);
                    }
                    else if (imglocation == null && pictureBoxAddPicture.Tag == null)
                    {
                        cmd.Parameters.Add("@picture", SqlDbType.Image).Value = DBNull.Value;

                    }
                    else 
                    {
                        cmd.Parameters.AddWithValue("@picture", picture);
                    }
                   
                    con.Open();
                    int a = cmd.ExecuteNonQuery();
                    if (a == 1)
                    {
                        message msg = new message();
                        msg.label1.Text = "Picture is Updated !";
                        msg.ShowDialog();
                        home.getdata();
                        return;
                    }
                }
                
            }
            else if (textBoxUserName.Text.Trim() != "" && textBoxNewPass.Text.Trim() != "" && textBoxConfirm.Text.Trim() != "")
            {
                if (textBoxConfirm.Text.Trim() == textBoxNewPass.Text.Trim())
                {
                    using (con = new SqlConnection(cs))
                    {
                        SqlCommand cmd = new SqlCommand("update login set username = @username,password = @password, picture = @picture where userid=@id", con);
                        cmd.Parameters.AddWithValue("@username", textBoxUserName.Text);
                        cmd.Parameters.AddWithValue("@password", textBoxNewPass.Text);
                        cmd.Parameters.AddWithValue("@id", Form1.id);
                        if (imglocation != null)
                        {
                            FileStream fs = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                            BinaryReader br = new BinaryReader(fs);
                            byte[] img = br.ReadBytes((int)fs.Length);
                            cmd.Parameters.AddWithValue("@Picture", img);
                        }
                        else if (imglocation == null && pictureBoxAddPicture.Tag == null)
                        {
                            cmd.Parameters.Add("@picture", SqlDbType.Image).Value = DBNull.Value;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@picture", picture);
                        }
                        con.Open();
                        int a = cmd.ExecuteNonQuery();
                        if (a == 1)
                        {
                            Form1.name = textBoxUserName.Text.ToUpper();
                            message msg = new message();
                            msg.label1.Text = "Information are Updated !";
                            msg.ShowDialog();
                            Form1.name = textBoxUserName.Text.ToUpper();
                            home.getdata();
                            clear();
                            return;
                        }
                    }
                }
                else
                {
                    message msg = new message();
                    msg.label1.Text = "Please Confirm New Password !";
                    msg.Show();
                }
            }
            else
            {
                message msg = new message();
                msg.label1.Text = "Please fill all information !";
                msg.Show();
            }
        }

        void clear()
        {
            textBoxUserName.Text = textBoxNewPass.Text = textBoxConfirm.Text = string.Empty;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void pictureBoxAddPicture_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
                if (pictureBoxAddPicture.Tag == null)
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        imglocation = ofd.FileName.ToString();
                        pictureBoxPicture.Image = Image.FromFile(imglocation);
                        pictureBoxAddPicture.Tag = "toogled";
                        pictureBoxAddPicture.Image = Properties.Resources.delete_pink;
                    }
                }
                else
                {
                    imglocation = null;
                    pictureBoxAddPicture.Tag = null;
                    pictureBoxAddPicture.Image = Properties.Resources.add_2;
                    pictureBoxPicture.Image = Properties.Resources.PngItem_25602551;
                }
            }
            catch (Exception ex)
            {
                message msg = new message();
                msg.label1.Text = ex.Message;
                msg.Show();
            }
        }
        
        public void GetUserPicture()
        {
            using (con = new SqlConnection(cs))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("select picture from login where userid = @id", con);
                    cmd.Parameters.AddWithValue("@id", Form1.id);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            picture = (byte[])(reader["picture"]);
                            if(picture == null) 
                            {
                                pictureBoxAddPicture.Image = Properties.Resources.add_2;
                                pictureBoxAddPicture.Tag = null;
                            }
                            else
                            {
                                MemoryStream ms = new MemoryStream(picture);
                                pictureBoxPicture.Image = Image.FromStream(ms);
                                pictureBoxAddPicture.Tag = "toogled";
                                pictureBoxAddPicture.Image = Properties.Resources.delete_pink;  
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    pictureBoxPicture.Image = Properties.Resources.PngItem_25602551;
                }
            }
        }
    }
}
