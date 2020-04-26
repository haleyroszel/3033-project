using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3033project
{
    class quiz
    {
        private int Fruit;
        private int Activity;
        private int Roof;
        private int Worker;

        public int getFruit()
        {
            return Fruit;
        }
        public void setFruit(int newFruit)
        {
            Fruit = newFruit;
        }

        public int getActivity()
        {
            return Activity;
        }
        public void setActivity(int newActivity)
        {
            Activity = newActivity;
        }

        public int getRoof()
        {
            return Roof;
        }
        public void setRoof(int newRoof)
        {
            Roof = newRoof;
        }


        public int getWorker()
        {
            return Worker;
        }
        public void setWorker(int newWorker)
        {
            Worker = newWorker;
        }

        public quiz()
        {
            Fruit = 0;
            Activity = 0;
            Roof = 0;
            Worker = 0;
        }
        public string Results()
        {
            string character = string.Empty;
            double total = 0;
            total = Fruit + Activity + Worker + Roof;

            if (total >= 14)
            {
                character = "Rover";
            }
            else if (total >= 12)
            {
                character = "Skye";
            }
            else if (total >= 10)
            {
                character = "Octavian";
            }
            else if (total >= 8)
            {
                character = "Goldie";
            }
            else if (total >= 6)
            {
                character = "Lobo";
            }
            else if (total >= 4)
            {
                character = "Cookie";
            }
            return character;
        }
    }
}
