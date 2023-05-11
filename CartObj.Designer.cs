
namespace Projet_Control_2
{
    partial class CartObj
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartObj));
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxRequire = new System.Windows.Forms.PictureBox();
            this.pictureBoxRemove = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinus = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlus = new System.Windows.Forms.PictureBox();
            this.pictureBoxMedicine = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRequire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Enabled = false;
            this.textBoxQuantity.Font = new System.Drawing.Font("Eras Medium ITC", 10.75F);
            this.textBoxQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxQuantity.Location = new System.Drawing.Point(83, 113);
            this.textBoxQuantity.MaxLength = 2;
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(57, 24);
            this.textBoxQuantity.TabIndex = 1;
            this.textBoxQuantity.Text = "1";
            this.textBoxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxQuantity.TextChanged += new System.EventHandler(this.textBoxQuantity_TextChanged);
            this.textBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantity_KeyPress);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(204)))), ((int)(((byte)(211)))));
            this.labelQuantity.Location = new System.Drawing.Point(82, 92);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(58, 15);
            this.labelQuantity.TabIndex = 2;
            this.labelQuantity.Text = "Quantity";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(204)))), ((int)(((byte)(211)))));
            this.labelTotalPrice.Location = new System.Drawing.Point(91, 154);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(35, 15);
            this.labelTotalPrice.TabIndex = 2;
            this.labelTotalPrice.Text = "Price";
            // 
            // labelPrice
            // 
            this.labelPrice.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelPrice.Location = new System.Drawing.Point(62, 170);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(99, 15);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Eras Medium ITC", 10.75F);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTitle.Location = new System.Drawing.Point(26, 64);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(165, 18);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Title";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Controls.Add(this.pictureBoxRequire);
            this.panel1.Controls.Add(this.labelTotalPrice);
            this.panel1.Controls.Add(this.pictureBoxRemove);
            this.panel1.Controls.Add(this.textBoxQuantity);
            this.panel1.Controls.Add(this.labelQuantity);
            this.panel1.Controls.Add(this.pictureBoxMinus);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Controls.Add(this.pictureBoxPlus);
            this.panel1.Controls.Add(this.pictureBoxMedicine);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 191);
            this.panel1.TabIndex = 4;
            // 
            // pictureBoxRequire
            // 
            this.pictureBoxRequire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRequire.Image = global::Projet_Control_2.Properties.Resources.pngegg1;
            this.pictureBoxRequire.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxRequire.Name = "pictureBoxRequire";
            this.pictureBoxRequire.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxRequire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRequire.TabIndex = 3;
            this.pictureBoxRequire.TabStop = false;
            this.pictureBoxRequire.Tag = "";
            this.toolTip1.SetToolTip(this.pictureBoxRequire, "Require Doctor Permission , click to upload it");
            this.pictureBoxRequire.Click += new System.EventHandler(this.pictureBoxRequire_Click);
            // 
            // pictureBoxRemove
            // 
            this.pictureBoxRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRemove.Image = global::Projet_Control_2.Properties.Resources.Close_green;
            this.pictureBoxRemove.Location = new System.Drawing.Point(199, 3);
            this.pictureBoxRemove.Name = "pictureBoxRemove";
            this.pictureBoxRemove.Size = new System.Drawing.Size(18, 18);
            this.pictureBoxRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRemove.TabIndex = 3;
            this.pictureBoxRemove.TabStop = false;
            this.pictureBoxRemove.Tag = "";
            this.toolTip1.SetToolTip(this.pictureBoxRemove, "Remove from cart");
            this.pictureBoxRemove.Click += new System.EventHandler(this.pictureBoxRemove_Click);
            // 
            // pictureBoxMinus
            // 
            this.pictureBoxMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinus.Image = global::Projet_Control_2.Properties.Resources.minus_2_128__1_;
            this.pictureBoxMinus.Location = new System.Drawing.Point(59, 115);
            this.pictureBoxMinus.Name = "pictureBoxMinus";
            this.pictureBoxMinus.Size = new System.Drawing.Size(19, 19);
            this.pictureBoxMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinus.TabIndex = 0;
            this.pictureBoxMinus.TabStop = false;
            this.pictureBoxMinus.Click += new System.EventHandler(this.pictureBoxMinus_Click);
            // 
            // pictureBoxPlus
            // 
            this.pictureBoxPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPlus.Image = global::Projet_Control_2.Properties.Resources.plus_8_128;
            this.pictureBoxPlus.Location = new System.Drawing.Point(145, 115);
            this.pictureBoxPlus.Name = "pictureBoxPlus";
            this.pictureBoxPlus.Size = new System.Drawing.Size(19, 19);
            this.pictureBoxPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPlus.TabIndex = 0;
            this.pictureBoxPlus.TabStop = false;
            this.pictureBoxPlus.Click += new System.EventHandler(this.pictureBoxPlus_Click);
            // 
            // pictureBoxMedicine
            // 
            this.pictureBoxMedicine.Location = new System.Drawing.Point(82, 3);
            this.pictureBoxMedicine.Name = "pictureBoxMedicine";
            this.pictureBoxMedicine.Size = new System.Drawing.Size(57, 57);
            this.pictureBoxMedicine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMedicine.TabIndex = 0;
            this.pictureBoxMedicine.TabStop = false;
            // 
            // CartObj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(220, 191);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CartObj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CartObj";
            this.Load += new System.EventHandler(this.CartObj_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRequire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMedicine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMedicine;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.PictureBox pictureBoxPlus;
        private System.Windows.Forms.PictureBox pictureBoxMinus;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxRemove;
        private System.Windows.Forms.PictureBox pictureBoxRequire;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
    }
}