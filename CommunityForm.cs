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
    public partial class CommunityForm : Form
    {
        pharmacyEntities2 dc;
        public CommunityForm()
        {
            InitializeComponent();
        }

        private void labelAddComment_Click(object sender, EventArgs e)
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
            Comment cmt = new Comment(this);
            foreach(Control item in cmt.Controls)
            {
                if((string)item.Tag != "add") { item.Visible = false; }
                else { item.Visible = true; }
            }
            cmt.pictureBoxRemoveComment.Tag = "close";
            cmt.pictureboxClientPic.Image = home.userpic;
            cmt.labelClientName.Text = Form1.name;
            cmt.ShowDialog();
            test.Close();
        }

        public void getdata()
        {
            if (home.minimazed)
            {
                tableLayoutPanel1.ColumnCount = 2;
            }
            else
            {
                tableLayoutPanel1.ColumnCount = 3;
            }
            tableLayoutPanel1.Controls.Clear();
            using (dc = new pharmacyEntities2())
            {
                var item = from C in dc.communities select C;
                List<community> cmt = new List<community>();
                cmt = item.ToList();
                int id;
                int count = 1;
                string name = null;
                byte[] pic = null;
                foreach (community obj in cmt)
                {

                    id = obj.clientid.Value;
                    List<login> list = new List<login>();
                    list = (from C in dc.logins where C.userid == id select C).ToList();
                    foreach (login l in list)
                    {
                        pic = l.picture;
                        name = l.username.ToString();
                    }
                    int idcomment = obj.id;
                    string comment = obj.comment;
                    int likes = (int)obj.likes;
                    Comment cm = new Comment(idcomment, name, pic, comment, likes, this);
                    if (obj.clientid == Form1.id)
                    {
                        cm.labelReport.Visible = false;
                        cm.pictureBoxRemoveComment.Visible = true;
                        cm.pictureBoxEdit.Visible = true;
                    }
                    else
                    {
                        cm.pictureBoxRemoveComment.Visible = false;
                        cm.pictureBoxRemoveComment.Visible = false;
                        cm.labelReport.Visible = true;

                    }
                    cm.TopLevel = false;
                    cm.Dock = DockStyle.Fill;
                    cm.AutoSize = false;
                    tableLayoutPanel1.Controls.Add(cm);
                    cm.Show();
                    tableLayoutPanel1.RowCount = count++;
                }
            }

        }

        private void CommunityForm_Load(object sender, EventArgs e)
        {
            getdata();
        }
    }
}
