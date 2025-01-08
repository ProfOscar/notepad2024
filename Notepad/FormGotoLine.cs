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
            //TODO: controllare che il num sia < di linesCount
        }
    }
}
