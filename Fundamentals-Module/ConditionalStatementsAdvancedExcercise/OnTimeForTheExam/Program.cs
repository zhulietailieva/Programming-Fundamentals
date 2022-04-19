using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMins = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMins = int.Parse(Console.ReadLine());
            string arriving = "";

            if (arrivalHour == examHour)
            {
                if (examMins - arrivalMins < 0)
                {
                    arriving = "late";
                }
                else if (examMins - arrivalMins <= 30)
                {
                    arriving = "on time";
                }
                else
                {
                    arriving = "early";
                }
            }
            else if (arrivalHour == examHour - 1)
            {
                if (examMins >= 30)
                {
                    arriving = "early";
                }
                else if (arrivalMins<30)
                {
                    arriving = "early";
                }
                else if (Math.Abs(arrivalMins - examMins) < 30)
                {
                    arriving = "early";
                }
                else
                {
                    arriving = "on time";
                }
            }
            else if (examHour-arrivalHour >= 2)
            {
                arriving = "early";
            }
            
            else
            {
                arriving = "late";
            }
            switch (arriving)
            {
                case "early":
                    Console.WriteLine("Early");
                    if (arrivalHour == examHour)
                    {
                        Console.WriteLine($"{(Math.Abs(arrivalMins - examMins)):d2} minutes before the start");
                    }
                    else if (arrivalHour == examHour - 1 && arrivalMins == examMins)
                    {
                        Console.WriteLine($"{Math.Abs(examHour - arrivalHour)}:{(Math.Abs(arrivalMins - examMins)):d2} hours before the start");
                    }
                    else if (arrivalHour == examHour-1&& Math.Abs(arrivalMins - examMins) < 30)
                    {
                        Console.WriteLine($"{((60-arrivalMins)+examMins):d2} minutes before the start");
                    }
                    else
                    {
                        if (examMins < arrivalMins)
                        {
                            Console.WriteLine($"{Math.Abs(examHour - arrivalHour-1)}:{((60-arrivalMins)+examMins):d2} hours before the start");
                        }
                        else
                        {
                            Console.WriteLine($"{Math.Abs(examHour - arrivalHour)}:{(Math.Abs(arrivalMins - examMins)):d2} hours before the start");
                        }
                        
                    }
                    break;
                case "on time":
                    Console.WriteLine("On time");
                    if (examHour == arrivalHour && examMins == arrivalMins)
                    {
                        return;
                    }
                   else if (arrivalHour == examHour - 1)
                    {
                        Console.WriteLine($"{(60-arrivalMins)} minutes before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{(Math.Abs(arrivalMins - examMins)):d2} minutes before the start");
                    }
                    break;
                case "late":
                    Console.WriteLine("Late");
                    if (arrivalHour == examHour)
                    {
                        Console.WriteLine($"{(Math.Abs(arrivalMins - examMins)):d2} minutes after the start");
                      
                    }
                    else if (arrivalHour == examHour + 1 && arrivalMins == examMins)
                    {
                        Console.WriteLine($"{Math.Abs(examHour - arrivalHour)}:{(Math.Abs(arrivalMins - examMins)):d2} hours after the start");
                    }
                    else if (arrivalHour == examHour + 1 && Math.Abs(arrivalMins - examMins) < 30)
                    {
                        Console.WriteLine($"{((60 - examMins) + arrivalMins):d2} minutes after the start");
                    }
                    else
                    {
                        if (examMins > arrivalMins)
                        {
                            Console.WriteLine($"{Math.Abs(examHour - arrivalHour + 1)}:{((60 - examMins) + arrivalMins):d2} hours after the start");
                        }
                        else
                        {
                             Console.WriteLine($"{Math.Abs(examHour-arrivalHour)}:{(Math.Abs(arrivalMins - examMins)):d2} hours after the start");
                        }
                       
                    }
                    break;
            }
        }
    }
}
