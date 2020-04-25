using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3033project
{
    class quiz
    {
        public int Fruit { get; set; }
        public int Activity { get; set; }
        public int Slider { get; set; }
        public int Furniture { get; set; }
        public int Worker { get; set; }
        public int Roof { get; set; }
        public int Style { get; set; }
        public int Constellation { get; set; }
        public int Museum { get; set; }
        public int Tool { get; set; }

        public quiz()
        {

            Fruit = 0;
            Activity = 0;
            Slider = 0;
            Furniture = 0;
            Worker = 0;
            Roof = 0;
            Style = 0;
            Constellation = 0;
            Museum = 0;
            Tool = 0;
        }

        public string Results ()
        {
            string character = string.Empty;
            double total = 0;
            total = Fruit + Activity + Slider + Furniture + Worker + Roof + Style + Constellation + Museum + Tool;

            if (total >= 35)
            {
                character = "Rover";
            }
            else if (total >= 30)
            {
                character = "Skye";
            }
            else if (total >= 25)
            {
                character = "Octavian";
            }
            else if (total >= 20)
            {
                character = "Goldie";
            }
            else if (total >= 15)
            {
                character = "Lobo";
            }
            else if (total >= 10)
            {
                character = "Cookie";
            }
            return character;
        }
    }

    
}
