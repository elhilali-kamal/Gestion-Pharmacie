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
    public partial class Cart : Form
    {
        public float totalprice;
        //List<orderDetaills> order = new List<orderDetaills>();
        pharmacyDataContext dc;
      
        public Cart()
        {
            InitializeComponent();
        }

        private void pictureBoxRemove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void getdata()
        {
            int count = 1;
            int a = 0;
            foreach (medicineObj med in medicines.cartmedicines)
            {
                
                int id = med.id;
                byte[] img = med.img;
                string title = med.Title;
                float price = med.price;
                int quantity = med.quantity;
                string require = med.Require;
                CartObj obj = new CartObj(id, img, title, price, quantity, require,this);
                obj.TopLevel = false;
                obj.Dock = DockStyle.Fill;
                obj.AutoSize = false;
                tableLayoutPanel1.Controls.Add(obj,a,1);
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 0));
                obj.Show();
                a++;
                tableLayoutPanel1.ColumnCount = count++;
            }
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            getdata();
            getprice();
        }

        public void getprice()
        {
            labelTotal.Text = totalprice.ToString() + " DH";

        }
        private void pictureBoxRemove_Click_1(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if(tableLayoutPanel1.Controls.Count > 0)
                {
                    int i = -1;
                    foreach (CartObj obj in tableLayoutPanel1.Controls)
                    {
                        if(obj.Require == "yes")
                        {
                            i = 0;
                        }

                    }
                    if(i == -1)
                    {
                        dc = new pharmacyDataContext();
                        order ord = new order();
                        ord.clientid = Form1.id;
                        ord.status = "Not Delivered";
                        ord.totalprice = (decimal)totalprice;
                        dc.orders.InsertOnSubmit(ord);
                        dc.SubmitChanges();
                        dc.Refresh(0);

                        foreach (CartObj obj in tableLayoutPanel1.Controls)
                        {
                            ordersDetail o = new ordersDetail();
                            o.orderid = ord.orderid;
                            o.medicineid = obj.ID;
                            o.title = obj.Title;
                            o.quantity = obj.wantedquantity.ToString();
                            o.price = (decimal)obj.priceTotal;
                            dc.ordersDetails.InsertOnSubmit(o);
                            dc.SubmitChanges();

                        }
                        message msg = new message();
                        msg.label1.Text = "The Order has been Queued !";
                        msg.ShowDialog();
                        tableLayoutPanel1.Controls.Clear();
                        medicines.cartmedicines.Clear();
                        medicines.Cart = medicines.cartmedicines.Count;
                        labelTotal.Text = "0";
                    }
                    else
                    {
                        message msg = new message();
                        msg.label1.Text = "Please upload Doctor permission on required medicines !";
                        msg.ShowDialog();
                    }
                }
                else
                {

                    message msg = new message();
                    msg.label1.Text = "There is no medicine in cart !";
                    msg.ShowDialog();
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
