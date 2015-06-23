namespace WindowsFormsApplication1
{
    partial class CreateProfile
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
            this.firstnLab = new System.Windows.Forms.Label();
            this.lastnLab = new System.Windows.Forms.Label();
            this.gTagLab = new System.Windows.Forms.Label();
            this.gameLab = new System.Windows.Forms.Label();
            this.gameListBox = new System.Windows.Forms.CheckedListBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.gamerTagBox = new System.Windows.Forms.TextBox();
            this.exitBut = new System.Windows.Forms.Button();
            this.submitBut = new System.Windows.Forms.Button();
            this.passwLab = new System.Windows.Forms.Label();
            this.passwBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // firstnLab
            // 
            this.firstnLab.AutoSize = true;
            this.firstnLab.Location = new System.Drawing.Point(10, 13);
            this.firstnLab.Name = "firstnLab";
            this.firstnLab.Size = new System.Drawing.Size(60, 13);
            this.firstnLab.TabIndex = 0;
            this.firstnLab.Text = "First Name:";
            // 
            // lastnLab
            // 
            this.lastnLab.AutoSize = true;
            this.lastnLab.Location = new System.Drawing.Point(10, 40);
            this.lastnLab.Name = "lastnLab";
            this.lastnLab.Size = new System.Drawing.Size(61, 13);
            this.lastnLab.TabIndex = 1;
            this.lastnLab.Text = "Last Name:";
            // 
            // gTagLab
            // 
            this.gTagLab.AutoSize = true;
            this.gTagLab.Location = new System.Drawing.Point(10, 67);
            this.gTagLab.Name = "gTagLab";
            this.gTagLab.Size = new System.Drawing.Size(63, 13);
            this.gTagLab.TabIndex = 2;
            this.gTagLab.Text = "Gamer Tag:";
            // 
            // gameLab
            // 
            this.gameLab.AutoSize = true;
            this.gameLab.Location = new System.Drawing.Point(12, 125);
            this.gameLab.Name = "gameLab";
            this.gameLab.Size = new System.Drawing.Size(43, 13);
            this.gameLab.TabIndex = 3;
            this.gameLab.Text = "Games:";
            this.gameLab.Click += new System.EventHandler(this.gameLab_Click);
            // 
            // gameListBox
            // 
            this.gameListBox.FormattingEnabled = true;
            this.gameListBox.Location = new System.Drawing.Point(80, 125);
            this.gameListBox.Name = "gameListBox";
            this.gameListBox.Size = new System.Drawing.Size(120, 124);
            this.gameListBox.TabIndex = 4;
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(83, 13);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(117, 20);
            this.firstNameBox.TabIndex = 5;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(83, 40);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(117, 20);
            this.lastNameBox.TabIndex = 6;
            // 
            // gamerTagBox
            // 
            this.gamerTagBox.Location = new System.Drawing.Point(83, 67);
            this.gamerTagBox.Name = "gamerTagBox";
            this.gamerTagBox.Size = new System.Drawing.Size(117, 20);
            this.gamerTagBox.TabIndex = 7;
            // 
            // exitBut
            // 
            this.exitBut.Location = new System.Drawing.Point(206, 226);
            this.exitBut.Name = "exitBut";
            this.exitBut.Size = new System.Drawing.Size(75, 23);
            this.exitBut.TabIndex = 8;
            this.exitBut.Text = "Exit";
            this.exitBut.UseVisualStyleBackColor = true;
            this.exitBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // submitBut
            // 
            this.submitBut.Location = new System.Drawing.Point(206, 197);
            this.submitBut.Name = "submitBut";
            this.submitBut.Size = new System.Drawing.Size(75, 23);
            this.submitBut.TabIndex = 9;
            this.submitBut.Text = "Submit";
            this.submitBut.UseVisualStyleBackColor = true;
            // 
            // passwLab
            // 
            this.passwLab.AutoSize = true;
            this.passwLab.Location = new System.Drawing.Point(13, 94);
            this.passwLab.Name = "passwLab";
            this.passwLab.Size = new System.Drawing.Size(56, 13);
            this.passwLab.TabIndex = 10;
            this.passwLab.Text = "Password:";
            // 
            // passwBox
            // 
            this.passwBox.Location = new System.Drawing.Point(83, 94);
            this.passwBox.Name = "passwBox";
            this.passwBox.Size = new System.Drawing.Size(117, 20);
            this.passwBox.TabIndex = 11;
            // 
            // CreateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.passwBox);
            this.Controls.Add(this.passwLab);
            this.Controls.Add(this.submitBut);
            this.Controls.Add(this.exitBut);
            this.Controls.Add(this.gamerTagBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.gameListBox);
            this.Controls.Add(this.gameLab);
            this.Controls.Add(this.gTagLab);
            this.Controls.Add(this.lastnLab);
            this.Controls.Add(this.firstnLab);
            this.Name = "CreateProfile";
            this.Text = "Create/ Edit Profile";
            this.Load += new System.EventHandler(this.createProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstnLab;
        private System.Windows.Forms.Label lastnLab;
        private System.Windows.Forms.Label gTagLab;
        private System.Windows.Forms.Label gameLab;
        private System.Windows.Forms.CheckedListBox gameListBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox gamerTagBox;
        private System.Windows.Forms.Button exitBut;
        private System.Windows.Forms.Button submitBut;
        private System.Windows.Forms.Label passwLab;
        private System.Windows.Forms.TextBox passwBox;
    }
}