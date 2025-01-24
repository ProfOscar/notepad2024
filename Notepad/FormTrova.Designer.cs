namespace Notepad
{
    partial class FormTrova
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDirezione = new System.Windows.Forms.GroupBox();
            this.rdbSu = new System.Windows.Forms.RadioButton();
            this.rdbGiu = new System.Windows.Forms.RadioButton();
            this.gbDirezione.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDirezione
            // 
            this.gbDirezione.Controls.Add(this.rdbGiu);
            this.gbDirezione.Controls.Add(this.rdbSu);
            this.gbDirezione.Location = new System.Drawing.Point(186, 52);
            this.gbDirezione.Name = "gbDirezione";
            this.gbDirezione.Size = new System.Drawing.Size(136, 70);
            this.gbDirezione.TabIndex = 6;
            this.gbDirezione.TabStop = false;
            this.gbDirezione.Text = "Direzione";
            // 
            // rdbSu
            // 
            this.rdbSu.AutoSize = true;
            this.rdbSu.Location = new System.Drawing.Point(7, 26);
            this.rdbSu.Name = "rdbSu";
            this.rdbSu.Size = new System.Drawing.Size(54, 24);
            this.rdbSu.TabIndex = 0;
            this.rdbSu.Text = "Su";
            this.rdbSu.UseVisualStyleBackColor = true;
            // 
            // rdbGiu
            // 
            this.rdbGiu.AutoSize = true;
            this.rdbGiu.Checked = true;
            this.rdbGiu.Location = new System.Drawing.Point(68, 25);
            this.rdbGiu.Name = "rdbGiu";
            this.rdbGiu.Size = new System.Drawing.Size(59, 24);
            this.rdbGiu.TabIndex = 1;
            this.rdbGiu.TabStop = true;
            this.rdbGiu.Text = "Giù";
            this.rdbGiu.UseVisualStyleBackColor = true;
            // 
            // FormTrova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(525, 183);
            this.Controls.Add(this.gbDirezione);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "FormTrova";
            this.Text = "Trova";
            this.Load += new System.EventHandler(this.FormTrova_Load);
            this.Controls.SetChildIndex(this.gbDirezione, 0);
            this.gbDirezione.ResumeLayout(false);
            this.gbDirezione.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDirezione;
        private System.Windows.Forms.RadioButton rdbGiu;
        private System.Windows.Forms.RadioButton rdbSu;
    }
}
