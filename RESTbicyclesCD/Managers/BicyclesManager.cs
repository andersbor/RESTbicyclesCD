﻿using System.Collections.Generic;
using RESTbicyclesCD.Models;

namespace RESTbicyclesCD.Managers
{
    public class BicyclesManager
    {
        private static int _nextId = 1;
        private static readonly List<Bicycle> Data = new List<Bicycle>
        {
            new Bicycle {Id = _nextId++, Brand = "SCO"},
            new Bicycle {Id=_nextId++, Brand = "Raleigh"}
        };

        public List<Bicycle> GetAll()
        {
            return Data;
        }
    }
}
