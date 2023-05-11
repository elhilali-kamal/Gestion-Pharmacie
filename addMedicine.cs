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
    public partial class addMedicine : Form
    {
        pharmacyDataContext dc;
        medicines meds;
        List<medicine> list = new List<medicine>();
        string imglocation;
        string check;
       
        public addMedicine()
        {
            InitializeComponent();
        }
        
        public addMedicine(medicines med)
        {
            InitializeComponent();
            this.meds = med;
        }

        private void addMedicine_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.medicine_add_2;
            pictureBoxPicture.Select();
            if (medicineObj.edit == true)
            {
                buttonClick.Text = "Update";
                getdatatomodify();
            }
        }

        void getdatatomodify()
        {

            dc = new pharmacyDataContext();
            var med = (from M in dc.medicines orderby M.title select M).ToList();
            list = med;
            foreach (medicine medecine in list)
            {
                if (medecine.medicineid == medicineObj.idmed)
                {
                    textBoxTitle.Text = medecine.title;
                    textBoxDescription.Text = medecine.description;
                    if (medecine.require == "yes") radioButtonYes.Checked = true;
                    else radioButtonNo.Checked = true;
                    textBoxPrice.Text = medecine.price.ToString();
                    textBoxQuantity.Text = medecine.quantity;
                    byte[] img = null;
                    img = medecine.picture.ToArray();
                    MemoryStream ms = new MemoryStream(img);
                    pictureBoxPicture.Image = Image.FromStream(ms);
                    pictureBoxPicture.Tag = "toogled";
                    pictureBoxAddPicture.Image = Properties.Resources.delete_pink;
                } 
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
                if (pictureBoxAddPicture.Tag == null)
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        imglocation = ofd.FileName.ToString();
                        pictureBoxPicture.Image = Image.FromFile(imglocation);
                        pictureBoxAddPicture.Tag = "toogled";
                        pictureBoxAddPicture.Image = Properties.Resources.delete_pink;
                    }
                }
                else
                {
                    imglocation = null;
                    pictureBoxAddPicture.Tag = null;
                    pictureBoxAddPicture.Image = Properties.Resources.add_2;
                    pictureBoxPicture.Image = Properties.Resources.Med_default;
                }
            }
            catch (Exception ex)
            {
                message msg = new message();
                msg.label1.Text = ex.Message;
                msg.Show();
            }
        }

        private void buttonClick_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonClick.Text == "Update")
                {
                    medicine med = new medicine();
                    using (dc = new pharmacyDataContext())
                    {
                        med = dc.medicines.SingleOrDefault(m => m.medicineid == medicineObj.idmed);
                        med.title = textBoxTitle.Text;
                        med.price = decimal.Parse(textBoxPrice.Text);
                        med.quantity = textBoxQuantity.Text;
                        med.require = check;
                        med.description = textBoxDescription.Text;
                        if (pictureBoxPicture.Tag == null)
                        {
                            byte[] img = null;
                            FileStream fs = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                            BinaryReader br = new BinaryReader(fs);
                            img = br.ReadBytes((int)fs.Length);
                            med.picture = img;
                        }
                        message msg = new message();
                        msg.label1.Text = "The Medicine is Updated Successfully !";
                        dc.SubmitChanges();
                        msg.ShowDialog();
                    }
                   
                }
                else
                {
                    if (textBoxTitle.Text.Trim() != "" && textBoxPrice.Text.Trim() != "" && textBoxQuantity.Text.Trim() != "" && (radioButtonYes.Checked || radioButtonNo.Checked) && textBoxDescription.Text.Trim() != "")
                    {
                        int i = -1;
                        dc = new pharmacyDataContext();
                        var t = (from M in dc.medicines orderby M.title select M).ToList();
                        list = t;
                        foreach (medicine m in list)
                        {
                            if(textBoxTitle.Text.ToUpper().Trim() == m.title )
                            {
                                i = 0;
                                break;
                            }
                        }
                        if (i == -1)
                        {
                            medicine med = new medicine();
                            med.title = textBoxTitle.Text;
                            med.price = decimal.Parse(textBoxPrice.Text);
                            med.quantity = textBoxQuantity.Text;
                            med.require = check;
                            med.description = textBoxDescription.Text;
                            byte[] img = null;
                            FileStream fs = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                            BinaryReader br = new BinaryReader(fs);
                            img = br.ReadBytes((int)fs.Length);
                            med.picture = img;
                            dc.medicines.InsertOnSubmit(med);
                            message msg = new message();
                            msg.label1.Text = "The Medicine is Added Successfully !";
                            msg.ShowDialog();
                            dc.SubmitChanges();
                            meds.getmedicine();
                            Clear();
                        }
                        else
                        {
                            message msg = new message();
                            msg.label1.Text = "Medicine is already exist !";
                            msg.ShowDialog();
                        }
                       
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

        void Clear()
        {
            textBoxTitle.Text = textBoxPrice.Text = textBoxQuantity.Text = textBoxDescription.Text = string.Empty;
            radioButtonYes.Checked = false;
            radioButtonNo.Checked = false;
            pictureBoxAddPicture.Tag = null;
            pictureBoxAddPicture.Image = Properties.Resources.add_2;
            pictureBoxPicture.Image = Properties.Resources.Med_default;
        }

        private void radioButtonYes_CheckedChanged(object sender, EventArgs e)
        {
            check = "yes";
        }

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            check = "no";
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
