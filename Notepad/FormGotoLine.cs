using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class FormGotoLine : Form
    {
        public int nLine;
        private int linesCount;

        public FormGotoLine(int currentLine, int linesCount)
        {
            InitializeComponent();
            txtNumRiga.Text = currentLine.ToString();
            this.linesCount = linesCount;
        }

        private void FormGotoLine_Load(object sender, EventArgs e)
        {
            txtNumRiga.Focus();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVai_Click(object sender, EventArgs e)
        {
            int.TryParse(txtNumRiga.Text, out nLine);
            if (nLine > linesCount || nLine < 1)
            {
                MessageBox.Show("Numero di riga maggiore del numero di righe totale oppure uguale a 0",
                    "Blocco note. Vai alla riga");
                txtNumRiga.Focus();
                txtNumRiga.Text = linesCount.ToString();
                txtNumRiga.SelectAll();
            } else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void txtNumRiga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                errorProviderTxtNumRiga.SetError(txtNumRiga, "Carattere non ammesso");
                e.Handled = true;
            }
            else
            {
                errorProviderTxtNumRiga.Clear();
            }
        }
    }
}
