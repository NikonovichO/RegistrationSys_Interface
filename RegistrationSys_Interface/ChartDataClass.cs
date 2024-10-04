using ScottPlot;
using ScottPlot.Drawing.Colormaps;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RegistrationSys_Interface
{
    internal class ChartDataClass
    {
        public  DateTime DataTimeStamp { get; set;}
        public double DataValue { get; set; }
        public static DateTime Dat1 { get; set;}
        public static DateTime Dat2 { get; set;}

        public ChartDataClass()
        {
           // Dat1 = _dat1;
            //Dat2 = _dat2;
        }

        public static async Task<List<ChartDataClass>> GetChartData(int id, DateTime _dat1, DateTime _dat2)
        {
           
                WorkWithData workWithData = new WorkWithData();
                List<ChartDataClass> chartDataList = new List<ChartDataClass>();
                Dat1 = _dat1;
                Dat2 = _dat2;
                string selectSQL = $"SELECT currtime, value FROM tInformation Where number_device={id} and (currtime between '{Dat1}' and '{Dat2}') and (value != 0)";

                SqlDataReader dr = await workWithData.GetDataReader(selectSQL);
               // if (dr.HasRows)
                //{
                    while (dr.Read())
                    {
                        ChartDataClass chartData = new ChartDataClass();
                        chartData.DataTimeStamp = Convert.ToDateTime(dr["currtime"]);
                        chartData.DataValue = Convert.ToDouble(dr["value"]);
                        chartDataList.Add(chartData);
                    }
                    dr.Close(); return chartDataList;
               // }
                //else
                //{
                //    MessageBox.Show("Нет данных для построения графика", "Ошибка вывода данных", MessageBoxButtons.OK);
                //    return null;
                //}
        }

        public static async Task<List<ChartDataClass>> GetGridData(int id, DateTime _dat1, DateTime _dat2)
        {
            WorkWithData workWithData = new WorkWithData();
            List<ChartDataClass> greedDataList = new List<ChartDataClass>();
            Dat1 = _dat1;
            Dat2 = _dat2;

            string selectSQL = $"SELECT currtime, value FROM tInformation Where number_device={id} and (currtime between '{Dat1}' and '{Dat2}') and (value != 0) Order by currtime DESC";
            SqlDataReader dr = await workWithData.GetDataReader(selectSQL);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ChartDataClass chartData = new ChartDataClass();
                    chartData.DataTimeStamp = Convert.ToDateTime(dr["currtime"]);
                    chartData.DataValue = Convert.ToDouble(dr["value"]);
                    greedDataList.Add(chartData);
                }
            }
            else
            {
                MessageBox.Show("Нет данных для построения графика", "Ошибка графика", MessageBoxButtons.OK);
                return null;
            }
            dr.Close(); return greedDataList;

        }



    }
}
    


