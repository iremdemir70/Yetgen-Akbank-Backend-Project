using System;
using Inheritance.Abstract;
using Inheritance.Common;

namespace Inheritance.Entities
{
    internal class Meeting : Event, INotification
    {

        public List<string> Guests { get; set; }

        public void GetNotification()
        {
            foreach (var guest in Guests)
                Console.WriteLine($"Inviting: {guest}");
        }

    }
}

