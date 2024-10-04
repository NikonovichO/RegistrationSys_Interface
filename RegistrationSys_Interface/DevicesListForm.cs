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
    public partial class DevicesListForm : Form
    {
        public DevicesListForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kGSH_Avtocam_RegistrDataSet.Devices". При необходимости она может быть перемещена или удалена.
            this.devicesTableAdapter.Fill(this.kGSH_Avtocam_RegistrDataSet.Devices);

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(0);
            editForm.ShowDialog();
        }
    }
}
