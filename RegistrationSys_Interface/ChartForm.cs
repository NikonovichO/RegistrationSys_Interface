using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Timers;
using System.Threading;
using ScottPlot.Drawing.Colormaps;
using ScottPlot.Plottable;
using System.Data.SqlClient;
using static ScottPlot.Plottable.PopulationPlot;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
namespace RegistrationSys_Interface
{
    public partial class ChartForm : Form
     {
        private int id;
        private string name;
        double[] dataX;
        double[] dataY;
        List<ChartDataClass> chartDataList;
        List<ChartDataClass> gridDataList;
        static DateTime dat1;
        static DateTime dat2;
        static DateTime maxdate;    
        private Crosshair Crosshair;

        public ChartForm(int _id, string _name,DateTime _maxdate)
        {
            InitializeComponent();
            id = _id;
            name = _name;
            maxdate = _maxdate;   
            timer1.Interval = 5000;
            timer1.Tick += new EventHandler(updateChart);
            Crosshair = formsPlot1.Plot.AddCrosshair(0, 0);
            formsPlot1_MouseLeave(null, null);
            formsPlot1.Plot.XAxis.DateTimeFormat(true);
        }
        
        private async void updateChart(Object myObject, EventArgs myEventArgs)
        {
            dat2 = DateTime.Now;
            dat1 = dat2.AddMinutes(-120);
            dateTimePicker1.Value = dat1;
            dateTimePicker2.Value = dat2;
            formsPlot1.Plot.Clear();
            await GetData(id,dat1, dat2);
        }

        private async void ChartForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kGSH_Avtocam_RegistrDataSet.Information". При необходимости она может быть перемещена или удалена.
            dateTimePicker1.Value = maxdate.AddMinutes(-120);
            dateTimePicker2.Value = maxdate;
            chBoxDates.Checked = true;  
            dat1 = dateTimePicker1.Value;
            dat2 = dateTimePicker2.Value;
            await GetData(id, dat1, dat2);
          //  CreateChart(dataX, dataY);
            this.MinimizeBox = false;
            await CreateGridView(id, dat1, dat2);
            //Crosshair = formsPlot1.Plot.AddCrosshair(0, 0);
        }

        private async Task <bool> GetData(int _id, DateTime _dat1, DateTime _dat2 )
        {
            formsPlot1.Plot.Clear();

            try
            {
                chartDataList = new List<ChartDataClass>();
                chartDataList =  await ChartDataClass.GetChartData(_id,_dat1,_dat2);
                if ( chartDataList.Count == 0 )  throw new Exception("Нет данных за выбранный период"); 
                dataX = new double[chartDataList.Count];
                dataY = new double[chartDataList.Count];    
                int i = 0;
                foreach (ChartDataClass data in chartDataList)
                {
                    dataX[i] = data.DataTimeStamp.ToOADate();
                    dataY[i] = data.DataValue;
                    i++;
                }
                await CreateGridView(_id, _dat1, _dat2);
                CreateChart(dataX, dataY);
             
                return true;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//+ ex.HResult.ToString());
                return false;
            }
        }
     
        void CreateChart(double[] dataX, double[] dataY)
        {
      
            formsPlot1.Plot.XLabel("Time[s]");
            formsPlot1.Plot.YLabel("Temperature[°C]");
            formsPlot1.Plot.Title("Temperature  "+ name);
            //LineStyle style = new LineStyle();
            //style = LineStyle.Dot;
            // formsPlot1.Plot.AddSignalXY(dataX,dataY, color: Color.Blue);
            Crosshair = formsPlot1.Plot.AddCrosshair(dataX[0], dataY[0]);
            formsPlot1.Plot.AddScatterPoints(dataX, dataY, Color.Blue, 4);
            formsPlot1.Plot.SetAxisLimitsY(70, 200);

            //   formsPlot1.Plot.AddScatter(dataX, dataY, Color.Blue, 1, 3, MarkerShape.filledCircle, style);

            //  formsPlot1.Plot.AxisAuto();

            formsPlot1.Refresh();   
        }

        async Task CreateGridView(int id, DateTime _dat1, DateTime _dat2)
        {
            gridDataList = new List<ChartDataClass>();

            dataGridView1.RowHeadersVisible = false;
            gridDataList = await ChartDataClass.GetGridData(id, _dat1, _dat2);
            dataGridView1.DataSource = gridDataList;
            dataGridView1.Columns[0].HeaderText = "TimeStamp";
            dataGridView1.Columns[0].DefaultCellStyle.Format = "HH:mm:ss";
            dataGridView1.Columns[1].HeaderText = "Temperature Value[°C]";
            dataGridView1.Columns[1].DefaultCellStyle.Format = "##.##";
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 50;
           
        }

        private async void btnSetPeriod_Click(object sender, EventArgs e)
        {
            Int32 day;
            Int32 month;
            Int32 year;

            if (chBoxDates.Checked)
            {
                dat1 = dateTimePicker1.Value;
                dat2 = dateTimePicker2.Value;
            }
            if (chBoxFixPeriod.Checked && cmbBoxPeriodList.SelectedIndex == 0)
            {
                dat1 = DateTime.Now.AddDays(-1);
                day = dat1.Day;
                month = dat1.Month;
                year = dat1.Year;
                dat1 = new DateTime(year, month, day, 00, 00, 01);
                dat2 = new DateTime(year, month, day, 23, 59, 59); 
            }
            if (chBoxFixPeriod.Checked && cmbBoxPeriodList.SelectedIndex == 1)
            {
                dat1 = dTPickerFixPeriod.Value;
                day = dat1.Day;
                month = dat1.Month;
                year = dat1.Year;
                dat1 = new DateTime(year, month, day, 00, 00, 01);
                dat2 = new DateTime(year, month, day, 23, 59, 59);
            }
            if (chBoxFixPeriod.Checked && cmbBoxPeriodList.SelectedIndex == 2)
            {
                dat1 = DateTime.Now.AddHours(- Convert.ToInt16(numUpDHours.Value));
                dat2 = DateTime.Now;
            }
   
            await GetData(id,dat1, dat2);
           // await CreateGridView(id, dat1, dat2);
            //устанавливать границы значений на осях нужно после добавления/обновления тренда
            formsPlot1.Plot.SetAxisLimitsY(Convert.ToDouble(numUpTempr1.Value), Convert.ToDouble(numUpTempr2.Value));
        }

        private void chBoxUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxUpdate.Checked)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void formsPlot1_MouseEnter(object sender, EventArgs e)
        {
            Crosshair.IsVisible = true;
        }

        private void formsPlot1_MouseMove(object sender, MouseEventArgs e)
        {
            (double coordinateX, double coordinateY) = formsPlot1.GetMouseCoordinates();

            Crosshair.X = coordinateX;
            Crosshair.Y = coordinateY;
            Crosshair.VerticalLine.PositionFormatter = x => DateTime.FromOADate(x).ToString("HH:mm:ss");
            formsPlot1.Refresh(lowQuality: true, skipIfCurrentlyRendering: true);
        }

        private void formsPlot1_MouseLeave(object sender, EventArgs e)
        {
            Crosshair.IsVisible = false;
            formsPlot1.Refresh();
        }

        private void cmbBoxPeriodList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxPeriodList.SelectedIndex == 1)
            {
                dTPickerFixPeriod.Visible = true;
                numUpDHours.Visible = false;
            }

            if (cmbBoxPeriodList.SelectedIndex == 2)
            {
                numUpDHours.Visible = true;
                dTPickerFixPeriod.Visible = false;
            }

            if (cmbBoxPeriodList.SelectedIndex == 0)
            {
                dTPickerFixPeriod.Visible = false;
                numUpDHours.Visible = false;
            }

            if (cmbBoxPeriodList.SelectedIndex == -1)
            {
                dTPickerFixPeriod.Visible = false;
                numUpDHours.Visible = false;
            }

        }

        private void chBoxDates_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxDates.Checked == true) chBoxFixPeriod.Checked = false;
        }

        private void chBoxFixPeriod_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxFixPeriod.Checked == true) chBoxDates.Checked = false;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (!btnPrevios.Enabled) btnPrevios.Enabled = true;
            WorkWithData workWithData = new WorkWithData();
            bool find = true;
            int maxId = workWithData.GetValue("Select MAX(number_device) From tDevices");
            while (find)
            {
                id = id + 1;
                if (id > maxId)//если достигнут конец набора записей
                {
                    btnNext.Enabled = false;
                    find = false;   
                    break;
                }

                // получаем данные для следующего графика

                DataTable idr = workWithData.GetDataTable("Select name_device, iswork From tDevices where number_device = " + id.ToString());

                if (Convert.ToBoolean(idr.Rows[0][1]) == false) continue;//если пресс отключен переходим на следующий
                name = idr.Rows[0][0].ToString();
                //if (idr != null) find = false;
                if (await GetData(id, dat1, dat2) == false)
                   {
                    continue;
                   }
               //  await  CreateGridView(id, dat1, dat2);
                 find = false;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!btnNext.Enabled) btnNext.Enabled = true;
            WorkWithData workWithData = new WorkWithData();
            bool find = true;
            int maxId = workWithData.GetValue("Select MAX(number_device) From tDevices");
            while (find)
            {
                id = id - 1;
                if (id < 1)//если достигнут конец набора записей
                {
                    btnPrevios.Enabled = false;
                    find = false;
                    break;
                }
               

                // получаем данные для следующего графика

                DataTable idr = workWithData.GetDataTable("Select name_device, iswork From tDevices where number_device = " + id.ToString());

                if (Convert.ToBoolean(idr.Rows[0][1]) == false) continue;//если пресс отключен переходим на следующий
                name = idr.Rows[0][0].ToString();
                //if (idr != null) find = false;
                if (await GetData(id, dat1, dat2) == false)
                {
                    continue;
                }
                
                find = false;
              //  await CreateGridView(id, dat1, dat2);
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Excel.Application ex = new Excel.Application
            {
                
                //Количество листов в рабочей книге
                SheetsInNewWorkbook = 2
            };
            //Добавить рабочую книгу
            Excel.Workbook workBook = ex.Workbooks.Add(Type.Missing);
            //Отключить отображение окон с сообщениями
            //app.DisplayAlerts = false;
            //Получаем первый лист документа (счет начинается с 1)
            Excel.Worksheet sheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);
            //Название листа (вкладки снизу)
            sheet.Name = "ChartData";
            for (int i = 0; i < dataX.Length; i++)
            {
                //FromOADate(t_n)
                sheet.Cells[i, 1].Value = DateTime.FromOADate(dataX[i-1]).ToString("HH:mm:ss");
                sheet.Cells[i, 2].Value= string.Format("{0:0.00}", dataY[i-1]);
            }
            ex.Visible = true;

        }
    }
}
