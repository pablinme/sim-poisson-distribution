using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimulationLab12
{
    class Team
    {
        public int ID { get; private set; }
        public bool Flag { get; set; }
        public int AverageGoals { get; private set; }

        private Random rand;
        public Team(int ID)
        {
            this.ID = ID;
            this.Flag = false;

            rand = new Random(ID);
            this.AverageGoals = rand.Next(8);
        }
    }
}
