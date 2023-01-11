
using System.Collections.Generic;

namespace ModelMainForm
{
    public class StatisticsOfWorkers
    {
        public StatisticsOfWorkers()
        {
            numberOfClientsServed = 0;
            amountOfMoneyEarned = 0;
            downTime = 0;

        }
       
        public void UpdateNumberOfClientsServed()
        {
            numberOfClientsServed++;
        }
        public void UpdateAmountOfMoneyEarned(int price)
        {
            amountOfMoneyEarned += price;
        }
        public void UpdateDownTime()
        {
            downTime++;
        }
        
        public int GetNumberOfClientsServed() 
        {return numberOfClientsServed;}
        public int GetAmountOfMoneyEarned()
        { return amountOfMoneyEarned; }
        public int GetDownTime()
        { return downTime; }


        private int numberOfClientsServed;
        private int amountOfMoneyEarned;
        private int downTime;
       

    }
}
