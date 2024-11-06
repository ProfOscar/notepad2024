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
    public partial class FormMain : Form
    {
        const string EDITED_MARK = "*";
        const string FORM_TITLE_SEPARATOR = " - ";
        const string PROGRAM_NAME = "Blocco note di Windows";
        string fileName;

        string lastSavedText;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lastSavedText = "";
            fileName = "Senza nome";
            SetFormTitle();
        }

        private void SetFormTitle(bool showEditedMark = false)
        {
            this.Text = showEditedMark ? EDITED_MARK : "";
            this.Text += fileName + FORM_TITLE_SEPARATOR + PROGRAM_NAME;
        }

        private void rtbMain_TextChanged(object sender, EventArgs e)
        {
            SetFormTitle(lastSavedText != rtbMain.Text);
        }
    }
}
