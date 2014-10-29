using CarConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConsoleApp.Views
{
    class CarView
    {
        private CarViewModel _CarViewModel;

        public CarView(CarViewModel carviewmodel)
        {
            _CarViewModel = carviewmodel;
        }
        public override string ToString()
        {
            if (_CarViewModel.NumberPassengers > 0)
            {
                return CommonCarText() +
                    _CarViewModel.Passengers +
                    "are the current passengers";
            }
            else
            {
                return CommonCarText() +
                    "There are no passengers";
            }
        }

        private string CommonCarText()
        {
            return "The car model, " + _CarViewModel.Model +
                                " has " + _CarViewModel.Doors +
                                " doors. ";
        }
    }
}
