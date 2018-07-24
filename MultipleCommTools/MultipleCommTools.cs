using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleCommTools
{
    public partial class MultipleCommTools : Form
    {
        public MultipleCommTools()
        {
            InitializeComponent();
        }
        ///
        private void MultipleCommTools_Load(object sender, EventArgs e)
        {
            //固定 窗口
            this.MaximizeBox = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            //串口启动初始化
            SerialportToolsInit();
           
        }

        /// <summary>
        /// 粘贴数据格式检查
        /// </summary>
        /// <returns></returns>
        private bool CheckClipboardDataPaste()
        {
            try
            {
                char[] PasteChar = Clipboard.GetDataObject().GetData(DataFormats.Text).ToString().ToCharArray();
                if (bSerialportTxAreaHexFormatChecked)
                {
                    foreach (char data in PasteChar)
                    {
                        if (!((data >= '0' && data <= '9')//数字0-9键   
                         || (data >= 'A' && data <= 'F')//字母A-F 
                         || (data >= 'a' && data <= 'f')//字母a-f
                         || data == 0x20))//空格
                        {
                            MessageBox.Show("粘贴数据含有非法字符，只能包含数字0-9,大写英文字母A-F,小写英文字母a-f以及空格！", "非法的粘贴", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
                else
                {
                    foreach (char data in PasteChar)
                    {
                        if (!((data >= 0x20 && data <= 0x7E)
                         || data == 0x0A
                         || data == 0x0D))//回车键
                        {
                            MessageBox.Show("粘贴数据含有非法字符，只能包含ASCII码字符！", "非法的粘贴", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// 打开关闭串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCtrlSerialport_Click(object sender, EventArgs e)
        {
            try {
                SerialPortToolCtrlOpenClose();
            }
            catch (FormatException)
            {
                MessageBox.Show("无效的波特率", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //串口助手接收事件处理函数
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPortToolDataReceive();
        }

        /// <summary>
        /// 手动发送数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSerialportTxCtrl_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPortToolsTxData(ref serialPort1);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 定时发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SerialToolAutoTxTimer_Tick(object sender, EventArgs e)
        {

            try
            {
                SerialportToolsSendTextData(ref serialPort1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SerialToolAutoTxTimer.Enabled = false;
                checkBoxTxRxData.Enabled = true;
                textBoxSerialportTxTick.Enabled = true;
                checkBoxSerialportTxedEmpty.Enabled = true;
                checkBoxSerialportAutoTx.Enabled = true;
                textBoxPortTxData.Enabled = true;
                btnSerialportTxCtrl.Text = "发送数据";
                MessageBox.Show(ex.Message, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void checkBoxSerialportShowRxTime_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSerialportShowRxTime.Checked)
            {
                checkBoxSerialportRxAppendLine.Checked = true;
                checkBoxSerialportRxAppendLine.Enabled = false;
            }
            else
            {
                checkBoxSerialportRxAppendLine.Enabled = true;
            }
        }

        private void btnEmptyTxText_Click(object sender, EventArgs e)
        {
            textBoxPortTxData.Clear();
        }

        /// <summary>
        /// 发送区域字符转换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hexToASCIIToolStripMenuItem_Click(object sender, EventArgs e)
        {


            //已经转换为HEX
            if (bSerialportTxAreaHexFormatChecked)
            {
                //16进制转ASCII
                if (textBoxPortTxData.Text.Length > 0)
                {
                    bSerialportTxAreaHexFormatChecked = false;
                    textBoxPortTxData.Text = System.Text.Encoding.Default.GetString(StringToHexBytes(textBoxPortTxData.Text.Replace(" ", "")));
                    hexToASCIIToolStripMenuItem.Text = "转换为HEX";
                    calCheckToolStripMenuItem.Visible = false;
                }
                
            }
            else
            {
                //ASCII转16进制
                Byte[] TxByteBfr = System.Text.Encoding.Default.GetBytes(textBoxPortTxData.Text);
                if (TxByteBfr.Length > 0)
                {
                    String strConv = String.Empty;
                    for (int i = 0; i < TxByteBfr.Length; i++)
                    {
                        strConv += Convert.ToString(TxByteBfr[i], 16).PadLeft(2, '0').ToUpper() + " ";
                    }
                    
                    textBoxPortTxData.Text = strConv;
                    //Console.WriteLine(textBoxPortTxData.Text);
                    textBoxPortTxData.SelectionStart = textBoxPortTxData.Text.Length;
                    hexToASCIIToolStripMenuItem.Text = "转换为ASCII";
                    calCheckToolStripMenuItem.Visible = true;
                    bSerialportTxAreaHexFormatChecked = true;
                }

            }
        }

        private void cbBoxPort_DropDown(object sender, EventArgs e)
        {
            String[] SerialPortsAry = SerialPort.GetPortNames();
            Array.Sort(SerialPortsAry, new CustomComparer());
            cbBoxPort.Items.Clear();
            cbBoxPort.Items.AddRange(SerialPortsAry);
            if (SerialportToolsName != null)
            {
                cbBoxPort.SelectedIndex = cbBoxPort.FindString(SerialportToolsName);
                if (cbBoxPort.SelectedIndex == -1)
                {
                    cbBoxPort.SelectedIndex = cbBoxPort.Items.Count > 0 ? 0 : -1;
                }
            }
            else
            {
                cbBoxPort.SelectedIndex = cbBoxPort.Items.Count > 0 ? 0 : -1;
            }
        }

        /// <summary>
        /// 清空接收区
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemClearRX_Click(object sender, EventArgs e)
        {
            textBoxPortRxData.Clear();
        }

        /// <summary>
        /// 浏览文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSerialportBrowerFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            opendlg.Filter = "Binary File(*.bin)|*.bin|Text File(*.txt)|*.txt|All File(*.*)|*.*";
            opendlg.RestoreDirectory = true;

            if (opendlg.ShowDialog() == DialogResult.OK)
            {
                textBoxSerialPortFilePath.Text = opendlg.FileName;
            }
        }

        /// <summary>
        /// 保存接收区数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemSaveRxData_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();

            saveDlg.Filter = "Text File(*.txt)|*.txt|Binary File(*.bin)|*.bin|All File(*.*)|*.*";
            saveDlg.RestoreDirectory = true;

            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter fsw = new StreamWriter(saveDlg.FileName, false);
                fsw.Write(textBoxPortRxData.Text);
                fsw.Close();
            }
        }

        /// <summary>
        /// 发送文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSerialportTxFile_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("串口未打开", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (File.Exists(textBoxSerialPortFilePath.Text.Trim()))
            {
                StreamReader fsr = new StreamReader(textBoxSerialPortFilePath.Text.Trim(), Encoding.Default);
                try
                {

                    serialPort1.Write(fsr.ReadToEnd());

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                fsr.Close();
            }
            else
            {
                MessageBox.Show("文件不存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TimerShowTick_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelCurTime.Text = DateTime.Now.ToString();
        }

        /// <summary>
        /// 清空计数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearRxTxCntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SerialportToolRxDatCnt = SerialportToolTxDatCnt = 0;
            toolStripStatusLabelRxCnt.Text = "RX:" + SerialportToolRxDatCnt.ToString();
            toolStripStatusLabelTxCnt.Text = "TX:" + SerialportToolTxDatCnt.ToString();
        }

        /// <summary>
        /// 修改波特率
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbBoxbaundRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBoxbaundRate.Text.Trim() == "自定义"){
                cbBoxbaundRate.DropDownStyle = ComboBoxStyle.DropDown;
            }else {
                cbBoxbaundRate.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void textBoxPortTxData_TextChanged(object sender, EventArgs e)
        {
            if (bSerialportTxAreaHexFormatChecked) {
                string Content = textBoxPortTxData.Text.Replace(" ", "");//获取去除空格后的字符内容
                int SpaceCount = Content.Length / 2;
                int StartIndex = 2;
                for (int i = 0; i < SpaceCount; i++)
                {
                    Content = Content.Insert(StartIndex, " ");
                    StartIndex = StartIndex + 3;
                }
                textBoxPortTxData.Text = Content.TrimEnd().ToUpper();
                textBoxPortTxData.SelectionStart = textBoxPortTxData.Text.Length;
                
            }
        }

        private void textBoxPortTxData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (bSerialportTxAreaHexFormatChecked)
            {
                if (   (e.KeyChar >= '0' && e.KeyChar <= '9')//数字0-9键   
                    || (e.KeyChar >= 'A' && e.KeyChar <= 'F')//字母A-F 
                    || (e.KeyChar >= 'a' && e.KeyChar <= 'f')//字母a-f 
                    
                  )
                  {
                     e.Handled = false;
                     return;
                  }

                if (e.KeyChar == 0x08//退格键
                    || e.KeyChar == 0x03//拷贝
                    || e.KeyChar == 0x18//剪切
                    || (e.KeyChar == 0x0D) || (e.KeyChar == 0x0A)
                    )
                {
                    e.Handled = false;
                    return;
                }

                if (e.KeyChar == 0x16)//粘贴
                {
                    if (CheckClipboardDataPaste()) {
                        e.Handled = false;
                        return;
                    }
                }
                    
                e.Handled = true;
            }
        }

        //发送接收到的数据
        private void checkBoxTxRxData_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTxRxData.Checked)
            {
                btnSerialportTxCtrl.Enabled = false;
                textBoxPortTxData.Enabled = false;
                checkBoxSerialportAutoTx.Enabled = false;
                textBoxSerialportTxTick.Enabled = false;
            }
            else
            {
                btnSerialportTxCtrl.Enabled = true;
                textBoxPortTxData.Enabled = true;
                textBoxSerialportTxTick.Enabled = true;
                checkBoxSerialportAutoTx.Enabled = true;
            }
        }


        private void checkBoxSerialRxShowCtrl_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSerialRxShowCtrl.Checked)
            {
                textBoxPortRxData.Enabled = false;
            }
            else
            {
                textBoxPortRxData.Enabled = true;
            }
        }

        /// <summary>
        /// 打开计算器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalTool_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void calCRCSumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxPortTxData.Text == "")
            {
                MessageBox.Show("请输入有效数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            textBoxPortTxData.AppendText(string.Format("{0:X2}", Lib.CalCrcCheck.CalCrcSumByte(StringToHexBytes(textBoxPortTxData.Text.Replace(" ", "")))));

        }


        private void modbusRTUCRCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxPortTxData.Text == ""){
                MessageBox.Show("请输入有效数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            byte[] crcAry = Lib.CalCrcCheck.MBRTUCRC16(StringToHexBytes(textBoxPortTxData.Text.Replace(" ", "")));
            textBoxPortTxData.AppendText(string.Format("{0:X2}", crcAry[0]));
            textBoxPortTxData.AppendText(string.Format("{0:X2}", crcAry[1]));
        }

        private void calCRCSumWORDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxPortTxData.Text == "")
            {
                MessageBox.Show("请输入有效数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            byte[] crcAry = Lib.CalCrcCheck.CalCrcSumWord(StringToHexBytes(textBoxPortTxData.Text.Replace(" ", "")));
            textBoxPortTxData.AppendText(string.Format("{0:X2}", crcAry[0]));
            textBoxPortTxData.AppendText(string.Format("{0:X2}", crcAry[1]));
        }

        private void calXORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxPortTxData.Text == "")
            {
                MessageBox.Show("请输入有效数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            textBoxPortTxData.AppendText(string.Format("{0:X2}", Lib.CalCrcCheck.CalCrcXOR(StringToHexBytes(textBoxPortTxData.Text.Replace(" ", "")))));

        }

        private void clearTxDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxPortTxData.Clear();
        }
    }
}
