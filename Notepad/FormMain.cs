using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

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
                reset();
            }
            else
            {
                // contenuti da salvare
                if (filePath != "")
                {
                    // file esistente, uso quello
                    salvaFile(filePath);
                    reset();
                }
                else
                {
                    // file nuovo: dialog per l'utente
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
                filePath = percorsoFile;
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

        private void salvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filePath != "")
            {
                // file già esistente
                salvaFile(filePath);
            }
            else
            {
                // file nuovo (diventa un salva con nome)
                salvaconnomeToolStripMenuItem_Click(sender, e);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (lastSavedText != rtbMain.Text)
            {
                DialogResult result = MessageBox.Show(
                    $"Salvare le modifiche a {fileName}?",
                    SHORT_PROGRAM_NAME,
                    MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (filePath != "")
                        salvaFile(filePath);
                    else
                    {
                        if (saveFileDialogMain.ShowDialog() == DialogResult.OK)
                            salvaFile(saveFileDialogMain.FileName);
                        else
                            e.Cancel = true;
                    }
                }
                else if (result == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void nuovaFinestraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Application.ExecutablePath);
        }

        private void apriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lastSavedText != rtbMain.Text)
            {
                DialogResult result = MessageBox.Show(
                    $"Salvare le modifiche a {fileName}?",
                    SHORT_PROGRAM_NAME,
                    MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (filePath != "")
                        salvaFile(filePath);
                    else
                    {
                        DialogResult saveFileDialogResult = saveFileDialogMain.ShowDialog();
                        if (saveFileDialogResult == DialogResult.OK)
                            salvaFile(saveFileDialogMain.FileName);
                        else if (saveFileDialogResult == DialogResult.Cancel)
                            return;
                    }
                }
                else if (result == DialogResult.Cancel)
                    return;
            }
            openFileDialogMain.FileName = "";
            if (openFileDialogMain.ShowDialog()== DialogResult.OK)
            {
                apriFile(openFileDialogMain.FileName);
            }
        }

        private void apriFile(string percorsoFile)
        {
            try
            {
                using (StreamReader reader = new StreamReader(percorsoFile))
                {
                    rtbMain.Text = reader.ReadToEnd();
                }
                filePath = percorsoFile;
                fileName = Path.GetFileName(filePath);
                lastSavedText = rtbMain.Text;
                SetFormTitle();
            }
            catch (Exception)
            {
                MessageBox.Show("Problemi durante l'apertura del documento",
                    "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
