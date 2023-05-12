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
using Projet_Control_2.DataSetSupplierTableAdapters;

namespace Projet_Control_2
{
    public partial class SupplierForm : Form
    {
        SqlConnection con = new SqlConnection();
        DataSetSupplier ds = new DataSetSupplier();
        supplierTableAdapter supplier = new supplierTableAdapter();
        public static int value;
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            getdata();
            labelAddSupplier.Select();
        }

        public void getdata()
        {
            try
            {
                supplier.Fill(ds.supplier);
                if (ds.supplier.Count == 0)
                {
                    labelNullData.Visible = true;
                }
                else
                {
                    labelNullData.Visible = false;

                }
                dataGridView1.DataSource = ds.supplier;

            }
            catch (Exception ex)
            {
                message msg = new message();
                msg.label1.Text = ex.Message;
                msg.ShowDialog();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (e.ColumnIndex == 1)
                {
                    try
                    {
                        message msg = new message();
                        msg.buttonClick.Size = new Size(82, 38);
                        msg.buttonClick.Text = "Yes";
                        msg.buttonNo.Visible = true;
                        msg.label1.Text = "Do you really want to delete this supplier ?";
                        msg.fadeIn(null, null);
                        msg.show(null, null);
                        msg.ShowDialog();
                        if (message.check)
                        {
                            ds.supplier.Rows[e.RowIndex].Delete();
                            supplier.Update(ds.supplier);
                            getdata();
                            
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        message m = new message();
                        m.label1.Text = ex.Message;
                        m.ShowDialog();
                    }
                }
                if (e.ColumnIndex == 0)
                {
                    value = e.RowIndex;
                    addSupplier add = new addSupplier();
                    add.buttonAdd.Text= "Update";
                    add.textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells["suppliername"].Value.ToString();
                    add.textBoxAddress.Text = dataGridView1.Rows[e.RowIndex].Cells["adress"].Value.ToString();
                    add.textBoxPhone.Text = dataGridView1.Rows[e.RowIndex].Cells["phone"].Value.ToString();
                    add.ShowDialog();
                    getdata();
                }
            }
        }

        private void labelAddSupplier_Click(object sender, EventArgs e)
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
            addSupplier add = new addSupplier();
            add.ShowDialog();
            test.Close();
            getdata();
        }

        private void pictureBoxAddSupplier_Click(object sender, EventArgs e)
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
            addSupplier add = new addSupplier();
            add.ShowDialog();
            test.Close();
            getdata();
        }

        private void textBoxSupplierName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSupplierName.Text != "")
            {
                supplier.FillBy(ds.supplier, '%' + textBoxSupplierName.Text + '%');
                dataGridView1.DataSource = ds.supplier;
                if (ds.supplier.Count == 0) labelNullData.Visible = true;
                else labelNullData.Visible = false;
            }
            else
            {
                getdata();
            }
        }
    }
}
