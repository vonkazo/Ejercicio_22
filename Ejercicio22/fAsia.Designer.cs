namespace Ejercicio22
{
    partial class fAsia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAsia));
            this.lbAsia = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbAsia
            // 
            this.lbAsia.FormattingEnabled = true;
            this.lbAsia.Location = new System.Drawing.Point(286, 60);
            this.lbAsia.Name = "lbAsia";
            this.lbAsia.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbAsia.Size = new System.Drawing.Size(214, 225);
            this.lbAsia.TabIndex = 0;
            // 
            // fAsia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbAsia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fAsia";
            this.Text = "Asia";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lbAsia;
    }
}