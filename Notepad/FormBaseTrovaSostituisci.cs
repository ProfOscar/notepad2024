using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class FormBaseTrovaSostituisci : Form
    {
        public FormBaseTrovaSostituisci()
        {
            InitializeComponent();
        }

        private void FormBaseTrovaSostituisci_Load(object sender, EventArgs e)
        {
            txtTrova.Text = FindReplaceService.Parameters.TextToFind;
            chkMaiusMinus.Checked = FindReplaceService.Parameters.IsCaseSensitive;
            chkParolaIntera.Checked = FindReplaceService.Parameters.IsWholeWord;
            btnTrova.Enabled = txtTrova.TextLength > 0;
        }

        private void btnTrova_Click(object sender, EventArgs e)
        {
            FindReplaceService.Parameters.TextToFind = txtTrova.Text;
            FindReplaceService.Parameters.IsCaseSensitive = chkMaiusMinus.Checked;
            FindReplaceService.Parameters.IsWholeWord = chkParolaIntera.Checked;
            if (FindReplaceService.Find() == -1)
                FindReplaceService.ShowNotFoundMessageBox();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTrova_TextChanged(object sender, EventArgs e)
        {
            btnTrova.Enabled = txtTrova.TextLength > 0;
        }
    }
}
