
namespace Projet_Control_2
{
    partial class addMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addMedicine));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxPicture = new Projet_Control_2.OvalPictureBox();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxAddPicture = new System.Windows.Forms.PictureBox();
            this.buttonClick = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBoxPicture);
            this.panel1.Controls.Add(this.radioButtonNo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.radioButtonYes);
            this.panel1.Controls.Add(this.textBoxQuantity);
            this.panel1.Controls.Add(this.textBoxPrice);
            this.panel1.Controls.Add(this.textBoxDescription);
            this.panel1.Controls.Add(this.textBoxTitle);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelQuantity);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBoxAddPicture);
            this.panel1.Location = new System.Drawing.Point(59, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 443);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxPicture
            // 
            this.pictureBoxPicture.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPicture.Image = global::Projet_Control_2.Properties.Resources.Med_default;
            this.pictureBoxPicture.Location = new System.Drawing.Point(187, 26);
            this.pictureBoxPicture.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxPicture.Name = "pictureBoxPicture";
            this.pictureBoxPicture.Size = new System.Drawing.Size(213, 197);
            this.pictureBoxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPicture.TabIndex = 6;
            this.pictureBoxPicture.TabStop = false;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.FlatAppearance.CheckedBackColor = System.Drawing.Color.MintCream;
            this.radioButtonNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonNo.Location = new System.Drawing.Point(469, 311);
            this.radioButtonNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(46, 21);
            this.radioButtonNo.TabIndex = 4;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            this.radioButtonNo.CheckedChanged += new System.EventHandler(this.radioButtonNo_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Eras Medium ITC", 7.5F);
            this.label6.Location = new System.Drawing.Point(389, 421);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "*DP = Doctor Permission";
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.FlatAppearance.CheckedBackColor = System.Drawing.Color.MintCream;
            this.radioButtonYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonYes.Location = new System.Drawing.Point(469, 284);
            this.radioButtonYes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(52, 21);
            this.radioButtonYes.TabIndex = 3;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Yes";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            this.radioButtonYes.CheckedChanged += new System.EventHandler(this.radioButtonYes_CheckedChanged);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.BackColor = System.Drawing.Color.MintCream;
            this.textBoxQuantity.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxQuantity.Location = new System.Drawing.Point(265, 293);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxQuantity.MaxLength = 2;
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(76, 22);
            this.textBoxQuantity.TabIndex = 2;
            this.textBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantity_KeyPress);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.Color.MintCream;
            this.textBoxPrice.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxPrice.Location = new System.Drawing.Point(87, 293);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPrice.MaxLength = 4;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(76, 22);
            this.textBoxPrice.TabIndex = 1;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.Color.MintCream;
            this.textBoxDescription.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxDescription.Location = new System.Drawing.Point(140, 341);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(339, 75);
            this.textBoxDescription.TabIndex = 5;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.Color.MintCream;
            this.textBoxTitle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxTitle.Location = new System.Drawing.Point(212, 246);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(161, 22);
            this.textBoxTitle.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Eras Medium ITC", 10F);
            this.label3.Location = new System.Drawing.Point(28, 341);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Eras Medium ITC", 10F);
            this.label5.Location = new System.Drawing.Point(355, 295);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Require DP*";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Eras Medium ITC", 10F);
            this.labelQuantity.Location = new System.Drawing.Point(180, 295);
            this.labelQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(74, 19);
            this.labelQuantity.TabIndex = 1;
            this.labelQuantity.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Eras Medium ITC", 10F);
            this.label2.Location = new System.Drawing.Point(28, 295);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Medium ITC", 10F);
            this.label1.Location = new System.Drawing.Point(147, 249);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // pictureBoxAddPicture
            // 
            this.pictureBoxAddPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAddPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAddPicture.Image = global::Projet_Control_2.Properties.Resources.add_2;
            this.pictureBoxAddPicture.Location = new System.Drawing.Point(365, 190);
            this.pictureBoxAddPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxAddPicture.Name = "pictureBoxAddPicture";
            this.pictureBoxAddPicture.Size = new System.Drawing.Size(35, 32);
            this.pictureBoxAddPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAddPicture.TabIndex = 0;
            this.pictureBoxAddPicture.TabStop = false;
            this.pictureBoxAddPicture.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // buttonClick
            // 
            this.buttonClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(212)))), ((int)(((byte)(202)))));
            this.buttonClick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClick.FlatAppearance.BorderSize = 0;
            this.buttonClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClick.Font = new System.Drawing.Font("Eras Demi ITC", 10F);
            this.buttonClick.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClick.Location = new System.Drawing.Point(271, 484);
            this.buttonClick.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClick.Name = "buttonClick";
            this.buttonClick.Size = new System.Drawing.Size(123, 37);
            this.buttonClick.TabIndex = 7;
            this.buttonClick.Text = "Add";
            this.buttonClick.UseVisualStyleBackColor = false;
            this.buttonClick.Click += new System.EventHandler(this.buttonClick_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Projet_Control_2.Properties.Resources.Close_256;
            this.pictureBox3.Location = new System.Drawing.Point(637, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // addMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(668, 540);
            this.Controls.Add(this.buttonClick);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "addMedicine";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addMedicine";
            this.Load += new System.EventHandler(this.addMedicine_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxAddPicture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button buttonClick;
        private OvalPictureBox pictureBoxPicture;
    }
}