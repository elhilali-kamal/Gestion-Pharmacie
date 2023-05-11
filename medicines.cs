using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Control_2
{
    public partial class medicines : Form
    {
        //Process process = Process.GetCurrentProcess();
        pharmacyDataContext dc;
        PictureBox pic = new PictureBox();
        List<medicine> list = new List<medicine>();
        int count;
        int c = 0, d = 0;
        public static int Cart;
        public static List<medicineObj> cartmedicines = new List<medicineObj>();
        FileStream fs = new FileStream(@"C:\Users\fouad\source\repos\Projet Control 2\Resources\Med default.png", FileMode.Open, FileAccess.Read);
        public medicines()
        {
            InitializeComponent();
        }

        home home;
        public medicines(home home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void medicine_Load(object sender, EventArgs e)
        {
            getmedicine();
            count = 0;
            pic.Click += new EventHandler(PictureBox_Click);
            Cart = cartmedicines.Count;
            labelCartCount.Text = Cart.ToString();

        }

        public void getmedicine()
        {
            if (home.minimazed)
            {
                tableLayoutPanel1.ColumnCount = 3;
            }
            else
            {
                tableLayoutPanel1.ColumnCount = 5;
            }
            tableLayoutPanel1.Controls.Clear();

            using (dc = new pharmacyDataContext())
            {
                var med = (from M in dc.medicines orderby M.title descending select M).ToList();
                list = med;

                //list.Sort();
                for (int i = 0; i < list.Count; i++)
                {
                    int id = list[i].medicineid;
                    string title = list[i].title.ToUpper();
                    string description = list[i].description;
                    string require = list[i].require;
                    float price = (float)list[i].price;
                    int quantity = int.Parse(list[i].quantity);
                    byte[] img = null;
                    if (list[i].picture != null)
                    {
                        img = (byte[])list[i].picture.ToArray();
                    }
                    else
                    {
                        BinaryReader br = new BinaryReader(fs);
                        img = br.ReadBytes((int)fs.Length);
                    }
                    medicineObj obj = new medicineObj(id, img, title, description, require, price, quantity, this);
                    int a = 0, b = 0;
                    obj.TopLevel = false;
                    obj.Dock = DockStyle.Fill;
                    obj.AutoSize = true;
                    tableLayoutPanel1.Controls.Add(obj, a, b);
                    obj.Show();
                    b++;
                    if (b >= 5)
                    {
                        b = 1;
                        a++;
                    }
                    c = a;
                    d = b;
                }
            }

            if (Form1.permission == "admin")
            {
                plus();
                pictureBoxCart.Visible = false;
                labelCartCount.Visible = false;
            }
            //Process.GetCurrentProcess().EnableRaisingEvents = true;
            //dc.Dispose();
            //process.Refresh();
        }

        private void PictureBox_Click(object sender, EventArgs e)
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
            medicineObj.edit = false;
            addMedicine add = new addMedicine(this);
            add.ShowDialog();
            test.Close();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
           if(textBoxSearch.Text.Trim() != "")
           {
                
                if (home.minimazed)
                {
                    tableLayoutPanel1.ColumnCount = 3;
                }
                else
                {
                    tableLayoutPanel1.ColumnCount = 5;
                }
                tableLayoutPanel1.Controls.Clear();
                using (dc = new pharmacyDataContext())
                {
                    var med = (from M in dc.medicines where M.title.Contains(textBoxSearch.Text.Trim().ToString()) select M).ToList();
                    list = med;
                    List<medicine> sorted = (list.OrderBy(x => x.title)).ToList();
                    for (int i = 0; i < sorted.Count; i++)
                    {
                        int id = sorted[i].medicineid;
                        string title = sorted[i].title;
                        string description = sorted[i].description;
                        string require = sorted[i].require;
                        float price = (float)sorted[i].price;
                        int quantity = int.Parse(sorted[i].quantity);
                        byte[] img = null;
                        if (sorted[i].picture != null)
                        {
                            img = (byte[])sorted[i].picture.ToArray();
                        }
                        else
                        {
                            BinaryReader br = new BinaryReader(fs);
                            img = br.ReadBytes((int)fs.Length);
                        }
                        medicineObj obj = new medicineObj(id, img, title, description, require, price, quantity, this);
                        int a = 0, b = 0;
                        obj.TopLevel = false;
                        obj.Dock = DockStyle.Fill;
                        obj.AutoSize = true;
                        tableLayoutPanel1.Controls.Add(obj, a, b);
                        obj.Show();
                        b++;
                        if (b >= 5)
                        {
                            b = 1;
                            a++;
                        }
                        c = a;
                        d = b;
                    }
                }

            }
           else
           {
                getmedicine();
           }
        }

        private void pictureBoxCart_Click(object sender, EventArgs e)
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
            Cart cart = new Cart();
            cart.ShowDialog();
            test.Close();
            Cart = cartmedicines.Count;
            labelCartCount.Text = Cart.ToString();
            

        }
        void plus()
        {
            pic.Size = new Size(70, 70);
            pic.Anchor = (AnchorStyles.None);
            pic.Image = Properties.Resources.plus_8_128;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Cursor = Cursors.Hand;
            if (count < 1)
            {
                tableLayoutPanel1.Controls.Add(pic, c, d);
                count++;
            }
            else
            {
                tableLayoutPanel1.Controls.Remove(pic);
                tableLayoutPanel1.Controls.Add(pic, c, d);
            }
        }
    }
}
