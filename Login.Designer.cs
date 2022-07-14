namespace ThesisDiscussionForum
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.cardinalPhoto = new System.Windows.Forms.PictureBox();
            this.start_lbl = new System.Windows.Forms.Label();
            this.login_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name_tbox = new System.Windows.Forms.TextBox();
            this.pass_tbox = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.gosignup_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardinalPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // cardinalPhoto
            // 
            this.cardinalPhoto.BackColor = System.Drawing.Color.Transparent;
            this.cardinalPhoto.Image = ((System.Drawing.Image)(resources.GetObject("cardinalPhoto.Image")));
            this.cardinalPhoto.Location = new System.Drawing.Point(-1, -2);
            this.cardinalPhoto.Name = "cardinalPhoto";
            this.cardinalPhoto.Size = new System.Drawing.Size(614, 571);
            this.cardinalPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardinalPhoto.TabIndex = 11;
            this.cardinalPhoto.TabStop = false;
            // 
            // start_lbl
            // 
            this.start_lbl.AutoSize = true;
            this.start_lbl.BackColor = System.Drawing.Color.Transparent;
            this.start_lbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_lbl.Location = new System.Drawing.Point(209, 512);
            this.start_lbl.Name = "start_lbl";
            this.start_lbl.Size = new System.Drawing.Size(405, 25);
            this.start_lbl.TabIndex = 12;
            this.start_lbl.Text = "A Thesis Discussion Forum for Mapuans";
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.BackColor = System.Drawing.Color.Transparent;
            this.login_lbl.Font = new System.Drawing.Font("Century Gothic", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.login_lbl.Location = new System.Drawing.Point(668, 44);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(297, 118);
            this.login_lbl.TabIndex = 13;
            this.login_lbl.Text = "Login";
            this.login_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.login_lbl.Click += new System.EventHandler(this.Login_lbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(650, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(657, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Password";
            // 
            // name_tbox
            // 
            this.name_tbox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_tbox.Location = new System.Drawing.Point(770, 222);
            this.name_tbox.Name = "name_tbox";
            this.name_tbox.Size = new System.Drawing.Size(205, 33);
            this.name_tbox.TabIndex = 16;
            // 
            // pass_tbox
            // 
            this.pass_tbox.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_tbox.Location = new System.Drawing.Point(770, 272);
            this.pass_tbox.Name = "pass_tbox";
            this.pass_tbox.PasswordChar = '*';
            this.pass_tbox.Size = new System.Drawing.Size(205, 33);
            this.pass_tbox.TabIndex = 17;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.login_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.login_btn.FlatAppearance.BorderSize = 3;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.login_btn.Location = new System.Drawing.Point(633, 332);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(370, 87);
            this.login_btn.TabIndex = 18;
            this.login_btn.Text = "Log in";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // gosignup_btn
            // 
            this.gosignup_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gosignup_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.gosignup_btn.FlatAppearance.BorderSize = 3;
            this.gosignup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gosignup_btn.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gosignup_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gosignup_btn.Location = new System.Drawing.Point(633, 450);
            this.gosignup_btn.Name = "gosignup_btn";
            this.gosignup_btn.Size = new System.Drawing.Size(370, 87);
            this.gosignup_btn.TabIndex = 19;
            this.gosignup_btn.Text = "No account?\rClick here to sign up\r\n";
            this.gosignup_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gosignup_btn.UseVisualStyleBackColor = false;
            this.gosignup_btn.Click += new System.EventHandler(this.Gosignup_btn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1025, 566);
            this.Controls.Add(this.gosignup_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.pass_tbox);
            this.Controls.Add(this.name_tbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_lbl);
            this.Controls.Add(this.start_lbl);
            this.Controls.Add(this.cardinalPhoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thesis Discussion Forum for Mapuan Students";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardinalPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cardinalPhoto;
        private System.Windows.Forms.Label start_lbl;
        private System.Windows.Forms.Label login_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_tbox;
        private System.Windows.Forms.TextBox pass_tbox;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button gosignup_btn;
    }
}