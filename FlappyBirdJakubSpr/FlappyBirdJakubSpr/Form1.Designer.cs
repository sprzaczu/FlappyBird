namespace FlappyBirdJakubSpr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxFlappyBird = new System.Windows.Forms.PictureBox();
            this.pictureBoxPipeTop = new System.Windows.Forms.PictureBox();
            this.pictureBoxPipeBottom = new System.Windows.Forms.PictureBox();
            this.pictureBoxGround = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.labelScore = new System.Windows.Forms.Label();
            this.labelEndGameCredit1 = new System.Windows.Forms.Label();
            this.labelEndGameCredit2 = new System.Windows.Forms.Label();
            this.labelEndGameCredit3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGround)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFlappyBird
            // 
            this.pictureBoxFlappyBird.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFlappyBird.Image")));
            this.pictureBoxFlappyBird.Location = new System.Drawing.Point(26, 82);
            this.pictureBoxFlappyBird.Name = "pictureBoxFlappyBird";
            this.pictureBoxFlappyBird.Size = new System.Drawing.Size(43, 36);
            this.pictureBoxFlappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFlappyBird.TabIndex = 0;
            this.pictureBoxFlappyBird.TabStop = false;
            // 
            // pictureBoxPipeTop
            // 
            this.pictureBoxPipeTop.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPipeTop.Image")));
            this.pictureBoxPipeTop.Location = new System.Drawing.Point(227, 296);
            this.pictureBoxPipeTop.Name = "pictureBoxPipeTop";
            this.pictureBoxPipeTop.Size = new System.Drawing.Size(105, 366);
            this.pictureBoxPipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPipeTop.TabIndex = 1;
            this.pictureBoxPipeTop.TabStop = false;
            // 
            // pictureBoxPipeBottom
            // 
            this.pictureBoxPipeBottom.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPipeBottom.Image")));
            this.pictureBoxPipeBottom.Location = new System.Drawing.Point(178, -131);
            this.pictureBoxPipeBottom.Name = "pictureBoxPipeBottom";
            this.pictureBoxPipeBottom.Size = new System.Drawing.Size(106, 260);
            this.pictureBoxPipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPipeBottom.TabIndex = 2;
            this.pictureBoxPipeBottom.TabStop = false;
            this.pictureBoxPipeBottom.Click += new System.EventHandler(this.pictureBoxPipeBottom_Click);
            // 
            // pictureBoxGround
            // 
            this.pictureBoxGround.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGround.Image")));
            this.pictureBoxGround.Location = new System.Drawing.Point(0, 387);
            this.pictureBoxGround.Name = "pictureBoxGround";
            this.pictureBoxGround.Size = new System.Drawing.Size(332, 73);
            this.pictureBoxGround.TabIndex = 3;
            this.pictureBoxGround.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 15;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(9, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(0, 13);
            this.labelScore.TabIndex = 4;
            this.labelScore.Click += new System.EventHandler(this.labelScore_Click);
            // 
            // labelEndGameCredit1
            // 
            this.labelEndGameCredit1.AutoSize = true;
            this.labelEndGameCredit1.Location = new System.Drawing.Point(162, 179);
            this.labelEndGameCredit1.Name = "labelEndGameCredit1";
            this.labelEndGameCredit1.Size = new System.Drawing.Size(35, 13);
            this.labelEndGameCredit1.TabIndex = 5;
            this.labelEndGameCredit1.Text = "label2";
            this.labelEndGameCredit1.Visible = false;
            // 
            // labelEndGameCredit2
            // 
            this.labelEndGameCredit2.AutoSize = true;
            this.labelEndGameCredit2.Location = new System.Drawing.Point(95, 225);
            this.labelEndGameCredit2.Name = "labelEndGameCredit2";
            this.labelEndGameCredit2.Size = new System.Drawing.Size(35, 13);
            this.labelEndGameCredit2.TabIndex = 6;
            this.labelEndGameCredit2.Text = "label3";
            this.labelEndGameCredit2.Visible = false;
            // 
            // labelEndGameCredit3
            // 
            this.labelEndGameCredit3.AutoSize = true;
            this.labelEndGameCredit3.Location = new System.Drawing.Point(34, 267);
            this.labelEndGameCredit3.Name = "labelEndGameCredit3";
            this.labelEndGameCredit3.Size = new System.Drawing.Size(35, 13);
            this.labelEndGameCredit3.TabIndex = 7;
            this.labelEndGameCredit3.Text = "label4";
            this.labelEndGameCredit3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(331, 460);
            this.Controls.Add(this.labelEndGameCredit3);
            this.Controls.Add(this.labelEndGameCredit2);
            this.Controls.Add(this.labelEndGameCredit1);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.pictureBoxGround);
            this.Controls.Add(this.pictureBoxPipeBottom);
            this.Controls.Add(this.pictureBoxPipeTop);
            this.Controls.Add(this.pictureBoxFlappyBird);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InGameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InGameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFlappyBird;
        private System.Windows.Forms.PictureBox pictureBoxPipeTop;
        private System.Windows.Forms.PictureBox pictureBoxPipeBottom;
        private System.Windows.Forms.PictureBox pictureBoxGround;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelEndGameCredit1;
        private System.Windows.Forms.Label labelEndGameCredit2;
        private System.Windows.Forms.Label labelEndGameCredit3;
    }
}

