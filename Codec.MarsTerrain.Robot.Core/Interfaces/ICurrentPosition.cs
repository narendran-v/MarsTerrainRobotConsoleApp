using Codec.MarsTerrain.Robot.Core.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codec.MarsTerrain.Robot.Core.Interfaces
{
    public interface ICurrentPosition
    {
        void SetCurrentPosition(Position position);
        void SetCurrentSide(CompassPointEnum compassPointEnum);
        Position GetCurrentPosition();
        CompassPointEnum GetCurrentSide();
        void AddX(int number);
        void AddY(int number);

    }
}
