using System;
using System.Collections.Generic;
using System.Text;

namespace Gym.Models.Athletes
{
    public class Boxer : Athlete
    {
        public Boxer(string fullName, string motivation, int numberOfMedals) : base(fullName, motivation, 60, numberOfMedals)
        {

        }

        public override void Exercise()
        {
            this.Stamina += 15;

            if (this.Stamina > 100)
            {
                this.Stamina = 100;
                throw new ArgumentException("Stamina cannot be exceed 100 points.");
            }
        }
    }
}
