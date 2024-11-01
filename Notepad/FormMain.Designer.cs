﻿namespace Notepad
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.topMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.salvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaconnomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.stampaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impostapaginaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annullaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tagliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incollaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selezionatuttoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acapoautomaticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carattereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sommarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cercaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.informazionisuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovaFinestraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.cercaConBingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trovaSuccessivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trovaPrecedenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sostituisciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oraDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vaiAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomAvantiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomIndietroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ripristinaZoomPredefinitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // topMenu
            // 
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.modificaToolStripMenuItem,
            this.formatoToolStripMenuItem,
            this.visualizzaToolStripMenuItem,
            this.ToolStripMenuItem});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(800, 24);
            this.topMenu.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuovoToolStripMenuItem,
            this.nuovaFinestraToolStripMenuItem,
            this.apriToolStripMenuItem,
            this.toolStripSeparator,
            this.salvaToolStripMenuItem,
            this.salvaconnomeToolStripMenuItem,
            this.toolStripSeparator1,
            this.impostapaginaToolStripMenuItem,
            this.stampaToolStripMenuItem,
            this.toolStripSeparator2,
            this.esciToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // nuovoToolStripMenuItem
            // 
            this.nuovoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuovoToolStripMenuItem.Image")));
            this.nuovoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nuovoToolStripMenuItem.Name = "nuovoToolStripMenuItem";
            this.nuovoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuovoToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.nuovoToolStripMenuItem.Text = "&Nuovo";
            // 
            // apriToolStripMenuItem
            // 
            this.apriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("apriToolStripMenuItem.Image")));
            this.apriToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.apriToolStripMenuItem.Name = "apriToolStripMenuItem";
            this.apriToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.apriToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.apriToolStripMenuItem.Text = "&Apri";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(264, 6);
            // 
            // salvaToolStripMenuItem
            // 
            this.salvaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salvaToolStripMenuItem.Image")));
            this.salvaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvaToolStripMenuItem.Name = "salvaToolStripMenuItem";
            this.salvaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvaToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.salvaToolStripMenuItem.Text = "&Salva";
            // 
            // salvaconnomeToolStripMenuItem
            // 
            this.salvaconnomeToolStripMenuItem.Name = "salvaconnomeToolStripMenuItem";
            this.salvaconnomeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.salvaconnomeToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.salvaconnomeToolStripMenuItem.Text = "&Salva con nome...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(264, 6);
            // 
            // stampaToolStripMenuItem
            // 
            this.stampaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stampaToolStripMenuItem.Image")));
            this.stampaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stampaToolStripMenuItem.Name = "stampaToolStripMenuItem";
            this.stampaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.stampaToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.stampaToolStripMenuItem.Text = "S&tampa...";
            // 
            // impostapaginaToolStripMenuItem
            // 
            this.impostapaginaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("impostapaginaToolStripMenuItem.Image")));
            this.impostapaginaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.impostapaginaToolStripMenuItem.Name = "impostapaginaToolStripMenuItem";
            this.impostapaginaToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.impostapaginaToolStripMenuItem.Text = "I&mposta pagina...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(264, 6);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.esciToolStripMenuItem.Text = "&Esci";
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.annullaToolStripMenuItem,
            this.toolStripSeparator3,
            this.tagliaToolStripMenuItem,
            this.copiaToolStripMenuItem,
            this.incollaToolStripMenuItem,
            this.eliminaToolStripMenuItem,
            this.toolStripSeparator6,
            this.cercaConBingToolStripMenuItem,
            this.trovaToolStripMenuItem,
            this.trovaSuccessivoToolStripMenuItem,
            this.trovaPrecedenteToolStripMenuItem,
            this.sostituisciToolStripMenuItem,
            this.vaiAToolStripMenuItem,
            this.toolStripSeparator4,
            this.selezionatuttoToolStripMenuItem,
            this.oraDataToolStripMenuItem});
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.modificaToolStripMenuItem.Text = "&Modifica";
            // 
            // annullaToolStripMenuItem
            // 
            this.annullaToolStripMenuItem.Name = "annullaToolStripMenuItem";
            this.annullaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.annullaToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.annullaToolStripMenuItem.Text = "&Annulla";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(232, 6);
            // 
            // tagliaToolStripMenuItem
            // 
            this.tagliaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tagliaToolStripMenuItem.Image")));
            this.tagliaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tagliaToolStripMenuItem.Name = "tagliaToolStripMenuItem";
            this.tagliaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tagliaToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.tagliaToolStripMenuItem.Text = "&Taglia";
            // 
            // copiaToolStripMenuItem
            // 
            this.copiaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copiaToolStripMenuItem.Image")));
            this.copiaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiaToolStripMenuItem.Name = "copiaToolStripMenuItem";
            this.copiaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiaToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.copiaToolStripMenuItem.Text = "&Copia";
            // 
            // incollaToolStripMenuItem
            // 
            this.incollaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("incollaToolStripMenuItem.Image")));
            this.incollaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.incollaToolStripMenuItem.Name = "incollaToolStripMenuItem";
            this.incollaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.incollaToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.incollaToolStripMenuItem.Text = "I&ncolla";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(232, 6);
            // 
            // selezionatuttoToolStripMenuItem
            // 
            this.selezionatuttoToolStripMenuItem.Name = "selezionatuttoToolStripMenuItem";
            this.selezionatuttoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selezionatuttoToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.selezionatuttoToolStripMenuItem.Text = "Sele&ziona tutto";
            // 
            // formatoToolStripMenuItem
            // 
            this.formatoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acapoautomaticoToolStripMenuItem,
            this.carattereToolStripMenuItem});
            this.formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            this.formatoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.formatoToolStripMenuItem.Text = "F&ormato";
            // 
            // acapoautomaticoToolStripMenuItem
            // 
            this.acapoautomaticoToolStripMenuItem.Name = "acapoautomaticoToolStripMenuItem";
            this.acapoautomaticoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acapoautomaticoToolStripMenuItem.Text = "A capo a&utomatico";
            // 
            // carattereToolStripMenuItem
            // 
            this.carattereToolStripMenuItem.Name = "carattereToolStripMenuItem";
            this.carattereToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.carattereToolStripMenuItem.Text = "Cara&ttere...";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sommarioToolStripMenuItem,
            this.indiceToolStripMenuItem,
            this.cercaToolStripMenuItem,
            this.toolStripSeparator5,
            this.informazionisuToolStripMenuItem});
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(24, 20);
            this.ToolStripMenuItem.Text = "&?";
            // 
            // sommarioToolStripMenuItem
            // 
            this.sommarioToolStripMenuItem.Name = "sommarioToolStripMenuItem";
            this.sommarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sommarioToolStripMenuItem.Text = "&Sommario";
            // 
            // indiceToolStripMenuItem
            // 
            this.indiceToolStripMenuItem.Name = "indiceToolStripMenuItem";
            this.indiceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.indiceToolStripMenuItem.Text = "&Indice";
            // 
            // cercaToolStripMenuItem
            // 
            this.cercaToolStripMenuItem.Name = "cercaToolStripMenuItem";
            this.cercaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cercaToolStripMenuItem.Text = "&Cerca";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // informazionisuToolStripMenuItem
            // 
            this.informazionisuToolStripMenuItem.Name = "informazionisuToolStripMenuItem";
            this.informazionisuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.informazionisuToolStripMenuItem.Text = "&Informazioni su...";
            // 
            // visualizzaToolStripMenuItem
            // 
            this.visualizzaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem});
            this.visualizzaToolStripMenuItem.Name = "visualizzaToolStripMenuItem";
            this.visualizzaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.visualizzaToolStripMenuItem.Text = "&Visualizza";
            // 
            // nuovaFinestraToolStripMenuItem
            // 
            this.nuovaFinestraToolStripMenuItem.Name = "nuovaFinestraToolStripMenuItem";
            this.nuovaFinestraToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.nuovaFinestraToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.nuovaFinestraToolStripMenuItem.Text = "&Nuova finestra";
            // 
            // eliminaToolStripMenuItem
            // 
            this.eliminaToolStripMenuItem.Name = "eliminaToolStripMenuItem";
            this.eliminaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.eliminaToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.eliminaToolStripMenuItem.Text = "E&limina";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(232, 6);
            // 
            // cercaConBingToolStripMenuItem
            // 
            this.cercaConBingToolStripMenuItem.Name = "cercaConBingToolStripMenuItem";
            this.cercaConBingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.cercaConBingToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.cercaConBingToolStripMenuItem.Text = "&Cerca con Bing...";
            // 
            // trovaToolStripMenuItem
            // 
            this.trovaToolStripMenuItem.Name = "trovaToolStripMenuItem";
            this.trovaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.trovaToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.trovaToolStripMenuItem.Text = "Tr&ova...";
            // 
            // trovaSuccessivoToolStripMenuItem
            // 
            this.trovaSuccessivoToolStripMenuItem.Name = "trovaSuccessivoToolStripMenuItem";
            this.trovaSuccessivoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.trovaSuccessivoToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.trovaSuccessivoToolStripMenuItem.Text = "T&rova successivo";
            // 
            // trovaPrecedenteToolStripMenuItem
            // 
            this.trovaPrecedenteToolStripMenuItem.Name = "trovaPrecedenteToolStripMenuItem";
            this.trovaPrecedenteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
            this.trovaPrecedenteToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.trovaPrecedenteToolStripMenuItem.Text = "Trova pre&cedente";
            // 
            // sostituisciToolStripMenuItem
            // 
            this.sostituisciToolStripMenuItem.Name = "sostituisciToolStripMenuItem";
            this.sostituisciToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.sostituisciToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.sostituisciToolStripMenuItem.Text = "&Sostituisci...";
            // 
            // oraDataToolStripMenuItem
            // 
            this.oraDataToolStripMenuItem.Name = "oraDataToolStripMenuItem";
            this.oraDataToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.oraDataToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.oraDataToolStripMenuItem.Text = "Ora/&Data";
            // 
            // vaiAToolStripMenuItem
            // 
            this.vaiAToolStripMenuItem.Name = "vaiAToolStripMenuItem";
            this.vaiAToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.vaiAToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.vaiAToolStripMenuItem.Text = "&Vai a...";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomAvantiToolStripMenuItem,
            this.zoomIndietroToolStripMenuItem,
            this.ripristinaZoomPredefinitoToolStripMenuItem});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zoomToolStripMenuItem.Text = "&Zoom";
            // 
            // zoomAvantiToolStripMenuItem
            // 
            this.zoomAvantiToolStripMenuItem.Name = "zoomAvantiToolStripMenuItem";
            this.zoomAvantiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.zoomAvantiToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.zoomAvantiToolStripMenuItem.Text = "&Zoom avanti";
            // 
            // zoomIndietroToolStripMenuItem
            // 
            this.zoomIndietroToolStripMenuItem.Name = "zoomIndietroToolStripMenuItem";
            this.zoomIndietroToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.zoomIndietroToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.zoomIndietroToolStripMenuItem.Text = "&Zoom indietro";
            // 
            // ripristinaZoomPredefinitoToolStripMenuItem
            // 
            this.ripristinaZoomPredefinitoToolStripMenuItem.Name = "ripristinaZoomPredefinitoToolStripMenuItem";
            this.ripristinaZoomPredefinitoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.ripristinaZoomPredefinitoToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.ripristinaZoomPredefinitoToolStripMenuItem.Text = "&Ripristina zoom predefinito";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.topMenu);
            this.MainMenuStrip = this.topMenu;
            this.Name = "FormMain";
            this.Text = "Blocco note di Windows";
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip topMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem salvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaconnomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem stampaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impostapaginaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annullaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tagliaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incollaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selezionatuttoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acapoautomaticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carattereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sommarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cercaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem informazionisuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuovaFinestraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem cercaConBingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trovaSuccessivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trovaPrecedenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sostituisciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vaiAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oraDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomAvantiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomIndietroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ripristinaZoomPredefinitoToolStripMenuItem;
    }
}

