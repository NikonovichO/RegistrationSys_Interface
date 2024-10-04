using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace RegistrationSys_Interface
{
    delegate void SetFilter (string filter);
    public partial class MainForm : Form
    {
        public string textlabel;
        public bool regEdit { get; set; }
        public string valueFilter { get; set; }
        private DataTable dt = new DataTable();
        //event SetFilter FilterChanged;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            WorkWithData workWithData = new WorkWithData();
            dataGridView1.DataSource = workWithData.GetDataTable("Select vlast_temperature.number_device as number_device, name_device, value, currtime From vlast_temperature INNER JOIN tDevices ON vlast_temperature.number_device = tDevices. number_device Where iswork = 1 Order by name_device");
           // dataGridView1.DataSource = workWithData.GetDataTable("WITH vLast_temperature AS  (SELECT number_device, value, currtime, ROW_NUMBER() OVER (PARTITION BY number_device ORDER BY currtime DESC) AS NRec FROM tInformation) SELECT d.number_device, d.name_device, lt.value, lt.currtime, d.IsWork FROM tDevices d INNER JOIN vLast_temperature lt ON d.number_device = lt.number_device WHERE lt.NRec = 1");
            timer1.Start();
            if (Environment.UserName == "nikonovichoa")
            {
                  btnEdit.Visible = true;
            }
           load_data();
        }

        //заполняем DataGridView данными
        private void load_data() 
        {
            try
            {

                Task.Factory.StartNew(() =>
               {
                   dt = WorkWithData.GetDataTable_1("Select vlast_temperature.number_device as number_device, name_device, value, currtime From vlast_temperature INNER JOIN tDevices ON vlast_temperature.number_device = tDevices. number_device Where iswork = 1 Order by name_device");
                   if (dt != null)
                   {
                       // dt =  WorkWithData.GetDataTable_1("WITH vLast_temperature AS (SELECT number_device, value, currtime, ROW_NUMBER() OVER (PARTITION BY number_device ORDER BY currtime DESC) AS NRec FROM tInformation) SELECT d.number_device, d.name_device, lt.value, lt.currtime, d.IsWork FROM tDevices d INNER JOIN vLast_temperature lt ON d.number_device = lt.number_device WHERE lt.NRec = 1");
                       int colNumDevice = dt.Columns["number_device"].Ordinal;
                       int colNameDevice = dt.Columns["name_device"].Ordinal;
                       int colCurrentTime = dt.Columns["currtime"].Ordinal;
                       int colValue = dt.Columns["value"].Ordinal;

                       foreach (DataRow row in dt.Rows)
                       {
                           IEnumerable<DataGridViewRow> rows = dataGridView1.Rows.Cast<DataGridViewRow>().Where(x => x.Cells["number_device"].Value.ToString() == row.ItemArray[colNumDevice].ToString());
                           if (rows.Count() > 0)
                           {
                               int rowIndex = rows.First().Index;
                               //     dataGridView1.Rows[rowIndex].Cells["name_device"].Value = row.ItemArray[colNameDevice].ToString();
                               dataGridView1.Rows[rowIndex].Cells["value"].Value = row.ItemArray[colValue];
                               dataGridView1.Rows[rowIndex].Cells["currtime"].Value = row.ItemArray[colCurrentTime];
                               TimeSpan rez = DateTime.Now - Convert.ToDateTime(dataGridView1.Rows[rowIndex].Cells["currtime"].Value.ToString());
                               //если данных нет в течение 5 минут, строка пресса окрашивается в серый цвет
                               if (rez.TotalMinutes > 9)
                               {
                                   dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightGray;
                               }
                               //если данные поступают, но раннее строка была окрашена в серый цвет, ей возвращается светлый
                               else if ((rez.TotalMinutes < 9) & (dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor == Color.LightGray))
                               {
                                   dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
                               }
                           }
                       }

                   }
               });
            }
            catch
            {
                load_data();
            }
                

 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DevicesForm DevicesForm = new DevicesForm();
            DevicesForm.ShowDialog();  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            load_data();
        }
          

        private void btnEdit_Click (object sender, EventArgs e)
        {
            new DevicesForm().ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            WorkWithData workWithData = new WorkWithData();
            int id = Convert.ToInt16(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
            if (MessageBox.Show( $"Удалить из базы данных ТРМ с адресом {id}?", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
                workWithData.ExecuteDeleteCommand($"Delete From Devices Where modbus_adress = {id}", id);
            else return;
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            //int id = Convert.ToInt16(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
            //string name = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            //ChartForm chartForm = new ChartForm(id,name);
            //timer1.Stop();  
            //chartForm.Show(); 
        }

        private void btnDel_Click_1(object sender, EventArgs e)
        {
            //new IPComForm(this).ShowDialog();
            new PasswordForm().ShowDialog();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            //timer1.Start();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChart_Click_1(object sender, EventArgs e)
        {
            int num_dev = Convert.ToInt16(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
            string name = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            DateTime maxdate = Convert.ToDateTime(dataGridView1[3, dataGridView1.CurrentRow.Index].Value);
            ChartForm chartForm = new ChartForm(num_dev, name, maxdate);
           // timer1.Stop();
            chartForm.Show();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {

        }
    }
}
