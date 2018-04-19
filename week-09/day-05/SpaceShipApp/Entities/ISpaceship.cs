using SpaceShipApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceShipApp.Entities
{
    public interface ISpaceship
    {
        void Move(int id);
        void GetOnBorad();
        void GetOff();
        SpaceVM Read();
    }
}
