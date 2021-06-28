/*

Copyright © 2020 Eren "Haltroy" Kanat

Use of this source code is governed by MIT License that can be found in github.com/Haltroy/Korot/blob/master/LICENSE

*/

using System;
using System.Windows.Forms;

namespace Korot
{
    public partial class frmMakeExt : Form
    {
        public frmMakeExt()
        {
            InitializeComponent();
        }

        private void anything_MouseEnter(object sender, EventArgs e)
        {
            Control cntrl = sender as Control;
            if (cntrl != null)
            {
                if (cntrl.Tag != null)
                {
                    textBox4.Text = cntrl.Tag.ToString();
                    return;
                }
                else
                {
                    textBox4.Text = textBox4.Tag.ToString();
                    return;
                }
            }
            else
            {
                textBox4.Text = textBox4.Tag.ToString();
                return;
            }
        }

        private void anything_MouseLeave(object sender, EventArgs e)
        {
            textBox4.Text = textBox4.Tag.ToString();
        }
    }
}