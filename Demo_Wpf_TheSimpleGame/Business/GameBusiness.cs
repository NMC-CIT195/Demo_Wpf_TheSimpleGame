using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_Wpf_TheSimpleGame.Presentation;
using Demo_Wpf_TheSimpleGame.Models;
using Demo_Wpf_TheSimpleGame.Data;

namespace Demo_Wpf_TheSimpleGame.Business
{
    /// <summary>
    /// business logic layer class
    /// instantiates the view and view model and interacts with the data layer
    /// </summary>
    public class GameBusiness
    {
        public enum GameStatus
        {
           QUIT,
           QUIT_SAVE
        }

        Player _playerOne = new Player();
        Player _playerTwo = new Player();

        public GameBusiness()
        {
            InitializeGame();
        }

        private void InitializeGame()
        {
            //
            // instantiate the data service and read all players
            //
            //IDataService dataService = new DataServiceSeed();
            IDataService dataService = new DataServiceXml();
            List<Player> allPlayers = dataService.ReadAll();

            //
            // choose players for games and add to the tuple
            //
            Player playerOne = allPlayers.FirstOrDefault(p => p.Name == "Darth");
            Player playerTwo = allPlayers.FirstOrDefault(p => p.Name == "Leia");
            (Player playerOne, Player playerTwo) gamePlayers = (playerOne, playerTwo);            

            //
            // instantiate the view model
            //
            GameViewModel gameViewModel = new GameViewModel(gamePlayers);

            //
            // instantiate the view, set data context, and show window.
            //
            GameView gameView = new GameView(gameViewModel);
            gameView.DataContext = gameViewModel;
            gameView.Show();
        }
    }
}
