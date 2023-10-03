using System;
using Inheritance.Abstract;
using Inheritance.Common;

namespace Inheritance.Entities
{
    internal class Todo : Event , INotification
    {
        public string Importance { get; set; }

        public void GetNotification()
        {
            Console.WriteLine($"Time to make To-Do: {Title}");
        }
    }
}

