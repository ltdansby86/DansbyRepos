namespace WindowsFormsApplication1
{
    partial class PlayerHome
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
            this.logoutBut = new System.Windows.Forms.Button();
            this.editBut = new System.Windows.Forms.Button();
            this.nameLab = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.gamerLab = new System.Windows.Forms.Label();
            this.gamerTag = new System.Windows.Forms.Label();
            this.winlabel = new System.Windows.Forms.Label();
            this.losslabel = new System.Windows.Forms.Label();
            this.wins = new System.Windows.Forms.Label();
            this.losses = new System.Windows.Forms.Label();
            this.gameLab = new System.Windows.Forms.Label();
            this.gameListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // logoutBut
            // 
            this.logoutBut.Location = new System.Drawing.Point(245, 217);
            this.logoutBut.Name = "logoutBut";
            this.logoutBut.Size = new System.Drawing.Size(75, 23);
            this.logoutBut.TabIndex = 0;
            this.logoutBut.Text = "Log out";
            this.logoutBut.UseVisualStyleBackColor = true;
            this.logoutBut.Click += new System.EventHandler(this.logoutBut_Click);
            // 
            // editBut
            // 
            this.editBut.Location = new System.Drawing.Point(245, 246);
            this.editBut.Name = "editBut";
            this.editBut.Size = new System.Drawing.Size(75, 23);
            this.editBut.TabIndex = 1;
            this.editBut.Text = "Edit Profile";
            this.editBut.UseVisualStyleBackColor = true;
            this.editBut.Click += new System.EventHandler(this.editBut_Click);
            // 
            // nameLab
            // 
            this.nameLab.AutoSize = true;
            this.nameLab.Location = new System.Drawing.Point(4, 13);
            this.nameLab.Name = "nameLab";
            this.nameLab.Size = new System.Drawing.Size(38, 13);
            this.nameLab.TabIndex = 3;
            this.nameLab.Text = "Name:";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(104, 13);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(57, 13);
            this.firstName.TabIndex = 4;
            this.firstName.Text = "First Name";
            this.firstName.Click += new System.EventHandler(this.firstName_Click);
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(104, 32);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(58, 13);
            this.lastName.TabIndex = 5;
            this.lastName.Text = "Last Name";
            // 
            // gamerLab
            // 
            this.gamerLab.AutoSize = true;
            this.gamerLab.Location = new System.Drawing.Point(4, 52);
            this.gamerLab.Name = "gamerLab";
            this.gamerLab.Size = new System.Drawing.Size(63, 13);
            this.gamerLab.TabIndex = 6;
            this.gamerLab.Text = "Gamer Tag:";
            this.gamerLab.Click += new System.EventHandler(this.gamerLab_Click);
            // 
            // gamerTag
            // 
            this.gamerTag.AutoSize = true;
            this.gamerTag.Location = new System.Drawing.Point(104, 52);
            this.gamerTag.Name = "gamerTag";
            this.gamerTag.Size = new System.Drawing.Size(57, 13);
            this.gamerTag.TabIndex = 7;
            this.gamerTag.Text = "GamerTag";
            // 
            // winlabel
            // 
            this.winlabel.AutoSize = true;
            this.winlabel.Location = new System.Drawing.Point(4, 82);
            this.winlabel.Name = "winlabel";
            this.winlabel.Size = new System.Drawing.Size(34, 13);
            this.winlabel.TabIndex = 8;
            this.winlabel.Text = "Wins:";
            this.winlabel.Click += new System.EventHandler(this.winlabel_Click);
            // 
            // losslabel
            // 
            this.losslabel.AutoSize = true;
            this.losslabel.Location = new System.Drawing.Point(4, 107);
            this.losslabel.Name = "losslabel";
            this.losslabel.Size = new System.Drawing.Size(43, 13);
            this.losslabel.TabIndex = 9;
            this.losslabel.Text = "Losses:";
            // 
            // wins
            // 
            this.wins.AutoSize = true;
            this.wins.Location = new System.Drawing.Point(104, 82);
            this.wins.Name = "wins";
            this.wins.Size = new System.Drawing.Size(13, 13);
            this.wins.TabIndex = 10;
            this.wins.Text = "0";
            this.wins.Click += new System.EventHandler(this.label1_Click);
            // 
            // losses
            // 
            this.losses.AutoSize = true;
            this.losses.Location = new System.Drawing.Point(104, 107);
            this.losses.Name = "losses";
            this.losses.Size = new System.Drawing.Size(13, 13);
            this.losses.TabIndex = 11;
            this.losses.Text = "0";
            this.losses.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // gameLab
            // 
            this.gameLab.AutoSize = true;
            this.gameLab.Location = new System.Drawing.Point(7, 135);
            this.gameLab.Name = "gameLab";
            this.gameLab.Size = new System.Drawing.Size(57, 13);
            this.gameLab.TabIndex = 12;
            this.gameLab.Text = "Game List:";
            // 
            // gameListBox
            // 
            this.gameListBox.FormattingEnabled = true;
            this.gameListBox.Location = new System.Drawing.Point(82, 135);
            this.gameListBox.Name = "gameListBox";
            this.gameListBox.Size = new System.Drawing.Size(120, 134);
            this.gameListBox.TabIndex = 13;
            // 
            // PlayerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 276);
            this.Controls.Add(this.gameListBox);
            this.Controls.Add(this.gameLab);
            this.Controls.Add(this.losses);
            this.Controls.Add(this.wins);
            this.Controls.Add(this.losslabel);
            this.Controls.Add(this.winlabel);
            this.Controls.Add(this.gamerTag);
            this.Controls.Add(this.gamerLab);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.nameLab);
            this.Controls.Add(this.editBut);
            this.Controls.Add(this.logoutBut);
            this.Name = "PlayerHome";
            this.Text = "PlayerHome";
            this.Load += new System.EventHandler(this.PlayerHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutBut;
        private System.Windows.Forms.Button editBut;
        private System.Windows.Forms.Label nameLab;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label gamerLab;
        private System.Windows.Forms.Label gamerTag;
        private System.Windows.Forms.Label winlabel;
        private System.Windows.Forms.Label losslabel;
        private System.Windows.Forms.Label wins;
        private System.Windows.Forms.Label losses;
        private System.Windows.Forms.Label gameLab;
        private System.Windows.Forms.ListBox gameListBox;
    }
}