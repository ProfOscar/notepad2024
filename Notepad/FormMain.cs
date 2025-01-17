using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System.Text.RegularExpressions;
using static System.Windows.Forms.LinkLabel;
using System.Text;

namespace Notepad
{
    public partial class FormMain : Form
    {
        const string EDITED_MARK = "*";
        const string FORM_TITLE_SEPARATOR = " - ";
        const string SHORT_PROGRAM_NAME = "Blocco note";
        const string PROGRAM_NAME = "Blocco note di Windows";

        const string WIN = "Windows (CRLF)";
        const string MAC = "Macintosh (CR)";
        const string UNIX = "Unix (LF)";

        string filePath;
        string fileName;

        Encoding encoding;

        string lastSavedText;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            pageSetupDialogMain.EnableMetric = true;
            pageSetupDialogMain.Document = printDocumentMain;
            annullaToolStripMenuItem.Enabled = false;
            copiaToolStripMenuItem.Enabled = false;
            tagliaToolStripMenuItem.Enabled = false;
            eliminaToolStripMenuItem.Enabled = false;
            cercaConBingToolStripMenuItem.Enabled = false;
            Clipboard.Clear();
            acapoautomaticoToolStripMenuItem.Checked = false;
            acapoautomaticoToolStripMenuItem.CheckOnClick = true;
            rtbMain.WordWrap = false;
            rtbMain.Font = new Font("Consolas", 11, FontStyle.Regular);
            rtbMain.MouseWheel += RtbMain_MouseWheel;
            barraDistatoToolStripMenuItem.Checked = true;
            barraDistatoToolStripMenuItem.CheckOnClick = true;
            bottomStatusStrip.Visible = true;
            StatusBarWriteZoom();
            reset();
        }

        private void RtbMain_MouseWheel(object sender, MouseEventArgs e)
        {
            if ((ModifierKeys & Keys.Control) == Keys.Control)
                StatusBarWriteZoom();
        }

        private void FormMain_Activated(object sender, EventArgs e)
        {
            incollaToolStripMenuItem.Enabled = Clipboard.ContainsText() || Clipboard.ContainsImage();
        }

        private void reset()
        {
            rtbMain.Text = "";
            lastSavedText = "";
            filePath = "";
            fileName = "Senza nome";
            SetFormTitle();
            WriteLineColumnInStatusBar();
            toolStripStatusLineEnding.Text = WIN;
            encoding = Encoding.UTF8;
            toolStripStatusEncoding.Text = encoding.BodyName.ToUpper();
        }

        private void SetFormTitle(bool showEditedMark = false)
        {
            this.Text = showEditedMark ? EDITED_MARK : "";
            this.Text += fileName + FORM_TITLE_SEPARATOR + PROGRAM_NAME;
        }

        private void rtbMain_TextChanged(object sender, EventArgs e)
        {
            SetFormTitle(lastSavedText != rtbMain.Text);
            annullaToolStripMenuItem.Enabled = rtbMain.CanUndo || rtbMain.CanRedo;
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
                string lineEnding = toolStripStatusLineEnding.Text == WIN ? "\r\n" :
                    toolStripStatusLineEnding.Text == MAC ? "\r" : "\n";
                using (StreamWriter writer = new StreamWriter(percorsoFile))
                {
                    writer.Write(rtbMain.Text.Replace("\n", lineEnding));
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
            if (openFileDialogMain.ShowDialog() == DialogResult.OK)
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
                    string st = reader.ReadToEnd();

                    // scrivo il line ending sulla status bar
                    if (st.Contains("\r\n")) toolStripStatusLineEnding.Text = WIN;
                    else if (st.Contains("\r")) toolStripStatusLineEnding.Text = MAC;
                    else toolStripStatusLineEnding.Text = UNIX;

                    // scrivo l'encoding sulla status bar
                    encoding = reader.CurrentEncoding;
                    toolStripStatusEncoding.Text = encoding.BodyName.ToUpper();

                    // il RichTextBox converte sempre gli 'a capo' in '\n'
                    rtbMain.Text = st;
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

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tagliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbMain.Cut();
            incollaToolStripMenuItem.Enabled = true;
        }

        private void copiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbMain.Copy();
            incollaToolStripMenuItem.Enabled = true;
        }

        private void incollaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbMain.Paste();
        }

        private void rtbMain_SelectionChanged(object sender, EventArgs e)
        {
            copiaToolStripMenuItem.Enabled =
            tagliaToolStripMenuItem.Enabled =
            eliminaToolStripMenuItem.Enabled =
            cercaConBingToolStripMenuItem.Enabled =
            rtbMain.SelectionLength > 0;
            WriteLineColumnInStatusBar();
        }

        private void WriteLineColumnInStatusBar()
        {
            int nLine = 1, nCol = 1;
            if (rtbMain.Text.Length > 0)
            {
                string stPrevText = rtbMain.Text.Substring(0, rtbMain.SelectionStart);
                nLine = Regex.Matches(stPrevText, @"\n").Count + 1;
                nCol = rtbMain.SelectionStart - stPrevText.LastIndexOf("\n");
            }
            toolStripStatusLineColumn.Text = $"Linea {nLine}, colonna {nCol}";
        }

        private void annullaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbMain.CanRedo)
                rtbMain.Redo();
            else
                rtbMain.Undo();
        }

        private void selezionatuttoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbMain.SelectAll();
        }

        private void oraDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbMain.SelectedText = DateTime.Now.ToString("HH:mm dd/MM/yyyy");
        }

        private void acapoautomaticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbMain.WordWrap = acapoautomaticoToolStripMenuItem.Checked;
            vaiAToolStripMenuItem.Enabled = !rtbMain.WordWrap;
        }

        private void carattereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialogMain.ShowDialog() == DialogResult.OK)
                rtbMain.Font = fontDialogMain.Font;
        }

        private void barraDistatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bottomStatusStrip.Visible = barraDistatoToolStripMenuItem.Checked;
        }

        private void guidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://go.microsoft.com/fwlink/?LinkId=834783");
        }

        private void inviafeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/ProfOscar/notepad2024/issues");
        }

        private void informazionisuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBoxMain aboutBoxMain = new AboutBoxMain();
            aboutBoxMain.ShowDialog();
        }

        private void zoomAvantiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbMain.ZoomFactor < 5)
            {
                rtbMain.ZoomFactor += (float)0.1;
                StatusBarWriteZoom();
            }

        }

        private void zoomIndietroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbMain.ZoomFactor >= 0.2)
            {
                rtbMain.ZoomFactor -= 0.1f;
                StatusBarWriteZoom();
            }
        }

        private void ripristinaZoomPredefinitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbMain.ZoomFactor = 1;
            StatusBarWriteZoom();
        }

        private void StatusBarWriteZoom()
        {
            int n = (int)(rtbMain.ZoomFactor * 10);
            toolStripStatusZoom.Text = $"{n}0%";
        }

        private void vaiAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int currentLine = rtbMain.GetLineFromCharIndex(rtbMain.SelectionStart) + 1;
            int linesCount = rtbMain.Lines.Length;
            FormGotoLine frmGotoLine = new FormGotoLine(currentLine, linesCount);
            if (frmGotoLine.ShowDialog() == DialogResult.OK)
            {
                int charIndexToGo = rtbMain.GetFirstCharIndexFromLine(frmGotoLine.nLine - 1);
                rtbMain.SelectionStart = charIndexToGo;
            }
        }

        private void cercaConBingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string baseUrl = "https://www.bing.com/search?q=";
            string searchKey = rtbMain.SelectedText.Trim();
            if (searchKey.Length > 128)
                searchKey = searchKey.Substring(0, 128);
            Process.Start(baseUrl + Uri.EscapeDataString(searchKey));
        }
    }
}
