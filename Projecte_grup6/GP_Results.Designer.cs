
namespace Projecte_grup6
{
    partial class GP_Results
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
            this.Foto_logo = new System.Windows.Forms.PictureBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.File_txt = new System.Windows.Forms.TextBox();
            this.Fichero_txt = new System.Windows.Forms.TextBox();
            this.FileSearch_btn = new System.Windows.Forms.Button();
            this.FileLoad_btn = new System.Windows.Forms.Button();
            this.OpcionesGrupo_cb = new System.Windows.Forms.ComboBox();
            this.OpcionesDatos_cb = new System.Windows.Forms.ComboBox();
            this.Excel_btn = new System.Windows.Forms.Button();
            this.Statistics_btn = new System.Windows.Forms.Button();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Append_btn = new System.Windows.Forms.Button();
            this.Informacion_txt = new System.Windows.Forms.TextBox();
            this.OrigenArxiu_ofd = new System.Windows.Forms.OpenFileDialog();
            this.Missatges_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Foto_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Foto_logo
            // 
            this.Foto_logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Foto_logo.Image = global::Projecte_grup6.Properties.Resources.formula_1_logo_200;
            this.Foto_logo.Location = new System.Drawing.Point(21, 12);
            this.Foto_logo.Name = "Foto_logo";
            this.Foto_logo.Size = new System.Drawing.Size(358, 121);
            this.Foto_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Foto_logo.TabIndex = 0;
            this.Foto_logo.TabStop = false;
            this.Foto_logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Titulo
            // 
            this.Titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(400, 47);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(356, 41);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "Grand Prix Information";
            this.Titulo.Click += new System.EventHandler(this.Titulo_Click);
            // 
            // File_txt
            // 
            this.File_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.File_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.File_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.File_txt.ForeColor = System.Drawing.Color.Black;
            this.File_txt.Location = new System.Drawing.Point(21, 144);
            this.File_txt.Name = "File_txt";
            this.File_txt.ReadOnly = true;
            this.File_txt.Size = new System.Drawing.Size(93, 17);
            this.File_txt.TabIndex = 2;
            this.File_txt.Text = "File:";
            // 
            // Fichero_txt
            // 
            this.Fichero_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Fichero_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Fichero_txt.Location = new System.Drawing.Point(68, 144);
            this.Fichero_txt.Name = "Fichero_txt";
            this.Fichero_txt.Size = new System.Drawing.Size(439, 22);
            this.Fichero_txt.TabIndex = 3;
            // 
            // FileSearch_btn
            // 
            this.FileSearch_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FileSearch_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileSearch_btn.Location = new System.Drawing.Point(529, 130);
            this.FileSearch_btn.Name = "FileSearch_btn";
            this.FileSearch_btn.Size = new System.Drawing.Size(75, 46);
            this.FileSearch_btn.TabIndex = 4;
            this.FileSearch_btn.Text = "...";
            this.FileSearch_btn.UseVisualStyleBackColor = true;
            this.FileSearch_btn.Click += new System.EventHandler(this.FileSearch_btn_Click);
            // 
            // FileLoad_btn
            // 
            this.FileLoad_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FileLoad_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileLoad_btn.Location = new System.Drawing.Point(610, 130);
            this.FileLoad_btn.Name = "FileLoad_btn";
            this.FileLoad_btn.Size = new System.Drawing.Size(178, 46);
            this.FileLoad_btn.TabIndex = 5;
            this.FileLoad_btn.Text = "Load";
            this.FileLoad_btn.UseVisualStyleBackColor = true;
            this.FileLoad_btn.Click += new System.EventHandler(this.FileLoad_btn_Click);
            // 
            // OpcionesGrupo_cb
            // 
            this.OpcionesGrupo_cb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OpcionesGrupo_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OpcionesGrupo_cb.FormattingEnabled = true;
            this.OpcionesGrupo_cb.Items.AddRange(new object[] {
            "Drivers",
            "Grand Prix",
            "Racing Team"});
            this.OpcionesGrupo_cb.Location = new System.Drawing.Point(21, 196);
            this.OpcionesGrupo_cb.Name = "OpcionesGrupo_cb";
            this.OpcionesGrupo_cb.Size = new System.Drawing.Size(218, 24);
            this.OpcionesGrupo_cb.TabIndex = 6;
            this.OpcionesGrupo_cb.SelectedIndexChanged += new System.EventHandler(this.OpcionesGrupo_cb_SelectedIndexChanged);
            // 
            // OpcionesDatos_cb
            // 
            this.OpcionesDatos_cb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OpcionesDatos_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OpcionesDatos_cb.FormattingEnabled = true;
            this.OpcionesDatos_cb.Location = new System.Drawing.Point(309, 196);
            this.OpcionesDatos_cb.Name = "OpcionesDatos_cb";
            this.OpcionesDatos_cb.Size = new System.Drawing.Size(198, 24);
            this.OpcionesDatos_cb.Sorted = true;
            this.OpcionesDatos_cb.TabIndex = 7;
            // 
            // Excel_btn
            // 
            this.Excel_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Excel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Excel_btn.Location = new System.Drawing.Point(529, 182);
            this.Excel_btn.Name = "Excel_btn";
            this.Excel_btn.Size = new System.Drawing.Size(259, 23);
            this.Excel_btn.TabIndex = 8;
            this.Excel_btn.Text = "Saves as CSV";
            this.Excel_btn.UseVisualStyleBackColor = true;
            // 
            // Statistics_btn
            // 
            this.Statistics_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Statistics_btn.BackColor = System.Drawing.Color.White;
            this.Statistics_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statistics_btn.Location = new System.Drawing.Point(524, 369);
            this.Statistics_btn.Name = "Statistics_btn";
            this.Statistics_btn.Size = new System.Drawing.Size(264, 35);
            this.Statistics_btn.TabIndex = 9;
            this.Statistics_btn.Text = "Statistics";
            this.Statistics_btn.UseVisualStyleBackColor = false;
            // 
            // Search_btn
            // 
            this.Search_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_btn.Location = new System.Drawing.Point(524, 239);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(124, 35);
            this.Search_btn.TabIndex = 10;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Append_btn
            // 
            this.Append_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Append_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Append_btn.Location = new System.Drawing.Point(654, 239);
            this.Append_btn.Name = "Append_btn";
            this.Append_btn.Size = new System.Drawing.Size(134, 35);
            this.Append_btn.TabIndex = 11;
            this.Append_btn.Text = "Append";
            this.Append_btn.UseVisualStyleBackColor = true;
            // 
            // Informacion_txt
            // 
            this.Informacion_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Informacion_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Informacion_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Informacion_txt.Location = new System.Drawing.Point(21, 243);
            this.Informacion_txt.Multiline = true;
            this.Informacion_txt.Name = "Informacion_txt";
            this.Informacion_txt.ReadOnly = true;
            this.Informacion_txt.Size = new System.Drawing.Size(486, 161);
            this.Informacion_txt.TabIndex = 12;
            this.Informacion_txt.Text = "Information";
            this.Informacion_txt.TextChanged += new System.EventHandler(this.Informacion_txt_TextChanged);
            // 
            // OrigenArxiu_ofd
            // 
            this.OrigenArxiu_ofd.FileName = "openFileDialog1";
            this.OrigenArxiu_ofd.FileOk += new System.ComponentModel.CancelEventHandler(this.OrigenArxiu_ofd_FileOk);
            // 
            // Missatges_lbl
            // 
            this.Missatges_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Missatges_lbl.AutoSize = true;
            this.Missatges_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Missatges_lbl.Location = new System.Drawing.Point(21, 422);
            this.Missatges_lbl.Name = "Missatges_lbl";
            this.Missatges_lbl.Size = new System.Drawing.Size(33, 19);
            this.Missatges_lbl.TabIndex = 13;
            this.Missatges_lbl.Text = "uyb";
            this.Missatges_lbl.Click += new System.EventHandler(this.Missatges_lbl_Click);
            // 
            // GP_Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Missatges_lbl);
            this.Controls.Add(this.Informacion_txt);
            this.Controls.Add(this.Append_btn);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.Statistics_btn);
            this.Controls.Add(this.Excel_btn);
            this.Controls.Add(this.OpcionesDatos_cb);
            this.Controls.Add(this.OpcionesGrupo_cb);
            this.Controls.Add(this.FileLoad_btn);
            this.Controls.Add(this.FileSearch_btn);
            this.Controls.Add(this.Fichero_txt);
            this.Controls.Add(this.File_txt);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.Foto_logo);
            this.Name = "GP_Results";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GP_Results_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Foto_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Foto_logo;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox File_txt;
        private System.Windows.Forms.TextBox Fichero_txt;
        private System.Windows.Forms.Button FileSearch_btn;
        private System.Windows.Forms.Button FileLoad_btn;
        private System.Windows.Forms.ComboBox OpcionesGrupo_cb;
        private System.Windows.Forms.ComboBox OpcionesDatos_cb;
        private System.Windows.Forms.Button Excel_btn;
        private System.Windows.Forms.Button Statistics_btn;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button Append_btn;
        private System.Windows.Forms.TextBox Informacion_txt;
        private System.Windows.Forms.OpenFileDialog OrigenArxiu_ofd;
        private System.Windows.Forms.Label Missatges_lbl;
    }
}