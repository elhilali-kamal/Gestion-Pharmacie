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
    public partial class medicineObj : Form
    {
        pharmacyDataContext dc;

        public int id;
        public byte[] img;
        public float price;
        public int quantity;
        string var;
        public static bool edit = false;
        public static int idmed;
        bool clicked =false;

        medicines med;
        public medicineObj(int id,byte[] image, string title, string description,string require, float price,int quantiy,medicines med)
        {
            InitializeComponent();
            this.ID = id;
            this.Title = title;
            this.Description = description;
            this.img = image;
            this.Image1 = convert(image);
            this.Require = require;
            this.price1 = price;
            this.Price = price;
            this.Quantity = quantity;
            this.med = med;
            show();
        }

     
        public int ID { get => id; set => id = value; }
        Image convert(byte[] img)
        {
            byte[] picture = (byte[])(img);
            MemoryStream ms = new MemoryStream(picture);
            return Image.FromStream(ms);
        }

        public string Title
        {
            get => labelTitle.Text.ToString();
            set => labelTitle.Text = value;
        }

        public string Description
        {
            get => labelDescription.Text;
            set => labelDescription.Text = value;
        }

        public Image Image1
        {
            get => pictureBoxMedicine.Image;
            set => pictureBoxMedicine.Image = value;
        }

        public double Price
        {
           
            set => labelPrice.Text = value.ToString() + " DH";
        }
        public float price1
        {
            get => price;
            set => price = value;
        }

        public string Require
        {
            set => var = value;
            get => var;
        }

        void show()
        {
            if (var == "yes")
            {
                labeRequire.Visible = true;
                pictureBoxRequire.Visible = true;
            }
            else
            {
                labeRequire.Visible = false;
                pictureBoxRequire.Visible = false;
            }
        }

        public int Quantity
        {
            get => quantity;
            set => quantity = value;
        }
        private void pictureBoxRemove_Click(object sender, EventArgs e)
        {
            
            if ((string)pictureBoxRemove.Tag == "remove")
            {
                message msg = new message();
                msg.buttonClick.Size = new Size(82, 38);
                msg.buttonClick.Text = "Yes";
                msg.buttonNo.Visible = true;
                msg.label1.Text = "Do you really want to delete this medicine ?";
                msg.fadeIn(null, null);
                msg.show(null, null);
                msg.ShowDialog();
                if (message.check)
                {
                    medicine med = new medicine();
                    using (dc = new pharmacyDataContext())
                    {
                        med = dc.medicines.SingleOrDefault(m => m.medicineid == this.id);
                        dc.medicines.DeleteOnSubmit(med);
                        dc.SubmitChanges();
                    }
                    this.Close();
                }
            }
            else
            {
                clicked = true;
                int check = -1;
                foreach (medicineObj item in medicines.cartmedicines)
                {
                    if (item.id != this.id)
                    {
                        continue;

                    }
                    else
                    {
                        check = 0;
                    }
                }
                if (check == -1)
                {
                    medicines.cartmedicines.Add(new medicineObj(this.id, this.img, this.Title, this.Description, this.Require, (float)this.price, this.quantity,med));
                    med.labelCartCount.Text = (++medicines.Cart).ToString();

                }

            }
        }

        private void pictureBoxEdit_Click(object sender, EventArgs e)
        {
            idmed = this.id;
            edit = true;
            test test = new test();
            if (!home.minimazed)
            {
                test.WindowState = FormWindowState.Maximized;
                test.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            }

            else
                test.WindowState = FormWindowState.Normal;
            test.Show();
            addMedicine add = new addMedicine();
            add.ShowDialog();
            test.Close();
            med.getmedicine();


        }

        private void medicineObj_Load(object sender, EventArgs e)
        {
            if(Form1.permission != "admin")
            {
                pictureBoxEdit.Visible = false;
                pictureBoxRemove.Image = Properties.Resources.add;
                pictureBoxRemove.Tag = "add";
            }
            else
            {
                
                pictureBoxRemove.Tag = "remove";
            }
        }
    }
}
