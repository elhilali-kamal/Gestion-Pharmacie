using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Control_2
{
    public partial class Comment : Form
    {
        pharmacyEntities2 dc;
        public int id;
        bool clicked = true;
        int likes;
        byte[] pic;
        CommunityForm cf;
        public Comment()
        {
            InitializeComponent();
        }

        public Comment(CommunityForm c)
        {
            InitializeComponent();
            this.cf = c;
        }
      

        public Comment(int id,string username,byte[] picture,string comment,int likes, CommunityForm cf)
        {
            InitializeComponent();
            this.Username = username;
            if (picture == null)
            {
                this.pic = null;
                this.Picture = Properties.Resources.PngItem_25602551;
            }
            else
            {
                this.pic = picture;
                this.Picture = convert(picture);
            }
             
            this.Comments = comment;
            this.Likes = likes;
            this.Id = id;
            this.cf = cf;
        }

        public string Username { get => labelClientName.Text; set => labelClientName.Text = value; }
        public Image Picture { get => pictureboxClientPic.Image; set => pictureboxClientPic.Image = value; }
        public string Comments { get => labelComment.Text; set => labelComment.Text = value; }
        public int Likes { get => likes; set => likes = value; }

        public int Id { get => id; set => id = value; }

        Image convert(byte[] img)
        {
            byte[] picture = (byte[])(img);
            MemoryStream ms = new MemoryStream(picture);
            return Image.FromStream(ms);
        }

        private void pictureBoxLike_Click(object sender, EventArgs e)
        {
            if (clicked)
            {
                pictureBoxLike.Image = Properties.Resources.Like_Green;
                pictureBoxLike.Size = new Size(41, 30);
                likes++;
                labelLikes.Text = likes.ToString() + " Likes";
                clicked = false;
                
            }
            else
            {
                pictureBoxLike.Image = Properties.Resources.Like_Grey;
                pictureBoxLike.Size = new Size(40, 30);
                likes--;
                labelLikes.Text = likes.ToString() + " Likes";
                clicked = true;
               
            }
        }
    
      
        private void buttonPost_Click(object sender, EventArgs e)
        {
            try
            {
                if(buttonPost.Text == "Update")
                {
                    community cm = new community();
                    using (dc = new pharmacyEntities2())
                    {
                        cm = dc.communities.SingleOrDefault(c => c.id == this.id);
                        cm.comment = textBoxComment.Text;
                        dc.SaveChanges();
                        message msg = new message();
                        msg.label1.Text = "Comment is updated succussefuly !";
                        msg.ShowDialog();
                        cf.getdata();
                        this.Close();
                    }
                }
                else
                {
                    using(dc = new pharmacyEntities2())
                    {
                        community cmt = new community();
                        cmt.clientid = Form1.id;
                        cmt.comment = textBoxComment.Text;
                        cmt.likes = 0;
                        cmt.publshDate = DateTime.Now;
                        cmt.reportCounter = 0;
                        dc.communities.Add(cmt);
                        message msg = new message();
                        msg.label1.Text = "Comment is posted successfully !";
                        msg.ShowDialog();
                        textBoxComment.Text = "";
                        dc.SaveChanges();
                        cf.getdata();
                        this.Close();
                    }
                   
                }
            }
                
               
            catch (Exception ex)
            {
                message msg = new message();
                msg.label1.Text = ex.Message;
                msg.ShowDialog();
            }
        }

        private void Comment_Load(object sender, EventArgs e)
        {
            labelLikes.Text = likes.ToString() + " Likes";
        }

        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
     
        }

        private void pictureBoxRemoveComment_Click(object sender, EventArgs e)
        {
            try
            {   if((string)pictureBoxRemoveComment.Tag == "close")
                {
                    this.Close();
                }
                else
                {
                    message msg = new message();
                    msg.buttonClick.Size = new Size(82, 38);
                    msg.buttonClick.Text = "Yes";
                    msg.buttonNo.Visible = true;
                    msg.label1.Text = "Do you really want to delete this Comment ?";
                    msg.fadeIn(null, null);
                    msg.show(null, null);
                    msg.ShowDialog();
                    if (message.check)
                    {
                        community cm = new community();
                        using (dc = new pharmacyEntities2())
                        {
                            cm = dc.communities.SingleOrDefault(c => c.id == this.id);
                            dc.communities.Remove(cm);
                            dc.SaveChanges();
                            message msg1 = new message();
                            msg1.label1.Text = "Comment is deleted successfully !";
                            msg1.ShowDialog();
                            cf.getdata();

                        }
                    }
                    
                }
                
            }
            catch (Exception ex)
            {
                message msg = new message();
                msg.label1.Text = ex.Message;
                msg.ShowDialog();
            }
        }

        private void pictureBoxEdit_Click(object sender, EventArgs e)
        {
            community cm = new community();
            using (dc = new pharmacyEntities2())
            {
                test test = new test();
                if (!home.minimazed)
                {
                    test.WindowState = FormWindowState.Maximized;
                    test.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
                }

                else
                    test.WindowState = FormWindowState.Normal;
                test.Show();
                cm = dc.communities.SingleOrDefault(c => c.id == this.id);
                Comment comment = new Comment(Id, Username,pic, Comments, Likes,cf) ;
                foreach (Control item in comment.Controls)
                {
                    if ((string)item.Tag != "add") { item.Visible = false; }
                    else { item.Visible = true; }
                }
                comment.pictureboxClientPic.Image = home.userpic;
                comment.labelClientName.Text = Form1.name;
                comment.textBoxComment.Text = Comments;
                comment.buttonPost.Text = "Update";
                comment.pictureBoxRemoveComment.Tag = "close";
                comment.ShowDialog();
                test.Close();

            }
        }
    }
}
