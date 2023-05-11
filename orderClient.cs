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
    public partial class orderClient : Form
    {
        public int idclient;
        public int idmedicine;
        string medname;
        string quantity;
        pharmacyDataContext dc;
        orders order;
        public orderClient(int orderid, int idclient, string clientname, float totalprice ,List<medicine> med,orders ord)
        {
            InitializeComponent();
            this.Idclient = idclient;
            foreach(medicine meds in med)
            {
                dataGridView1.Rows.Add(meds.title, meds.quantity, meds.price);
            }
            this.Clientname = clientname;
            this.Total = totalprice;
            this.Orderid = orderid;
            this.order = ord;
        }

        public int Idclient { get => idclient; set => idclient = value; }
        public int Idmedicine { get => idmedicine; set => idmedicine = value; }

        public int Orderid { get => int.Parse(labelOrderID.Text); set => labelOrderID.Text = value.ToString(); }

        public string Clientname { get => labelClientName.Text; set => labelClientName.Text = value; }
        public string Qntity { get => quantity; set => quantity = value; }

        public float Total { get => float.Parse(labelTotalPrice.Text); set => labelTotalPrice.Text = value.ToString(); }
        public string Medsname
        {
            get => medname;
            set => medname= value;
        }

        public orderClient()
        {
            InitializeComponent();
        }

        private void orderClient_Load(object sender, EventArgs e)
        {
            labelOrderDate.Text = DateTime.Now.ToLongDateString();
            labelTotalPrice.Text = Total.ToString() + " DH";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            message msg = new message();
            msg.buttonClick.Size = new Size(82, 38);
            msg.buttonClick.Text = "Yes";
            msg.buttonNo.Visible = true;
            msg.label1.Text = "Do you really want to cancel this order ?";
            msg.fadeIn(null, null);
            msg.show(null, null);
            msg.ShowDialog();
            if (message.check)
            {
                dc = new pharmacyDataContext();
                var ord = from M in dc.orders select M;
                List<order> list = new List<order>();
                list = ord.ToList();
                foreach (order order in list)
                {
                    if (order.orderid == this.Orderid)
                    {
                        order od = dc.orders.SingleOrDefault(m => m.orderid == order.orderid);
                        dc.orders.DeleteOnSubmit(od);
                        dc.SubmitChanges();
                        break;
                    }
                }
                order.getorder();
                
            }
                
        }
    }
}
