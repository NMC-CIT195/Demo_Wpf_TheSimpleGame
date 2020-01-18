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
    /// instatiates the view and view model and interacts with the data layer
    /// </summary>
    public class GameBusiness
    {
        public GameBusiness()
        {
            GameView gameView = new GameView();
            GameViewModel gameViewModel = new GameViewModel(gameView);


        }
    }
}
