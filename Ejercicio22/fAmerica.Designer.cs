namespace Ejercicio22
{
    partial class fAmerica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAmerica));
            this.lbAmerica = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbAmerica
            // 
            this.lbAmerica.FormattingEnabled = true;
            this.lbAmerica.Location = new System.Drawing.Point(292, 89);
            this.lbAmerica.Name = "lbAmerica";
            this.lbAmerica.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbAmerica.Size = new System.Drawing.Size(214, 225);
            this.lbAmerica.TabIndex = 1;
            // 
            // fAmerica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbAmerica);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fAmerica";
            this.Text = "America";
            this.Activated += new System.EventHandler(this.fAmerica_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lbAmerica;
    }
}