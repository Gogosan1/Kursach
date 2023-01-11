using System;

namespace ModelMainForm
{
    public class InputData
    {
        public int EndTime { get; }
        public InputData(int endTime, int lambda)
        {
            EndTime = endTime * 60; // время в минутах
            this.amountOfRequestOnHour = lambda;
            counterOfRequests = 0;
            timeHour = 0;
        }


       
        public bool WillBeANewRequest(int nowTime)
        {
            int counterNowTimeHour = 0;
            int x = nowTime;
            while (x > 60)
            {
                x -= 60;
                counterNowTimeHour++;
            }

            if (timeHour < counterNowTimeHour)
            {
                timeHour++;
                counterOfRequests = 0;
            }

            if (counterOfRequests < amountOfRequestOnHour)
            {
                counterOfRequests++;
                return true;
            }
            else return false;
        }
        private int counterOfRequests;
        private int timeHour;
        private int amountOfRequestOnHour; 
    }
}
