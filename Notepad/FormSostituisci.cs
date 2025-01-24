using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Notepad
{
    public partial class FormSostituisci : Notepad.FormBaseTrovaSostituisci
    {
        public FormSostituisci()
        {
            InitializeComponent();
        }

        private void FormSostituisci_Load(object sender, EventArgs e)
        {
            btnSostituisci.Enabled = btnSostituisciTutto.Enabled = txtTrova.TextLength > 0;
        }

        private void txtTrova_TextChanged(object sender, EventArgs e)
        {
            btnSostituisci.Enabled = btnSostituisciTutto.Enabled = txtTrova.TextLength > 0;
        }

        private void btnSostituisci_Click(object sender, EventArgs e)
        {
            FindReplaceService.Parameters.TextToFind = txtTrova.Text;
            FindReplaceService.Parameters.TextToReplace = txtSostituisci.Text;
            if (FindReplaceService.Replace() == -1)
                FindReplaceService.ShowNotFoundMessageBox();
        }

        private void btnSostituisciTutto_Click(object sender, EventArgs e)
        {
            FindReplaceService.Parameters.TextToFind = txtTrova.Text;
            FindReplaceService.Parameters.TextToReplace = txtSostituisci.Text;
            FindReplaceService.ReplaceAll();
        }
    }
}
