﻿
namespace Projecte_grup6
{
    partial class principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.llistatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unAltreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.llistatsToolStripMenuItem,
            this.unAltreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // llistatsToolStripMenuItem
            // 
            this.llistatsToolStripMenuItem.Name = "llistatsToolStripMenuItem";
            this.llistatsToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.llistatsToolStripMenuItem.Text = "Llistats";
            this.llistatsToolStripMenuItem.Click += new System.EventHandler(this.llistatsToolStripMenuItem_Click);
            // 
            // unAltreToolStripMenuItem
            // 
            this.unAltreToolStripMenuItem.Name = "unAltreToolStripMenuItem";
            this.unAltreToolStripMenuItem.Size = new System.Drawing.Size(41, 24);
            this.unAltreToolStripMenuItem.Text = "GP";
            this.unAltreToolStripMenuItem.Click += new System.EventHandler(this.unAltreToolStripMenuItem_Click);
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 608);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "principal";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem llistatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unAltreToolStripMenuItem;
    }
}