using System;

namespace Homework_ALevel_SOLID.L
{
    public  class Nokia100_IncorrectUsage: Phone
    {
        public void NokiaCall()
        {
            Call();
        }

        public void NokiaReadMessage()
        {
            ReadMessage();
        }

        public void UseCalculator()
        {
            Console.WriteLine("Use calculator");
        }
    }
}
