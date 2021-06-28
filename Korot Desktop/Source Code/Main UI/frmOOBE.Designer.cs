/* 

Copyright © 2020 Eren "Haltroy" Kanat

Use of this source code is governed by MIT License that can be found in github.com/Haltroy/Korot/blob/master/LICENSE 

*/
namespace Korot
{
    partial class frmOOBE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOOBE));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbCont = new System.Windows.Forms.Label();
            this.btContinue2 = new HTAlt.WinForms.HTButton();
            this.lbLang = new System.Windows.Forms.ListBox();
            this.lbChooseLang = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbContinueBack = new System.Windows.Forms.Label();
            this.btContinue = new HTAlt.WinForms.HTButton();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.tmrLang = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-9, -28);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(628, 545);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbCont);
            this.tabPage1.Controls.Add(this.btContinue2);
            this.tabPage1.Controls.Add(this.lbLang);
            this.tabPage1.Controls.Add(this.lbChooseLang);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(620, 519);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbCont
            // 
            this.lbCont.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCont.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lbCont.Location = new System.Drawing.Point(6, 457);
            this.lbCont.Name = "lbCont";
            this.lbCont.Size = new System.Drawing.Size(610, 23);
            this.lbCont.TabIndex = 6;
            this.lbCont.Text = "To continue, please press the \"Continue\" button below.";
            this.lbCont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btContinue2
            // 
            this.btContinue2.AutoColor = true;
            this.btContinue2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btContinue2.ButtonImage = null;
            this.btContinue2.ButtonShape = HTAlt.WinForms.HTButton.ButtonShapes.Rectangle;
            this.btContinue2.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btContinue2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btContinue2.DrawImage = true;
            this.btContinue2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btContinue2.ImageSizeMode = HTAlt.WinForms.HTButton.ButtonImageSizeMode.None;
            this.btContinue2.Location = new System.Drawing.Point(3, 492);
            this.btContinue2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btContinue2.Name = "btContinue2";
            this.btContinue2.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btContinue2.Size = new System.Drawing.Size(614, 23);
            this.btContinue2.TabIndex = 5;
            this.btContinue2.Text = "Continue";
            this.btContinue2.Visible = false;
            this.btContinue2.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbLang
            // 
            this.lbLang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLang.FormattingEnabled = true;
            this.lbLang.Location = new System.Drawing.Point(10, 46);
            this.lbLang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbLang.Name = "lbLang";
            this.lbLang.Size = new System.Drawing.Size(604, 407);
            this.lbLang.TabIndex = 4;
            this.lbLang.Click += new System.EventHandler(this.lbLang_Click);
            this.lbLang.SelectedIndexChanged += new System.EventHandler(this.lbLang_SelectedIndexChanged);
            this.lbLang.DoubleClick += new System.EventHandler(this.lbLang_DoubleClick);
            // 
            // lbChooseLang
            // 
            this.lbChooseLang.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbChooseLang.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbChooseLang.Location = new System.Drawing.Point(3, 4);
            this.lbChooseLang.Name = "lbChooseLang";
            this.lbChooseLang.Size = new System.Drawing.Size(614, 43);
            this.lbChooseLang.TabIndex = 3;
            this.lbChooseLang.Text = "Choose a language.";
            this.lbChooseLang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbContinueBack);
            this.tabPage2.Controls.Add(this.btContinue);
            this.tabPage2.Controls.Add(this.lbWelcome);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(620, 519);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbContinueBack
            // 
            this.lbContinueBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbContinueBack.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lbContinueBack.Location = new System.Drawing.Point(7, 214);
            this.lbContinueBack.Name = "lbContinueBack";
            this.lbContinueBack.Size = new System.Drawing.Size(610, 106);
            this.lbContinueBack.TabIndex = 19;
            this.lbContinueBack.Text = "This project is now retired. This means Korot will no longer supported after 15 A" +
    "ugust 2021.\r\nPlease switch to Yorot or any Yorot flavor instead.";
            this.lbContinueBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btContinue
            // 
            this.btContinue.AutoColor = true;
            this.btContinue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btContinue.ButtonImage = null;
            this.btContinue.ButtonShape = HTAlt.WinForms.HTButton.ButtonShapes.Rectangle;
            this.btContinue.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btContinue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btContinue.DrawImage = true;
            this.btContinue.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btContinue.ImageSizeMode = HTAlt.WinForms.HTButton.ButtonImageSizeMode.None;
            this.btContinue.Location = new System.Drawing.Point(3, 492);
            this.btContinue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btContinue.Name = "btContinue";
            this.btContinue.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btContinue.Size = new System.Drawing.Size(614, 23);
            this.btContinue.TabIndex = 17;
            this.btContinue.Text = "Close";
            this.btContinue.Visible = false;
            this.btContinue.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbWelcome
            // 
            this.lbWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbWelcome.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbWelcome.Location = new System.Drawing.Point(3, 4);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(614, 63);
            this.lbWelcome.TabIndex = 7;
            this.lbWelcome.Text = "Important Advice";
            this.lbWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrLang
            // 
            this.tmrLang.Enabled = true;
            this.tmrLang.Interval = 10000;
            this.tmrLang.Tick += new System.EventHandler(this.tmrLang_Tick);
            // 
            // frmOOBE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 511);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmOOBE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Korot #SwitchToYorot";
            this.Load += new System.EventHandler(this.frmOOBE_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private HTAlt.WinForms.HTButton btContinue2;
        private System.Windows.Forms.Label lbChooseLang;
        private HTAlt.WinForms.HTButton btContinue;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Label lbCont;
        private System.Windows.Forms.Label lbContinueBack;
        private System.Windows.Forms.ListBox lbLang;
        private System.Windows.Forms.Timer tmrLang;
    }
}