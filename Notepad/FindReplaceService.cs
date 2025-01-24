using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            //TODO
            return -1;
        }

        /// <summary>
        /// Cerca il parametro TextToFind all'interno del RichTextBox Target e lo sostituisce con TextToReplace
        /// </summary>
        /// <returns>La posizione del testo trovato, oppure -1 se non trovato</returns>
        public static int Replace()
        {
            //TODO
            return -1;
        }

        /// <summary>
        /// Cerca tutte le occorrenze del parametro TextToFind all'interno del RichTextBox Target e le sostituisce con TextToReplace
        /// </summary>
        /// <returns>True se ci sono state sostituzioni, altrimenti false</returns>
        public static bool ReplaceAll()
        {
            return false;
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
