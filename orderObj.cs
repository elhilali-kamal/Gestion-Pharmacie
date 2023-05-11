using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Projet_Control_2
{
    public partial class orderObj : Form
    {
        public int id;
        pharmacyDataContext dc;
        public orderObj(int id, string clientname,string status)
        {
            InitializeComponent();
            this.ID = id;
            this.Clientname = clientname;
            this.Status = status;
        }

        public int ID { get => id; set => id = value; }

        public string Clientname
        {
            get => labelClientName.Text.ToString();
            set => labelClientName.Text = value;
        }

        public string Status
        {
            get => labelStatus.Text;
            set => labelStatus.Text = value;
        }

        public orderObj()
        {
            InitializeComponent();

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            Rapport rp = new Rapport();
            dc = new pharmacyDataContext();
            var order = from o in dc.orders select new {o.client.clientid,o.client.firstname};
            rp.reportViewer1.Reset();
            rp.reportViewer1.ProcessingMode = ProcessingMode.Local;
            rp.reportViewer1.LocalReport.ReportPath = @"C:\Users\fouad\source\repos\Projet Control 2\Report2.rdlc";
            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("clientid", "said");
            //parameters[1] = new ReportParameter("[@RPClientName]", Clientname);
            
            //ReportParameter ClientID = new ReportParameter("@RPClientID", id.ToString());
            //ReportParameter ClientName = new ReportParameter("@RPClientName", name);
            rp.reportViewer1.LocalReport.SetParameters(parameters);
            rp.reportViewer1.RefreshReport();
            rp.ShowDialog();
        }
    }
}
