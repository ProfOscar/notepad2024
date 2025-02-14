using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    static class FindReplaceService
    {
        public static RichTextBox Target;

        public struct Parameters
        {
            public static string TextToFind = "";
            public static string TextToReplace = "";
            public static bool IsUp = false;
            public static bool IsCaseSensitive = false;
            public static bool IsWholeWord = false;
        }

        /// <summary>
        /// Cerca il parametro TextToFind all'interno del RichTextBox Target
        /// </summary>
        /// <returns>La posizione del testo trovato, oppure -1 se non trovato</returns>
        public static int Find()
        {
            int start = 0;
            int end = Target.TextLength;
            RichTextBoxFinds options = RichTextBoxFinds.None;
            if (Parameters.IsUp)
            {
                options |= RichTextBoxFinds.Reverse;
                end = Target.SelectionStart;
                if (end == 0) return -1;
            }
            else
            {
                start = Target.SelectionStart + Target.SelectionLength;
                if (start >= end) return -1;
            }
            if (Parameters.IsCaseSensitive) { options |= RichTextBoxFinds.MatchCase; }
            if (Parameters.IsWholeWord) { options |= RichTextBoxFinds.WholeWord; }
            Target.Focus();
            return Target.Find(Parameters.TextToFind, start, end, options);
        }

        /// <summary>
        /// Cerca il parametro TextToFind all'interno del RichTextBox Target e lo sostituisce con TextToReplace
        /// </summary>
        /// <returns>La posizione del testo trovato, oppure -1 se non trovato</returns>
        public static int Replace()
        {
            StringComparison comparison = Parameters.IsCaseSensitive ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase;
            int stComp = String.Compare(Target.SelectedText, Parameters.TextToFind, comparison);
            if (stComp == 0) Target.SelectedText = Parameters.TextToReplace;
            return Find();
        }

        /// <summary>
        /// Cerca tutte le occorrenze del parametro TextToFind all'interno del RichTextBox Target e le sostituisce con TextToReplace
        /// </summary>
        public static void ReplaceAll()
        {
            RegexOptions options = !Parameters.IsCaseSensitive ? RegexOptions.IgnoreCase : RegexOptions.None;
            Target.Text = Regex.Replace(Target.Text, Parameters.TextToFind, Parameters.TextToReplace, options);
        }

        /// <summary>
        /// Mostra una MessageBox ben formattata per comunicare che il testo cercato non è presente
        /// </summary>
        public static void ShowNotFoundMessageBox()
        {
            MessageBox.Show(
                    $"Impossibile trovare \"{FindReplaceService.Parameters.TextToFind}\"",
                    "Blocco note",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
        }
    }
}
