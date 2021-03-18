
namespace _180321Task
{
    partial class Form1
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
            this.TopPnl = new System.Windows.Forms.Panel();
            this.SelectImageBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.OpenDescriptionBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SaveDescriptionBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SaveCvBtn = new Guna.UI2.WinForms.Guna2Button();
            this.LoadCvBtn = new Guna.UI2.WinForms.Guna2Button();
            this.userImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TopPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPnl
            // 
            this.TopPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(179)))), ((int)(((byte)(253)))));
            this.TopPnl.Controls.Add(this.guna2HtmlLabel2);
            this.TopPnl.Controls.Add(this.pictureBox1);
            this.TopPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPnl.Location = new System.Drawing.Point(0, 0);
            this.TopPnl.Name = "TopPnl";
            this.TopPnl.Size = new System.Drawing.Size(464, 46);
            this.TopPnl.TabIndex = 0;
            this.TopPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPnl_MouseDown);
            this.TopPnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPnl_MouseMove);
            this.TopPnl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPnl_MouseUp);
            // 
            // SelectImageBtn
            // 
            this.SelectImageBtn.AutoRoundedCorners = true;
            this.SelectImageBtn.BorderRadius = 21;
            this.SelectImageBtn.CheckedState.Parent = this.SelectImageBtn;
            this.SelectImageBtn.CustomImages.Parent = this.SelectImageBtn;
            this.SelectImageBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(198)))), ((int)(((byte)(117)))));
            this.SelectImageBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SelectImageBtn.ForeColor = System.Drawing.Color.White;
            this.SelectImageBtn.HoverState.Parent = this.SelectImageBtn;
            this.SelectImageBtn.Location = new System.Drawing.Point(166, 103);
            this.SelectImageBtn.Name = "SelectImageBtn";
            this.SelectImageBtn.ShadowDecoration.Parent = this.SelectImageBtn;
            this.SelectImageBtn.Size = new System.Drawing.Size(135, 45);
            this.SelectImageBtn.TabIndex = 2;
            this.SelectImageBtn.Text = "Select Image";
            this.SelectImageBtn.Click += new System.EventHandler(this.SelectImageBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(163, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Acceptable image format: *png";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 207);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(389, 33);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "Account Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(122, 264);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(313, 96);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // OpenDescriptionBtn
            // 
            this.OpenDescriptionBtn.CheckedState.Parent = this.OpenDescriptionBtn;
            this.OpenDescriptionBtn.CustomImages.Parent = this.OpenDescriptionBtn;
            this.OpenDescriptionBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OpenDescriptionBtn.ForeColor = System.Drawing.Color.White;
            this.OpenDescriptionBtn.HoverState.Parent = this.OpenDescriptionBtn;
            this.OpenDescriptionBtn.Location = new System.Drawing.Point(238, 366);
            this.OpenDescriptionBtn.Name = "OpenDescriptionBtn";
            this.OpenDescriptionBtn.ShadowDecoration.Parent = this.OpenDescriptionBtn;
            this.OpenDescriptionBtn.Size = new System.Drawing.Size(95, 45);
            this.OpenDescriptionBtn.TabIndex = 7;
            this.OpenDescriptionBtn.Text = "Open";
            this.OpenDescriptionBtn.Click += new System.EventHandler(this.OpenDescriptionBtn_Click);
            // 
            // SaveDescriptionBtn
            // 
            this.SaveDescriptionBtn.CheckedState.Parent = this.SaveDescriptionBtn;
            this.SaveDescriptionBtn.CustomImages.Parent = this.SaveDescriptionBtn;
            this.SaveDescriptionBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(198)))), ((int)(((byte)(117)))));
            this.SaveDescriptionBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SaveDescriptionBtn.ForeColor = System.Drawing.Color.White;
            this.SaveDescriptionBtn.HoverState.Parent = this.SaveDescriptionBtn;
            this.SaveDescriptionBtn.Location = new System.Drawing.Point(339, 366);
            this.SaveDescriptionBtn.Name = "SaveDescriptionBtn";
            this.SaveDescriptionBtn.ShadowDecoration.Parent = this.SaveDescriptionBtn;
            this.SaveDescriptionBtn.Size = new System.Drawing.Size(96, 45);
            this.SaveDescriptionBtn.TabIndex = 8;
            this.SaveDescriptionBtn.Text = "Save";
            this.SaveDescriptionBtn.Click += new System.EventHandler(this.SaveDescriptionBtn_Click);
            // 
            // SaveCvBtn
            // 
            this.SaveCvBtn.CheckedState.Parent = this.SaveCvBtn;
            this.SaveCvBtn.CustomImages.Parent = this.SaveCvBtn;
            this.SaveCvBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(198)))), ((int)(((byte)(117)))));
            this.SaveCvBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaveCvBtn.ForeColor = System.Drawing.Color.White;
            this.SaveCvBtn.HoverState.Parent = this.SaveCvBtn;
            this.SaveCvBtn.Location = new System.Drawing.Point(24, 505);
            this.SaveCvBtn.Name = "SaveCvBtn";
            this.SaveCvBtn.ShadowDecoration.Parent = this.SaveCvBtn;
            this.SaveCvBtn.Size = new System.Drawing.Size(411, 56);
            this.SaveCvBtn.TabIndex = 9;
            this.SaveCvBtn.Text = "Save ";
            this.SaveCvBtn.Click += new System.EventHandler(this.SaveCvBtn_Click);
            // 
            // LoadCvBtn
            // 
            this.LoadCvBtn.CheckedState.Parent = this.LoadCvBtn;
            this.LoadCvBtn.CustomImages.Parent = this.LoadCvBtn;
            this.LoadCvBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoadCvBtn.ForeColor = System.Drawing.Color.White;
            this.LoadCvBtn.HoverState.Parent = this.LoadCvBtn;
            this.LoadCvBtn.Location = new System.Drawing.Point(24, 443);
            this.LoadCvBtn.Name = "LoadCvBtn";
            this.LoadCvBtn.ShadowDecoration.Parent = this.LoadCvBtn;
            this.LoadCvBtn.Size = new System.Drawing.Size(411, 56);
            this.LoadCvBtn.TabIndex = 10;
            this.LoadCvBtn.Text = "Load";
            this.LoadCvBtn.Click += new System.EventHandler(this.LoadCvBtn_Click);
            // 
            // userImage
            // 
            this.userImage.BackColor = System.Drawing.Color.Transparent;
            this.userImage.Image = global::_180321Task.Properties.Resources.userImage2;
            this.userImage.Location = new System.Drawing.Point(12, 53);
            this.userImage.Name = "userImage";
            this.userImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.userImage.ShadowDecoration.Parent = this.userImage;
            this.userImage.Size = new System.Drawing.Size(134, 135);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userImage.TabIndex = 1;
            this.userImage.TabStop = false;
            this.userImage.UseTransparentBackground = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_180321Task.Properties.Resources.blue_close_window_40px;
            this.pictureBox1.Location = new System.Drawing.Point(419, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(15, 6);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(140, 33);
            this.guna2HtmlLabel2.TabIndex = 11;
            this.guna2HtmlLabel2.Text = "Info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(464, 582);
            this.Controls.Add(this.LoadCvBtn);
            this.Controls.Add(this.SaveCvBtn);
            this.Controls.Add(this.SaveDescriptionBtn);
            this.Controls.Add(this.OpenDescriptionBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectImageBtn);
            this.Controls.Add(this.userImage);
            this.Controls.Add(this.TopPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TopPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPnl;
        private Guna.UI2.WinForms.Guna2CirclePictureBox userImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button SelectImageBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Guna.UI2.WinForms.Guna2Button OpenDescriptionBtn;
        private Guna.UI2.WinForms.Guna2Button SaveDescriptionBtn;
        private Guna.UI2.WinForms.Guna2Button SaveCvBtn;
        private Guna.UI2.WinForms.Guna2Button LoadCvBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}

