using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet_Control_2.DataSetSupplierTableAdapters;

namespace Projet_Control_2
{
    public partial class addSupplier : Form
    {
        DataSetSupplier ds = new DataSetSupplier();
        supplierTableAdapter supplier = new supplierTableAdapter();
        bool pass;
        public addSupplier()
        {
            InitializeComponent();
        }

        private void addSupplier_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.add_supplier;
            supplier.Fill(ds.supplier);

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonAdd.Text == "Update")
                {
                    ds.supplier.Rows[SupplierForm.value][1] = textBoxName.Text;
                    ds.supplier.Rows[SupplierForm.value][2] = textBoxPhone.Text;
                    ds.supplier.Rows[SupplierForm.value][3] = textBoxAddress.Text;
                    supplier.Update(ds.supplier);
                    message msg = new message();
                    msg.label1.Text = "Supplier is successfuly Updated !";
                    msg.ShowDialog();
                }
                else
                {
                    DataSetSupplier.supplierRow row = ds.supplier.NewsupplierRow();
                    row.suppliername = textBoxName.Text;
                    row.phone = textBoxPhone.Text;
                    row.adress = textBoxAddress.Text;
                    ds.supplier.Rows.Add(row);
                    supplier.Update(ds.supplier);
                    message msg = new message();
                    msg.label1.Text = "Supplier is successfuly added !";
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

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxPhone_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBoxPhone.Text, @"^((\+2126)|(\+2127)|(06)|(07))[0-9]{8}$") || textBoxPhone.Text.Trim() == "")
            {
                errorProvider1.SetError(textBoxPhone, "Please enter a valid Phone number");
                pass = false;
            }
            else
            {
                errorProvider1.SetError(textBoxPhone, "");
                pass = true;
            }
        }
    }
}
