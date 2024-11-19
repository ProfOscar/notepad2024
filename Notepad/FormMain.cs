using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        const string SHORT_PROGRAM_NAME = "Blocco note";
        const string PROGRAM_NAME = "Blocco note di Windows";

        string filePath;
        string fileName;

        string lastSavedText;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            rtbMain.Text = "";
            lastSavedText = "";
            filePath = "";
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

        private void nuovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lastSavedText == rtbMain.Text)
            {
                // non c'è nulla da salvare
                rtbMain.Text = "";
            }
            else
            {
                // contenuti da salvare: dialog per l'utente
                DialogResult result = MessageBox.Show(
                    $"Salvare le modifiche a {fileName}?",
                    SHORT_PROGRAM_NAME,
                    MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (saveFileDialogMain.ShowDialog() == DialogResult.OK)
                    {
                        salvaFile(saveFileDialogMain.FileName);
                        reset();
                    }
                }
                else if (result == DialogResult.No)
                {
                    reset();
                }
            }
        }

        private void salvaconnomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                salvaFile(saveFileDialogMain.FileName);
            }
        }

        private void salvaFile(string percorsoFile)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(percorsoFile))
                {
                    writer.Write(rtbMain.Text);
                }
                filePath = saveFileDialogMain.FileName;
                fileName = Path.GetFileName(filePath);
                lastSavedText = rtbMain.Text;
                SetFormTitle();
            }
            catch (Exception)
            {
                MessageBox.Show("Problemi durante il salvataggio del documento",
                    "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
