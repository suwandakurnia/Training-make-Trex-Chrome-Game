namespace TREX_Google_Chrome
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
            this.Floor = new System.Windows.Forms.PictureBox();
            this.TRex = new System.Windows.Forms.PictureBox();
            this.Obstacle1 = new System.Windows.Forms.PictureBox();
            this.Obstacle2 = new System.Windows.Forms.PictureBox();
            this.ScoreText = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle2)).BeginInit();
            this.SuspendLayout();
            // 
            // Floor
            // 
            this.Floor.BackColor = System.Drawing.Color.Black;
            this.Floor.Location = new System.Drawing.Point(-12, 452);
            this.Floor.Name = "Floor";
            this.Floor.Size = new System.Drawing.Size(652, 50);
            this.Floor.TabIndex = 0;
            this.Floor.TabStop = false;
            // 
            // TRex
            // 
            this.TRex.Image = global::TREX_Google_Chrome.Properties.Resources.running;
            this.TRex.Location = new System.Drawing.Point(131, 385);
            this.TRex.Name = "TRex";
            this.TRex.Size = new System.Drawing.Size(44, 60);
            this.TRex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TRex.TabIndex = 1;
            this.TRex.TabStop = false;
            // 
            // Obstacle1
            // 
            this.Obstacle1.Image = global::TREX_Google_Chrome.Properties.Resources.obstacle_1;
            this.Obstacle1.Location = new System.Drawing.Point(371, 405);
            this.Obstacle1.Name = "Obstacle1";
            this.Obstacle1.Size = new System.Drawing.Size(23, 46);
            this.Obstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Obstacle1.TabIndex = 2;
            this.Obstacle1.TabStop = false;
            this.Obstacle1.Tag = "Obstacle";
            // 
            // Obstacle2
            // 
            this.Obstacle2.Image = global::TREX_Google_Chrome.Properties.Resources.obstacle_2;
            this.Obstacle2.Location = new System.Drawing.Point(534, 400);
            this.Obstacle2.Name = "Obstacle2";
            this.Obstacle2.Size = new System.Drawing.Size(50, 50);
            this.Obstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Obstacle2.TabIndex = 3;
            this.Obstacle2.TabStop = false;
            this.Obstacle2.Tag = "Obstacle";
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreText.Location = new System.Drawing.Point(13, 13);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(86, 24);
            this.ScoreText.TabIndex = 4;
            this.ScoreText.Text = "Score- 0";
            this.ScoreText.Click += new System.EventHandler(this.ScoreText_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(618, 475);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.Obstacle2);
            this.Controls.Add(this.Obstacle1);
            this.Controls.Add(this.TRex);
            this.Controls.Add(this.Floor);
            this.Name = "Form1";
            this.Text = "TREX Google Chrome";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Floor;
        private System.Windows.Forms.PictureBox TRex;
        private System.Windows.Forms.PictureBox Obstacle1;
        private System.Windows.Forms.PictureBox Obstacle2;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Timer GameTimer;
    }
}

