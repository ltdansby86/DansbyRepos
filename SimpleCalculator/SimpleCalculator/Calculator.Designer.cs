﻿namespace SimpleCalculator
{
    partial class Calculator
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
            this.displyScreen = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.clearBut = new System.Windows.Forms.Button();
            this.equalsBut = new System.Windows.Forms.Button();
            this.addBut = new System.Windows.Forms.Button();
            this.subBut = new System.Windows.Forms.Button();
            this.multBut = new System.Windows.Forms.Button();
            this.devBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displyScreen
            // 
            this.displyScreen.Location = new System.Drawing.Point(12, 12);
            this.displyScreen.Name = "displyScreen";
            this.displyScreen.Size = new System.Drawing.Size(189, 20);
            this.displyScreen.TabIndex = 0;
            this.displyScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(73, 38);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(14, 68);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(44, 68);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(23, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(73, 68);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(23, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(14, 97);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(23, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(42, 97);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(23, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(71, 97);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(23, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(42, 127);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(23, 23);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button10_Click);
            // 
            // clearBut
            // 
            this.clearBut.Location = new System.Drawing.Point(14, 126);
            this.clearBut.Name = "clearBut";
            this.clearBut.Size = new System.Drawing.Size(23, 23);
            this.clearBut.TabIndex = 11;
            this.clearBut.Text = "C";
            this.clearBut.UseVisualStyleBackColor = true;
            this.clearBut.Click += new System.EventHandler(this.clearBut_Click);
            // 
            // equalsBut
            // 
            this.equalsBut.Location = new System.Drawing.Point(71, 127);
            this.equalsBut.Name = "equalsBut";
            this.equalsBut.Size = new System.Drawing.Size(23, 23);
            this.equalsBut.TabIndex = 12;
            this.equalsBut.Text = "=";
            this.equalsBut.UseVisualStyleBackColor = true;
            this.equalsBut.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // addBut
            // 
            this.addBut.Location = new System.Drawing.Point(103, 39);
            this.addBut.Name = "addBut";
            this.addBut.Size = new System.Drawing.Size(23, 23);
            this.addBut.TabIndex = 13;
            this.addBut.Text = "+";
            this.addBut.UseVisualStyleBackColor = true;
            this.addBut.Click += new System.EventHandler(this.addBut_Click);
            // 
            // subBut
            // 
            this.subBut.Location = new System.Drawing.Point(103, 67);
            this.subBut.Name = "subBut";
            this.subBut.Size = new System.Drawing.Size(23, 23);
            this.subBut.TabIndex = 14;
            this.subBut.Text = "-";
            this.subBut.UseVisualStyleBackColor = true;
            this.subBut.Click += new System.EventHandler(this.subBut_Click);
            // 
            // multBut
            // 
            this.multBut.Location = new System.Drawing.Point(103, 97);
            this.multBut.Name = "multBut";
            this.multBut.Size = new System.Drawing.Size(23, 23);
            this.multBut.TabIndex = 15;
            this.multBut.Text = "x";
            this.multBut.UseVisualStyleBackColor = true;
            this.multBut.Click += new System.EventHandler(this.button10_Click_2);
            // 
            // devBut
            // 
            this.devBut.Location = new System.Drawing.Point(103, 127);
            this.devBut.Name = "devBut";
            this.devBut.Size = new System.Drawing.Size(23, 23);
            this.devBut.TabIndex = 16;
            this.devBut.Text = "/";
            this.devBut.UseVisualStyleBackColor = true;
            this.devBut.Click += new System.EventHandler(this.devBut_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 261);
            this.Controls.Add(this.devBut);
            this.Controls.Add(this.multBut);
            this.Controls.Add(this.subBut);
            this.Controls.Add(this.addBut);
            this.Controls.Add(this.equalsBut);
            this.Controls.Add(this.clearBut);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.displyScreen);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displyScreen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button clearBut;
        private System.Windows.Forms.Button equalsBut;
        private System.Windows.Forms.Button addBut;
        private System.Windows.Forms.Button subBut;
        private System.Windows.Forms.Button multBut;
        private System.Windows.Forms.Button devBut;
    }
}

