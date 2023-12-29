namespace Atestat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.playground = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gameover_lbl = new System.Windows.Forms.Label();
            this.points_lbl = new System.Windows.Forms.Label();
            this.score_lbl = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.racket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.BackColor = System.Drawing.Color.Green;
            this.playground.Controls.Add(this.label1);
            this.playground.Controls.Add(this.gameover_lbl);
            this.playground.Controls.Add(this.points_lbl);
            this.playground.Controls.Add(this.score_lbl);
            this.playground.Controls.Add(this.ball);
            this.playground.Controls.Add(this.racket);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(1365, 528);
            this.playground.TabIndex = 0;
            this.playground.Paint += new System.Windows.Forms.PaintEventHandler(this.playground_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(808, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 81);
            this.label1.TabIndex = 5;
            this.label1.Text = "Final score is ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameover_lbl
            // 
            this.gameover_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gameover_lbl.AutoSize = true;
            this.gameover_lbl.BackColor = System.Drawing.Color.Transparent;
            this.gameover_lbl.Location = new System.Drawing.Point(649, 138);
            this.gameover_lbl.Name = "gameover_lbl";
            this.gameover_lbl.Size = new System.Drawing.Size(495, 324);
            this.gameover_lbl.TabIndex = 4;
            this.gameover_lbl.Text = "GAME OVER\r\n\r\nESC->EXIT\r\nSPACE->RESTART";
            this.gameover_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameover_lbl.Click += new System.EventHandler(this.gameover_lbl_Click);
            // 
            // points_lbl
            // 
            this.points_lbl.AutoSize = true;
            this.points_lbl.BackColor = System.Drawing.Color.Transparent;
            this.points_lbl.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.points_lbl.Location = new System.Drawing.Point(175, 9);
            this.points_lbl.Name = "points_lbl";
            this.points_lbl.Size = new System.Drawing.Size(52, 62);
            this.points_lbl.TabIndex = 3;
            this.points_lbl.Text = "0";
            this.points_lbl.Click += new System.EventHandler(this.points_lbl_Click);
            // 
            // score_lbl
            // 
            this.score_lbl.AutoSize = true;
            this.score_lbl.BackColor = System.Drawing.Color.Transparent;
            this.score_lbl.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.score_lbl.Location = new System.Drawing.Point(12, 9);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(167, 62);
            this.score_lbl.TabIndex = 2;
            this.score_lbl.Text = "SCORE";
            this.score_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Green;
            this.ball.Image = global::Atestat.Properties.Resources.purepng1;
            this.ball.Location = new System.Drawing.Point(516, 224);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(69, 61);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            this.ball.Click += new System.EventHandler(this.ball_Click);
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.Color.Green;
            this.racket.Location = new System.Drawing.Point(538, 455);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(283, 73);
            this.racket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racket.TabIndex = 0;
            this.racket.TabStop = false;
            this.racket.Click += new System.EventHandler(this.racket_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 528);
            this.Controls.Add(this.playground);
            this.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel playground;
        private PictureBox racket;
        private PictureBox ball;
        private System.Windows.Forms.Timer timer1;
        private Label score_lbl;
        private Label points_lbl;
        private Label gameover_lbl;
        private Label label1;
    }
}