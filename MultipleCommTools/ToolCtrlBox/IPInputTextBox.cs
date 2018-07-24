using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MultipleCommTools.ToolCtrlBox
{
    public partial class IPInputTextBox : UserControl
    {
        public IPInputTextBox()
        {
            InitializeComponent();
        }
        TextBox ParentTxt;
        private void IPInput_Load(object sender, EventArgs e)
        {
            ParentTxt = txt_1;
        }
        public void txt_KeyDown(object sender, KeyEventArgs e)
        {
            ParentTxt = (TextBox)sender;
            if (e.KeyCode == Keys.Left)
            {
                switch (ParentTxt.Name.Split('_')[1])
                {
                    case "1":
                        break;
                    case "2":
                        if (ParentTxt.SelectionStart == 0 && ParentTxt.Text != "")
                        {
                            if (int.Parse(ParentTxt.Text) > 255)
                            {
                               // MessageBox.Show(ParentTxt.Text + "不是有效项。请指定一个介于1和255之间的值。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                ParentTxt.Text = "255";
                                ParentTxt.SelectionStart = 0;
                            }
                            else
                            {
                                txt_1.Focus();
                            }
                        }
                        else if (ParentTxt.Text == "")
                        {
                            txt_1.Focus();
                        }
                        break;
                    case "3":
                        if (ParentTxt.SelectionStart == 0 && ParentTxt.Text != "")
                        {
                            if (int.Parse(ParentTxt.Text) > 255)
                            {
                                //MessageBox.Show(ParentTxt.Text + "不是有效项。请指定一个介于1和255之间的值。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                ParentTxt.Text = "255";
                                ParentTxt.SelectionStart = 0;
                            }
                            else
                            {
                                txt_2.Focus();
                            }
                        }
                        else if (ParentTxt.Text == "")
                        {
                            txt_2.Focus();
                        }
                        break;
                    case "4":
                        if (ParentTxt.SelectionStart == 0 && ParentTxt.Text != "")
                        {
                            if (int.Parse(ParentTxt.Text) > 255)
                            {
                                //MessageBox.Show(ParentTxt.Text + "不是有效项。请指定一个介于1和255之间的值。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                ParentTxt.Text = "255";
                                ParentTxt.SelectionStart = 0;
                            }
                            else
                            {
                                txt_3.Focus();
                            }
                        }
                        else if (ParentTxt.Text == "")
                        {
                            txt_3.Focus();
                        }
                        break;
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                switch (ParentTxt.Name.Split('_')[1])
                {
                    case "1":
                        if (ParentTxt.SelectionStart == ParentTxt.Text.Length && ParentTxt.Text != "")
                        {
                            if (int.Parse(ParentTxt.Text) > 223)
                            {
                             //   MessageBox.Show(ParentTxt.Text + "不是有效项。请指定一个介于1和223之间的值。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                ParentTxt.Text = "223";
                                ParentTxt.SelectionStart = ParentTxt.Text.Length;
                            }
                            else
                            {
                                txt_2.Focus();
                            }
                        }
                        else if (ParentTxt.Text == "")
                        {
                            txt_2.Focus();
                        }
                        break;
                    case "2":
                        if (ParentTxt.SelectionStart == ParentTxt.Text.Length && ParentTxt.Text != "")
                        {
                            if (int.Parse(ParentTxt.Text) > 255)
                            {
                              //  MessageBox.Show(ParentTxt.Text + "不是有效项。请指定一个介于1和255之间的值。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                ParentTxt.Text = "255";
                                ParentTxt.SelectionStart = ParentTxt.Text.Length;
                            }
                            else
                            {
                                txt_3.Focus();
                            }
                        }
                        else if (ParentTxt.Text == "")
                        {
                            txt_3.Focus();
                        }
                        break;
                    case "3":
                        if (ParentTxt.SelectionStart == ParentTxt.Text.Length && ParentTxt.Text != "")
                        {
                            if (int.Parse(ParentTxt.Text) > 255)
                            {
                             //   MessageBox.Show(ParentTxt.Text + "不是有效项。请指定一个介于1和255之间的值。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                ParentTxt.Text = "255";
                                ParentTxt.SelectionStart = ParentTxt.Text.Length;
                            }
                            else
                            {
                                txt_4.Focus();
                            }
                        }
                        else if (ParentTxt.Text == "")
                        {
                            txt_4.Focus();
                        }
                        break;
                    case "4":
                        break;
                }
            }
        }
        public void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ParentTxt = (TextBox)sender;
            Regex regex = new Regex(@"^[0-9]+$");
            if (!regex.IsMatch(e.KeyChar.ToString()) && e.KeyChar != (Char)Keys.Back)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (Char)Keys.Back)
            {
                e.Handled = false;
                switch (ParentTxt.Name.Split('_')[1])
                {
                    case "1":
                        break;
                    case "2":
                        if (ParentTxt.SelectionStart == 0)
                        {
                            txt_1.Focus();
                            if (txt_1.Text != "")
                            {
                                txt_1.Text = txt_1.Text.Substring(0, txt_1.Text.Length - 1);
                            }
                            txt_1.SelectionStart = txt_1.Text.Length;
                        }
                        break;
                    case "3":
                        if (ParentTxt.SelectionStart == 0)
                        {
                            txt_2.Focus();
                            if (txt_2.Text != "")
                            {
                                txt_2.Text = txt_2.Text.Substring(0, txt_2.Text.Length - 1);
                            }
                            txt_2.SelectionStart = txt_2.Text.Length;
                        }
                        break;
                    case "4":
                        if (ParentTxt.SelectionStart == 0)
                        {
                            txt_3.Focus();
                            if (txt_3.Text != "")
                            {
                                txt_3.Text = txt_3.Text.Substring(0, txt_3.Text.Length - 1);
                            }
                            txt_3.SelectionStart = txt_3.Text.Length;
                        }
                        break;
                }
            }
            else
            {
                switch (ParentTxt.Name.Split('_')[1])
                {
                    case "1":
                        if (ParentTxt.SelectionStart == ParentTxt.Text.Length)
                        {
                            if (int.Parse(ParentTxt.Text + e.KeyChar.ToString()) > 223)
                            {
                                //MessageBox.Show(ParentTxt.Text + e.KeyChar.ToString() + "不是有效项。请指定一个介于1和223之间的值。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                e.Handled = true;
                                ParentTxt.Text = "223";
                            }
                            else
                            {
                                e.Handled = false;
                            }
                        }
                        else if(ParentTxt.Text.Length != 3)
                        {
                            e.Handled = false;
                        }
                        else
                        {
                            e.Handled = true;
                        }
                        break;
                    default:
                        if (ParentTxt.SelectionStart == ParentTxt.Text.Length)
                        {
                            if (int.Parse(ParentTxt.Text + e.KeyChar.ToString()) > 255)
                            {
                                //MessageBox.Show(ParentTxt.Text + e.KeyChar.ToString() + "不是有效项。请指定一个介于1和255之间的值。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                e.Handled = true;
                                ParentTxt.Text = "255";
                            }
                            else
                            {
                                e.Handled = false;
                            }
                        }
                        else if (ParentTxt.Text.Length != 3)
                        {
                            e.Handled = false;
                        }
                        else
                        {
                            e.Handled = true;
                        }
                        break;
                }
            }
        }
        public void txt_TextChanged(object sender, EventArgs e)
        {
            if (ParentTxt.Text.Length == 3)
            {
                switch (ParentTxt.Name.Split('_')[1])
                {
                    case "1":
                        if (ParentTxt.SelectionStart == ParentTxt.Text.Length)
                        {
                            txt_2.Focus();
                        }
                        break;
                    case "2":
                        if (ParentTxt.SelectionStart == ParentTxt.Text.Length)
                        {
                            txt_3.Focus();
                        }
                        break;
                    case "3":
                        if (ParentTxt.SelectionStart == ParentTxt.Text.Length)
                        {
                            txt_4.Focus();
                        }
                        break;
                    case "4":
                        break;
                }
            }
        }
    }
}
