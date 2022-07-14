namespace ThesisDiscussionForum
{
    partial class Home
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
            this.body_gbox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.control_gbox = new System.Windows.Forms.GroupBox();
            this.logout_btn = new System.Windows.Forms.Button();
            this.bookmark_btn = new System.Windows.Forms.Button();
            this.profile_btn = new System.Windows.Forms.Button();
            this.start_lbl = new System.Windows.Forms.Label();
            this.body_gbox.SuspendLayout();
            this.control_gbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // body_gbox
            // 
            this.body_gbox.BackColor = System.Drawing.Color.Gainsboro;
            this.body_gbox.Controls.Add(this.label1);
            this.body_gbox.Controls.Add(this.control_gbox);
            this.body_gbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.body_gbox.Location = new System.Drawing.Point(-1, 101);
            this.body_gbox.Name = "body_gbox";
            this.body_gbox.Size = new System.Drawing.Size(1027, 465);
            this.body_gbox.TabIndex = 0;
            this.body_gbox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 2;
            this.label1.Visible = false;
            // 
            // control_gbox
            // 
            this.control_gbox.BackColor = System.Drawing.Color.DarkGray;
            this.control_gbox.Controls.Add(this.logout_btn);
            this.control_gbox.Controls.Add(this.bookmark_btn);
            this.control_gbox.Controls.Add(this.profile_btn);
            this.control_gbox.Location = new System.Drawing.Point(13, 19);
            this.control_gbox.Name = "control_gbox";
            this.control_gbox.Size = new System.Drawing.Size(220, 234);
            this.control_gbox.TabIndex = 1;
            this.control_gbox.TabStop = false;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.Teal;
            this.logout_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.logout_btn.FlatAppearance.BorderSize = 3;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.logout_btn.Location = new System.Drawing.Point(18, 153);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(179, 50);
            this.logout_btn.TabIndex = 2;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // bookmark_btn
            // 
            this.bookmark_btn.BackColor = System.Drawing.Color.Teal;
            this.bookmark_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bookmark_btn.FlatAppearance.BorderSize = 3;
            this.bookmark_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookmark_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookmark_btn.ForeColor = System.Drawing.Color.White;
            this.bookmark_btn.Location = new System.Drawing.Point(18, 87);
            this.bookmark_btn.Name = "bookmark_btn";
            this.bookmark_btn.Size = new System.Drawing.Size(179, 50);
            this.bookmark_btn.TabIndex = 2;
            this.bookmark_btn.Text = "Bookmarks";
            this.bookmark_btn.UseVisualStyleBackColor = false;
            // 
            // profile_btn
            // 
            this.profile_btn.BackColor = System.Drawing.Color.Teal;
            this.profile_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.profile_btn.FlatAppearance.BorderSize = 3;
            this.profile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profile_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_btn.ForeColor = System.Drawing.Color.White;
            this.profile_btn.Location = new System.Drawing.Point(18, 19);
            this.profile_btn.Name = "profile_btn";
            this.profile_btn.Size = new System.Drawing.Size(179, 50);
            this.profile_btn.TabIndex = 1;
            this.profile_btn.Text = "Profile";
            this.profile_btn.UseVisualStyleBackColor = false;
            this.profile_btn.Click += new System.EventHandler(this.Profile_btn_Click);
            // 
            // start_lbl
            // 
            this.start_lbl.AutoSize = true;
            this.start_lbl.BackColor = System.Drawing.Color.Transparent;
            this.start_lbl.Font = new System.Drawing.Font("Century Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_lbl.Location = new System.Drawing.Point(12, 50);
            this.start_lbl.Name = "start_lbl";
            this.start_lbl.Size = new System.Drawing.Size(954, 39);
            this.start_lbl.TabIndex = 13;
            this.start_lbl.Text = "Welcome to the Thesis Discussion Forum for Mapuan Students";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1025, 566);
            this.Controls.Add(this.start_lbl);
            this.Controls.Add(this.body_gbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thesis Discussion Forum for Mapuan Students";
            this.Load += new System.EventHandler(this.Home_Load);
            this.body_gbox.ResumeLayout(false);
            this.body_gbox.PerformLayout();
            this.control_gbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox body_gbox;
        private System.Windows.Forms.GroupBox control_gbox;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button bookmark_btn;
        private System.Windows.Forms.Button profile_btn;
        private System.Windows.Forms.Label start_lbl;
        private System.Windows.Forms.Label label1;
    }
}