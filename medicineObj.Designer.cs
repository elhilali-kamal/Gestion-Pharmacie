
namespace Projet_Control_2
{
    partial class medicineObj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(medicineObj));
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelAdd = new System.Windows.Forms.Label();
            this.labeRequire = new System.Windows.Forms.Label();
            this.pictureBoxRequire = new System.Windows.Forms.PictureBox();
            this.pictureBoxEdit = new System.Windows.Forms.PictureBox();
            this.pictureBoxRemove = new System.Windows.Forms.PictureBox();
            this.pictureBoxMedicine = new System.Windows.Forms.PictureBox();
            this.labelPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRequire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Eras Demi ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.labelTitle.Location = new System.Drawing.Point(12, 4);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(163, 23);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Title";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Eras Demi ITC", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(180, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Description";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDescription
            // 
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Eras Medium ITC", 8.25F);
            this.labelDescription.Location = new System.Drawing.Point(181, 91);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(70, 99);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Description";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelAdd
            // 
            this.labelAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAdd.AutoSize = true;
            this.labelAdd.Font = new System.Drawing.Font("Eras Demi ITC", 10.25F);
            this.labelAdd.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.labelAdd.Location = new System.Drawing.Point(195, 198);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(40, 17);
            this.labelAdd.TabIndex = 3;
            this.labelAdd.Text = "Price";
            this.labelAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labeRequire
            // 
            this.labeRequire.AutoSize = true;
            this.labeRequire.Font = new System.Drawing.Font("Eras Demi ITC", 6.25F);
            this.labeRequire.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labeRequire.Location = new System.Drawing.Point(50, 222);
            this.labeRequire.Name = "labeRequire";
            this.labeRequire.Size = new System.Drawing.Size(123, 12);
            this.labeRequire.TabIndex = 4;
            this.labeRequire.Text = "Require Doctor Persmission";
            this.labeRequire.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxRequire
            // 
            this.pictureBoxRequire.Image = global::Projet_Control_2.Properties.Resources.pngegg1;
            this.pictureBoxRequire.Location = new System.Drawing.Point(22, 217);
            this.pictureBoxRequire.Name = "pictureBoxRequire";
            this.pictureBoxRequire.Size = new System.Drawing.Size(22, 22);
            this.pictureBoxRequire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRequire.TabIndex = 5;
            this.pictureBoxRequire.TabStop = false;
            // 
            // pictureBoxEdit
            // 
            this.pictureBoxEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEdit.Image = global::Projet_Control_2.Properties.Resources.writing_pencil_pngrepo_com;
            this.pictureBoxEdit.Location = new System.Drawing.Point(205, 4);
            this.pictureBoxEdit.Name = "pictureBoxEdit";
            this.pictureBoxEdit.Size = new System.Drawing.Size(22, 22);
            this.pictureBoxEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEdit.TabIndex = 2;
            this.pictureBoxEdit.TabStop = false;
            this.pictureBoxEdit.Click += new System.EventHandler(this.pictureBoxEdit_Click);
            // 
            // pictureBoxRemove
            // 
            this.pictureBoxRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRemove.Image = global::Projet_Control_2.Properties.Resources.Close_green;
            this.pictureBoxRemove.Location = new System.Drawing.Point(232, 4);
            this.pictureBoxRemove.Name = "pictureBoxRemove";
            this.pictureBoxRemove.Size = new System.Drawing.Size(21, 21);
            this.pictureBoxRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRemove.TabIndex = 2;
            this.pictureBoxRemove.TabStop = false;
            this.pictureBoxRemove.Tag = "";
            this.pictureBoxRemove.Click += new System.EventHandler(this.pictureBoxRemove_Click);
            // 
            // pictureBoxMedicine
            // 
            this.pictureBoxMedicine.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMedicine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxMedicine.Location = new System.Drawing.Point(13, 43);
            this.pictureBoxMedicine.Name = "pictureBoxMedicine";
            this.pictureBoxMedicine.Size = new System.Drawing.Size(162, 164);
            this.pictureBoxMedicine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMedicine.TabIndex = 0;
            this.pictureBoxMedicine.TabStop = false;
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrice.Font = new System.Drawing.Font("Eras Demi ITC", 9.25F);
            this.labelPrice.ForeColor = System.Drawing.Color.Black;
            this.labelPrice.Location = new System.Drawing.Point(176, 213);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(78, 25);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // medicineObj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(255, 249);
            this.Controls.Add(this.pictureBoxRequire);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelAdd);
            this.Controls.Add(this.labeRequire);
            this.Controls.Add(this.pictureBoxEdit);
            this.Controls.Add(this.pictureBoxRemove);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxMedicine);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "medicineObj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "medicineObj";
            this.Load += new System.EventHandler(this.medicineObj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRequire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMedicine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxRemove;
        public System.Windows.Forms.PictureBox pictureBoxMedicine;
        public System.Windows.Forms.Label labelTitle;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.PictureBox pictureBoxRequire;
        public System.Windows.Forms.Label labelAdd;
        public System.Windows.Forms.Label labeRequire;
        private System.Windows.Forms.PictureBox pictureBoxEdit;
        public System.Windows.Forms.Label labelPrice;
    }
}