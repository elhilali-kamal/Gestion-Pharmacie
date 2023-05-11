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
    public partial class CartObj : Form
    {
        int id;
        int quantity;
        float price = 40;
        string require;
        public int wantedquantity;
        string imglocation;
        public  float priceTotal;
        int medicineid;
        Cart cart;
        public CartObj()
        {
            InitializeComponent();
        }


        public CartObj(int id,byte[] picture,string title,float price,int quantity,string require,Cart cart)
        {
            InitializeComponent();
            this.ID = id;
            this.Image1 = convert(picture);
            this.Title = title;
            this.Price = price;
            this.Quantity = quantity;
            this.require = require;
            this.cart = cart;
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


        public Image Image1
        {
            get => pictureBoxMedicine.Image;
            set => pictureBoxMedicine.Image = value;
        }
        public float Price
        {
            get => price;
            set => price = value;
        }

        public string Require
        {
            set => require = value;
            get => require;
        }

        void show()
        {
            if (require == "yes")
            {
                pictureBoxRequire.Visible = true;
            }
            else
            {
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
            foreach(medicineObj obj in medicines.cartmedicines)
            {
                if(obj.id == this.id)
                {
                    medicines.cartmedicines.Remove(obj);
                    break;
                }
            }
            cart.totalprice -= priceTotal;
            cart.getprice();
            this.Close();
        }

        private void pictureBoxPlus_Click(object sender, EventArgs e)
        {
            
            textBoxQuantity.Text = (++wantedquantity).ToString(); 
            labelPrice.Text = (wantedquantity * price).ToString() + " DH";
            priceTotal = wantedquantity * price;
            cart.totalprice += price; 
            cart.getprice();
            

        }

        private void pictureBoxMinus_Click(object sender, EventArgs e)
        {
            if(wantedquantity > 1)
            {
             
                textBoxQuantity.Text = (--wantedquantity).ToString();
                labelPrice.Text = (wantedquantity * price).ToString() + " DH";
                priceTotal = wantedquantity * price;
                cart.totalprice -= price;
                cart.getprice();
            }

        }

        private void CartObj_Load(object sender, EventArgs e)
        {
            wantedquantity = 1;
            pictureBoxRemove.Select();
            priceTotal = wantedquantity * price;
            TotalPrice();

        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            
            //if (textBoxQuantity.Text == "0" )
            //{
            //    textBoxQuantity.Text = "1";
            //}
            //if (textBoxQuantity.Text != "")
            //    wantedquantity = int.Parse(textBoxQuantity.Text);
            //    //TotalPrice();

        }

        private void textBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        void TotalPrice()
        {
            labelPrice.Text = (wantedquantity * price).ToString() + " DH";
            //priceTotal = wantedquantity * price;
            cart.totalprice += price;
            //cart.getprice();
        }

        private void pictureBoxRequire_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imglocation = ofd.FileName.ToString();
                    toolTip1.SetToolTip(pictureBoxRequire, "");
                    message msg = new message();
                    msg.label1.Text = "Doctor permission is uploaded !";
                    msg.ShowDialog();
                    pictureBoxRequire.Visible = false;
                    require = "no";

                }
            }
            catch (Exception ex)
            {
                message msg = new message();
                msg.label1.Text = ex.Message;
                msg.ShowDialog();
            }
        }
    }
}
