﻿namespace Wonders_of_Space1
{
    partial class FrmBurn
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
            this.PnlGame = new System.Windows.Forms.Panel();
            this.Tmrmeteor = new System.Windows.Forms.Timer(this.components);
            this.Tmrsat = new System.Windows.Forms.Timer(this.components);
            this.Tmraircraft = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.Color.Black;
            this.PnlGame.Location = new System.Drawing.Point(12, 85);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(686, 498);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            // 
            // Tmrmeteor
            // 
            this.Tmrmeteor.Enabled = true;
            this.Tmrmeteor.Tick += new System.EventHandler(this.Tmrmeteor_Tick);
            // 
            // Tmrsat
            // 
            this.Tmrsat.Enabled = true;
            // 
            // Tmraircraft
            // 
            this.Tmraircraft.Enabled = true;
            this.Tmraircraft.Tick += new System.EventHandler(this.Tmraircraft_Tick_1);
            // 
            // FrmBurn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 636);
            this.Controls.Add(this.PnlGame);
            this.Name = "FrmBurn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmBurn_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmBurn_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Timer Tmrmeteor;
        private System.Windows.Forms.Timer Tmrsat;
        private System.Windows.Forms.Timer Tmraircraft;
    }
}

