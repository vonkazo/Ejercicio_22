namespace Ejercicio22
{
    partial class fEuropa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEuropa));
            this.lbEuropa = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbEuropa
            // 
            this.lbEuropa.FormattingEnabled = true;
            this.lbEuropa.Location = new System.Drawing.Point(291, 82);
            this.lbEuropa.Name = "lbEuropa";
            this.lbEuropa.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbEuropa.Size = new System.Drawing.Size(214, 225);
            this.lbEuropa.TabIndex = 1;
            // 
            // fEuropa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbEuropa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fEuropa";
            this.Text = "Europa";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lbEuropa;
    }
}