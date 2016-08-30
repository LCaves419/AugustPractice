using System;

namespace Grades
{
    public class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();

            bool good = true;
            while (good)
            {
                try
                {
                    Console.WriteLine("Enter a name:");
                    book.Name = Console.ReadLine();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    //Console.WriteLine(ex.StackTrace);
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine("Something went wrong!");
                }

                float grf = 0;
                string gr = "";

                try
                {
                    Console.WriteLine("Enter a grade");
                    gr = Console.ReadLine();
                    grf = float.Parse(gr);
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine("Something went wrong!");
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                if (grf >= 0)
                    book.AddGrade(grf);
                else
                {
                    good = false;
                }
            }

            GradeStats stats = book.ComputeStats();
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            WriteResult("Grade", stats.LetterGrade);
        }

        //Write Letter Grade
        static void WriteResult(string description, string result)
        {
            Console.WriteLine($"{description} : {result}", description, result);
        }

        //Write Grade Stats
        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description} : {result}", description, result);
            //:F2 formats floating point numbers
        }




    }


    //SpeechSynthesizer synth = new SpeechSynthesizer();
    //synth.Speak("Hello this is the Gradebook program");


    ////GradeBook.AddGrade(91); => if static class Gradebook
    //GradeBook book = new GradeBook();
    //book.AddGrade(91);
    //book.AddGrade(89.5f);//makes complier teat 89.5 as a float
    //book.AddGrade(75);

    //GradeBook g1 = new GradeBook();
    //GradeBook g2 = new GradeBook();
    //g1.Name = "Lara";


    //book.NameChanged += new NameChangedDelegate(OnNameChanged);
    //book.Name = "Lara's GradeBook";
    //book.Name = "GradeBook";
    //Console.WriteLine(book.Name);
    //static void OnNameChanged(object sender, NameChangedEventArgs args)
    //{
    //    Console.WriteLine($"GradeBook changing name from {args.ExistingName} to {args.NewName}");
    //}



}
