using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

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
            pageSetupDialogMain.EnableMetric = true;
            pageSetupDialogMain.Document = printDocumentMain;
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
                reset();
            }
            else
            {
                if (filePath != "")
                {
                    salvaFile(filePath);
                    reset();
                }
                else
                {
                    DialogResult result = ChiediSeSalvare();
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

        private DialogResult ChiediSeSalvare()
        {
            return MessageBox.Show(
                        $"Salvare le modifiche a {fileName}?",
                        SHORT_PROGRAM_NAME,
                        MessageBoxButtons.YesNoCancel);
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
                salvaFile(filePath);
            }
            else
            {
                salvaconnomeToolStripMenuItem_Click(sender, e);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (lastSavedText != rtbMain.Text)
            {
                DialogResult result = ChiediSeSalvare();
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
                DialogResult result = ChiediSeSalvare();
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

        private void impostapaginaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Usando RichTextBoxEx NON BISOGNA applicare le impostazioni di stampa all'oggetto PrintDocument
            /*
            if (pageSetupDialogMain.ShowDialog() == DialogResult.OK)
            {
                printDocumentMain.PrinterSettings = pageSetupDialogMain.PrinterSettings;
            }
            */
            pageSetupDialogMain.ShowDialog();
        }

        private void stampaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (printDialogMain.ShowDialog() == DialogResult.OK)
                {
                    printDocumentMain.DocumentName = fileName;
                    printDocumentMain.Print();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problemi durante la stampa.\nSe stai stampando su file verifica che il file di destinazione non sia aperto.",
                    "ATTENZIONE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int indexFirstCharOnPage;
        private void printDocumentMain_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            indexFirstCharOnPage = 0;
        }
        private void printDocumentMain_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            indexFirstCharOnPage = rtbMain.FormatRange(false, e, indexFirstCharOnPage, rtbMain.TextLength);
            e.HasMorePages = indexFirstCharOnPage < rtbMain.TextLength;
        }
        private void printDocumentMain_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            rtbMain.FormatRangeDone();
        }
    }
}
