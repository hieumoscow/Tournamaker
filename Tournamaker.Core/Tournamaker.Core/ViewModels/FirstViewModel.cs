using System.Collections.Generic;
using Cirrious.MvvmCross.ViewModels;
using Tournamaker.Core.Model;

namespace Tournamaker.Core.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
		private string _hello = "Hello MvvmCross";
        public string Hello
		{ 
			get { return _hello; }
			set { _hello = value; RaisePropertyChanged(() => Hello); }
		}

        public List<Tournament> Tournaments { get; set; } 

        public void Init()
        {
            var tournaments = new List<Tournament>
            {
                new Tournament {Name = "Tennis Aus", Quantities = 10},
                new Tournament {Name = "Football VFF", Quantities = 20}
            };

            Tournaments = tournaments;
        }
    }
}
