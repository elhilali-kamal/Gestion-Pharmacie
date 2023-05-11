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
    public partial class orderDetailsForm : Form
    {
        public int id;

        public orderDetailsForm(int id, string medsname,double quantity, double price)
        {
            InitializeComponent();
            this.ID = id;
            this.Medsname = medsname;
            this.Quantity = quantity;
            this.Price = price;
        }

        public int ID { get => id; set => id = value; }

        public string Medsname
        {
            get => labelMedsName.Text.ToString();
            set => labelMedsName.Text = value;
        }

        public double Quantity
        {
            get => double.Parse(labelQuantity.Text);
            set => labelQuantity.Text = value.ToString();
        }
        public double Price
        {
            get => double.Parse(labelPrice.Text);
            set => labelPrice.Text = value.ToString();
        }
        public orderDetailsForm()
        {
            InitializeComponent();
        }
    }
}
