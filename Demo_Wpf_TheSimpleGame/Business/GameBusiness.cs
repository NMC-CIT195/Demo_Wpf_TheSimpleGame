using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_Wpf_TheSimpleGame.Presentation;
using Demo_Wpf_TheSimpleGame.Models;

namespace Demo_Wpf_TheSimpleGame.Business
{
    /// <summary>
    /// business logic layer class
    /// instantiates the view and view model and interacts with the data layer
    /// </summary>
    public class GameBusiness
    {
        Player _playerOne = new Player();
        Player _playerTwo = new Player();

        public GameBusiness()
        {
            InitializeGame();
        }

        private void InitializeGame()
        {
            (Player playerOne, Player playerTwo) players = GetPlayerInfo();

            GameViewModel gameViewModel = new GameViewModel(players);

            GameView gameView = new GameView(gameViewModel);
            gameView.DataContext = gameViewModel;
            gameView.Show();

        }

        private (Player playerOne, Player playerTwo) GetPlayerInfo()
        {
            (Player playerOne, Player playerTwo) players;

            players.playerOne = new Player()
            {
                Name = "Sally",
                Wins = 5,
                Losses = 2,
                Ties = 1
            };

            players.playerTwo = new Player()
            {
                Name = "Bill",
                Wins = 3,
                Losses = 7,
                Ties = 2
            };

            return players;
        }

    }
}
