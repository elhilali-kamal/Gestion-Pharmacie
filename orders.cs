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
    public partial class orders : Form
    {
        pharmacyDataContext dc;
        public orders()
        {
            InitializeComponent();
        }
        public void getmedicine()
        {
            tableLayoutPanel1.Controls.Clear();
            dc = new pharmacyDataContext();
            var med = (from O in  dc.orders select O).ToList();
            List<order> list = new List<order>();
            list = med;
            int id=0;
            tableLayoutPanel1.RowCount = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].clientid != id)
                {
                    id = (int)list[i].clientid;
                    string clientname = list[i].client.lastname + " " + list[i].client.firstname;
                    string status = list[i].status;
                    orderObj order = new orderObj(id, clientname, status);
                    int c = 0, d = 0;
                    order.TopLevel = false;
                    order.Dock = DockStyle.Fill;
                    order.AutoSize = true;
                    tableLayoutPanel1.Controls.Add(order, c, d);
                    order.Show();
                    d++;
                }
            }
        }

        public void getorder()
        {
            tableLayoutPanel1.Controls.Clear();
            if (home.minimazed)
            {
                tableLayoutPanel1.ColumnCount = 3;
            }
            else
            {
                tableLayoutPanel1.ColumnCount = 5;
            }
            dc = new pharmacyDataContext();
            var r = (from O in dc.orders select O).ToList();
            List<order> list = new List<order>();
            var c = (from od in dc.ordersDetails select od).ToList();
            List<ordersDetail> ls = new List<ordersDetail>();
            ls = c;
            list = r;
            int count = 1;
            if(list.Count > 0)
            {
                
                int clientid = 0;
                string clientname = null;
                float totalprice = 0;
                int orderid = 0;
                int x = 0, y = 0;
                foreach (order obj in list)
                {
                    if(obj.clientid == Form1.id)
                    {
                        List<medicine> med = new List<medicine>();
                        foreach (ordersDetail ord in ls)
                        {
                            if (ord.orderid == obj.orderid)
                            {
                                medicine medicine = new medicine();
                                medicine.title = ord.title;
                                medicine.price = (decimal)ord.price;
                                medicine.quantity = ord.quantity;
                                med.Add(medicine);

                            }

                        }
                        orderid = (int)obj.orderid;
                        clientid = (int)obj.clientid;
                        clientname = obj.client.lastname + " " + obj.client.firstname;
                        totalprice = (float)obj.totalprice;

                        orderClient order = new orderClient(orderid, clientid, clientname, totalprice, med, this);
                        order.TopLevel = false;
                        order.Dock = DockStyle.Fill;
                        order.AutoSize = false;
                        tableLayoutPanel1.Controls.Add(order);
                        order.Show();
                    }
                    
                  

                }
               

            }


        }
        private void orders_Load(object sender, EventArgs e)
        {
            if (Form1.permission == "admin")
                getmedicine();
            else
                getorder();
        }
    }
}
