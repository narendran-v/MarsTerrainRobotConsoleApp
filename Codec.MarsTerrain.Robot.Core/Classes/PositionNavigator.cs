using Codec.MarsTerrain.Robot.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codec.MarsTerrain.Robot.Core.Classes
{
    public class PositionNavigator : IPositionNavigator
    {
        private ICurrentPosition _currentPosition;
        private IPlateau _plateau;
        private ICompass _compassNavigator;
        public PositionNavigator(ICurrentPosition currentPosition, IPlateau plateau, ICompass compassNavigator)
        {
            _currentPosition = currentPosition;
            _plateau = plateau;
            _compassNavigator = compassNavigator;
        }

        public void Navigate(char command)
        {
            var newSide = _compassNavigator.Navigate(command);
            _currentPosition.SetCurrentSide(newSide);

            if (command.ToString().ToUpper() == "F") GoAhead();
        }
        private void GoAhead()
        {
            switch (_currentPosition.GetCurrentSide())
            {
                case CompassPointEnum.North:
                    NavigateToNorth();
                    break;
                case CompassPointEnum.East:
                    NavigateToEast();
                    break;
                case CompassPointEnum.South:
                    NavigateToSouth();
                    break;
                case CompassPointEnum.West:
                    NavigateToWest();
                    break;
                default:
                    break;
            }
        }

        private void NavigateToWest()
        {
            if (_currentPosition.GetCurrentPosition().X > 1) _currentPosition.AddX(-1);
        }

        private void NavigateToSouth()
        {
            if (_currentPosition.GetCurrentPosition().Y > 1) _currentPosition.AddY(-1);
        }

        private void NavigateToEast()
        {
            if (_currentPosition.GetCurrentPosition().X < _plateau.GetXGrid()) _currentPosition.AddX(1);
        }

        private void NavigateToNorth()
        {
            if (_currentPosition.GetCurrentPosition().Y < _plateau.GetYGrid()) _currentPosition.AddY(1);
        }

        public ICurrentPosition GetCurrentPosition()
        {
            return _currentPosition;
        }
    }
}
