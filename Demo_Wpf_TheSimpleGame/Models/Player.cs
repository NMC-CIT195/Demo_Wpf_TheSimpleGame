using Demo_Wpf_TheSimpleGame.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Wpf_TheSimpleGame.Models
{
    public class Player : ObservableObject
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Ties { get; set; }
    }
}
