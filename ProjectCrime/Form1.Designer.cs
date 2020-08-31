namespace ProjectCrime
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtadminid = new System.Windows.Forms.TextBox();
            this.txtadminname = new System.Windows.Forms.TextBox();
            this.txtloginoffID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtloginoffName = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSystem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkKhaki;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN LOGIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkKhaki;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADMIN ID :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkKhaki;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "ADMIN NAME :";
            // 
            // txtadminid
            // 
            this.txtadminid.BackColor = System.Drawing.Color.Honeydew;
            this.txtadminid.Location = new System.Drawing.Point(167, 96);
            this.txtadminid.Name = "txtadminid";
            this.txtadminid.Size = new System.Drawing.Size(57, 20);
            this.txtadminid.TabIndex = 3;
            this.txtadminid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtadminname
            // 
            this.txtadminname.BackColor = System.Drawing.Color.Honeydew;
            this.txtadminname.Location = new System.Drawing.Point(211, 161);
            this.txtadminname.Name = "txtadminname";
            this.txtadminname.Size = new System.Drawing.Size(126, 20);
            this.txtadminname.TabIndex = 4;
            // 
            // txtloginoffID
            // 
            this.txtloginoffID.BackColor = System.Drawing.Color.Honeydew;
            this.txtloginoffID.Location = new System.Drawing.Point(683, 96);
            this.txtloginoffID.Name = "txtloginoffID";
            this.txtloginoffID.Size = new System.Drawing.Size(57, 20);
            this.txtloginoffID.TabIndex = 5;
            this.txtloginoffID.TextChanged += new System.EventHandler(this.txtloginoffID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkKhaki;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(518, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 45);
            this.label4.TabIndex = 6;
            this.label4.Text = "OFFICER LOGIN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkKhaki;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(512, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 34);
            this.label5.TabIndex = 7;
            this.label5.Text = "OFFICER ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkKhaki;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Tw Cen MT", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(512, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 34);
            this.label6.TabIndex = 8;
            this.label6.Text = "OFFICER NAME :";
            // 
            // txtloginoffName
            // 
            this.txtloginoffName.BackColor = System.Drawing.Color.Honeydew;
            this.txtloginoffName.Location = new System.Drawing.Point(731, 160);
            this.txtloginoffName.Name = "txtloginoffName";
            this.txtloginoffName.Size = new System.Drawing.Size(78, 20);
            this.txtloginoffName.TabIndex = 9;
            this.txtloginoffName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.MintCream;
            this.login.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(99, 226);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(125, 40);
            this.login.TabIndex = 10;
            this.login.Text = "LOGIN";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MintCream;
            this.button2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(588, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 40);
            this.button2.TabIndex = 11;
            this.button2.Text = "LOGIN";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSystem
            // 
            this.btnSystem.Location = new System.Drawing.Point(795, 286);
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.Size = new System.Drawing.Size(84, 26);
            this.btnSystem.TabIndex = 12;
            this.btnSystem.Text = "System";
            this.btnSystem.UseVisualStyleBackColor = true;
            this.btnSystem.Click += new System.EventHandler(this.btnSystem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectCrime.Properties.Resources._1__3_;
            this.ClientSize = new System.Drawing.Size(903, 324);
            this.Controls.Add(this.btnSystem);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.login);
            this.Controls.Add(this.txtloginoffName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtloginoffID);
            this.Controls.Add(this.txtadminname);
            this.Controls.Add(this.txtadminid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtadminid;
        private System.Windows.Forms.TextBox txtadminname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtloginoffName;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txtloginoffID;
        private System.Windows.Forms.Button btnSystem;
    }
}