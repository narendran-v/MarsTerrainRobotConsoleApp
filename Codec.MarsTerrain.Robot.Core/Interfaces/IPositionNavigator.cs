﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codec.MarsTerrain.Robot.Core.Interfaces
{
    public interface IPositionNavigator
    {
        void Navigate(char command);
        ICurrentPosition GetCurrentPosition();
    }
}
