using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Math;

namespace RegistrationSys_Interface // форма редактирования устройства
{
    public partial class EditForm : Form
    {
        private int regEdit; //0- insert, 1-update.
       // public int idDevice; // id ;
        private int numDevice; //номер устройства, вулканизатора
        private string nameDevice; //название (полное наименование вулканизационного пресса)
        private bool isWork; //в работе или отключен
        public EditForm(int reg)
        {
            InitializeComponent();
            regEdit = reg;    
        }

        public EditForm(int _reg, int _num, string _name, Boolean _iswork) //конструктор для редактирования
        {
            InitializeComponent();
            regEdit = _reg; //режим использования формы : 0-добавляем новое, 1- редактируем существующее;
            numDevice = _num; 
            nameDevice = _name; 
            isWork = _iswork;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //добавление нового устройства
            WorkWithData workWithData = new WorkWithData();
            if (regEdit == 0) 
            {
                try
                {
                    int adr = Convert.ToInt16(numUpDnumber.Value);
                    numDevice = (int)numUpDnumber.Value;
                    nameDevice = tbName.Text;
                    isWork = chBWork.Checked;
                    string command_text = "Insert INTO tDevices (number_device,name_device, IsWork) values(@_pr1,@_pr2,@_pr3) ";
                    workWithData.ExecuteAddUpdateDevices(command_text, numDevice, nameDevice, isWork);
                    this.Close();
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    if (ex.Number == 2601)
                        MessageBox.Show("В БД уже есть устройство с таким номером", "Ошибка", MessageBoxButtons.OK);
                    else MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
                }
            }
            //
            if (regEdit == 1)
            {
                try
                {
                    numDevice = Convert.ToInt16(numUpDnumber.Value);
                    nameDevice = tbName.Text.Trim();
                    isWork = chBWork.Checked;
                    string command_text = "Update tDevices set  name_device=@_pr2, IsWork=@_pr3 Where number_device=@_pr1 ";
                    workWithData.ExecuteAddUpdateDevices(command_text,  numDevice, nameDevice, isWork);
                    this.Close();
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    //if (ex.Number == 2627)
                    //    MessageBox.Show("В БД уже есть устройство с таким адресом", "Ошибка", MessageBoxButtons.OK);
                    //else MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chBWork.Checked) chBWork.Text = "Работает";
            else chBWork.Text = "Отключен";
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
           
            numUpDnumber.Value = numDevice;
            tbName.Text = nameDevice;
            chBWork.Checked = isWork;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             new IPComForm(this).ShowDialog(); 
        }
    }
}