using System;

namespace Assessment
{
    internal class Alexa
    {
        public string GreetingMessage { get; set; }
        public string OwnerName { get; set; }
        public bool FirstMessage { get; set; }
        public Alexa()
        {
        }

        internal string Talk()
        {
            string message = string.Empty;
            if (!FirstMessage)
            {
                message = "hello, i am Alexa";
                FirstMessage = true;
            }
            else
            {
                message = GreetingMessage;
            }
            return message;
        }


        internal void Configure(Action<Alexa> action)
        {
            Alexa alexa = new Alexa();
            action.Invoke(alexa);
            GreetingMessage = alexa.GreetingMessage;
            OwnerName = alexa.OwnerName;
        }
    }
}