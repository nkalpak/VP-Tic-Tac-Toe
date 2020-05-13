using System;
using System.Windows.Forms;

// TODO: Create checkers for win states (horizontal, vertical, primary/secondary diagonal)

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private readonly GameBoard _gameBoard = new GameBoard();
        
        private void HandleButtonSignRender(Button button)
        {
            string buttonName = button.Name;
            string lastChar = buttonName.Substring(buttonName.Length - 1);
            int buttonIndex = int.Parse(lastChar) - 1;

            string sign = _gameBoard.SignBoardAtPosition(buttonIndex);
            button.Text = sign;

            if (!_gameBoard.HasWon) return;
            
            WinnerDisplay.Text = $@"{_gameBoard.WinningPlayer} has won!";
            
            Player1Wins.Text = GetPlayerWinsText(1, _gameBoard.Player1Wins);
            Player2Wins.Text = GetPlayerWinsText(2, _gameBoard.Player2Wins);
            _gameBoard.ResetGameBoard();
            ResetButtons();
        }

        private string GetPlayerWinsText(int player, uint wins)
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

        public Form1()
        {
            InitializeComponent();
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