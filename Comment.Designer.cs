
namespace Projet_Control_2
{
    partial class Comment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comment));
            this.labelClientName = new System.Windows.Forms.Label();
            this.labelReport = new System.Windows.Forms.Label();
            this.labelLikes = new System.Windows.Forms.Label();
            this.pictureBoxLike = new System.Windows.Forms.PictureBox();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.buttonPost = new System.Windows.Forms.Button();
            this.pictureBoxEdit = new System.Windows.Forms.PictureBox();
            this.pictureBoxRemoveComment = new System.Windows.Forms.PictureBox();
            this.pictureboxClientPic = new Projet_Control_2.OvalPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemoveComment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxClientPic)).BeginInit();
            this.SuspendLayout();
            // 
            // labelClientName
            // 
            this.labelClientName.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientName.Location = new System.Drawing.Point(70, 19);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(120, 23);
            this.labelClientName.TabIndex = 1;
            this.labelClientName.Tag = "add";
            this.labelClientName.Text = "Client Name";
            this.labelClientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelReport
            // 
            this.labelReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelReport.Font = new System.Drawing.Font("Eras Medium ITC", 10.25F);
            this.labelReport.Location = new System.Drawing.Point(398, 143);
            this.labelReport.Name = "labelReport";
            this.labelReport.Size = new System.Drawing.Size(55, 23);
            this.labelReport.TabIndex = 1;
            this.labelReport.Text = "Report";
            this.labelReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLikes
            // 
            this.labelLikes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLikes.Font = new System.Drawing.Font("Eras Medium ITC", 10.25F);
            this.labelLikes.Location = new System.Drawing.Point(69, 142);
            this.labelLikes.Name = "labelLikes";
            this.labelLikes.Size = new System.Drawing.Size(74, 23);
            this.labelLikes.TabIndex = 3;
            this.labelLikes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxLike
            // 
            this.pictureBoxLike.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxLike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLike.Image = global::Projet_Control_2.Properties.Resources.Like_Grey;
            this.pictureBoxLike.Location = new System.Drawing.Point(29, 137);
            this.pictureBoxLike.Name = "pictureBoxLike";
            this.pictureBoxLike.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxLike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLike.TabIndex = 2;
            this.pictureBoxLike.TabStop = false;
            this.pictureBoxLike.Click += new System.EventHandler(this.pictureBoxLike_Click);
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(19, 65);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(434, 68);
            this.textBoxComment.TabIndex = 5;
            this.textBoxComment.Tag = "add";
            // 
            // labelComment
            // 
            this.labelComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelComment.Font = new System.Drawing.Font("Eras Medium ITC", 9.25F);
            this.labelComment.Location = new System.Drawing.Point(18, 65);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(435, 68);
            this.labelComment.TabIndex = 1;
            this.labelComment.Text = "Comment";
            // 
            // buttonPost
            // 
            this.buttonPost.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(204)))), ((int)(((byte)(211)))));
            this.buttonPost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPost.FlatAppearance.BorderSize = 0;
            this.buttonPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPost.Font = new System.Drawing.Font("Eras Demi ITC", 9F);
            this.buttonPost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPost.Location = new System.Drawing.Point(200, 143);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(75, 25);
            this.buttonPost.TabIndex = 7;
            this.buttonPost.Tag = "add";
            this.buttonPost.Text = "Post it";
            this.buttonPost.UseVisualStyleBackColor = false;
            this.buttonPost.Visible = false;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // pictureBoxEdit
            // 
            this.pictureBoxEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEdit.Image = global::Projet_Control_2.Properties.Resources.writing_pencil_pngrepo_com;
            this.pictureBoxEdit.Location = new System.Drawing.Point(411, 4);
            this.pictureBoxEdit.Name = "pictureBoxEdit";
            this.pictureBoxEdit.Size = new System.Drawing.Size(22, 22);
            this.pictureBoxEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEdit.TabIndex = 8;
            this.pictureBoxEdit.TabStop = false;
            this.pictureBoxEdit.Tag = "";
            this.pictureBoxEdit.Visible = false;
            this.pictureBoxEdit.Click += new System.EventHandler(this.pictureBoxEdit_Click);
            // 
            // pictureBoxRemoveComment
            // 
            this.pictureBoxRemoveComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRemoveComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRemoveComment.Image = global::Projet_Control_2.Properties.Resources.Close_green;
            this.pictureBoxRemoveComment.Location = new System.Drawing.Point(439, 4);
            this.pictureBoxRemoveComment.Name = "pictureBoxRemoveComment";
            this.pictureBoxRemoveComment.Size = new System.Drawing.Size(22, 22);
            this.pictureBoxRemoveComment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRemoveComment.TabIndex = 9;
            this.pictureBoxRemoveComment.TabStop = false;
            this.pictureBoxRemoveComment.Tag = "add";
            this.pictureBoxRemoveComment.Visible = false;
            this.pictureBoxRemoveComment.Click += new System.EventHandler(this.pictureBoxRemoveComment_Click);
            // 
            // pictureboxClientPic
            // 
            this.pictureboxClientPic.BackColor = System.Drawing.Color.DarkGray;
            this.pictureboxClientPic.Location = new System.Drawing.Point(19, 9);
            this.pictureboxClientPic.Name = "pictureboxClientPic";
            this.pictureboxClientPic.Size = new System.Drawing.Size(43, 43);
            this.pictureboxClientPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxClientPic.TabIndex = 0;
            this.pictureboxClientPic.TabStop = false;
            this.pictureboxClientPic.Tag = "add";
            // 
            // Comment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(465, 173);
            this.Controls.Add(this.pictureBoxRemoveComment);
            this.Controls.Add(this.pictureBoxEdit);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.labelLikes);
            this.Controls.Add(this.pictureBoxLike);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.labelReport);
            this.Controls.Add(this.labelClientName);
            this.Controls.Add(this.pictureboxClientPic);
            this.Controls.Add(this.textBoxComment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Comment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recommended";
            this.Load += new System.EventHandler(this.Comment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemoveComment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxClientPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label labelComment;
        public System.Windows.Forms.Label labelClientName;
        public System.Windows.Forms.PictureBox pictureBoxLike;
        public System.Windows.Forms.Label labelReport;
        internal OvalPictureBox pictureboxClientPic;
        public System.Windows.Forms.Label labelLikes;
        public System.Windows.Forms.Button buttonPost;
        public System.Windows.Forms.PictureBox pictureBoxEdit;
        public System.Windows.Forms.PictureBox pictureBoxRemoveComment;
        public System.Windows.Forms.TextBox textBoxComment;
    }
}