using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_Wpf_TheSimpleGame.Models;

namespace Demo_Wpf_TheSimpleGame.Presentation
{
    public class GameViewModel : ObservableObject
    {
        private Gameboard _gameboard;
        private Player _playerX;
        private Player _playerO;
        private string _messageBoxContent;



        public Gameboard Gameboard
        {
            get { return _gameboard; }
            set
            {
                _gameboard = value;
                OnPropertyChanged(nameof(Gameboard));
            }
        }

        public Player PlayerX
        {
            get { return _playerX; }
            set
            {
                _playerX = value;
                OnPropertyChanged(nameof(PlayerX));
            }
        }

        public Player PlayerO
        {
            get { return _playerO; }
            set
            {
                _playerO = value;
                OnPropertyChanged(nameof(PlayerO));
            }
        }
        
        public string MessageBoxContent
        {
            get { return _messageBoxContent; }
            set
            {
                _messageBoxContent = value;
                OnPropertyChanged(nameof(MessageBoxContent));
            }
        }

        public GameViewModel((Player playerOne, Player playerTwo) players)
        {
            _playerX = players.playerOne;
            _playerO = players.playerTwo;

            InitializeGame();
        }

        private void InitializeGame()
        {
            _gameboard = new Gameboard();

            _gameboard.CurrentRoundState = Gameboard.GameboardState.PlayerXTurn;
            MessageBoxContent = "Player X Moves";
        }

        public void PlayerMove(int row, int column)
        {
            if (_gameboard.GameboardPositionAvailable(new GameboardPosition(row, column)))
            {
                if (_gameboard.CurrentRoundState == Gameboard.GameboardState.PlayerXTurn)
                {
                    Gameboard.CurrentBoard[row][column] = Gameboard.PLAYER_PIECE_X;
                    OnPropertyChanged(nameof(Gameboard));
                    _gameboard.CurrentRoundState = Gameboard.GameboardState.PlayerOTurn;
                    MessageBoxContent = "Player O Moves";
                }
                else
                {
                    Gameboard.CurrentBoard[row][column] = Gameboard.PLAYER_PIECE_O;
                    OnPropertyChanged(nameof(Gameboard));
                    _gameboard.CurrentRoundState = Gameboard.GameboardState.PlayerXTurn;
                    MessageBoxContent = "Player X Moves";
                }
                UpdateCurrentRoundState();
            }
        }

        public void UpdateCurrentRoundState()
        {
            _gameboard.UpdateGameboardState();
            if (_gameboard.CurrentRoundState == Gameboard.GameboardState.CatsGame)
            {

            }
            else if (_gameboard.CurrentRoundState == Gameboard.GameboardState.PlayerXWin)
            {

            }
            else if (_gameboard.CurrentRoundState == Gameboard.GameboardState.PlayerOWin)
            {

            }
        }
    }
}
