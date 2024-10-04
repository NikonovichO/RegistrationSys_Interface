using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationSys_Interface
{
    public partial class IPComForm : Form
    {
        private bool regEdit; //1-новая запись, 0-редактировать
        private int ncom;
        public string selectedIP;
        private Form formOwner;
        public IPComForm(Form FormOwner)
        {
            InitializeComponent();
            formOwner = FormOwner;
        }

        private void IPComForm_Activated(object sender, EventArgs e)
        {
           

        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            panelAddEdit.Visible = true;
            regEdit=true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelAddEdit.Visible = false;   

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ip = ipAdressControl1.StrigIP;
            int com = (int)numericUpDown1.Value;
            string commandText="";
            switch (regEdit)
            {
               //новая запись
                case true: commandText = "Insert INTO tCOMPorts (id_com,ip_adress,IsWork) values (@_pr1,@_pr2,@_pr3)"; break;
                 
                case false: commandText = $"Update tCOMPorts Set id_com = @_pr1,ip_adress = @_pr2, IsWork = @_pr3) where id_com = {ncom}"; break;
            }
            //WorkWithData.ExecuteAddUpdateCOMPorts(commandText,com,ip,chBWork.Checked);
            refreshGridView();
            panelAddEdit.Visible = false;  
            
            // WorkWithData.ExecuteAddUpdateCommand(comText, );
        }

       private void button1_Click(object sender, EventArgs e)
        {
            regEdit = false;
            ncom = Convert.ToInt16(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
            numericUpDown1.Value = ncom;
            string ip = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString().Replace(".","");
           // ipAdressControl1.StrigIP = ip;
            ipAdressControl1.textChange(ip);
            panelAddEdit.Visible = true;
        }

        private void refreshGridView()
        {
            DataTable dt = new DataTable();
            //dt = WorkWithData.GetDataTable("Select * From tCOMPorts");
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].DataPropertyName = "id_com";
            dataGridView1.Columns[0].HeaderText = "Com-порт";
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].DataPropertyName = "ip_adress";
            dataGridView1.Columns[1].HeaderText = "IP";
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].DataPropertyName = "IsWork";
            dataGridView1.Columns[2].HeaderText = " ";
            dataGridView1.Columns[2].Width = 10;
            dataGridView1.Columns[2].Visible = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[2].Value) == false)
                    row.DefaultCellStyle.BackColor = Color.LightGray;
            }
        }

        private void IPComForm_Load(object sender, EventArgs e)
        {
            refreshGridView();
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
               if (formOwner is MainForm)
                {
                    ((MainForm)formOwner).valueFilter = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                    Close();
                }
                if (formOwner is EditForm)
                {
                   // ((EditForm)formOwner).ipAdressControl1.textChange(dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString());
                    //((EditForm)formOwner).idCom = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
                    //((EditForm)formOwner).lbCom.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString().Trim();
                    Close();
                }
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) e.Handled = true;
        }
    }
    }

