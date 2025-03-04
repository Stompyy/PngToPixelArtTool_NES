﻿namespace PngToPixelArtTool_NES
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_Original = new System.Windows.Forms.PictureBox();
            this.pictureBox_Pixelated = new System.Windows.Forms.PictureBox();
            this.pictureBox_ClosestMatch = new System.Windows.Forms.PictureBox();
            this.pictureBox_ClosestMatchFour = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pixelated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ClosestMatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ClosestMatchFour)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1156, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fIleToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_Original, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_Pixelated, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_ClosestMatch, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_ClosestMatchFour, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1156, 467);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox_Original
            // 
            this.pictureBox_Original.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Original.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_Original.Name = "pictureBox_Original";
            this.pictureBox_Original.Size = new System.Drawing.Size(379, 227);
            this.pictureBox_Original.TabIndex = 0;
            this.pictureBox_Original.TabStop = false;
            // 
            // pictureBox_Pixelated
            // 
            this.pictureBox_Pixelated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Pixelated.Location = new System.Drawing.Point(388, 3);
            this.pictureBox_Pixelated.Name = "pictureBox_Pixelated";
            this.pictureBox_Pixelated.Size = new System.Drawing.Size(379, 227);
            this.pictureBox_Pixelated.TabIndex = 1;
            this.pictureBox_Pixelated.TabStop = false;
            // 
            // pictureBox_ClosestMatch
            // 
            this.pictureBox_ClosestMatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_ClosestMatch.Location = new System.Drawing.Point(773, 3);
            this.pictureBox_ClosestMatch.Name = "pictureBox_ClosestMatch";
            this.pictureBox_ClosestMatch.Size = new System.Drawing.Size(380, 227);
            this.pictureBox_ClosestMatch.TabIndex = 2;
            this.pictureBox_ClosestMatch.TabStop = false;
            // 
            // pictureBox_ClosestMatchFour
            // 
            this.pictureBox_ClosestMatchFour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_ClosestMatchFour.Location = new System.Drawing.Point(773, 236);
            this.pictureBox_ClosestMatchFour.Name = "pictureBox_ClosestMatchFour";
            this.pictureBox_ClosestMatchFour.Size = new System.Drawing.Size(380, 228);
            this.pictureBox_ClosestMatchFour.TabIndex = 3;
            this.pictureBox_ClosestMatchFour.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 495);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "PngToPixelArtTool_NES";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pixelated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ClosestMatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ClosestMatchFour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox_Original;
        private System.Windows.Forms.PictureBox pictureBox_Pixelated;
        private System.Windows.Forms.PictureBox pictureBox_ClosestMatch;
        private System.Windows.Forms.PictureBox pictureBox_ClosestMatchFour;
    }
}

