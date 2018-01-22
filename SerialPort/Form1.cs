using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace 袁朝阳
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Initial();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           //comboBoxCOM.DataSource = System.IO.Ports.SerialPort.GetPortNames();
            
            try
            {
                if (!serialPort1.IsOpen)
                    serialPort1.Open();
                if (serialPort1.IsOpen == true)
                {
                    if (serialPort1.BytesToRead != 0)
                    {
                        serialPort1.Encoding = Encoding.ASCII;
                        data = serialPort1.ReadExisting();//读取串口数据

                        if (checkBoxHex.Checked)
                            HexShow();
                        else
                            richTextBoxRecieve.AppendText(data);

                        switch (flag)
                        {
                            case 2:
                                TemperatureBipolar();
                                break;
                            case 1:
                                TemperatureUnipolar();
                                break;

                        }

                    }
                }
            }

            catch (Exception)
            {
                //MessageBox.Show("Port Access is failure，Reset The Serial Basic Information", "Prompting");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = SeriesChartType.Point;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.Series[0].MarkerStyle = MarkerStyle.Cross;
            chart1.Series[0].MarkerSize = 3;
            chart1.Series[0].MarkerColor = Color.Black;
            chart1.Series[0].LegendText = "Temperature";
            //chart1.ChartAreas[0].AxisY.Interval = 0.5;
        }

        #region interation

        private void 保存图像ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "|*.jpeg|*.png|*.bmp|*.tiff|*.emf|*.emfDual|*.emfplus";
            saveFile.RestoreDirectory = true;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = saveFile.FileName.ToString(); //获得文件路径 

                chart1.SaveImage(localFilePath, ChartImageFormat.Jpeg);
            }
        }
        private void 保存数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "|*.txt";
            saveFile.RestoreDirectory = true;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = saveFile.FileName.ToString(); //获得文件路径 
                StreamWriter writer = new StreamWriter(localFilePath, true, Encoding.UTF8);
                writer.Write(textBoxADC.Text);
                writer.Dispose();
            }
        }

        #region serialPort params set
        private void comboBoxCOM_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                serialPort1.PortName = comboBoxCOM.SelectedItem.ToString();
                serialPort1.Open();
            }
            catch { }
        }

        private void comboBoxBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.BaudRate = Int32.Parse(comboBoxBaudRate.SelectedItem.ToString());
        }

        private void comboBoxParity_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxParity.SelectedIndex)
            {
                case 0:
                    serialPort1.Parity = Parity.None; break;
                case 1:
                    serialPort1.Parity = Parity.Odd; break;
                case 2:
                    serialPort1.Parity = Parity.Even; break;
                case 3:
                    serialPort1.Parity = Parity.Mark; break;
                case 4:
                    serialPort1.Parity = Parity.Space; break;
            }
        }

        private void comboBoxDataBit_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.DataBits = Int32.Parse(comboBoxDataBit.SelectedItem.ToString());
        }

        private void comboBoxStopBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxStopBits.SelectedIndex)
                {
                    case 0:
                        serialPort1.StopBits = StopBits.None; break;
                    case 1:
                        serialPort1.StopBits = StopBits.One; break;
                    case 2:
                        serialPort1.StopBits = StopBits.Two; break;
                    case 3:
                        serialPort1.StopBits = StopBits.OnePointFive; break;
                }
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("       Sorry,不支持1.5为停止位，请更改代码       " +
                    "", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        private void pictureBoxFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "hex文件|*.hex|文本文件|*.txt|其他|*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = fileDialog.FileName;
                textBoxSend.Text = File.ReadAllText(path);
            }
        }
        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            richTextBoxRecieve.Text = "";
            textBoxSend.Text = "";
        }
        private void buttonRestart_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            Application.Restart();
        }
        private void button_send1_Click(object sender, EventArgs e)
        {
            //Thread thread1 = new Thread(() => Send(1.ToString()));
            Send(1.ToString());


        }
        private void button1_Send_Click(object sender, EventArgs e)
        {
            //Thread thread1 = new Thread(() => Send(textBoxSend.Text));
            Send(textBoxSend.Text.ToString());

        }
        private void button_send2_Click(object sender, EventArgs e)
        {
            //Thread thread1 = new Thread(() => Send(2.ToString()));
            Send(2.ToString());

        }
        private void button_closeOrOpenSerial_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    button_closeOrOpenSerial.Text = "打开\r\n\r\n串口";
                }
                else
                {
                    timer1.Enabled = true;
                    serialPort1.Open();
                    button_closeOrOpenSerial.Text = "关闭\r\n\r\n串口";
                }
            }

            catch (Exception)
            {
                //MessageBox.Show("                   请打开串口，或检查单片机连接！                   " +
                //    "", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void textBoxSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (checkBoxSingleSend.Checked)
                Send(((char)e.KeyValue).ToString());
        }

        #region menuStrip

        private void 反馈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请发送建议至yuanzhaoyang658@outlook.com!", "建议", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void 内部温度_Unipolar_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = 1;       //内部温度，单极性
            this.Width = 1173;
        }
        private void 内部温度_Bipolar_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            flag = 2;       //内部温度，双极性
            this.Width = 1173;
        }
        private void 查看帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("左边为数据接收框，右边是数据发送框，点击按钮1和按钮2，可以快速发送数字1或数字2", "帮助",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #endregion


        #region    private methods
        void Send(string sendString)
        {
            try
            {
                char[] a = sendString.ToCharArray();
                byte[] WriteBuffer = Encoding.ASCII.GetBytes(a);

                button1.Text = "等待";


                serialPort1.Write(WriteBuffer, 0, WriteBuffer.Length);
                button1.Text = "发送";
                textBoxSend.Text = "";
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("                   请打开串口，或检查单片机连接！                   " +
                    "", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void TemperatureUnipolar()
        {
            List<int> number = ADCUnipolarDataSort();
            foreach (int item in number)
            {
                double i = ((item / 16777215.0) / 8 * 2450 - 757) / -1.73;
                textBoxADC.AppendText((i).ToString() + "\r\n");

                //chart1.ChartAreas[0].AxisY.Minimum = i > k ? k : Math.Round(i - 0.5);
                chart1.Series[0].Points.AddY(i);
            }
        }
        void TemperatureBipolar() //有问题
        {
            List<int> number = ADCBipolarDataSort();
            foreach (int item in number)
            {
                double i = ((item / 8388608.0) / 8 * 2450.0 - 54.3) / 0.205;
                textBoxADC.AppendText(i.ToString() + "\r\n");

                //chart1.ChartAreas[0].AxisY.Minimum = i > k ? k : Math.Round(i - 0.5);
                chart1.Series[0].Points.AddY(i);
            }

        }
        List<int> ADCBipolarDataSort()
        {
            byte[] recieveBuffer = Encoding.ASCII.GetBytes(data);
            string s = "";
            for (int i = 0; i < recieveBuffer.Length; i++)
            {
                s += Convert.ToString(recieveBuffer[i], 10) + " ";
            }
            string[] adc = Regex.Split(s, "0 0 0", RegexOptions.None);

            List<int> number = new List<int>();
            foreach (string item in adc)
            {
                string[] ADC = item.Trim().Split(' ');
                if (ADC.Length == 3)
                {
                    if (Int32.Parse(ADC[0]) >= 128)
                        number.Add(-16777215 + Int32.Parse(ADC[0]) * 256 * 256 + Int32.Parse(ADC[1]) * 256 + Int32.Parse(ADC[2]));
                    else
                        number.Add(Int32.Parse(ADC[0]) * 256 * 256 + Int32.Parse(ADC[1]) * 256 + Int32.Parse(ADC[2]));
                }
            }
            return number;
        }
        List<int> ADCUnipolarDataSort()
        {
            byte[] recieveBuffer = Encoding.ASCII.GetBytes(data);
            string s = "";
            for (int i = 0; i < recieveBuffer.Length; i++)
            {
                s += Convert.ToString(recieveBuffer[i], 10) + " ";
            }
            string[] adc = Regex.Split(s, "0 0 0", RegexOptions.None);
            List<int> number = new List<int>();
            foreach (string item in adc)
            {
                string[] ADC = item.Trim().Split(' ');
                if (ADC.Length == 3)
                {
                    number.Add(Int32.Parse(ADC[0]) * 256 * 256 + Int32.Parse(ADC[1]) * 256 + Int32.Parse(ADC[2]));
                }

            }
            return number;
        }
        void HexShow()
        {
            byte[] recieveBuffer = Encoding.ASCII.GetBytes(data);
            string hex = "";
            for (int i = 0; i < recieveBuffer.Length; i++)
            {
                hex += Convert.ToString(recieveBuffer[i], 16) + " ";
            }
            richTextBoxRecieve.AppendText(hex);
        }
        void Initial()
        {
            comboBoxCOM.DataSource = SerialPort.GetPortNames();

            serialPort1.BaudRate = 9600;
            serialPort1.Parity = Parity.None;
            serialPort1.DataBits = 8;
            serialPort1.StopBits = StopBits.One;

            comboBoxBaudRate.SelectedIndex = 0;
            comboBoxParity.SelectedIndex = 0;
            comboBoxDataBit.SelectedIndex = 1;
            comboBoxStopBits.SelectedIndex = 1;
        }
        #endregion

        #region    private fileds
        string data = "";
        int flag = 0;       //共作方式，单极性，双极性

        #endregion

    }
}
