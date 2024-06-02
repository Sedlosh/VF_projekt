namespace VF_projekt
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.player = new System.Windows.Forms.PictureBox();
            this.award = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.AI1 = new System.Windows.Forms.PictureBox();
            this.AI2 = new System.Windows.Forms.PictureBox();
            this.floor1 = new System.Windows.Forms.PictureBox();
            this.floor2 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.scoreBoard = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.award);
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.AI1);
            this.panel1.Controls.Add(this.AI2);
            this.panel1.Controls.Add(this.floor1);
            this.panel1.Controls.Add(this.floor2);
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 543);
            this.panel1.TabIndex = 0;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = global::VF_projekt.Properties.Resources.pokusOTransparentnost;
            this.player.Cursor = System.Windows.Forms.Cursors.Default;
            this.player.Image = global::VF_projekt.Properties.Resources.hazmat;
            this.player.InitialImage = null;
            this.player.Location = new System.Drawing.Point(427, 432);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(45, 98);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.player.TabIndex = 3;
            this.player.TabStop = false;
            // 
            // award
            // 
            this.award.Image = global::VF_projekt.Properties.Resources.bronze;
            this.award.Location = new System.Drawing.Point(109, 213);
            this.award.Name = "award";
            this.award.Size = new System.Drawing.Size(250, 100);
            this.award.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.award.TabIndex = 4;
            this.award.TabStop = false;
            // 
            // explosion
            // 
            this.explosion.Image = global::VF_projekt.Properties.Resources.explosion;
            this.explosion.Location = new System.Drawing.Point(100, 383);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(50, 50);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.explosion.TabIndex = 4;
            this.explosion.TabStop = false;
            // 
            // AI1
            // 
            this.AI1.BackColor = System.Drawing.Color.Transparent;
            this.AI1.BackgroundImage = global::VF_projekt.Properties.Resources.pokusOTransparentnost;
            this.AI1.Image = global::VF_projekt.Properties.Resources.radiace_final;
            this.AI1.Location = new System.Drawing.Point(109, 123);
            this.AI1.Name = "AI1";
            this.AI1.Size = new System.Drawing.Size(42, 42);
            this.AI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AI1.TabIndex = 4;
            this.AI1.TabStop = false;
            this.AI1.Tag = "radiationLeft";
            // 
            // AI2
            // 
            this.AI2.BackColor = System.Drawing.Color.Transparent;
            this.AI2.BackgroundImage = global::VF_projekt.Properties.Resources.pokusOTransparentnost;
            this.AI2.Image = global::VF_projekt.Properties.Resources.radiace_final;
            this.AI2.Location = new System.Drawing.Point(317, 123);
            this.AI2.Name = "AI2";
            this.AI2.Size = new System.Drawing.Size(42, 42);
            this.AI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AI2.TabIndex = 4;
            this.AI2.TabStop = false;
            this.AI2.Tag = "radiationRight";
            // 
            // floor1
            // 
            this.floor1.Image = global::VF_projekt.Properties.Resources.xxxx;
            this.floor1.Location = new System.Drawing.Point(0, -500);
            this.floor1.Name = "floor1";
            this.floor1.Size = new System.Drawing.Size(475, 643);
            this.floor1.TabIndex = 3;
            this.floor1.TabStop = false;
            // 
            // floor2
            // 
            this.floor2.Image = global::VF_projekt.Properties.Resources.xxxx;
            this.floor2.Location = new System.Drawing.Point(0, 0);
            this.floor2.Name = "floor2";
            this.floor2.Size = new System.Drawing.Size(475, 643);
            this.floor2.TabIndex = 1;
            this.floor2.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.Location = new System.Drawing.Point(199, 586);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(97, 42);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.restart);
            // 
            // scoreBoard
            // 
            this.scoreBoard.BackColor = System.Drawing.Color.White;
            this.scoreBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreBoard.Location = new System.Drawing.Point(12, 545);
            this.scoreBoard.Name = "scoreBoard";
            this.scoreBoard.Size = new System.Drawing.Size(475, 38);
            this.scoreBoard.TabIndex = 1;
            this.scoreBoard.Text = "Score: 0";
            this.scoreBoard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.scoreBoard.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(14, 653);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(473, 119);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pohybujte se šipkami vlevo a vpravo.\r\n\r\nVyhýbejte se radiaci a přežijte co nejdél" +
    "e to zvládnete.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(499, 781);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scoreBoard);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Hra pro VF";
            this.TransparencyKey = System.Drawing.Color.Purple;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label scoreBoard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox floor1;
        private System.Windows.Forms.PictureBox AI2;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox AI1;
        private System.Windows.Forms.PictureBox award;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox floor2;
    }
}

