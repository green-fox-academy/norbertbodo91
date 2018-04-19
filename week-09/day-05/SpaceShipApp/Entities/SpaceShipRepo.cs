using SpaceShipApp.Models;
using SpaceShipApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceShipApp.Entities
{
    public class SpaceShipRepo : ISpaceship
    {
        planetspaceshipContext db;

        public SpaceShipRepo(planetspaceshipContext ctx)
        {
            db = ctx;
        }

        public void GetOff()
        {
            Spaceship transport = db.Spaceship.FirstOrDefault();
            Planet planet = db.Planet.FirstOrDefault(x => x.Name == transport.Planet);
            int fleet = transport.Utilization;
            planet.Population += fleet;
            transport.Utilization -= fleet;            
            db.SaveChanges();            
        }

        public void GetOnBorad()
        {
            Spaceship transport = db.Spaceship.FirstOrDefault();
            Planet planet = db.Planet.FirstOrDefault(x=> x.Name == transport.Planet);
            int fleet = transport.MaxCapacity - transport.Utilization;

            if (fleet <= planet.Population)
            {
                transport.Utilization += fleet;                
                planet.Population -= fleet;
            }
            else
            {
                transport.Utilization += Convert.ToInt32(planet.Population);
                planet.Population -= planet.Population;
            }
            db.SaveChanges();
        }

        public void Move(int id)
        {
            Spaceship toMove = db.Spaceship.FirstOrDefault();
            toMove.Planet = db.Planet.FirstOrDefault(x => x.Id == id).Name;
            db.SaveChanges();
        }

        public SpaceVM Read()
        {
            SpaceVM vmodel = new SpaceVM();
            vmodel.Planets = db.Planet.ToList();
            vmodel.SpaceShip = db.Spaceship.FirstOrDefault();
            return vmodel;
        }
    }
}
