using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kavarera_Anti_Virus
{
    public partial class UserControl1 : UserControl
    {
        int safecount;
        UserControl1 uc1 = new UserControl1();
        public UserControl1()
        {
            InitializeComponent();
            
        }
        string[] symbols = { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "-", "+", "=", ":", ";", ",", "<", ".", ">", "?", "/" };
        private void Passwdtb_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void Passwdtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            uc1.Hide();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            pwdstatuslbl.Text = "";
        }

        private void Passwdtb_KeyDown(object sender, KeyEventArgs e)
        {
            {
                safecount++;

                if (passwdtb.Text.Contains("!"))
                {
                    safecount = safecount + 3;
                }
                if (passwdtb.Text.Contains("@"))
                {
                    safecount = safecount + 3;
                }
                if (passwdtb.Text.Contains("#"))
                {
                    safecount = safecount + 3;
                }
                if (passwdtb.Text.Contains("$"))
                {
                    safecount = safecount + 3;
                }
                if (passwdtb.Text.Contains("%"))
                {
                    safecount = safecount + 3;
                }
                if (passwdtb.Text.Contains("^"))
                {
                    safecount = safecount + 3;
                }
                if (passwdtb.Text.Contains("&"))
                {
                    safecount = safecount + 3;
                }
                if (passwdtb.Text.Contains("*"))
                {
                    safecount = safecount + 3;
                }
                if (passwdtb.Text.Contains("-"))
                {
                    safecount = safecount + 3;
                }
                if (passwdtb.Text.Contains("."))
                {
                    safecount = safecount + 3;
                }
                if (passwdtb.Text.Contains("_"))
                {
                    safecount = safecount + 3;
                }

                //======================================================
                if (passwdtb.Text == "")
                {
                    passwdtb.Clear();
                    safecount = 0;
                }
                
                if (e.KeyCode == Keys.Decimal)
                {
                    safecount = safecount + 2;
                }


                if (e.KeyCode == Keys.Back)
                {
                    if (safecount == 0)
                    {

                    }
                    else
                        safecount--;
                }

                if (safecount > 20)
                {
                    pwdstatuslbl.Text = "GOOD";
                    pwdstatuslbl.ForeColor = Color.Green;
                }
                if (safecount < 12)
                {
                    pwdstatuslbl.Text = "Not Bad";
                    pwdstatuslbl.ForeColor = Color.Yellow;
                }
                if (safecount < 8)
                {
                    pwdstatuslbl.Text = "BAD";
                    pwdstatuslbl.ForeColor = Color.Red;
                }

            }
        }

        private void Passwdtb_KeyUp(object sender, KeyEventArgs e)
        {
            if (safecount > 20)
            {
                pwdstatuslbl.Text = "GOOD";
                pwdstatuslbl.ForeColor = Color.Green;
            }
            if (safecount < 12)
            {
                pwdstatuslbl.Text = "Not Bad";
                pwdstatuslbl.ForeColor = Color.Yellow;
            }
            if (safecount < 8)
            {
                pwdstatuslbl.Text = "BAD";
                pwdstatuslbl.ForeColor = Color.Red;
            }
        }
    }
}
