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
using System.Text.RegularExpressions;
using System.IO;

namespace Projet_Control_2
{
    public partial class addClient : Form
    {
        string cs = @"Data source = .; Initial catalog = pharmacy ; Integrated security = True";
        bool pass, pass1;
        int id;
        string imglocation;
        SqlConnection con;
        ClientForm client;

        public addClient()
        {
            InitializeComponent();
        }

        private void addClient_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.v870_tang_34;
        }
       
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        public addClient(ClientForm client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void clear()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).Clear();
                }
            }
           
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(buttonAdd.Text == "Update")
            {
                if (textBoxFirstName.Text != "" && textBoxLastName.Text != "" && pass && textBoxAddress.Text != "" && pass1 && textBoxUserName.Text != "" && textBoxPassword.Text != "")
                {
                    try
                    {
                        using(con = new SqlConnection(cs))
                        {
                            SqlCommand cmd = new SqlCommand("update client set firstname = @firstname ,lastname = @lastname ,age = @age,adress = @address ,phone = @phone ,username = @username , password = @password where clientid = @id", con);
                            cmd.Parameters.AddWithValue("@id", ClientForm.value);
                            cmd.Parameters.AddWithValue("@firstname", textBoxFirstName.Text.Trim());
                            cmd.Parameters.AddWithValue("@lastname", textBoxLastName.Text.Trim());
                            cmd.Parameters.AddWithValue("@age", textBoxAge.Text.Trim());
                            cmd.Parameters.AddWithValue("@address", textBoxAddress.Text.Trim());
                            cmd.Parameters.AddWithValue("@phone", textBoxPhone.Text.Trim());
                            cmd.Parameters.AddWithValue("@username", textBoxUserName.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", textBoxPassword.Text.Trim());
                            con.Open();
                            int a = cmd.ExecuteNonQuery();
                            if (a == 1)
                            {
                                message msg = new message();
                                msg.label1.Text = "Client is Updated !";
                                msg.ShowDialog();
                                client.getdata();
                                clear();
                                buttonAdd.Text = "Add";
                            }
                        }
                        return;
                    }
                    catch (Exception ex)
                    {
                        message msg = new message();
                        msg.label1.Text = ex.Message;
                        msg.ShowDialog();
                    }
                }
                else
                {
                    message msg = new message();
                    msg.label1.Text = "Please fill all information !";
                    msg.ShowDialog();
                    return;
                }

            }
            else
            {
                if (textBoxFirstName.Text != "" && textBoxLastName.Text != "" && pass && textBoxAddress.Text != "" && pass1 && textBoxUserName.Text != "" && textBoxPassword.Text != "")
                {
                    try
                    {
                        using (con = new SqlConnection(cs))
                        {
                            SqlCommand cmd = new SqlCommand("insert into client values(@firstname,@lastname,@age,@address,@phone,@username,@password)", con);
                            cmd.Parameters.AddWithValue("@firstname", textBoxFirstName.Text.Trim());
                            cmd.Parameters.AddWithValue("@lastname", textBoxLastName.Text.Trim());
                            cmd.Parameters.AddWithValue("@age", textBoxAge.Text.Trim());
                            cmd.Parameters.AddWithValue("@address", textBoxAddress.Text.Trim());
                            cmd.Parameters.AddWithValue("@phone", textBoxPhone.Text.Trim());
                            cmd.Parameters.AddWithValue("@username", textBoxUserName.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", textBoxPassword.Text.Trim());
                            con.Open();
                            int a = cmd.ExecuteNonQuery();
                            if (a == 1)
                            {
                                message msg = new message();
                                msg.label1.Text = "Client is Added !";
                                msg.ShowDialog();
                                client.getdata();
                                clear();
                            }
                        }
                        return;
                    }
                    catch (Exception ex)
                    {
                        message msg = new message();
                        msg.label1.Text = ex.Message;
                        msg.ShowDialog();
                    }
                }
                else
                {
                    message msg = new message();
                    msg.label1.Text = "Please fill all information !";
                    msg.ShowDialog();
                }
            }
           
        }

        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxAge_Leave(object sender, EventArgs e)
        {
            if(textBoxAge.Text != "")
            {
                if (int.Parse(textBoxAge.Text) < 18)
                {
                    errorProvider1.SetError(textBoxAge, "Please age should be more than 18 ");
                    pass1 = false;
                }
                else
                {
                    errorProvider1.SetError(textBoxAge, "");
                    pass1 = true;
                }
            } 
        }
    }
}
