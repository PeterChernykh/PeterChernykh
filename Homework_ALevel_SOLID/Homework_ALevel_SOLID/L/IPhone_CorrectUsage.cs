using System;
namespace Homework_ALevel_SOLID.L
{
    public class ApplePhone_CorrectUsage: Phone
    {
        public void ICall()
        {
            Call();
        }

        public void IReadMessage()
        {
            ReadMessage();
        }

        public void ITakePhoto()
        {
            TakePhoto();
        }

        public void UseButton()
        {
            Console.WriteLine("Use central button");
        }

        public void CallSiri()
        {
            Console.WriteLine("Call Siri");
        }
    }
}
