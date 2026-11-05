using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project8_2.tamagotchi
{
    public class Cat
    {
        private int maxHunger = 0;
        private int currentHunger = 0;
        private int maxEnergy = 0;
        private int currentEnergy = 0;
        private int maxHappines = 0;
        private int currentHappines = 0;
        public Cat()
        {
            this.maxEnergy = this.currentEnergy = 100;
            this.maxHunger = this.currentHunger = 0;
            this.maxHappines = this.currentHappines = 100;
        }
        public int getEnergy()
        {
            return this.currentEnergy;
        }
        public int getHunger()
        {
            return this.currentHunger;
        }
        public int getHappines()
        {
            return this.currentHappines;
        }
        public void increaseEnergy(int value)
        {
            if (maxEnergy < currentEnergy + value)
            {
                maxEnergy = currentEnergy;
            }
            else
            {
                currentEnergy += value;
            }

        }
        public void decreaseEnergy(int value)
        {
            if (currentEnergy - value < 0)
            {
                currentEnergy = 0;
            }
            else
            {
                currentEnergy -= value;
            }
        }

        public void increaseHunger(int value)
        {
            currentHunger += value;
            if (maxHunger < currentHunger)
            {
                maxHunger = currentHunger;
            }
           

        }
        public void decreaseHunger(int value)
        {
            if (currentHunger - value < 0)
            {
                currentHunger = 0;
            }
            else
            {
                currentHunger -= value;
            }
        }
        public void increaseHappines(int value)
        {
            if (maxHappines < currentHappines + value)
            {
                maxHappines = currentHappines;
            }
            else
            {
                currentHappines += value;
            }

        }
        public void decreaseHappines(int value)
        {
            if (currentHappines - value < 0)
            {
                currentHappines = 0;
            }
            else
            {
                currentHappines -= value;
            }

        }
    }
    
}
