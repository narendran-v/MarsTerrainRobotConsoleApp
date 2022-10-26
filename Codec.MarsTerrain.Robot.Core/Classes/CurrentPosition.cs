using Codec.MarsTerrain.Robot.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codec.MarsTerrain.Robot.Core.Classes
{
    public class CurrentPosition : ICurrentPosition
    {
        private Position _currentPosition;
        private CompassPointEnum _currentSide;

        public CurrentPosition()
        {
            _currentPosition = new Position(1, 1);
            _currentSide = CompassPointEnum.North;
        }

        public void AddX(int number)
        {
            _currentPosition.X += number;
        }

        public void AddY(int number)
        {
            _currentPosition.Y += number;
        }

        public Position GetCurrentPosition()
        {
            return _currentPosition;
        }

        public CompassPointEnum GetCurrentSide()
        {
            return _currentSide;
        }

        public void SetCurrentPosition(Position position)
        {
            _currentPosition = position;
        }

        public void SetCurrentSide(CompassPointEnum compassPointEnum)
        {
            _currentSide = compassPointEnum;
        }
    }
}
