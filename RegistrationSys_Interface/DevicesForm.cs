using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationSys_Interface
{
    public partial class DevicesForm : Form
    {
        private DataTable dt;
        private int curr_device; //текущее устройство
        public DevicesForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(0);
            editForm.ShowDialog();
        }

        
        private void DevicesForm_Load(object sender, EventArgs e)
        {
            load_data();

            dataGridView1.Columns[0].DataPropertyName = "number_device";
            dataGridView1.Columns[0].HeaderText = "Номер устройства";
            dataGridView1.Columns[0].Width = 70;


            dataGridView1.Columns[1].DataPropertyName = "name_device";
            dataGridView1.Columns[1].HeaderText = "Наименование";
            dataGridView1.Columns[1].Width = 200;

            dataGridView1.Columns[2].DataPropertyName = "IsWork";
            dataGridView1.Columns[2].HeaderText = "Включен";
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[2].Width = 60;
        }

        private void load_data()
        {
            WorkWithData workWithData = new WorkWithData();
            dt = workWithData.GetDataTable ("Select number_device, name_device, IsWork  FROM tDevices");
            dataGridView1.DataSource = dt;
            //foreach (DataGridViewRow row in dataGridView1.Rows
            //{
            //    if (Convert.ToBoolean(row.Cells[4].Value) == false)
            //        row.DefaultCellStyle.BackColor = Color.LightGray;
            //}
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           // try
           // {
                curr_device = Convert.ToInt16(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
                //string str = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                EditForm editForm = new EditForm(1, Convert.ToInt16(dataGridView1[0, dataGridView1.CurrentRow.Index].Value), dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString(), Convert.ToBoolean(dataGridView1[2, dataGridView1.CurrentRow.Index].Value));
                editForm.ShowDialog();
          //  }
           // catch
           // {
            //    MessageBox.Show("Выберите устройство для редактирования");
           // }
        }

        private void DevicesForm_Activated(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
