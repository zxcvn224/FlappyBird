namespace flappybirds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grounds = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.bird = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // grounds
            // 
            this.grounds.Image = ((System.Drawing.Image)(resources.GetObject("grounds.Image")));
            this.grounds.Location = new System.Drawing.Point(-4, 582);
            this.grounds.Name = "grounds";
            this.grounds.Size = new System.Drawing.Size(658, 49);
            this.grounds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grounds.TabIndex = 2;
            this.grounds.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Black;
            this.scoreLabel.Font = new System.Drawing.Font("Vineta BT", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.ForeColor = System.Drawing.Color.Red;
            this.scoreLabel.Location = new System.Drawing.Point(52, 19);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(255, 50);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "score: 0";
            this.scoreLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Beige;
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.Location = new System.Drawing.Point(118, 201);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(145, 104);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 5;
            this.bird.TabStop = false;
            this.bird.Click += new System.EventHandler(this.bird_Click);
            this.bird.MouseEnter += new System.EventHandler(this.pictureBox5_MouseEnter);
            // 
            // pipeTop
            // 
            this.pipeTop.Image = ((System.Drawing.Image)(resources.GetObject("pipeTop.Image")));
            this.pipeTop.Location = new System.Drawing.Point(303, 0);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(114, 172);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 6;
            this.pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.BackColor = System.Drawing.Color.Transparent;
            this.pipeBottom.Image = ((System.Drawing.Image)(resources.GetObject("pipeBottom.Image")));
            this.pipeBottom.Location = new System.Drawing.Point(484, 400);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(117, 185);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 7;
            this.pipeBottom.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playAgain
            // 
            this.playAgain.BackColor = System.Drawing.Color.Black;
            this.playAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playAgain.Font = new System.Drawing.Font("Swis721 BlkEx BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playAgain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playAgain.Location = new System.Drawing.Point(303, 214);
            this.playAgain.Name = "playAgain";
            this.playAgain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.playAgain.Size = new System.Drawing.Size(273, 109);
            this.playAgain.TabIndex = 8;
            this.playAgain.Text = "Play again";
            this.playAgain.UseVisualStyleBackColor = false;
            this.playAgain.Visible = false;
            this.playAgain.Click += new System.EventHandler(this.playAgain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(654, 634);
            this.Controls.Add(this.playAgain);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.grounds);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.grounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox grounds;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button playAgain;
    }
}

