using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int yob=0;
            int mob=0;
            int dob=0;
            

            try
            {
                Console.WriteLine("Enter the year of your birth");
                yob = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the month of your birth");
                mob = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the date of your birth");
                dob = Convert.ToInt32(Console.ReadLine());
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);


            }

           int rCode = CheckTheBirthDate( yob,mob,dob);







            switch (rCode)
            {
                case 0:
                    Console.WriteLine("hey! you are born today.Welcome");
                    break;
                case 1:
                    Console.WriteLine("You have entered a future date");
                    break;
                case 2:
                    Console.WriteLine("You are lucky to leave 135 years");
                    break;
                case -1:
                    Console.WriteLine("you are born in this year");
                    break;
                case 3:
                    CalculateAge(yob, mob, dob);
                    if (TodayBirthday(mob, dob))
                    {
                        Console.WriteLine("happy birthday");

                    }
                    Console.WriteLine(DisplayAstrologicalsighns(mob, dob));
                    break;

                default:
                    Console.WriteLine("Please check your input");


                    break;


            }



            Console.ReadLine();

        }

        private static void CalculateAge(int yob, int mob, int dob)
        {
            DateTime bdate = new DateTime(yob, mob, dob);
            DateTime tdate = DateTime.Today;
            if (tdate.Year > bdate.Year && tdate.Month > bdate.Month && tdate.Day > bdate.Day)
            {
                Console.WriteLine("your age is");
                Console.WriteLine("Year: " + (tdate.Year - bdate.Year) + " Month: " + (tdate.Month - bdate.Month) + " Date: " + (tdate.Day - bdate.Day));
            }
            else
            {
                Console.WriteLine("your age is");
                Console.WriteLine("Year: " + (tdate.Year - bdate.Year) + " Month: " + ((tdate.Month - 1) + (12 - bdate.Month)) + " Date: " + ((30 - tdate.Day) + (bdate.Day)));
            }
            return;
        }




        private static String DisplayAstrologicalsighns(int mob, int dob)
        {
            switch (mob)
            {
                case 1:
                    if (dob <= 20)
                    {
                        return "capricorn";
                    }
                    else
                    {
                        return "Aquarius";
                    }
                case 2:
                    if (dob <= 18)
                    {
                        return "Aquarius";
                    }
                    else
                    {
                        return "Pisces";
                    }
                case 3:
                    if (dob <= 20)
                    {
                        return "Pisces";
                    }
                    else
                    {
                        return "Aries";
                    }
                case 4:
                    if (dob <= 20)
                    {
                        return "Aries";
                    }
                    else
                    {
                        return "Taurus";
                    }
                case 5:
                    if (dob <= 21)
                    {
                        return "Tauras";
                    }
                    else
                    {
                        return "Gemini";
                    }
                case 6:
                    if (dob <= 21)
                    {
                        return "Gemini";
                    }
                    else
                    {
                        return "Cancer";
                    }
                case 7:
                    if (dob <= 22)
                    {
                        return "Cancer";
                    }
                    else
                    {
                        return "Leo";
                    }
                case 8:
                    if (dob <= 23)
                    {
                        return "Leo";
                    }
                    else
                    {
                        return "Virgo";
                    }
                case 9:
                    if (dob <= 22)
                    {
                        return "Virgo";
                    }
                    else
                    {
                        return "Libra";
                    }
                case 10:
                    if (dob <= 23)
                    {
                        return "Libra";
                    }
                    else
                    {
                        return "Scorpio";
                    }
                case 11:
                    if (dob <= 22)
                    {
                        return "Scorpio";
                    }
                    else
                    {
                        return "Sagittarius";
                    }
                case 12:
                    if (dob <= 21)
                    {
                        return "Sagittarius";
                    }
                    else
                    {
                        return "Capricon";
                    }
                default:
                    return "null";





            }


        }

        private static bool TodayBirthday(int mob, int dob)
        {
            DateTime tdy = DateTime.Today;
            if (mob == tdy.Month && dob == tdy.Day)
            {
                return true;
            }
            else
                return false;

        }

        private static int CheckTheBirthDate(int yob, int mob, int dob)
        {
            DateTime bdate = new DateTime(yob, mob, dob);
            DateTime tdate = DateTime.Today;
            int rValue = DateTime.Compare(bdate, DateTime.Now);
            if (rValue < 0)
            {
                if ((tdate.Year - bdate.Year) >= 135)
                {
                    return 2;
                }
                else
                {
                    if ((tdate.Year - bdate.Year) == 0)
                    {
                        return -1;
                    }
                    else
                    {
                        return 3;

                    }
                }
            }
            else if (rValue > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
    }
}























