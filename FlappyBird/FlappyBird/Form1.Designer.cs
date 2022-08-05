namespace FlappyBird
{
    partial class Form1
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
            this.bird = new System.Windows.Forms.PictureBox();
            this.pipeUp = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeDown = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pipeDown2 = new System.Windows.Forms.PictureBox();
            this.pipeDown3 = new System.Windows.Forms.PictureBox();
            this.pipeUp3 = new System.Windows.Forms.PictureBox();
            this.pipeUp2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp2)).BeginInit();
            this.SuspendLayout();
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Aqua;
            this.bird.BackgroundImage = global::FlappyBird.Properties.Resources.bird;
            this.bird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bird.Location = new System.Drawing.Point(90, 394);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(110, 78);
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // pipeUp
            // 
            this.pipeUp.BackgroundImage = global::FlappyBird.Properties.Resources.pipe;
            this.pipeUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipeUp.Location = new System.Drawing.Point(467, 609);
            this.pipeUp.Name = "pipeUp";
            this.pipeUp.Size = new System.Drawing.Size(172, 205);
            this.pipeUp.TabIndex = 1;
            this.pipeUp.TabStop = false;
            // 
            // ground
            // 
            this.ground.BackgroundImage = global::FlappyBird.Properties.Resources.ground;
            this.ground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ground.Location = new System.Drawing.Point(-1, 806);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1855, 94);
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // pipeDown
            // 
            this.pipeDown.BackgroundImage = global::FlappyBird.Properties.Resources.pipedown;
            this.pipeDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipeDown.Location = new System.Drawing.Point(467, -53);
            this.pipeDown.Name = "pipeDown";
            this.pipeDown.Size = new System.Drawing.Size(172, 398);
            this.pipeDown.TabIndex = 3;
            this.pipeDown.TabStop = false;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Black;
            this.Score.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Score.Location = new System.Drawing.Point(237, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(27, 31);
            this.Score.TabIndex = 4;
            this.Score.Text = " ";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // pipeDown2
            // 
            this.pipeDown2.BackgroundImage = global::FlappyBird.Properties.Resources.pipedown;
            this.pipeDown2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipeDown2.Location = new System.Drawing.Point(903, -164);
            this.pipeDown2.Name = "pipeDown2";
            this.pipeDown2.Size = new System.Drawing.Size(172, 398);
            this.pipeDown2.TabIndex = 5;
            this.pipeDown2.TabStop = false;
            // 
            // pipeDown3
            // 
            this.pipeDown3.BackgroundImage = global::FlappyBird.Properties.Resources.pipedown;
            this.pipeDown3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipeDown3.Location = new System.Drawing.Point(1454, -63);
            this.pipeDown3.Name = "pipeDown3";
            this.pipeDown3.Size = new System.Drawing.Size(172, 376);
            this.pipeDown3.TabIndex = 6;
            this.pipeDown3.TabStop = false;
            // 
            // pipeUp3
            // 
            this.pipeUp3.BackgroundImage = global::FlappyBird.Properties.Resources.pipe;
            this.pipeUp3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipeUp3.Location = new System.Drawing.Point(1611, 574);
            this.pipeUp3.Name = "pipeUp3";
            this.pipeUp3.Size = new System.Drawing.Size(172, 271);
            this.pipeUp3.TabIndex = 7;
            this.pipeUp3.TabStop = false;
            // 
            // pipeUp2
            // 
            this.pipeUp2.BackgroundImage = global::FlappyBird.Properties.Resources.pipe;
            this.pipeUp2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipeUp2.Location = new System.Drawing.Point(1047, 519);
            this.pipeUp2.Name = "pipeUp2";
            this.pipeUp2.Size = new System.Drawing.Size(172, 355);
            this.pipeUp2.TabIndex = 8;
            this.pipeUp2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1856, 893);
            this.Controls.Add(this.pipeDown3);
            this.Controls.Add(this.pipeDown2);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.pipeDown);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeUp);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.pipeUp2);
            this.Controls.Add(this.pipeUp3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipeUp;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipeDown;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pipeDown2;
        private System.Windows.Forms.PictureBox pipeDown3;
        private System.Windows.Forms.PictureBox pipeUp3;
        private System.Windows.Forms.PictureBox pipeUp2;
    }
}

