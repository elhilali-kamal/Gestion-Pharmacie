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
using System.Runtime.InteropServices;

namespace Projet_Control_2
{
    public partial class home : Form
    {
        string cs = "Data source = . ; Initial catalog = pharmacy ; Integrated security = True";
        SqlConnection con;
        Timer timer1;
        public static bool minimazed;
        bool inmedicine;
        bool inorder;
        bool incommunity;
        public static Image userpic;
       



        public home()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {
            timer1 = new Timer();
            timer1.Interval = 100;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
            getdata();
            panel3.Visible = true;
            buttonHome_Click(null, null);
            if(Form1.permission != "admin")
                buttonClient.Text = "Community";
                


        }

        public void getdata()
        {
            this.BackgroundImage = Properties.Resources.v870_tang_30;
            labelFullName.Text = Form1.name;
            labelDate.Select();
            minimazed = true;
            try
            {
                using (con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("select username,picture from login where username = @username;select count(*) from client;select medicineid,title from medicine where quantity = '0'", con);
                    cmd.Parameters.AddWithValue("@username", Form1.name);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Form1.name = reader["username"].ToString().ToUpper();
                            if (reader["picture"] == DBNull.Value)
                            {
                                pictureboxP.Image = Properties.Resources.PngItem_25602551;
                            }
                            else
                            {
                                byte[] picture = (byte[])(reader["picture"]);
                                MemoryStream ms = new MemoryStream(picture);
                                pictureboxP.Image = Image.FromStream(ms);
                            }
                            userpic = pictureboxP.Image;
                            
                        }
                        reader.NextResult();
                        while (reader.Read())
                        {
                            if(reader.HasRows)
                                labelClient.Text = reader[0].ToString();
                        }
                        reader.NextResult();
                        if (reader.HasRows)
                        {
                            BindingSource source = new BindingSource();
                            source.DataSource = reader;
                            dataGridView1.DataSource = source;
                        }
                        else
                        {
                            dataGridView1.Rows.Clear();
                        }
                


                    }
                }
              
            }
            catch (Exception ex)
            {
                message msg = new message();
                msg.label1.Text = ex.Message;
                msg.Show();
            }
        }
        
        void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            labelTime.Text = time.ToString("hh:mm");
            labelSec.Text = time.ToString(":ss");
            labelDay.Text = time.ToString("dddd");
            labelDate.Text = time.ToString("dd MMM yyyy");
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            foreach (Button btn in this.panel2.Controls)
            {
                if (btn.Text == "Home") { btn.BackColor = Color.Honeydew; }
                else btn.BackColor = Color.FromArgb(224, 239, 236);
            }
            labelFormName.Text = "Home";
            panel3.Controls.Clear();
            panel3.Visible = true;
            inmedicine = false;
            inorder = false;
            incommunity = false;
            if (Form1.permission == "admin")
            {
                panel3.Controls.Add(tableLayoutPanel1);
                getdata();
            }
            else
            {

                HomeClient home = new HomeClient();
                home.TopLevel = false;
                home.Dock = DockStyle.Fill;
                panel3.Controls.Add(home);
                home.Show();
            }

            
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            foreach (Button btn in this.panel2.Controls)
            {
                if (btn.Text == "Client" || btn.Text == "Community") { btn.BackColor = Color.Honeydew; }
                else btn.BackColor = Color.FromArgb(224, 239, 236);
            }
            inmedicine = false;
            inorder = false;
            incommunity = false;
            if (Form1.permission == "admin")
            {
                labelFormName.Text = "Client";
                panel3.Controls.Clear();
                ClientForm c = new ClientForm();
                c.TopLevel = false;
                panel3.Controls.Add(c);
                c.Dock = DockStyle.Fill;
                panel3.Visible = true;
                c.Show();
            }
            else
            {
                incommunity = true;
                labelFormName.Text = "Community";
                panel3.Controls.Clear();
                CommunityForm form = new CommunityForm();
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                panel3.Controls.Add(form);
                panel3.Visible = true;
                form.Show();
            }
        }

        private void buttonMedicine_Click(object sender, EventArgs e)
        {
            foreach (Button btn in this.panel2.Controls)
            {
                if (btn.Text == "Medicine") { btn.BackColor = Color.Honeydew; }
                else btn.BackColor = Color.FromArgb(224, 239, 236);
            }
            labelFormName.Text = "Medicine";
            panel3.Controls.Clear();
            medicines med = new medicines(this);
            med.TopLevel = false;
            panel3.Controls.Add(med);
            med.Dock = DockStyle.Fill;
            med.Show();
            panel3.Visible = true;
            inorder = false;
            incommunity = false;
            inmedicine = true;
        }
        private void buttonOrder_Click(object sender, EventArgs e)
        {
            foreach (Button btn in this.panel2.Controls)
            {
                if (btn.Text == "Order") { btn.BackColor = Color.Honeydew; }
                else btn.BackColor = Color.FromArgb(224, 239, 236);
            }
            labelFormName.Text = "Order";
            panel3.Controls.Clear();
            orders order = new orders();
            order.TopLevel = false;
            panel3.Controls.Add(order);
            order.Dock = DockStyle.Fill;
            panel3.Visible = true;
            inmedicine = false;
            incommunity = false;
            if (Form1.permission != "admin")
            {
                inorder = true;
                order.panel2.Controls.Clear();
                order.panel2.Size = new Size(0, 0);
                order.labelPrintAll.Visible = false;
            }
           
            order.Show();


        }
        private void buttonSupplier_Click(object sender, EventArgs e)
        {
            foreach (Button btn in this.panel2.Controls)
            {
                if (btn.Text == "Supplier") { btn.BackColor = Color.Honeydew; }
                else btn.BackColor = Color.FromArgb(224, 239, 236);
            }
            labelFormName.Text = "Supplier";
            panel3.Controls.Clear();
            SupplierForm supplier = new SupplierForm();
            supplier.TopLevel = false;
            panel3.Controls.Add(supplier);
            supplier.Dock = DockStyle.Fill;
            supplier.Show();
            panel3.Visible = true;
            inmedicine = false;
            inorder = false;
            incommunity = false;
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            foreach (Button btn in this.panel2.Controls)
            {
                if (btn.Text == "Setting") { btn.BackColor = Color.Honeydew; }
                else btn.BackColor = Color.FromArgb(224, 239, 236);
            }
            labelFormName.Text = "Setting";
            panel3.Controls.Clear();
            setting setting = new setting(this);
            setting.TopLevel = false;
            panel3.Controls.Add(setting);
            setting.Dock = DockStyle.Fill;
            setting.Show();
            panel3.Visible = true;
            inmedicine = false;
            inorder = false;
            incommunity = false;
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            message msg = new message();
            msg.buttonClick.Size = new Size(82, 38);
            msg.buttonClick.Text = "Log Out";
            msg.buttonNo.Text = "Quit";
            msg.buttonNo.Visible = true;
            msg.pictureBoxExit.Visible = true;
            msg.label1.Text = "Do you want to ?";
            msg.fadeIn(null, null);
            msg.show(null, null);
            msg.ShowDialog();
            if (message.log == "logout")
            {
                this.Close();
            }
            else if(message.log == "quit")
            {
                Application.Exit();
            }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            if (minimazed)
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
                minimazed = false;
                if (inmedicine) buttonMedicine_Click(null, null);
                else if (inorder) buttonOrder_Click(null, null);
                else if (incommunity) buttonClient_Click(null, null);
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                minimazed = true;
                if (inmedicine) buttonMedicine_Click(null, null);
                else if (inorder) buttonOrder_Click(null, null);
                else if (incommunity) buttonClient_Click(null, null);
            }
        }

     
    }
}
