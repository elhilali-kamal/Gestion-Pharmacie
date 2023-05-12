
namespace Projet_Control_2
{
    partial class SupplierForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAddSupplier = new System.Windows.Forms.Label();
            this.textBoxSupplierName = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxAddSupplier = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.supplierid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnRemove = new System.Windows.Forms.DataGridViewImageColumn();
            this.labelNullData = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelAddSupplier);
            this.panel1.Controls.Add(this.textBoxSupplierName);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBoxAddSupplier);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 100);
            this.panel1.TabIndex = 0;
            // 
            // labelAddSupplier
            // 
            this.labelAddSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAddSupplier.AutoSize = true;
            this.labelAddSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAddSupplier.Font = new System.Drawing.Font("Eras Demi ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(204)))), ((int)(((byte)(211)))));
            this.labelAddSupplier.Location = new System.Drawing.Point(777, 39);
            this.labelAddSupplier.Name = "labelAddSupplier";
            this.labelAddSupplier.Size = new System.Drawing.Size(127, 23);
            this.labelAddSupplier.TabIndex = 9;
            this.labelAddSupplier.Text = "Add Supplier";
            this.labelAddSupplier.Click += new System.EventHandler(this.labelAddSupplier_Click);
            // 
            // textBoxSupplierName
            // 
            this.textBoxSupplierName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(239)))), ((int)(((byte)(236)))));
            this.textBoxSupplierName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSupplierName.Font = new System.Drawing.Font("Eras Medium ITC", 14F);
            this.textBoxSupplierName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(212)))), ((int)(((byte)(202)))));
            this.textBoxSupplierName.Location = new System.Drawing.Point(74, 39);
            this.textBoxSupplierName.Name = "textBoxSupplierName";
            this.textBoxSupplierName.Size = new System.Drawing.Size(149, 22);
            this.textBoxSupplierName.TabIndex = 8;
            this.textBoxSupplierName.TextChanged += new System.EventHandler(this.textBoxSupplierName_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Projet_Control_2.Properties.Resources.Rectangle_1;
            this.pictureBox2.Location = new System.Drawing.Point(65, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxAddSupplier
            // 
            this.pictureBoxAddSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxAddSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAddSupplier.Image = global::Projet_Control_2.Properties.Resources.add;
            this.pictureBoxAddSupplier.Location = new System.Drawing.Point(748, 38);
            this.pictureBoxAddSupplier.Name = "pictureBoxAddSupplier";
            this.pictureBoxAddSupplier.Size = new System.Drawing.Size(26, 26);
            this.pictureBoxAddSupplier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAddSupplier.TabIndex = 7;
            this.pictureBoxAddSupplier.TabStop = false;
            this.pictureBoxAddSupplier.Click += new System.EventHandler(this.pictureBoxAddSupplier_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projet_Control_2.Properties.Resources.search_green;
            this.pictureBox1.Location = new System.Drawing.Point(36, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(204)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(204)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierid,
            this.suppliername,
            this.phone,
            this.adress,
            this.ColumnEdit,
            this.ColumnRemove});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Eras Medium ITC", 11.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(931, 346);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // supplierid
            // 
            this.supplierid.DataPropertyName = "supplierid";
            this.supplierid.HeaderText = "Supplier ID";
            this.supplierid.Name = "supplierid";
            this.supplierid.ReadOnly = true;
            this.supplierid.Visible = false;
            // 
            // suppliername
            // 
            this.suppliername.DataPropertyName = "suppliername";
            this.suppliername.FillWeight = 101.2352F;
            this.suppliername.HeaderText = "Supplier Name";
            this.suppliername.Name = "suppliername";
            this.suppliername.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.FillWeight = 101.2352F;
            this.phone.HeaderText = "Phone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // adress
            // 
            this.adress.DataPropertyName = "adress";
            this.adress.FillWeight = 101.2352F;
            this.adress.HeaderText = "Address";
            this.adress.Name = "adress";
            this.adress.ReadOnly = true;
            // 
            // ColumnEdit
            // 
            this.ColumnEdit.FillWeight = 8.121827F;
            this.ColumnEdit.HeaderText = "";
            this.ColumnEdit.Image = global::Projet_Control_2.Properties.Resources.edit_128;
            this.ColumnEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnEdit.Name = "ColumnEdit";
            this.ColumnEdit.ReadOnly = true;
            this.ColumnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnRemove
            // 
            this.ColumnRemove.FillWeight = 8.172631F;
            this.ColumnRemove.HeaderText = "";
            this.ColumnRemove.Image = global::Projet_Control_2.Properties.Resources.Close_green;
            this.ColumnRemove.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnRemove.Name = "ColumnRemove";
            this.ColumnRemove.ReadOnly = true;
            this.ColumnRemove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnRemove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // labelNullData
            // 
            this.labelNullData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNullData.AutoSize = true;
            this.labelNullData.BackColor = System.Drawing.Color.MintCream;
            this.labelNullData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNullData.Font = new System.Drawing.Font("Eras Demi ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNullData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(204)))), ((int)(((byte)(211)))));
            this.labelNullData.Location = new System.Drawing.Point(329, 144);
            this.labelNullData.Name = "labelNullData";
            this.labelNullData.Size = new System.Drawing.Size(293, 23);
            this.labelNullData.TabIndex = 9;
            this.labelNullData.Text = "No Supplier Information Found";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 15F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Projet_Control_2.Properties.Resources.edit_128;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 27;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 15F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Projet_Control_2.Properties.Resources.Close_green;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 26;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(239)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(931, 446);
            this.Controls.Add(this.labelNullData);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SupplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label labelAddSupplier;
        private System.Windows.Forms.TextBox textBoxSupplierName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxAddSupplier;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label labelNullData;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierid;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliername;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn adress;
        private System.Windows.Forms.DataGridViewImageColumn ColumnEdit;
        private System.Windows.Forms.DataGridViewImageColumn ColumnRemove;
    }
}