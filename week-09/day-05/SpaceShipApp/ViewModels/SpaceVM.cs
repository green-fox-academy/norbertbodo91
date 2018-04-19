using SpaceShipApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceShipApp.ViewModels
{
    public class SpaceVM
    {
        public List<Planet> Planets { get; set; }
        public Spaceship SpaceShip { get; set; }
    }
}
