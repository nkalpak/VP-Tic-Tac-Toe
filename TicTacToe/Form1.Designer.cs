namespace TicTacToe
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
            this.GameButton1 = new System.Windows.Forms.Button();
            this.GameButton2 = new System.Windows.Forms.Button();
            this.GameButton3 = new System.Windows.Forms.Button();
            this.GameButton4 = new System.Windows.Forms.Button();
            this.GameButton5 = new System.Windows.Forms.Button();
            this.GameButton6 = new System.Windows.Forms.Button();
            this.GameButton7 = new System.Windows.Forms.Button();
            this.GameButton8 = new System.Windows.Forms.Button();
            this.GameButton9 = new System.Windows.Forms.Button();
            this.Player1Wins = new System.Windows.Forms.Label();
            this.Player2Wins = new System.Windows.Forms.Label();
            this.ExitGameButton = new System.Windows.Forms.Button();
            this.PlayAgainButton = new System.Windows.Forms.Button();
            this.WinnerDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GameButton1
            // 
            this.GameButton1.Location = new System.Drawing.Point(144, 105);
            this.GameButton1.Name = "GameButton1";
            this.GameButton1.Size = new System.Drawing.Size(75, 75);
            this.GameButton1.TabIndex = 0;
            this.GameButton1.UseVisualStyleBackColor = true;
            this.GameButton1.Click += new System.EventHandler(this.GameButton1_Click);
            // 
            // GameButton2
            // 
            this.GameButton2.Location = new System.Drawing.Point(225, 105);
            this.GameButton2.Name = "GameButton2";
            this.GameButton2.Size = new System.Drawing.Size(75, 75);
            this.GameButton2.TabIndex = 0;
            this.GameButton2.UseVisualStyleBackColor = true;
            this.GameButton2.Click += new System.EventHandler(this.GameButton2_Click);
            // 
            // GameButton3
            // 
            this.GameButton3.Location = new System.Drawing.Point(306, 105);
            this.GameButton3.Name = "GameButton3";
            this.GameButton3.Size = new System.Drawing.Size(75, 75);
            this.GameButton3.TabIndex = 0;
            this.GameButton3.UseVisualStyleBackColor = true;
            this.GameButton3.Click += new System.EventHandler(this.GameButton3_Click);
            // 
            // GameButton4
            // 
            this.GameButton4.Location = new System.Drawing.Point(144, 186);
            this.GameButton4.Name = "GameButton4";
            this.GameButton4.Size = new System.Drawing.Size(75, 75);
            this.GameButton4.TabIndex = 0;
            this.GameButton4.UseVisualStyleBackColor = true;
            this.GameButton4.Click += new System.EventHandler(this.GameButton4_Click);
            // 
            // GameButton5
            // 
            this.GameButton5.Location = new System.Drawing.Point(225, 186);
            this.GameButton5.Name = "GameButton5";
            this.GameButton5.Size = new System.Drawing.Size(75, 75);
            this.GameButton5.TabIndex = 0;
            this.GameButton5.UseVisualStyleBackColor = true;
            this.GameButton5.Click += new System.EventHandler(this.GameButton5_Click);
            // 
            // GameButton6
            // 
            this.GameButton6.Location = new System.Drawing.Point(306, 186);
            this.GameButton6.Name = "GameButton6";
            this.GameButton6.Size = new System.Drawing.Size(75, 75);
            this.GameButton6.TabIndex = 0;
            this.GameButton6.UseVisualStyleBackColor = true;
            this.GameButton6.Click += new System.EventHandler(this.GameButton6_Click);
            // 
            // GameButton7
            // 
            this.GameButton7.Location = new System.Drawing.Point(144, 267);
            this.GameButton7.Name = "GameButton7";
            this.GameButton7.Size = new System.Drawing.Size(75, 75);
            this.GameButton7.TabIndex = 0;
            this.GameButton7.UseVisualStyleBackColor = true;
            this.GameButton7.Click += new System.EventHandler(this.GameButton7_Click);
            // 
            // GameButton8
            // 
            this.GameButton8.Location = new System.Drawing.Point(225, 267);
            this.GameButton8.Name = "GameButton8";
            this.GameButton8.Size = new System.Drawing.Size(75, 75);
            this.GameButton8.TabIndex = 0;
            this.GameButton8.UseVisualStyleBackColor = true;
            this.GameButton8.Click += new System.EventHandler(this.GameButton8_Click);
            // 
            // GameButton9
            // 
            this.GameButton9.Location = new System.Drawing.Point(306, 267);
            this.GameButton9.Name = "GameButton9";
            this.GameButton9.Size = new System.Drawing.Size(75, 75);
            this.GameButton9.TabIndex = 0;
            this.GameButton9.UseVisualStyleBackColor = true;
            this.GameButton9.Click += new System.EventHandler(this.GameButton9_Click);
            // 
            // Player1Wins
            // 
            this.Player1Wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Player1Wins.Location = new System.Drawing.Point(144, 14);
            this.Player1Wins.Name = "Player1Wins";
            this.Player1Wins.Size = new System.Drawing.Size(100, 23);
            this.Player1Wins.TabIndex = 2;
            this.Player1Wins.Text = "Player 1: 0 wins";
            // 
            // Player2Wins
            // 
            this.Player2Wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Player2Wins.Location = new System.Drawing.Point(281, 14);
            this.Player2Wins.Name = "Player2Wins";
            this.Player2Wins.Size = new System.Drawing.Size(100, 23);
            this.Player2Wins.TabIndex = 2;
            this.Player2Wins.Text = "Player 2: 0 wins";
            // 
            // ExitGameButton
            // 
            this.ExitGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitGameButton.Location = new System.Drawing.Point(144, 384);
            this.ExitGameButton.Name = "ExitGameButton";
            this.ExitGameButton.Size = new System.Drawing.Size(113, 46);
            this.ExitGameButton.TabIndex = 3;
            this.ExitGameButton.Text = "Exit";
            this.ExitGameButton.UseVisualStyleBackColor = true;
            this.ExitGameButton.Visible = false;
            this.ExitGameButton.Click += new System.EventHandler(this.ExitGameButton_Click);
            // 
            // PlayAgainButton
            // 
            this.PlayAgainButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PlayAgainButton.FlatAppearance.BorderSize = 0;
            this.PlayAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayAgainButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PlayAgainButton.Location = new System.Drawing.Point(268, 384);
            this.PlayAgainButton.Name = "PlayAgainButton";
            this.PlayAgainButton.Size = new System.Drawing.Size(113, 46);
            this.PlayAgainButton.TabIndex = 3;
            this.PlayAgainButton.Text = "Play Again";
            this.PlayAgainButton.UseVisualStyleBackColor = false;
            this.PlayAgainButton.Visible = false;
            this.PlayAgainButton.Click += new System.EventHandler(this.PlayAgainButton_Click);
            // 
            // WinnerDisplay
            // 
            this.WinnerDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.WinnerDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.WinnerDisplay.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.WinnerDisplay.Location = new System.Drawing.Point(144, 51);
            this.WinnerDisplay.Name = "WinnerDisplay";
            this.WinnerDisplay.Size = new System.Drawing.Size(237, 40);
            this.WinnerDisplay.TabIndex = 4;
            this.WinnerDisplay.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.WinnerDisplay);
            this.Controls.Add(this.PlayAgainButton);
            this.Controls.Add(this.ExitGameButton);
            this.Controls.Add(this.Player2Wins);
            this.Controls.Add(this.Player1Wins);
            this.Controls.Add(this.GameButton9);
            this.Controls.Add(this.GameButton6);
            this.Controls.Add(this.GameButton3);
            this.Controls.Add(this.GameButton8);
            this.Controls.Add(this.GameButton7);
            this.Controls.Add(this.GameButton5);
            this.Controls.Add(this.GameButton4);
            this.Controls.Add(this.GameButton2);
            this.Controls.Add(this.GameButton1);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button ExitGameButton;
        private System.Windows.Forms.Button GameButton1;
        private System.Windows.Forms.Button GameButton2;
        private System.Windows.Forms.Button GameButton3;
        private System.Windows.Forms.Button GameButton4;
        private System.Windows.Forms.Button GameButton5;
        private System.Windows.Forms.Button GameButton6;
        private System.Windows.Forms.Button GameButton7;
        private System.Windows.Forms.Button GameButton8;
        private System.Windows.Forms.Button GameButton9;
        private System.Windows.Forms.Button PlayAgainButton;
        private System.Windows.Forms.Label Player1Wins;
        private System.Windows.Forms.Label Player2Wins;
        private System.Windows.Forms.Label WinnerDisplay;

        #endregion
    }
}