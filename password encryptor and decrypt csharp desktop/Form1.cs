using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_encryptor_and_decrypt_csharp_desktop
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        clssecurity security = new clssecurity();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         try
            {
                if (button1.Text == "encrypt")
                {
                    txt2.Text = security.psEncrypt(txt1.Text);
                    txt1.Clear();
                    button1.Text = "decrypt";
                }
                else if (button1.Text == "decrypt")
                {
                    txt1.Text = security.psDescrypt(txt2.Text);
                    txt2.Clear();
                    button1.Text = "encrypt";
                }
            }
            catch (Exception)
            {

            }

          
        }
    }
}
