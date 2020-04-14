using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwithAndEnumeration
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Todo> todoList = new List<Todo>()
            {
                new Todo() { Description="Android Programming", EstimatedHours=3, State=State.InProgress },
                new Todo() { Description="Web Development", EstimatedHours=5, State=State.NotStarted },
                new Todo() { Description="Data Structures", EstimatedHours=5, State=State.Deleted },
                new Todo() { Description="Probability and Stats", EstimatedHours=5, State=State.Completed },
                new Todo() { Description="Software Dev", EstimatedHours=9, State=State.OnHold }
            };

            foreach( var item in todoList )
            {
                switch(item.State)
                {
                    case State.Completed:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case State.Deleted:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case State.InProgress:
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    case State.NotStarted:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    case State.OnHold:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        break;
                }
                Console.WriteLine("{0}-{1}", item.Description, item.State);
            }
            Console.ReadKey();
        }
    }
    enum State
    {
        InProgress,
        NotStarted,
        Completed,
        Deleted,
        OnHold
    }
    class Todo
    {
        public string Description { get; set; }
        public int EstimatedHours { get; set; }
        public State State { get; set; }

    }
}
