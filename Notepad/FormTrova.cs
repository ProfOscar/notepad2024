using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Notepad
{
    public partial class FormTrova : Notepad.FormBaseTrovaSostituisci
    {
        public FormTrova()
        {
            InitializeComponent();
        }

        private void FormTrova_Load(object sender, EventArgs e)
        {
            rdbSu.Checked = FindReplaceService.Parameters.IsUp;
            rdbGiu.Checked = !rdbSu.Checked;
        }

        private void rdbSu_CheckedChanged(object sender, EventArgs e)
        {
            FindReplaceService.Parameters.IsUp = rdbSu.Checked;
        }
    }
}
