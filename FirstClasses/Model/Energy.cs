using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClasses.Model
{
    class Energy
    {
        private double massa;
        private double velocity;
        public Energy(double massa, double velocity)
        {
            this.massa = massa;
            this.velocity = velocity;
        }

        public double Massa
        {
            get { return massa; }
            set { massa = value;}
        }
        public double Velocity
        {
            get { return velocity; }
            set { velocity = value; }
        }
        public double KinetikeEnargy()
        {
            return massa * velocity * velocity / 2;
        }
    }
}
