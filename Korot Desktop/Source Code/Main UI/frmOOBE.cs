/*

Copyright © 2020 Eren "Haltroy" Kanat

Use of this source code is governed by MIT License that can be found in github.com/Haltroy/Korot/blob/master/LICENSE

*/

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Korot
{
    public partial class frmOOBE : Form
    {
        private readonly Settings Settings;
        private readonly bool isKorotDead = false;

        public frmOOBE(Settings settings, bool isDead)
        {
            Settings = settings;
            InitializeComponent();
            isKorotDead = isDead;
            foreach (Control x in Controls)
            {
                try { x.Font = new Font("Ubuntu", x.Font.Size, x.Font.Style); } catch { continue; }
            }
        }

        private bool allowSwitch = false;
        public string Yes = "Yes";
        public string No = "No";
        public string OK = "OK";
        public string Cancel = "Cancel";

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        { if (allowSwitch) { allowSwitch = false; e.Cancel = false; } else { e.Cancel = true; } }

        public void RefreshLangList()
        {
            int savedValue = lbLang.SelectedIndex;
            lbLang.Items.Clear();
            foreach (string foundfile in Directory.GetFiles(Application.StartupPath + "//Lang//", "*.klf", SearchOption.TopDirectoryOnly))
            {
                lbLang.Items.Add(Path.GetFileNameWithoutExtension(foundfile));
            }
            try { lbLang.SelectedIndex = savedValue; } catch { }
        }

        private int switchedTimes = 0;

        private void lbLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbLang.SelectedItem != null)
            {
                if (lbLang.SelectedIndex < -1 || lbLang.SelectedIndex > lbLang.Items.Count - 1 || !File.Exists(Application.StartupPath + "//Lang//" + lbLang.SelectedItem.ToString() + ".klf"))
                {
                    btContinue2.Visible = false;
                }
                else
                {
                    switchedTimes++;
                    Settings.LanguageSystem.ReadFromFile(Application.StartupPath + "\\Lang\\" + lbLang.SelectedItem.ToString() + ".klf", true);
                    Text = Settings.LanguageSystem.GetItemText("OOBETitle");
                    btContinue.Text = Settings.LanguageSystem.GetItemText("Close");
                    btContinue2.Text = Settings.LanguageSystem.GetItemText("OOBEContinue");
                    lbWelcome.Text = Settings.LanguageSystem.GetItemText("OOBEWelcome");
                    lbChooseLang.Text = Settings.LanguageSystem.GetItemText("ChooseALanguage");
                    lbCont.Text = Settings.LanguageSystem.GetItemText("OOBEContinueInfo");
                    if (isKorotDead)
                    {
                        lbContinueBack.Text = Settings.LanguageSystem.GetItemText("OOBEKorotDeath").Replace("[NEWLINE]", Environment.NewLine);
                    }
                    else
                    {
                        lbContinueBack.Text = Settings.LanguageSystem.GetItemText("OOBEKorotIsDying").Replace("[NEWLINE]", Environment.NewLine);
                    }
                    Yes = Settings.LanguageSystem.GetItemText("Yes");
                    No = Settings.LanguageSystem.GetItemText("No");
                    OK = Settings.LanguageSystem.GetItemText("OK");
                    Cancel = Settings.LanguageSystem.GetItemText("Cancel");
                    btContinue2.Visible = true;
                }
            }
            else
            {
                btContinue2.Visible = false;
            }
        }

        private void frmOOBE_Load(object sender, EventArgs e)
        {
            RefreshLangList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tmrLang.Stop();
            allowSwitch = true;
            tabControl1.SelectedTab = tabPage2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbLang_DoubleClick(object sender, EventArgs e)
        {
            if (lbLang.SelectedItem != null)
            {
                if (lbLang.SelectedIndex < -1 || lbLang.SelectedIndex > lbLang.Items.Count - 1 || !File.Exists(Application.StartupPath + "//Lang//" + lbLang.SelectedItem.ToString() + ".klf"))
                {
                }
                else
                {
                    lbLang_SelectedIndexChanged(sender, e);
                    button3_Click(sender, e);
                    tmrLang.Stop();
                }
            }
        }

        private void lbLang_Click(object sender, EventArgs e)
        {
            if (lbLang.SelectedItem != null)
            {
                if (lbLang.SelectedIndex < -1 || lbLang.SelectedIndex > lbLang.Items.Count - 1 || !File.Exists(Application.StartupPath + "//Lang//" + lbLang.SelectedItem.ToString() + ".klf"))
                {
                }
                else
                {
                    lbLang_SelectedIndexChanged(sender, e);
                    tmrLang.Stop();
                }
            }
        }

        private void tmrLang_Tick(object sender, EventArgs e)
        {
            if (switchedTimes > 19)
            {
                Random rn = new Random();
                int randomgen = rn.Next(0, lbLang.Items.Count - 1);
                lbLang.SelectedIndex = randomgen;
                return;
            }
            lbLang.SelectedIndex = lbLang.SelectedIndex == lbLang.Items.Count - 1 ? 0 : lbLang.SelectedIndex + 1;
        }
    }
}