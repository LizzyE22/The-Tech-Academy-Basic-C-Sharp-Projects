﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Interfaces
{
    interface IWalkAway
    {
        //no need to say public- everything is public in an interface
        void WalkAway(Player player);
    }
}
