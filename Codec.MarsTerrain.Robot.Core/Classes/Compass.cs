using Codec.MarsTerrain.Robot.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codec.MarsTerrain.Robot.Core.Classes
{
    public class Compass : ICompass
    {
        private CompassPointEnum _currentPoint = CompassPointEnum.North;
        public CompassPointEnum Navigate(char command)
        {
            switch (command)
            {
                case 'R':
                    TurnRight();
                    break;
                case 'L':
                    TurnLeft();
                    break;
                default:
                    break;
            }
            return _currentPoint;
        }

        private void TurnRight()
        {
            if (_currentPoint == CompassPointEnum.West)
            {
                _currentPoint = CompassPointEnum.North;
            }
            else
            {
                _currentPoint = (CompassPointEnum)_currentPoint.GetHashCode() + 1;
            }
        }

        private void TurnLeft()
        {
            if (_currentPoint == CompassPointEnum.North)
            {
                _currentPoint = CompassPointEnum.West;
            }
            else
            {
                _currentPoint = (CompassPointEnum)_currentPoint.GetHashCode() - 1;
            }
        }
    }
}
