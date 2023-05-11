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

namespace Projet_Control_2
{
    public partial class ClientForm : Form
    {
        string cs = @"Data source=.;Initial catalog=pharmacy;Integrated security = True";
        SqlConnection con;
        BindingSource source=new BindingSource();
        public static int value;
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            getdata();
            labelAddClient.Select();
        }

        public void getdata()
        {
            try
            {
                using (con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("select clientid,firstname,lastname,age,adress,phone from client",con);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        source.DataSource = dr;
                        dataGridView1.DataSource = source;
                        dataGridView1.ClearSelection();
                        labelNullData.Visible = false;
                    }
                    else
                    {
                        dr.Close();
                        SqlCommand cmd2 = new SqlCommand("DBCC CHECKIDENT ('[client]', RESEED, 1);DBCC CHECKIDENT ('[login]', RESEED, 1)", con);
                        cmd2.ExecuteNonQuery();
                        dataGridView1.Rows.Clear();
                        labelNullData.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                message msg = new message();
                msg.label1.Text = ex.Message;
                msg.ShowDialog();
            }
        }

     

        private void labelAddClient_Click(object sender, EventArgs e)
        {
            addClient add = new addClient(this);
            add.ShowDialog();
        }

        private void pictureBoxAddClient_Click(object sender, EventArgs e)
        {
            addClient add = new addClient(this);
            add.ShowDialog();
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxUserName.Text != "")
                {
                    using (con = new SqlConnection(cs))
                    {
                        SqlCommand cmd = new SqlCommand("select clientid,firstname,lastname,age,adress,phone from client where firstname like @search or lastname like @search", con);
                        cmd.Parameters.AddWithValue("@search", "%" + textBoxUserName.Text + "%");
                        con.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            source.DataSource = dr;
                            dataGridView1.DataSource = source;
                            labelNullData.Visible = false;
                        }
                        else
                        {
                            dataGridView1.Rows.Clear();
                            labelNullData.Visible = true;
                        }
                    }
                }
                else
                {
                    getdata();
                }
                
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
                        msg.label1.Text = "Do you really want to delete this medicine ?";
                        msg.fadeIn(null, null);
                        msg.show(null, null);
                        msg.ShowDialog();
                        if (message.check)
                        {
                            using (con = new SqlConnection(cs))
                            {
                                SqlCommand cmd = new SqlCommand("delete from client where clientid = @id", con);
                                cmd.Parameters.AddWithValue("id", dataGridView1.Rows[e.RowIndex].Cells["Clientid"].Value);
                                con.Open();
                                int res = cmd.ExecuteNonQuery();
                                if (res != 1)
                                {
                                    message m = new message();
                                    m.label1.Text = "Erron,Couldn't delete this client !";
                                    m.ShowDialog();
                                }
                                getdata();
                            }
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
                    value = (int)dataGridView1.Rows[e.RowIndex].Cells["Clientid"].Value;
                    addClient add = new addClient(this);
                    add.buttonAdd.Text= "Update";
                    add.textBoxFirstName.Text = dataGridView1.Rows[e.RowIndex].Cells["firstname"].Value.ToString();
                    add.textBoxLastName.Text = dataGridView1.Rows[e.RowIndex].Cells["lastname"].Value.ToString();
                    add.textBoxAge.Text = dataGridView1.Rows[e.RowIndex].Cells["age"].Value.ToString();
                    add.textBoxAddress.Text = dataGridView1.Rows[e.RowIndex].Cells["adress"].Value.ToString();
                    add.textBoxPhone.Text = dataGridView1.Rows[e.RowIndex].Cells["phone"].Value.ToString();
                    using(con = new SqlConnection(cs))
                    {
                        SqlCommand cmd = new SqlCommand("select username,password from login where userid = @id", con);
                        cmd.Parameters.AddWithValue("id", dataGridView1.Rows[e.RowIndex].Cells["Clientid"].Value);
                        con.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        dr.Read();
                        if (dr.HasRows)
                        {
                            add.textBoxUserName.Text = dr[0].ToString();
                            add.textBoxPassword.Text = dr[1].ToString();
                        }
                        dr.Close();
                    }
                    add.ShowDialog();
                    getdata();
                }
            }
        }
    }
}
