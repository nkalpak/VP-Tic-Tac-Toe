using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private readonly GameBoard _gameBoard = new GameBoard();
        
        private void HandleButtonSignRender(Button button)
        {
            // If board is currently in win state (waiting for play again or exit), don't allow any more clicks.
            if (_gameBoard.HasWon) return;
            
            int buttonIndex = GetIndexFromButtonName(button.Name);

            string sign = _gameBoard.SignBoardAtPosition(buttonIndex);
            button.Text = sign;

            if (_gameBoard.HasWon) HandleWinCondition();
            if (_gameBoard.Draw) HandleDrawCondition();
        }

        private int GetIndexFromButtonName(string name)
        {
            string lastChar = name.Substring(name.Length - 1);
            int buttonIndex = int.Parse(lastChar) - 1;

            return buttonIndex;
        }

        private void HandleDrawCondition()
        {
            SetGameControlButtons(true);
            SetGameEndDisplay("Draw");
        }

        private void HandleWinCondition()
        {
            SetGameEndDisplay($@"{_gameBoard.WinningPlayer} has won!");

            Player1Wins.Text = GetPlayerWinsText(1, _gameBoard.Player1Wins);
            Player2Wins.Text = GetPlayerWinsText(2, _gameBoard.Player2Wins);
            
            SetGameControlButtons(true);
        }

        private static string GetPlayerWinsText(int player, uint wins)
        {
            return $@"Player {player}: {wins} wins.";
        }

        private void ResetButtons()
        {
            GameButton1.Text = "";
            GameButton2.Text = "";
            GameButton3.Text = "";
            GameButton4.Text = "";
            GameButton5.Text = "";
            GameButton6.Text = "";
            GameButton7.Text = "";
            GameButton8.Text = "";
            GameButton9.Text = "";
        }

        private void SetGameEndDisplay(string text)
        {
            GameEndDisplay.Visible = true;
            GameEndDisplay.Text = text;
        }

        private void SetGameControlButtons(bool shouldShow)
        {
            ExitGameButton.Visible = shouldShow;
            PlayAgainButton.Visible = shouldShow;
        }

        public Form1()
        {
            InitializeComponent();
        }
        
        private void PlayAgainButton_Click(object sender, EventArgs e)
        {
            SetGameControlButtons(false);
            GameEndDisplay.Visible = false;
            
            _gameBoard.ResetGameBoard();
            ResetButtons();
        }
        
        private void ExitGameButton_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }
        private void GameButton1_Click(object sender, EventArgs e)
        {
            HandleButtonSignRender(sender as Button);
        }

        private void GameButton2_Click(object sender, EventArgs e)
        {
            HandleButtonSignRender(sender as Button);
        }

        private void GameButton3_Click(object sender, EventArgs e)
        {
            HandleButtonSignRender(sender as Button);
        }

        private void GameButton4_Click(object sender, EventArgs e)
        {
            HandleButtonSignRender(sender as Button);
        }

        private void GameButton5_Click(object sender, EventArgs e)
        {
            HandleButtonSignRender(sender as Button);
        }

        private void GameButton6_Click(object sender, EventArgs e)
        {
            HandleButtonSignRender(sender as Button);
        }

        private void GameButton7_Click(object sender, EventArgs e)
        {
            HandleButtonSignRender(sender as Button);
        }

        private void GameButton8_Click(object sender, EventArgs e)
        {
            HandleButtonSignRender(sender as Button);
        }

        private void GameButton9_Click(object sender, EventArgs e)
        {
            HandleButtonSignRender(sender as Button);
        }
    }
}