namespace Proyecto
{
    partial class Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cone = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label_user = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.connect = new System.Windows.Forms.Button();
            this.headerr = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.headerr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(358, 199);
            this.listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 251);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            // 
            // cone
            // 
            this.cone.ActiveBorderThickness = 1;
            this.cone.ActiveCornerRadius = 20;
            this.cone.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.cone.ActiveForecolor = System.Drawing.Color.White;
            this.cone.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.cone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.cone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cone.BackgroundImage")));
            this.cone.ButtonText = "Enviar";
            this.cone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cone.ForeColor = System.Drawing.Color.SeaGreen;
            this.cone.IdleBorderThickness = 1;
            this.cone.IdleCornerRadius = 20;
            this.cone.IdleFillColor = System.Drawing.Color.White;
            this.cone.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.cone.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.cone.Location = new System.Drawing.Point(272, 245);
            this.cone.Margin = new System.Windows.Forms.Padding(5);
            this.cone.Name = "cone";
            this.cone.Size = new System.Drawing.Size(107, 33);
            this.cone.TabIndex = 2;
            this.cone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cone.Visible = false;
            this.cone.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.BackColor = System.Drawing.SystemColors.Control;
            this.label_user.Location = new System.Drawing.Point(98, 52);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(43, 13);
            this.label_user.TabIndex = 3;
            this.label_user.Text = "Usuario";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(98, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 20);
            this.textBox2.TabIndex = 6;
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(98, 103);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(85, 26);
            this.connect.TabIndex = 7;
            this.connect.Text = "Conectar";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click_1);
            // 
            // headerr
            // 
            this.headerr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.headerr.Controls.Add(this.bunifuImageButton1);
            this.headerr.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerr.Location = new System.Drawing.Point(0, 0);
            this.headerr.Name = "headerr";
            this.headerr.Size = new System.Drawing.Size(393, 23);
            this.headerr.TabIndex = 8;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuImageButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(380, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(13, 23);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.headerr;
            this.bunifuDragControl1.Vertical = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(-15, -15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(393, 283);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.headerr);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.cone);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Chat";
            this.Text = "Chat";
            this.headerr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ListBox listBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel label_user;
        private Bunifu.Framework.UI.BunifuThinButton2 cone;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Panel headerr;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}