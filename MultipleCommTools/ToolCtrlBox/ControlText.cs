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
    public partial class ControlText : TextBox
    {
        public ControlText()
        {
        }
        public void txt_TextChange(object sender, EventArgs e)
        {
            if (this.Text.Length == 3)
            {
                SendKeys.Send("{TAB}");
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Tab)
            {
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
