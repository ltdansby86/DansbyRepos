namespace WindowsFormsApplication1
{
    partial class Startscreen
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
            this.title = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.newPlayerbut = new System.Windows.Forms.Button();
            this.playerBut = new System.Windows.Forms.Button();
            this.adminBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(3, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(516, 43);
            this.title.TabIndex = 0;
            this.title.Text = "Welcome to Game Tournamet 2015";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(13, 81);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(92, 13);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "Gamertag/ Name:";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(13, 121);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(56, 13);
            this.passLabel.TabIndex = 2;
            this.passLabel.Text = "Password:";
            this.passLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(126, 81);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(176, 20);
            this.userBox.TabIndex = 3;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(126, 121);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(176, 20);
            this.passBox.TabIndex = 4;
            // 
            // newPlayerbut
            // 
            this.newPlayerbut.Location = new System.Drawing.Point(16, 170);
            this.newPlayerbut.Name = "newPlayerbut";
            this.newPlayerbut.Size = new System.Drawing.Size(75, 23);
            this.newPlayerbut.TabIndex = 5;
            this.newPlayerbut.Text = "New Player";
            this.newPlayerbut.UseVisualStyleBackColor = true;
            this.newPlayerbut.Click += new System.EventHandler(this.button1_Click);
            // 
            // playerBut
            // 
            this.playerBut.Location = new System.Drawing.Point(97, 170);
            this.playerBut.Name = "playerBut";
            this.playerBut.Size = new System.Drawing.Size(101, 23);
            this.playerBut.TabIndex = 6;
            this.playerBut.Text = "Sign in as Player";
            this.playerBut.UseVisualStyleBackColor = true;
            this.playerBut.Click += new System.EventHandler(this.playerBut_Click);
            // 
            // adminBut
            // 
            this.adminBut.Location = new System.Drawing.Point(204, 170);
            this.adminBut.Name = "adminBut";
            this.adminBut.Size = new System.Drawing.Size(101, 23);
            this.adminBut.TabIndex = 7;
            this.adminBut.Text = "Sign in as Admin";
            this.adminBut.UseVisualStyleBackColor = true;
            this.adminBut.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Startscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 261);
            this.Controls.Add(this.adminBut);
            this.Controls.Add(this.playerBut);
            this.Controls.Add(this.newPlayerbut);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.title);
            this.Name = "Startscreen";
            this.Text = "Game Tournament";
            this.Load += new System.EventHandler(this.Startscreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Button newPlayerbut;
        private System.Windows.Forms.Button playerBut;
        private System.Windows.Forms.Button adminBut;
    }
}

