
namespace Projecte_grup6
{
    partial class llistats
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReportLlistes = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.frmllistats = new System.Windows.Forms.ComboBox();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReportLlistes
            // 
            this.ReportLlistes.ActiveViewIndex = -1;
            this.ReportLlistes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportLlistes.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReportLlistes.Location = new System.Drawing.Point(12, 56);
            this.ReportLlistes.Name = "ReportLlistes";
            this.ReportLlistes.Size = new System.Drawing.Size(1535, 528);
            this.ReportLlistes.TabIndex = 0;
            // 
            // frmllistats
            // 
            this.frmllistats.FormattingEnabled = true;
            this.frmllistats.Items.AddRange(new object[] {
            "ex1.rpt",
            "ex2.rpt",
            "ex3.rpt"});
            this.frmllistats.Location = new System.Drawing.Point(12, 26);
            this.frmllistats.Name = "frmllistats";
            this.frmllistats.Size = new System.Drawing.Size(298, 24);
            this.frmllistats.TabIndex = 1;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(316, 20);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(115, 34);
            this.button.TabIndex = 2;
            this.button.Text = "Veure llistats";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 590);
            this.Controls.Add(this.button);
            this.Controls.Add(this.frmllistats);
            this.Controls.Add(this.ReportLlistes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReportLlistes;
        private System.Windows.Forms.ComboBox frmllistats;
        private System.Windows.Forms.Button button;
        //private Llistats Llistats1;
    }
}

