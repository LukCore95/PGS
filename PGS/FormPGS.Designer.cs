namespace PGS
{
    partial class FormPGS
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPGS));
            this.panelName = new System.Windows.Forms.Panel();
            this.buttonName = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.panelName.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelName
            // 
            this.panelName.Controls.Add(this.buttonName);
            this.panelName.Controls.Add(this.labelName);
            this.panelName.Controls.Add(this.textBoxName);
            resources.ApplyResources(this.panelName, "panelName");
            this.panelName.Name = "panelName";
            // 
            // buttonName
            // 
            resources.ApplyResources(this.buttonName, "buttonName");
            this.buttonName.Name = "buttonName";
            this.buttonName.UseVisualStyleBackColor = true;
            this.buttonName.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelName
            // 
            resources.ApplyResources(this.labelName, "labelName");
            this.labelName.Name = "labelName";
            // 
            // textBoxName
            // 
            resources.ApplyResources(this.textBoxName, "textBoxName");
            this.textBoxName.Name = "textBoxName";
            // 
            // FormPGS
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelName);
            this.Name = "FormPGS";
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Button buttonName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
    }
}

