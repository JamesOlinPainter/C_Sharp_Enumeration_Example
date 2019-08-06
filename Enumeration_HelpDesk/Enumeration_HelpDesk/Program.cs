using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration_HelpDesk
{
    class Program
    {
        static void Main(string[] args)
        {
            //  create List of Todos
            List<HelpDeskCalls> helps = new List<HelpDeskCalls>()
            {
                new HelpDeskCalls { DescriptionOfProblem ="Error 404 - File Not Found",
                    DateReported = new DateTime(2019, 01, 14, 20, 35, 55), Priority = Priority.Low,
                    Status = Status.NotStarted, PersonWhoReportedProblem = "Bruce Wayne", Notes = ""},
                new HelpDeskCalls { DescriptionOfProblem ="Error 500 - Unexpected Error",
                    DateReported = new DateTime(2019, 01, 24, 12, 55, 32), Priority = Priority.Medium,
                    Status = Status.InProg, PersonWhoReportedProblem = "Clark Kent", Notes = ""},
                new HelpDeskCalls { DescriptionOfProblem ="Error 413 - Payload Too Large",
                    DateReported = new DateTime(2019, 01, 16, 23, 31, 19), Priority = Priority.Medium,
                    Status = Status.Completed, PersonWhoReportedProblem = "Diana Prince", Notes = ""},
                new HelpDeskCalls { DescriptionOfProblem ="Error 508 - Loop Detected",
                    DateReported = new DateTime(2019, 02, 11, 23, 00, 12), Priority = Priority.High,
                    Status = Status.Unresolved, PersonWhoReportedProblem = "Barry Allen", Notes = ""},
                new HelpDeskCalls { DescriptionOfProblem ="Error 401 - Unauthorized",
                    DateReported = new DateTime(2019, 02, 11, 23, 00, 12), Priority = Priority.High,
                    Status = Status.NotStarted, PersonWhoReportedProblem = "Arthur Curry", Notes = ""},
                new HelpDeskCalls { DescriptionOfProblem ="Error 405 - Method not supported",
                    DateReported = new DateTime(2019, 02, 11, 23, 00, 12), Priority = Priority.Medium,
                    Status = Status.InProg, PersonWhoReportedProblem = "Victor Stone", Notes = ""},
                new HelpDeskCalls { DescriptionOfProblem ="Error 500 - An error occurred during execution of custom server code",
                    DateReported = new DateTime(2019, 02, 11, 23, 00, 12), Priority = Priority.Medium,
                    Status = Status.Completed, PersonWhoReportedProblem = "Hal Jordan", Notes = ""},
                new HelpDeskCalls { DescriptionOfProblem ="Error 403 - Invalid username or password",
                    DateReported = new DateTime(2019, 02, 11, 23, 00, 12), Priority = Priority.Low,
                    Status = Status.Unresolved, PersonWhoReportedProblem = "J'onn J'onzz", Notes = ""}
            };

            PrintHelps(helps);



        }   //  end main

        private static void PrintHelps(List<HelpDeskCalls> helps)
        {
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var help in helps)
            {
                switch (help.Status)
                {
                    case Status.NotStarted:
                        help.Notes = "Just reported";
                        break;
                    case Status.InProg:
                        help.Notes = "Help Desk personnel on scene";
                        break;
                    case Status.Completed:
                        help.Notes = "Ticket is complete";
                        break;
                    case Status.Unresolved:
                        help.Notes = "Ongoing investigation";
                        break;
                }   //  end switch
                //Print the Description of problem, Date reported, Status, Priority, Person who reported problem, and Notes.
                Console.WriteLine("\nProblem Discription: " + help.DescriptionOfProblem + 
                                  "\nDate Reported: " + help.DateReported +
                                  "\nStatus: " + help.Status +
                                  "\nPriority: " + help.Priority +
                                  "\nPerson Reporting: " + help.PersonWhoReportedProblem +
                                  "\nNotes: " + help.Notes);
            }   //  end foreach
            Console.WriteLine("\n\n");

            foreach (var help in helps)
            {
                switch (help.Priority)
                {
                    case Priority.Low:
                        Console.WriteLine("The problem is on the back-burner.\n");
                        break;
                    case Priority.Medium:
                        Console.WriteLine("The problem is important.\n");
                        break;
                    case Priority.High:
                        Console.WriteLine("The problem is critical.\n");
                        break;
                }
            }
                Console.ReadLine();
        }   //  end PrintTask method

    }   //  end Program class

    class HelpDeskCalls
    {
        public string DescriptionOfProblem { get; set; }
        public DateTime DateReported { get; set; }
        public Status Status { get; set; }
        public Priority Priority { get; set; }
        public string PersonWhoReportedProblem { get; set; }
        public string Notes { get; set; }

    }   //  end Todo class

    enum Status
    {
        NotStarted,
        InProg,
        Completed,
        Unresolved
    }   //  end Status enum

    enum Priority
    {
        Low,
        Medium,
        High
    }   //  end Days enum

}   //  end NameSpace
