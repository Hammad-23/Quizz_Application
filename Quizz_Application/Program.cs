using System;

namespace Quizz_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in Quizz App");
            Console.WriteLine("");
            Console.WriteLine("We have two categories of Quizz");
            Console.WriteLine("1) Computer Science");
            Console.WriteLine("2) General Knowledge");
            Console.WriteLine("");
            Console.Write("Enter option number to select the quizz:  ");
            int quizzCategory = int.Parse(Console.ReadLine());
            if (quizzCategory == 1)
            {
                Console.Clear();
                QuizzComputer();
            }
            else if (quizzCategory == 2)
            {
                Console.Clear();
                QuizzGK();
            }
            else
            {
                Console.WriteLine("Invalid Option");
            }
        }

        static void QuizzComputer()
        {
            string[][] questions = new string[10][];
            questions[0] = new string[5] { "Q1) Which of the following languages is more suited to a structured program?", "PL/1", "FORTRAN", "BASIC", "PASCAL" };
            questions[1] = new string[5] { "Q2) The brain of any computer system is", "ALU", "Memory", "CPU", "Control unit" };
            questions[2] = new string[5] { "Q3) Which of the following computer language is used for artificial intelligence?", "FORTRAN", "PROLOG", "C", "COBOL" };
            questions[3] = new string[5] { "Q4) Which of the following is the 1's complement of 10?", "01", "110", "11", "10" };
            questions[4] = new string[5] { "Q5) Which part interprets program instructions and initiate control operations.", "Input", "Storage unit", "Logic unit", "Control unit" };
            questions[5] = new string[5] { "Q6) The binary system uses powers of", "2", "10", "8", "16" };
            questions[6] = new string[5] { "Q7) A computer program that converts assembly language to machine language is", "Compiler", "Interpreter", "Assembler", "Comparator" };
            questions[7] = new string[5] { "Q8) The time for which a piece of equipment operates is called", "Seek time", "Effective time", "Access time", "Real time" };
            questions[8] = new string[5] { "Q9) A name applied by Intel corp. to high speed MOS technology is called", "HDLC", "LAP", "HMOS", "SDLC" };
            questions[9] = new string[5] { "Q10) A common boundary between two systems is called", "Interdiction", "Interface", "Surface", "None of the above" };

            string[] optionNumbers = { "", "A) ", "B) ", "C) ", "D) " };
            string[] ans = new string[10];
            int score = 0;
            string[] correct = { "PASCAL", "CPU", "PROLOG", "01", "Control unit", "2", "Assembler", "Effective time", "HMOS", "Interface" };
            for (int i = 0; i < questions.Length; i++)
            {

                for (int j = 0; j < questions[i].Length; j++)
                {
                    Console.WriteLine(optionNumbers[j] + questions[i][j]);
                }
                Console.Write("Enter option:  ");
                char opt = char.Parse(Console.ReadLine());
                if (opt == 'a' || opt == 'A')
                {
                    ans[i] = questions[i][1];
                }
                else if (opt == 'b' || opt == 'B')
                {
                    ans[i] = questions[i][2];
                }
                else if (opt == 'c' || opt == 'C')
                {
                    ans[i] = questions[i][3];
                }
                else if (opt == 'd' || opt == 'D')
                {
                    ans[i] = questions[i][4];
                }
                else
                {
                    Console.WriteLine("Invalid Option");
                }
                Console.Clear();
                Console.WriteLine("");

            }

            for (int k = 0; k < correct.Length; k++)
            {
                if (correct[k] == ans[k])
                {
                    score++;
                }

            }
            Console.WriteLine("");
            Result(score);

        }



        static void QuizzGK()
        {
            string[][] questions = new string[10][];
            questions[0] = new string[5] { "Q1) Sultan Ahmed Mosque in Istanbul is popularly known as the", "Green Mosque", "Blue Mosque", "Red Mosque", "Yellow Mosque" };
            questions[1] = new string[5] { "Q2) Joe Biden on 20 January 2021 became the ___ president of the United States.", "45th", "46th", "47th", "48th" };
            questions[2] = new string[5] { "Q3) According to Pfizer pharmaceutical company, their Covid-19 vaccine has __ effective rate.", "80%", "85%", "90%", "95%" };
            questions[3] = new string[5] { "Q4) What is the hottest continent on Earth?", "Africa", "Asia", "Antarctica", "Europe" };
            questions[4] = new string[5] { "Q5) The birthplace of the World Wide Web was", "NASA", "Pentagon", "CERN", "Microsoft" };
            questions[5] = new string[5] { "Q6) Which country contains the most volcanoes in the world?", "Indonesia", "Maldives", "South Africa", "Mexico" };
            questions[6] = new string[5] { "Q7) The oldest university in the world is", "Cambridge University", "Oxford University", "University of Bologna", "University of Warwick" };
            questions[7] = new string[5] { "Q8) Which country is also called “Rainbow Nation”?", "Japan", "Norway", "Netherlands", "South Africa" };
            questions[8] = new string[5] { "Q9) ‘Aksai Chin’ is a disputed area between", "China and India", "China and Pakistan", "India and Pakistan", "India and Nepal" };
            questions[9] = new string[5] { "Q10) Yellow Sea lies between", "America and Canada", "England and France", "China and Korea", "Norway and Sweden" };

            string[] optionNumbers = { "", "A) ", "B) ", "C) ", "D) " };
            string[] ans = new string[10];
            int score = 0;
            string[] correct = { "Blue Mosque", "46th", "95%", "Africa", "CERN", "Indonesia", "University of Bologna", "South Africa", "China and India", "China and Korea" };
            for (int i = 0; i < questions.Length; i++)
            {
                for (int j = 0; j < questions[i].Length; j++)
                {
                    Console.WriteLine(optionNumbers[j] + questions[i][j]);
                }
                Console.Write("Enter option:  ");
                char opt = char.Parse(Console.ReadLine());
                if (opt == 'a' || opt == 'A')
                {
                    ans[i] = questions[i][1];
                }
                else if (opt == 'b' || opt == 'B')
                {
                    ans[i] = questions[i][2];
                }
                else if (opt == 'c' || opt == 'C')
                {
                    ans[i] = questions[i][3];
                }
                else if (opt == 'd' || opt == 'D')
                {
                    ans[i] = questions[i][4];
                }
                else
                {
                    Console.WriteLine("Invalid Option");
                }
                Console.Clear();
                Console.WriteLine("");

            }

            for (int k = 0; k < correct.Length; k++)
            {
                if (correct[k] == ans[k])
                {
                    score++;
                }

            }
            Console.WriteLine("");
            Result(score);



        }


        static void Result(int _score)
        {

            if (_score <= 10 && _score >= 7)
            {
                Console.WriteLine("Your Score is " + _score);
                Console.WriteLine("");
                Console.WriteLine("Good Result");
            }
            else if (_score >= 5 && _score <= 6)
            {
                Console.WriteLine("Your Score is " + _score);
                Console.WriteLine("");
                Console.WriteLine("Average Result");
            }
            else if (_score >= 1 && _score <= 4)
            {
                Console.WriteLine("Your Score is " + _score);
                Console.WriteLine("");
                Console.WriteLine("You need to work hard");
            }
            else if (_score == 0)
            {
                Console.WriteLine("Your Score is " + _score);
                Console.WriteLine("");
                Console.WriteLine("Sorry you are failed");
            }

        }
        }
}
