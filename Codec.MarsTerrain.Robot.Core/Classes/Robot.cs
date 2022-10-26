using Codec.MarsTerrain.Robot.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codec.MarsTerrain.Robot.Core.Classes
{
    public class Robot : IRobot
    {
        private ICurrentPosition _currentPosition;
        private IPositionNavigator _positionNavigator;
        private string _navigationCommand;

        public Robot(string navigationCommand, ICurrentPosition currentPosition, IPositionNavigator positionNavigator)
        {
            _navigationCommand = navigationCommand;
            _currentPosition = currentPosition;
            _positionNavigator = positionNavigator;
        }

        public string GetCurrentPosition()
        {
            return $"{_currentPosition.GetCurrentPosition().X},{_currentPosition.GetCurrentPosition().Y},{_currentPosition.GetCurrentSide()}";
        }

        public void Navigate()
        {
            foreach (var command in _navigationCommand)
            {
                _positionNavigator.Navigate(command);
            }
        }
    }
}
