namespace PuzzleGame
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
            this.PuzzleBox = new System.Windows.Forms.GroupBox();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.Scores = new System.Windows.Forms.ListBox();
            this.movesLabel = new System.Windows.Forms.Label();
            this.timerElapse = new System.Windows.Forms.Timer(this.components);
            this.PuzzleBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            this.SuspendLayout();
            // 
            // PuzzleBox
            // 
            this.PuzzleBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PuzzleBox.Controls.Add(this.pictureBox33);
            this.PuzzleBox.Controls.Add(this.pictureBox32);
            this.PuzzleBox.Controls.Add(this.pictureBox31);
            this.PuzzleBox.Controls.Add(this.pictureBox23);
            this.PuzzleBox.Controls.Add(this.pictureBox22);
            this.PuzzleBox.Controls.Add(this.pictureBox21);
            this.PuzzleBox.Controls.Add(this.pictureBox13);
            this.PuzzleBox.Controls.Add(this.pictureBox12);
            this.PuzzleBox.Controls.Add(this.pictureBox11);
            this.PuzzleBox.Location = new System.Drawing.Point(12, 23);
            this.PuzzleBox.Name = "PuzzleBox";
            this.PuzzleBox.Size = new System.Drawing.Size(353, 340);
            this.PuzzleBox.TabIndex = 0;
            this.PuzzleBox.TabStop = false;
            // 
            // pictureBox33
            // 
            this.pictureBox33.Location = new System.Drawing.Point(235, 233);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(106, 105);
            this.pictureBox33.TabIndex = 5;
            this.pictureBox33.TabStop = false;
            this.pictureBox33.Click += new System.EventHandler(this.pictureBox33_Click);
            // 
            // pictureBox32
            // 
            this.pictureBox32.Location = new System.Drawing.Point(123, 233);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(106, 105);
            this.pictureBox32.TabIndex = 6;
            this.pictureBox32.TabStop = false;
            this.pictureBox32.Click += new System.EventHandler(this.pictureBox32_Click);
            // 
            // pictureBox31
            // 
            this.pictureBox31.Location = new System.Drawing.Point(9, 233);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(108, 105);
            this.pictureBox31.TabIndex = 7;
            this.pictureBox31.TabStop = false;
            this.pictureBox31.Click += new System.EventHandler(this.pictureBox31_Click);
            // 
            // pictureBox23
            // 
            this.pictureBox23.Location = new System.Drawing.Point(235, 122);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(106, 105);
            this.pictureBox23.TabIndex = 2;
            this.pictureBox23.TabStop = false;
            this.pictureBox23.Click += new System.EventHandler(this.pictureBox23_Click);
            // 
            // pictureBox22
            // 
            this.pictureBox22.Location = new System.Drawing.Point(123, 122);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(106, 105);
            this.pictureBox22.TabIndex = 3;
            this.pictureBox22.TabStop = false;
            this.pictureBox22.Click += new System.EventHandler(this.pictureBox22_Click);
            // 
            // pictureBox21
            // 
            this.pictureBox21.Location = new System.Drawing.Point(9, 122);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(108, 105);
            this.pictureBox21.TabIndex = 4;
            this.pictureBox21.TabStop = false;
            this.pictureBox21.Click += new System.EventHandler(this.pictureBox21_Click);
            // 
            // pictureBox13
            // 
            this.pictureBox13.Location = new System.Drawing.Point(235, 11);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(106, 105);
            this.pictureBox13.TabIndex = 1;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Click += new System.EventHandler(this.pictureBox13_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(123, 11);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(106, 105);
            this.pictureBox12.TabIndex = 1;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox12_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(9, 11);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(108, 105);
            this.pictureBox11.TabIndex = 1;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.Location = new System.Drawing.Point(401, 23);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(166, 152);
            this.pictureBoxOriginal.TabIndex = 1;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(401, 204);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(492, 204);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(75, 23);
            this.quitBtn.TabIndex = 3;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(435, 256);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 30);
            this.timeLabel.TabIndex = 4;
            // 
            // Scores
            // 
            this.Scores.FormattingEnabled = true;
            this.Scores.ItemHeight = 16;
            this.Scores.Location = new System.Drawing.Point(589, 23);
            this.Scores.Name = "Scores";
            this.Scores.Size = new System.Drawing.Size(189, 340);
            this.Scores.TabIndex = 5;
            // 
            // movesLabel
            // 
            this.movesLabel.AutoSize = true;
            this.movesLabel.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movesLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.movesLabel.Location = new System.Drawing.Point(18, 398);
            this.movesLabel.Name = "movesLabel";
            this.movesLabel.Size = new System.Drawing.Size(182, 30);
            this.movesLabel.TabIndex = 6;
            this.movesLabel.Text = "Moves made : ";
            // 
            // timerElapse
            // 
            this.timerElapse.Tick += new System.EventHandler(this.updateTimeElapsed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.movesLabel);
            this.Controls.Add(this.Scores);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.pictureBoxOriginal);
            this.Controls.Add(this.PuzzleBox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PuzzleBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox PuzzleBox;
        private System.Windows.Forms.PictureBox pictureBox33;
        private System.Windows.Forms.PictureBox pictureBox32;
        private System.Windows.Forms.PictureBox pictureBox31;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.ListBox Scores;
        private System.Windows.Forms.Label movesLabel;
        private System.Windows.Forms.Timer timerElapse;
    }
}

