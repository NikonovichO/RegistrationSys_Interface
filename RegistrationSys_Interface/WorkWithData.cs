using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.Windows.Input;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace RegistrationSys_Interface
{
      public class WorkWithData
    {
        private  SqlConnection connection {get;} = new SqlConnection(Properties.Settings.Default.KGSH_Avtocam_RegistrConnectionString);
        private  SqlConnection connection1 {get;} = new SqlConnection(Properties.Settings.Default.KGSH_Avtocam_RegistrConnectionString);
        public  DataTable GetDataTable(string _cmdText)
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (SqlCommand command = new SqlCommand(_cmdText, connection))
                {
                    if (connection.State == 0) connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка выборки данных!  " + ex.Message);
                return null;
            }

        }
        public static DataTable GetDataTable_1(string _cmdText)
        {
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.KGSH_Avtocam_RegistrConnectionString);
                DataTable dataTable = new DataTable();
                using (SqlCommand command = new SqlCommand(_cmdText, connection))
                {
                    if (connection.State == 0) connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка выборки данных!  "+ ex.Message);
                return null;
            }
        }

        /// <summary>
        /// добавление нового/редактирования устройств (таблица Devices)
        /// </summary>
        /// <param name="_cmdText"></param sql command>
        /// <param name="_pr1"></param NCom>
        /// <param name="_pr2"></param modbus_adress>
        /// <param name="_pr3"></param name device for user>
        /// <param name="_pr4"></param IsWork>
        public  void ExecuteAddUpdateDevices(string _cmdText,  int _pr1, string _pr2, bool _pr3)
        {
            using (SqlCommand command = new SqlCommand(_cmdText, connection))
            {
                if (connection.State == 0) connection.Open();
 
                command.Parameters.AddWithValue("_pr1", _pr1); //номер вулканизатора 
                command.Parameters.AddWithValue("_pr2", _pr2); //имя пресса для пользователя
                command.Parameters.AddWithValue("_pr3", _pr3); //пресс включено/выключено
                //if (_pr4 != null)  command.Parameters.AddWithValue("_pr4", _pr4);
                command.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// добавление/редактирование com
        /// </summary>
        /// <param name="_cmdText"></param sql command>
        /// <param name="_pr1"></param NCom>
        /// <param name="_pr2"></param ip_adress>
        /// <param name="_pr3"></param IsWork>
        public  void ExecuteAddUpdateCOMPorts(string _cmdText, int _pr1, string _pr2, bool _pr3)
        {
            using (SqlCommand command = new SqlCommand(_cmdText, connection))
            {
                if (connection.State == 0) connection.Open();
                
                command.Parameters.AddWithValue("_pr1", _pr1);// 
                command.Parameters.AddWithValue("_pr2", _pr2);
                command.Parameters.AddWithValue("_pr3", _pr3);
                command.ExecuteNonQuery();
            }
        }
        public void ExecuteDeleteCommand(string _cmdText, int pAdr)
        {
            using (SqlCommand command = new SqlCommand(_cmdText, connection))
            {
                if (connection.State == 0) connection.Open();
                command.Parameters.AddWithValue("adr", pAdr);
                command.ExecuteNonQuery();
            }
        }
        public  async Task<SqlDataReader> GetDataReader(string _cmdText)
        {
            try
            {
                if (connection1.State == 0) connection1.Open();
                SqlCommand read_command = new SqlCommand(_cmdText, connection1);
                SqlDataReader dataReader = await read_command.ExecuteReaderAsync();
                return dataReader;
            }
            catch (Exception)
            {
                MessageBox.Show(" Нет данных для построения графика", "Ошибка графика", MessageBoxButtons.OK);
                return null;
            }
        }

        public int GetValue(string _cmdText)
        {
            int res=1;
            try
            {
                if (connection1.State == 0) connection1.Open();
                SqlCommand read_command = new SqlCommand(_cmdText, connection1);
                res = (Int32)read_command.ExecuteScalar();
                return res;
            }
            catch (Exception)
            {
                MessageBox.Show(" Нет данных для построения графика", "Ошибка графика", MessageBoxButtons.OK);
                return 0;
            }
        }
    }
}
