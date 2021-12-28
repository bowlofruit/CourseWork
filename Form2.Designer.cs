
namespace BallGame
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.endgame = new System.Windows.Forms.PictureBox();
            this.reward0 = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.logleft = new System.Windows.Forms.PictureBox();
            this.logup = new System.Windows.Forms.PictureBox();
            this.logright = new System.Windows.Forms.PictureBox();
            this.addleftup = new System.Windows.Forms.Button();
            this.addup = new System.Windows.Forms.Button();
            this.addrightup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.endgame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reward0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logright)).BeginInit();
            this.SuspendLayout();
            // 
            // endgame
            // 
            this.endgame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.endgame.BackColor = System.Drawing.Color.Transparent;
            this.endgame.Location = new System.Drawing.Point(1136, 609);
            this.endgame.Name = "endgame";
            this.endgame.Size = new System.Drawing.Size(144, 112);
            this.endgame.TabIndex = 4;
            this.endgame.TabStop = false;
            // 
            // reward0
            // 
            this.reward0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reward0.BackColor = System.Drawing.Color.Transparent;
            this.reward0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.reward0.Image = ((System.Drawing.Image)(resources.GetObject("reward0.Image")));
            this.reward0.Location = new System.Drawing.Point(3000, 277);
            this.reward0.Name = "reward0";
            this.reward0.Size = new System.Drawing.Size(79, 77);
            this.reward0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reward0.TabIndex = 2;
            this.reward0.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
            this.ball.Location = new System.Drawing.Point(40, 10);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(64, 64);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // logleft
            // 
            this.logleft.BackColor = System.Drawing.Color.Transparent;
            this.logleft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logleft.Image = global::BallGame.Properties.Resources.logleft;
            this.logleft.Location = new System.Drawing.Point(2000, 323);
            this.logleft.Name = "logleft";
            this.logleft.Size = new System.Drawing.Size(170, 170);
            this.logleft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logleft.TabIndex = 9;
            this.logleft.TabStop = false;
            // 
            // logup
            // 
            this.logup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logup.BackColor = System.Drawing.Color.Transparent;
            this.logup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logup.Image = global::BallGame.Properties.Resources.loghor;
            this.logup.Location = new System.Drawing.Point(2000, -4);
            this.logup.Name = "logup";
            this.logup.Size = new System.Drawing.Size(170, 55);
            this.logup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logup.TabIndex = 5;
            this.logup.TabStop = false;
            this.logup.Visible = false;
            // 
            // logright
            // 
            this.logright.BackColor = System.Drawing.Color.Transparent;
            this.logright.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logright.Image = global::BallGame.Properties.Resources.logright;
            this.logright.Location = new System.Drawing.Point(2000, 323);
            this.logright.Name = "logright";
            this.logright.Size = new System.Drawing.Size(170, 170);
            this.logright.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logright.TabIndex = 10;
            this.logright.TabStop = false;
            // 
            // addleftup
            // 
            this.addleftup.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addleftup.BackColor = System.Drawing.Color.ForestGreen;
            this.addleftup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.addleftup.ForeColor = System.Drawing.Color.DarkGreen;
            this.addleftup.Location = new System.Drawing.Point(873, 653);
            this.addleftup.Name = "addleftup";
            this.addleftup.Size = new System.Drawing.Size(36, 30);
            this.addleftup.TabIndex = 11;
            this.addleftup.Text = "+";
            this.addleftup.UseVisualStyleBackColor = false;
            this.addleftup.Click += new System.EventHandler(this.button_AddLeftUpReflector);
            // 
            // addup
            // 
            this.addup.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addup.BackColor = System.Drawing.Color.ForestGreen;
            this.addup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.addup.ForeColor = System.Drawing.Color.DarkGreen;
            this.addup.Location = new System.Drawing.Point(594, 653);
            this.addup.Name = "addup";
            this.addup.Size = new System.Drawing.Size(36, 30);
            this.addup.TabIndex = 12;
            this.addup.Text = "+";
            this.addup.UseVisualStyleBackColor = false;
            this.addup.Click += new System.EventHandler(this.button_AddUpReflector);
            // 
            // addrightup
            // 
            this.addrightup.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addrightup.BackColor = System.Drawing.Color.ForestGreen;
            this.addrightup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.addrightup.ForeColor = System.Drawing.Color.DarkGreen;
            this.addrightup.Location = new System.Drawing.Point(296, 653);
            this.addrightup.Name = "addrightup";
            this.addrightup.Size = new System.Drawing.Size(36, 30);
            this.addrightup.TabIndex = 13;
            this.addrightup.Text = "+";
            this.addrightup.UseVisualStyleBackColor = false;
            this.addrightup.Click += new System.EventHandler(this.button_AddRightUpReflector);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SandyBrown;
            this.label1.Location = new System.Drawing.Point(794, 686);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "LeftUp/RightDown";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SandyBrown;
            this.label2.Location = new System.Drawing.Point(563, 686);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Up/Down";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SandyBrown;
            this.label3.Location = new System.Drawing.Point(207, 686);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "LeftDown/RightUp";
            // 
            // start
            // 
            this.start.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.start.AutoSize = true;
            this.start.BackColor = System.Drawing.Color.ForestGreen;
            this.start.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.start.FlatAppearance.BorderSize = 3;
            this.start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.Color.DarkGreen;
            this.start.Location = new System.Drawing.Point(536, 10);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(180, 48);
            this.start.TabIndex = 17;
            this.start.Text = "Click To Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.button_StartLevel);
            // 
            // restart
            // 
            this.restart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.restart.AutoSize = true;
            this.restart.BackColor = System.Drawing.Color.ForestGreen;
            this.restart.Enabled = false;
            this.restart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.restart.FlatAppearance.BorderSize = 3;
            this.restart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restart.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart.ForeColor = System.Drawing.Color.DarkGreen;
            this.restart.Location = new System.Drawing.Point(536, 10);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(180, 48);
            this.restart.TabIndex = 18;
            this.restart.Text = "Restart";
            this.restart.UseVisualStyleBackColor = false;
            this.restart.Visible = false;
            this.restart.Click += new System.EventHandler(this.button_RestartLevel);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addrightup);
            this.Controls.Add(this.addup);
            this.Controls.Add(this.addleftup);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.logright);
            this.Controls.Add(this.reward0);
            this.Controls.Add(this.endgame);
            this.Controls.Add(this.logleft);
            this.Controls.Add(this.logup);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BallGame";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ESC);
            ((System.ComponentModel.ISupportInitialize)(this.endgame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reward0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logright)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.PictureBox endgame;
        public System.Windows.Forms.PictureBox reward0;
        public System.Windows.Forms.PictureBox ball;
        public System.Windows.Forms.PictureBox logleft;
        public System.Windows.Forms.PictureBox logup;
        public System.Windows.Forms.PictureBox logright;
        private System.Windows.Forms.Button addleftup;
        private System.Windows.Forms.Button addup;
        private System.Windows.Forms.Button addrightup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button restart;
    }
}