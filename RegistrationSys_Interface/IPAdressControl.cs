using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationSys_Interface
{
    public partial class IPAdressControl : UserControl
    {
        public string StrigIP { get; set; }
        public IPAdressControl()
        {
            InitializeComponent();
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            StrigIP = maskedTextBox1.Text;
        }
        public void textChange(string ip)
        {
            maskedTextBox1.Text = ip;
        }
    }
}
