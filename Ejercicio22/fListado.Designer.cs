namespace Ejercicio22
{
    partial class fListado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fListado));
            this.lbListado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbListado
            // 
            this.lbListado.FormattingEnabled = true;
            this.lbListado.Location = new System.Drawing.Point(287, 52);
            this.lbListado.Name = "lbListado";
            this.lbListado.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbListado.Size = new System.Drawing.Size(205, 212);
            this.lbListado.TabIndex = 0;
            // 
            // fListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbListado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fListado";
            this.Text = "Listado";
            this.Activated += new System.EventHandler(this.fListado_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lbListado;
    }
}