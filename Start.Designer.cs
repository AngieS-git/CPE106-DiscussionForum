namespace ThesisDiscussionForum
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.cardinalPhoto = new System.Windows.Forms.PictureBox();
            this.start_lbl = new System.Windows.Forms.Label();
            this.gosignup_btn = new System.Windows.Forms.Button();
            this.gologin_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardinalPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // cardinalPhoto
            // 
            this.cardinalPhoto.BackColor = System.Drawing.Color.Transparent;
            this.cardinalPhoto.Image = ((System.Drawing.Image)(resources.GetObject("cardinalPhoto.Image")));
            this.cardinalPhoto.Location = new System.Drawing.Point(0, -3);
            this.cardinalPhoto.Name = "cardinalPhoto";
            this.cardinalPhoto.Size = new System.Drawing.Size(614, 571);
            this.cardinalPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardinalPhoto.TabIndex = 0;
            this.cardinalPhoto.TabStop = false;
            this.cardinalPhoto.Click += new System.EventHandler(this.CardinalPhoto_Click);
            // 
            // start_lbl
            // 
            this.start_lbl.AutoSize = true;
            this.start_lbl.BackColor = System.Drawing.Color.Transparent;
            this.start_lbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_lbl.Location = new System.Drawing.Point(209, 516);
            this.start_lbl.Name = "start_lbl";
            this.start_lbl.Size = new System.Drawing.Size(405, 25);
            this.start_lbl.TabIndex = 1;
            this.start_lbl.Text = "A Thesis Discussion Forum for Mapuans";
            // 
            // gosignup_btn
            // 
            this.gosignup_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gosignup_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.gosignup_btn.FlatAppearance.BorderSize = 3;
            this.gosignup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gosignup_btn.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gosignup_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gosignup_btn.Location = new System.Drawing.Point(630, 142);
            this.gosignup_btn.Name = "gosignup_btn";
            this.gosignup_btn.Size = new System.Drawing.Size(370, 87);
            this.gosignup_btn.TabIndex = 2;
            this.gosignup_btn.Text = "Sign Up";
            this.gosignup_btn.UseVisualStyleBackColor = false;
            this.gosignup_btn.Click += new System.EventHandler(this.Gosignup_btn_Click);
            // 
            // gologin_btn
            // 
            this.gologin_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gologin_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.gologin_btn.FlatAppearance.BorderSize = 3;
            this.gologin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gologin_btn.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gologin_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gologin_btn.Location = new System.Drawing.Point(630, 273);
            this.gologin_btn.Name = "gologin_btn";
            this.gologin_btn.Size = new System.Drawing.Size(370, 87);
            this.gologin_btn.TabIndex = 3;
            this.gologin_btn.Text = "Login";
            this.gologin_btn.UseVisualStyleBackColor = false;
            this.gologin_btn.Click += new System.EventHandler(this.Gologin_btn_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1025, 566);
            this.Controls.Add(this.gologin_btn);
            this.Controls.Add(this.gosignup_btn);
            this.Controls.Add(this.start_lbl);
            this.Controls.Add(this.cardinalPhoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thesis Discussion Forum for Mapuan Students";
            this.Load += new System.EventHandler(this.Start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardinalPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cardinalPhoto;
        private System.Windows.Forms.Label start_lbl;
        private System.Windows.Forms.Button gosignup_btn;
        private System.Windows.Forms.Button gologin_btn;
    }
}

