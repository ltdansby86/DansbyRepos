namespace WindowsFormsApplication1
{
    partial class AdminHome
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
            this.nameLab = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.gameLab = new System.Windows.Forms.Label();
            this.gameTitle = new System.Windows.Forms.Label();
            this.playerLab = new System.Windows.Forms.Label();
            this.playerTot = new System.Windows.Forms.Label();
            this.playerListBox = new System.Windows.Forms.CheckedListBox();
            this.exitBut = new System.Windows.Forms.Button();
            this.winBut = new System.Windows.Forms.Button();
            this.lossBut = new System.Windows.Forms.Button();
            this.removeBut = new System.Windows.Forms.Button();
            this.rankBut = new System.Windows.Forms.Button();
            this.addPlayerBut = new System.Windows.Forms.Button();
            this.editBut = new System.Windows.Forms.Button();
            this.gameListbut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLab
            // 
            this.nameLab.AutoSize = true;
            this.nameLab.Location = new System.Drawing.Point(13, 13);
            this.nameLab.Name = "nameLab";
            this.nameLab.Size = new System.Drawing.Size(38, 13);
            this.nameLab.TabIndex = 0;
            this.nameLab.Text = "Name:";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(57, 13);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(57, 13);
            this.firstName.TabIndex = 1;
            this.firstName.Text = "First Name";
            this.firstName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(57, 26);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(58, 13);
            this.lastName.TabIndex = 2;
            this.lastName.Text = "Last Name";
            this.lastName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // gameLab
            // 
            this.gameLab.AutoSize = true;
            this.gameLab.Location = new System.Drawing.Point(13, 53);
            this.gameLab.Name = "gameLab";
            this.gameLab.Size = new System.Drawing.Size(38, 13);
            this.gameLab.TabIndex = 3;
            this.gameLab.Text = "Game:";
            // 
            // gameTitle
            // 
            this.gameTitle.AutoSize = true;
            this.gameTitle.Location = new System.Drawing.Point(57, 53);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(27, 13);
            this.gameTitle.TabIndex = 4;
            this.gameTitle.Text = "Title";
            // 
            // playerLab
            // 
            this.playerLab.AutoSize = true;
            this.playerLab.Location = new System.Drawing.Point(13, 82);
            this.playerLab.Name = "playerLab";
            this.playerLab.Size = new System.Drawing.Size(44, 13);
            this.playerLab.TabIndex = 5;
            this.playerLab.Text = "Players:";
            // 
            // playerTot
            // 
            this.playerTot.AutoSize = true;
            this.playerTot.Location = new System.Drawing.Point(57, 82);
            this.playerTot.Name = "playerTot";
            this.playerTot.Size = new System.Drawing.Size(13, 13);
            this.playerTot.TabIndex = 6;
            this.playerTot.Text = "0";
            this.playerTot.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // playerListBox
            // 
            this.playerListBox.FormattingEnabled = true;
            this.playerListBox.Location = new System.Drawing.Point(16, 113);
            this.playerListBox.Name = "playerListBox";
            this.playerListBox.Size = new System.Drawing.Size(165, 139);
            this.playerListBox.TabIndex = 7;
            this.playerListBox.SelectedIndexChanged += new System.EventHandler(this.playerListBox_SelectedIndexChanged);
            // 
            // exitBut
            // 
            this.exitBut.Location = new System.Drawing.Point(187, 229);
            this.exitBut.Name = "exitBut";
            this.exitBut.Size = new System.Drawing.Size(75, 23);
            this.exitBut.TabIndex = 8;
            this.exitBut.Text = "Exit";
            this.exitBut.UseVisualStyleBackColor = true;
            // 
            // winBut
            // 
            this.winBut.Location = new System.Drawing.Point(187, 200);
            this.winBut.Name = "winBut";
            this.winBut.Size = new System.Drawing.Size(75, 23);
            this.winBut.TabIndex = 9;
            this.winBut.Text = "Add Win";
            this.winBut.UseVisualStyleBackColor = true;
            // 
            // lossBut
            // 
            this.lossBut.Location = new System.Drawing.Point(187, 171);
            this.lossBut.Name = "lossBut";
            this.lossBut.Size = new System.Drawing.Size(75, 23);
            this.lossBut.TabIndex = 10;
            this.lossBut.Text = "Add Loss";
            this.lossBut.UseVisualStyleBackColor = true;
            // 
            // removeBut
            // 
            this.removeBut.Location = new System.Drawing.Point(187, 142);
            this.removeBut.Name = "removeBut";
            this.removeBut.Size = new System.Drawing.Size(75, 23);
            this.removeBut.TabIndex = 11;
            this.removeBut.Text = "Remove";
            this.removeBut.UseVisualStyleBackColor = true;
            // 
            // rankBut
            // 
            this.rankBut.Location = new System.Drawing.Point(187, 113);
            this.rankBut.Name = "rankBut";
            this.rankBut.Size = new System.Drawing.Size(75, 23);
            this.rankBut.TabIndex = 12;
            this.rankBut.Text = "Rank ";
            this.rankBut.UseVisualStyleBackColor = true;
            // 
            // addPlayerBut
            // 
            this.addPlayerBut.Location = new System.Drawing.Point(105, 77);
            this.addPlayerBut.Name = "addPlayerBut";
            this.addPlayerBut.Size = new System.Drawing.Size(157, 23);
            this.addPlayerBut.TabIndex = 13;
            this.addPlayerBut.Text = "Add Player";
            this.addPlayerBut.UseVisualStyleBackColor = true;
            // 
            // editBut
            // 
            this.editBut.Location = new System.Drawing.Point(187, 8);
            this.editBut.Name = "editBut";
            this.editBut.Size = new System.Drawing.Size(75, 23);
            this.editBut.TabIndex = 14;
            this.editBut.Text = "Edit";
            this.editBut.UseVisualStyleBackColor = true;
            this.editBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // gameListbut
            // 
            this.gameListbut.Location = new System.Drawing.Point(187, 48);
            this.gameListbut.Name = "gameListbut";
            this.gameListbut.Size = new System.Drawing.Size(75, 23);
            this.gameListbut.TabIndex = 15;
            this.gameListbut.Text = "Game List";
            this.gameListbut.UseVisualStyleBackColor = true;
            this.gameListbut.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.gameListbut);
            this.Controls.Add(this.editBut);
            this.Controls.Add(this.addPlayerBut);
            this.Controls.Add(this.rankBut);
            this.Controls.Add(this.removeBut);
            this.Controls.Add(this.lossBut);
            this.Controls.Add(this.winBut);
            this.Controls.Add(this.exitBut);
            this.Controls.Add(this.playerListBox);
            this.Controls.Add(this.playerTot);
            this.Controls.Add(this.playerLab);
            this.Controls.Add(this.gameTitle);
            this.Controls.Add(this.gameLab);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.nameLab);
            this.Name = "AdminHome";
            this.Text = "AdminHome";
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLab;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label gameLab;
        private System.Windows.Forms.Label gameTitle;
        private System.Windows.Forms.Label playerLab;
        private System.Windows.Forms.Label playerTot;
        private System.Windows.Forms.CheckedListBox playerListBox;
        private System.Windows.Forms.Button exitBut;
        private System.Windows.Forms.Button winBut;
        private System.Windows.Forms.Button lossBut;
        private System.Windows.Forms.Button removeBut;
        private System.Windows.Forms.Button rankBut;
        private System.Windows.Forms.Button addPlayerBut;
        private System.Windows.Forms.Button editBut;
        private System.Windows.Forms.Button gameListbut;
    }
}