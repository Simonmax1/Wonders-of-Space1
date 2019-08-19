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
            this.username = new System.Windows.Forms.TextBox();
            this.startbtn = new System.Windows.Forms.Button();
            this.TmrBullet = new System.Windows.Forms.Timer(this.components);
            this.level = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.Color.Transparent;
            this.PnlGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlGame.Location = new System.Drawing.Point(12, 12);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(551, 472);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            // 
            // Tmrmeteor
            // 
            this.Tmrmeteor.Interval = 10;
            this.Tmrmeteor.Tick += new System.EventHandler(this.Tmrmeteor_Tick);
            // 
            // Tmrsat
            // 
            this.Tmrsat.Tick += new System.EventHandler(this.Tmrsat_Tick_1);
            // 
            // Tmraircraft
            // 
            this.Tmraircraft.Tick += new System.EventHandler(this.Tmraircraft_Tick_1);
            // 
            // score
            // 
            this.score.Enabled = false;
            this.score.Location = new System.Drawing.Point(638, 82);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(100, 26);
            this.score.TabIndex = 1;
            this.score.Text = "0";
            this.score.TextChanged += new System.EventHandler(this.score_TextChanged);
            // 
            // lives
            // 
            this.lives.Enabled = false;
            this.lives.Location = new System.Drawing.Point(638, 184);
            this.lives.Name = "lives";
            this.lives.Size = new System.Drawing.Size(100, 26);
            this.lives.TabIndex = 2;
            this.lives.Text = "20";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(657, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lives";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(657, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Score";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(638, 340);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 26);
            this.username.TabIndex = 5;
            // 
            // startbtn
            // 
            this.startbtn.BackColor = System.Drawing.Color.Gold;
            this.startbtn.Location = new System.Drawing.Point(638, 420);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(127, 32);
            this.startbtn.TabIndex = 6;
            this.startbtn.Text = "Start Game";
            this.startbtn.UseVisualStyleBackColor = false;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // TmrBullet
            // 
            this.TmrBullet.Enabled = true;
            this.TmrBullet.Tick += new System.EventHandler(this.TmrBullet_Tick);
            // 
            // level
            // 
            this.level.Enabled = false;
            this.level.Location = new System.Drawing.Point(638, 267);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(100, 26);
            this.level.TabIndex = 7;
            this.level.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(657, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(645, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "User Name:";
            // 
            // FrmBurn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Wonders_of_Space1.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(799, 522);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.level);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.username);
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
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Timer TmrBullet;
        private System.Windows.Forms.TextBox level;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

