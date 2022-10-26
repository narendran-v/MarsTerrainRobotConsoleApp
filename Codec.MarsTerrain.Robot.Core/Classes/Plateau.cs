using Codec.MarsTerrain.Robot.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codec.MarsTerrain.Robot.Core.Classes
{
    public class Plateau : IPlateau
    {
        private int _xGrid;
        private int _yGrid;

        public Plateau(string grid)
        {
            _xGrid = Convert.ToInt32(grid.ToUpper().Split('X')[0]);
            _yGrid = Convert.ToInt32(grid.ToUpper().Split('X')[1]);
        }

        public int GetXGrid()
        {
            return _xGrid;
        }

        public int GetYGrid()
        {
            return _yGrid;
        }
    }
}
