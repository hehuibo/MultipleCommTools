using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// 串口调试工具相关
/// </summary>

namespace MultipleCommTools
{


    /// <summary>
    /// 对带有数字的字符串排序 : A1  A10 A2  ---> A1  A2 A10
    /// </summary>
    public class CustomComparer : System.Collections.IComparer
    {
        public int Compare(object x, object y)
        {
            string s1 = (string)x;
            string s2 = (string)y;
            if (s1.Length > s2.Length) return 1;
            if (s1.Length < s2.Length) return -1;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] > s2[i]) return 1;
                if (s1[i] < s2[i]) return -1;
            }
            return 0;
        }
    }

    public partial class MultipleCommTools : Form
	{

        public static int SerialportToolRxDatCnt = 0;
        public static int SerialportToolTxDatCnt = 0;
        public static String SerialportToolsName = null;
        public static bool bSerialportTxAreaHexFormatChecked = false;

        //串口调试工具启动初始化
        private void SerialportToolsInit()
        {
            //获取串口列表
            String[] SerialPortsAry = SerialPort.GetPortNames();
            Array.Sort(SerialPortsAry, new CustomComparer());
            cbBoxPort.Items.AddRange(SerialPortsAry);
            cbBoxPort.SelectedIndex = cbBoxPort.Items.Count > 0 ? 0 : -1;

            //BaundRate
            cbBoxbaundRate.Items.Add("1200");
            cbBoxbaundRate.Items.Add("2400");
            cbBoxbaundRate.Items.Add("4800");
            cbBoxbaundRate.Items.Add("9600");
            cbBoxbaundRate.Items.Add("14400");
            cbBoxbaundRate.Items.Add("19200");
            cbBoxbaundRate.Items.Add("38400");
            cbBoxbaundRate.Items.Add("57600");
            cbBoxbaundRate.Items.Add("115200");
            cbBoxbaundRate.Items.Add("128000");
            cbBoxbaundRate.Items.Add("256000");
            cbBoxbaundRate.Items.Add("自定义");
            
            cbBoxbaundRate.SelectedIndex = 3;

            //Priority
            cbBoxParity.Items.Add("NONE");
            cbBoxParity.Items.Add("ODD");
            cbBoxParity.Items.Add("EVEN");
            cbBoxParity.Items.Add("MARK");
            cbBoxParity.Items.Add("SPACE");
            cbBoxParity.SelectedIndex = 0;

            //DataBits
            cbBoxDatabits.Items.Add("5");
            cbBoxDatabits.Items.Add("6");
            cbBoxDatabits.Items.Add("7");
            cbBoxDatabits.Items.Add("8");
            cbBoxDatabits.SelectedIndex = 3;

            //StopBits
            cbBoxStopbits.Items.Add("1");
            cbBoxStopbits.Items.Add("1.5");
            cbBoxStopbits.Items.Add("2");
            cbBoxStopbits.SelectedIndex = 0;

            picBoxOpenPort.Visible = false;
            picBoxClosePort.Visible = true;
            textBoxSerialportTxTick.Text = "1000";

            bSerialportTxAreaHexFormatChecked = false;

            toolStripStatusLabelRxCnt.Text = "RX:" + SerialportToolRxDatCnt.ToString();
            toolStripStatusLabelTxCnt.Text = "TX:" + SerialportToolTxDatCnt.ToString();
            toolStripStatusLabelCurTime.Text = DateTime.Now.ToString();
            TimerShowTick.Enabled = true;
            supperTercheckBox.Enabled = false;
        }

        //串口调试工具参数设置
        private void SerialPortToolSetProperty()
        {
            serialPort1.PortName = cbBoxPort.Text.Trim();

            //serialPort1.BaudRate = Convert.ToInt32(cbBoxbaundRate.Text.Trim());
            serialPort1.BaudRate = Int32.Parse(cbBoxbaundRate.Text.Trim());
            /*校验位*/
            Parity mPortParity = Parity.None;
            switch (cbBoxParity.SelectedIndex)
            {
                case 0:
                    mPortParity = Parity.None;
                    break;
                case 1:
                    mPortParity = Parity.Odd;
                    break;

                case 2:
                    mPortParity = Parity.Even;
                    break;
                case 3:
                    mPortParity = Parity.Mark;
                    break;
                case 4:
                    mPortParity = Parity.Space;
                    break;

            }
            serialPort1.Parity = mPortParity;

            //停止位
            StopBits mStopBits = StopBits.One;
            switch (cbBoxStopbits.SelectedIndex)
            {
                case 0:
                    mStopBits = StopBits.One;
                    break;
                case 1:
                    mStopBits = StopBits.OnePointFive;//数据位5 1.5 -- > OK
                    break;
                 case 2 :
                    mStopBits = StopBits.Two;
                    break;
            }
            serialPort1.StopBits = mStopBits;
            //数据位
            serialPort1.DataBits = Convert.ToInt32(cbBoxDatabits.Text.Trim());

            serialPort1.Encoding = System.Text.Encoding.GetEncoding("GB2312");
        }

        /// <summary>
        /// 打开关闭串口
        /// </summary>
        private void SerialPortToolCtrlOpenClose()
        {
            if (!serialPort1.IsOpen)
            {
                try
                {
                    SerialPortToolSetProperty();
                    serialPort1.Open();
                    picBoxClosePort.Visible = false;
                    picBoxOpenPort.Visible = true;
                    btnCtrlSerialport.Text = "关闭串口";
                    cbBoxPort.Enabled = false;
                    cbBoxbaundRate.Enabled = false;
                    cbBoxDatabits.Enabled = false;
                    cbBoxParity.Enabled = false;
                    cbBoxStopbits.Enabled = false;
                    SerialportToolsName = serialPort1.PortName;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }else{
                try
                {
                    serialPort1.Close();
                    picBoxClosePort.Visible = true;
                    picBoxOpenPort.Visible = false;
                    btnCtrlSerialport.Text = "打开串口";
                    cbBoxPort.Enabled = true;
                    cbBoxbaundRate.Enabled = true;
                    cbBoxDatabits.Enabled = true;
                    cbBoxParity.Enabled = true;
                    cbBoxStopbits.Enabled = true;

                    String[] SerialPortsAry = SerialPort.GetPortNames();
                    Array.Sort(SerialPortsAry);
                    cbBoxPort.Items.Clear();
                    cbBoxPort.Items.AddRange(SerialPortsAry);
                    if (SerialportToolsName != null){
                        cbBoxPort.SelectedIndex = cbBoxPort.FindString(SerialportToolsName);
                        if (cbBoxPort.SelectedIndex == -1){
                            cbBoxPort.SelectedIndex = cbBoxPort.Items.Count > 0 ? 0 : -1;
                        }
                    }else{
                        cbBoxPort.SelectedIndex = cbBoxPort.Items.Count > 0 ? 0 : -1;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        //仅供串口调试助手接收调用
        private void SerialPortToolDataReceive()
        {
            String SerialRxStrTmp = null;
            String SerialRxStrTmpBfr = null;
            SerialportToolRxDatCnt += serialPort1.BytesToRead;


            SerialRxStrTmpBfr = serialPort1.ReadExisting();

            //发送接收到的数据
            if (checkBoxTxRxData.Checked) {
                serialPort1.Write(SerialRxStrTmpBfr);
                SerialportToolTxDatCnt += SerialRxStrTmpBfr.Length;
            }

            //16进制接收
            if (checkBoxSerialportRxHexFormat.Checked)
            {
                Byte[] rcvBuffer = System.Text.Encoding.Default.GetBytes(SerialRxStrTmpBfr);
                for (int i = 0; i < rcvBuffer.Length; i++)
                {
                    SerialRxStrTmp += rcvBuffer[i].ToString("X2") + " ";
                }

            }
            else
            {
                SerialRxStrTmp = SerialRxStrTmpBfr;
            }
   

            if (checkBoxSerialportRxAppendLine.Checked)
            {
                SerialRxStrTmp += "\r\n";
            }

            //显示接收数据
            if (!checkBoxSerialRxShowCtrl.Checked) {
                textBoxPortRxData.Invoke(
                  new MethodInvoker(
                      () => {
                          if (checkBoxSerialportShowRxTime.Checked)
                          {
                              textBoxPortRxData.AppendText(DateTime.Now.ToString("【yyyy/MM/dd HH:mm:ss:ffff】") + SerialRxStrTmp);
                          }
                          else
                          {
                              textBoxPortRxData.AppendText(SerialRxStrTmp);
                          }

                      }
                  )
                );
            }

            //显示接收计数
            this.Invoke(
                new MethodInvoker(
                   () => {
                       toolStripStatusLabelRxCnt.Text = "RX:" + SerialportToolRxDatCnt.ToString();

                       if (checkBoxTxRxData.Checked){
                           toolStripStatusLabelTxCnt.Text = "TX:" + SerialportToolTxDatCnt.ToString();
                       }
                       
                   }        
                )
            );
        }
        private void SerialportToolsSendTextData(ref SerialPort sPort)
        {
            try
            {
                if (bSerialportTxAreaHexFormatChecked)
                {
                    String TextStrTmp = textBoxPortTxData.Text.Replace(" ", "");
                    Byte[] TxByteBuffer = StringToHexBytes(TextStrTmp);
                    sPort.Write(TxByteBuffer, 0, TxByteBuffer.Length);
                    SerialportToolTxDatCnt += TextStrTmp.Length / 2;
                }
                else
                {
                    sPort.Write(textBoxPortTxData.Text);
                    SerialportToolTxDatCnt += textBoxPortTxData.Text.Length;
                }


                if (checkBoxSerialportTxedEmpty.Checked && checkBoxSerialportTxedEmpty.Enabled)
                {
                    textBoxPortTxData.Clear();
                }

                toolStripStatusLabelTxCnt.Text = "TX:" + SerialportToolTxDatCnt.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 字符串转化为十六进制
        /// </summary>
        /// <param name="strToConv"></param>
        /// <returns></returns>
        private Byte[] StringToHexBytes(String strToConv)
        {
            if (strToConv.Length % 2 != 0)
            {
                strToConv = strToConv.Insert(strToConv.Length - 1, "0");
            }

            Byte[] bytesHex = new Byte[strToConv.Length / 2];
            try
            {
                for (int i = 0; i < strToConv.Length / 2; i++)
                {
                    bytesHex[i] = Convert.ToByte(strToConv.Substring(2 * i, 2), 16);
                }
            }
            catch
            {

            }

            return bytesHex;
        }

        private void serialPortToolTxAreaDataFormat()
        {
            if (bSerialportTxAreaHexFormatChecked)
            {
                //16进制转ASCII
                Byte[] TxByteBfr = System.Text.Encoding.Default.GetBytes(textBoxPortTxData.Text);
                if (TxByteBfr.Length > 0)
                {
                    String strConv = String.Empty;
                    for (int i = 0; i < TxByteBfr.Length; i++)
                    {
                        strConv += Convert.ToString(TxByteBfr[i], 16).PadLeft(2, '0').ToUpper() + " ";
                    }

                    textBoxPortTxData.Text = strConv;
                }
                bSerialportTxAreaHexFormatChecked = false;
            }
            else
            {
                //ASCII转16进制
                if (textBoxPortTxData.Text.Length > 0)
                {
                    textBoxPortTxData.Text = System.Text.Encoding.Default.GetString(StringToHexBytes(textBoxPortTxData.Text.Replace(" ", "")));
                }
                bSerialportTxAreaHexFormatChecked = true;
            }
        }

        private void SerialPortToolsTxData(ref SerialPort sPort)
        {
            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("串口未打开", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //定时发送
            if (checkBoxSerialportAutoTx.Checked)
            {
                if (textBoxPortTxData.Text == "")
                {
                    MessageBox.Show("发送数据为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (SerialToolAutoTxTimer.Enabled)
                {
                    SerialToolAutoTxTimer.Enabled = false;
                    checkBoxTxRxData.Enabled = true;
                    textBoxSerialportTxTick.Enabled = true;
                    checkBoxSerialportTxedEmpty.Enabled = true;
                    checkBoxSerialportAutoTx.Enabled = true;
                    textBoxPortTxData.Enabled = true;
                    btnSerialportTxCtrl.Text = "发送数据";
                    if (checkBoxSerialportTxedEmpty.Checked)
                    {
                        textBoxPortTxData.Clear();
                    }
                }
                else
                {
                    if (Convert.ToInt32(textBoxSerialportTxTick.Text.Trim()) > 0)
                    {
                        textBoxSerialportTxTick.Enabled = false;
                        SerialToolAutoTxTimer.Interval = Convert.ToInt32(textBoxSerialportTxTick.Text.Trim());
                        SerialToolAutoTxTimer.Enabled = true;
                        checkBoxSerialportTxedEmpty.Enabled = false;
                        checkBoxSerialportAutoTx.Enabled = false;
                        checkBoxTxRxData.Enabled = false;
                        textBoxPortTxData.Enabled = false;
                        btnSerialportTxCtrl.Text = "停止发送";
                    }
                    else
                    {
                        MessageBox.Show("发送周期必须大于0");
                    }
                }
            }
            else
            {
                if (textBoxPortTxData.Text == "")
                {
                    MessageBox.Show("发送数据为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try {
                    SerialportToolsSendTextData(ref sPort);
                } catch (Exception ex) {
                    throw ex;
                }
                
            }
        }

    }
}
