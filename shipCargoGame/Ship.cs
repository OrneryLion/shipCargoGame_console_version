using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shipCargoGame
{
    class Ship
    {
        const int CYCLE_WEIGHT = 3;
        const int CAR_WEIGHT = 5;
        const int TRUCK_WEIGHT = 11;
        const int TRAIN_WEIGHT = 17;

        const int MAX_WEIGHT = 10;


        public int Capacity { get; set; }
        public int cycleCount { get; set; }
        public int carCount { get; set; }
        public int truckCount { get; set; }
        public int trainCarCount { get; set; }

        Random random = new Random();


        // methods (functions)
        public int getShipLoad()
        {
            // calculate the total weight of the cargo on the ship.

            return cycleCount * CYCLE_WEIGHT+ carCount * CAR_WEIGHT + truckCount * TRUCK_WEIGHT + trainCarCount * TRAIN_WEIGHT;
        }

        // constructor - called when a new instance is created.
        public Ship()
        {
            cycleCount = 0;
            carCount = 0;
            trainCarCount = 0;
            truckCount = 0;

            // create a random sized ship.
            Capacity = random.Next(MAX_WEIGHT) * CYCLE_WEIGHT + random.Next(MAX_WEIGHT) * CAR_WEIGHT + random.Next(MAX_WEIGHT) * TRUCK_WEIGHT + random.Next(MAX_WEIGHT) * TRAIN_WEIGHT;
            
        }

        public int overUnder()
        {
            // return a value of how loaded the ship is
            return Capacity - getShipLoad();
        }

        public override string ToString()
        {
            return "Capacity = " + Capacity + ", CurrentLoad = " + getShipLoad();
        }
    }

}
