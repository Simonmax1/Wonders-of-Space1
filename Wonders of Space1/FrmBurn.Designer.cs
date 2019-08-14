namespace Wonders_of_Space1
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
            this.score = new System.Windows.Forms.TextBox();
            this.lives = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.Color.Black;
            this.PnlGame.Location = new System.Drawing.Point(12, 85);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(640, 498);
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
            // score
            // 
            this.score.Location = new System.Drawing.Point(658, 85);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(100, 26);
            this.score.TabIndex = 1;
            this.score.TextChanged += new System.EventHandler(this.score_TextChanged);
            // 
            // lives
            // 
            this.lives.Location = new System.Drawing.Point(672, 202);
            this.lives.Name = "lives";
            this.lives.Size = new System.Drawing.Size(100, 26);
            this.lives.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(658, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lives";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(658, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Score";
            // 
            // FrmBurn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 636);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lives);
            this.Controls.Add(this.score);
            this.Controls.Add(this.PnlGame);
            this.Name = "FrmBurn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmBurn_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmBurn_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Timer Tmrmeteor;
        private System.Windows.Forms.Timer Tmrsat;
        private System.Windows.Forms.Timer Tmraircraft;
        private System.Windows.Forms.TextBox score;
        private System.Windows.Forms.TextBox lives;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

