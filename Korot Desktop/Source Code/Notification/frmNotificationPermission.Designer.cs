﻿/* 

Copyright © 2020 Eren "Haltroy" Kanat

Use of this source code is governed by MIT License that can be found in github.com/Haltroy/Korot/blob/master/LICENSE 

*/

namespace Korot
{
    partial class frmNotificationPermission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotificationPermission));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new HTAlt.WinForms.HTButton();
            this.button2 = new HTAlt.WinForms.HTButton();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pRight = new System.Windows.Forms.Panel();
            this.pUp = new System.Windows.Forms.Panel();
            this.pLeft = new System.Windows.Forms.Panel();
            this.pDown = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Text = "Block";
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(1, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(387, 26);
            this.button1.TabIndex = 1;
            this.button1.DrawImage = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Text = "Allow";
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.Location = new System.Drawing.Point(1, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(388, 26);
            this.button2.TabIndex = 1;
            this.button2.DrawImage = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.label2.Location = new System.Drawing.Point(361, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pRight
            // 
            this.pRight.BackColor = System.Drawing.Color.Black;
            this.pRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pRight.Location = new System.Drawing.Point(388, 1);
            this.pRight.Name = "pRight";
            this.pRight.Size = new System.Drawing.Size(1, 108);
            this.pRight.TabIndex = 10;
            // 
            // pUp
            // 
            this.pUp.BackColor = System.Drawing.Color.Black;
            this.pUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pUp.Location = new System.Drawing.Point(1, 0);
            this.pUp.Name = "pUp";
            this.pUp.Size = new System.Drawing.Size(388, 1);
            this.pUp.TabIndex = 9;
            // 
            // pLeft
            // 
            this.pLeft.BackColor = System.Drawing.Color.Black;
            this.pLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeft.Location = new System.Drawing.Point(0, 0);
            this.pLeft.Name = "pLeft";
            this.pLeft.Size = new System.Drawing.Size(1, 135);
            this.pLeft.TabIndex = 8;
            // 
            // pDown
            // 
            this.pDown.BackColor = System.Drawing.Color.Black;
            this.pDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pDown.Location = new System.Drawing.Point(0, 135);
            this.pDown.Name = "pDown";
            this.pDown.Size = new System.Drawing.Size(389, 1);
            this.pDown.TabIndex = 7;
            // 
            // frmNotificationPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(389, 136);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pRight);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pUp);
            this.Controls.Add(this.pLeft);
            this.Controls.Add(this.pDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Ubuntu", 8.25F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(389, 136);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(389, 136);
            this.Name = "frmNotificationPermission";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Tag = "deez nuts";
            this.Text = "please no not look at tags";
            this.Deactivate += new System.EventHandler(this.frmNotificationPermission_Leave);
            this.Leave += new System.EventHandler(this.frmNotificationPermission_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private HTAlt.WinForms.HTButton button1;
        private HTAlt.WinForms.HTButton button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pRight;
        private System.Windows.Forms.Panel pUp;
        private System.Windows.Forms.Panel pLeft;
        private System.Windows.Forms.Panel pDown;
    }
}