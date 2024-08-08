using System;
using System.Threading;
using System.Collections.Generic;

class Program
{
  //Anorexia Meal List
    static List<string> mealsA = new List<string> { System.IO.File.ReadAllText(@"mealsA/B1"), System.IO.File.ReadAllText(@"mealsA/B2"), System.IO.File.ReadAllText(@"mealsA/B3"), System.IO.File.ReadAllText(@"mealsA/B4"), System.IO.File.ReadAllText(@"mealsA/B5"), System.IO.File.ReadAllText(@"mealsA/B6"), System.IO.File.ReadAllText(@"mealsA/B7"), System.IO.File.ReadAllText(@"mealsA/L1"), System.IO.File.ReadAllText(@"mealsA/L2"), System.IO.File.ReadAllText(@"mealsA/L3"), System.IO.File.ReadAllText(@"mealsA/L4"), System.IO.File.ReadAllText(@"mealsA/L5"), System.IO.File.ReadAllText(@"mealsA/L6"), System.IO.File.ReadAllText(@"mealsA/L7"), System.IO.File.ReadAllText(@"mealsA/D1"), System.IO.File.ReadAllText(@"mealsA/D2"), System.IO.File.ReadAllText(@"mealsA/D3"), System.IO.File.ReadAllText(@"mealsA/D4"), System.IO.File.ReadAllText(@"mealsA/D5"), System.IO.File.ReadAllText(@"mealsA/D6"), System.IO.File.ReadAllText(@"mealsA/D7") };

  //Bulimia Meal List
    static List<string> mealsB = new List<string> { System.IO.File.ReadAllText(@"mealsB/B1"), System.IO.File.ReadAllText(@"mealsB/B2"), System.IO.File.ReadAllText(@"mealsB/B3"), System.IO.File.ReadAllText(@"mealsB/B4"), System.IO.File.ReadAllText(@"mealsB/B5"), System.IO.File.ReadAllText(@"mealsB/B6"), System.IO.File.ReadAllText(@"mealsB/B7"),  System.IO.File.ReadAllText(@"mealsB/L1"), System.IO.File.ReadAllText(@"mealsB/L2"), System.IO.File.ReadAllText(@"mealsB/L3"), System.IO.File.ReadAllText(@"mealsB/L4"), System.IO.File.ReadAllText(@"mealsB/L5"), System.IO.File.ReadAllText(@"mealsB/L6"), System.IO.File.ReadAllText(@"mealsB/L7"), System.IO.File.ReadAllText(@"mealsB/D1"), System.IO.File.ReadAllText(@"mealsB/D2"), System.IO.File.ReadAllText(@"mealsB/D3"), System.IO.File.ReadAllText(@"mealsB/D4"), System.IO.File.ReadAllText(@"mealsB/D5"), System.IO.File.ReadAllText(@"mealsB/D6"), System.IO.File.ReadAllText(@"mealsB/D7")  };

  //BingeEating Meal List
    static List<string> mealsC = new List<string> {System.IO.File.ReadAllText(@"mealsC/B1"), System.IO.File.ReadAllText(@"mealsC/B2"), System.IO.File.ReadAllText(@"mealsC/B3"), System.IO.File.ReadAllText(@"mealsC/B4"), System.IO.File.ReadAllText(@"mealsC/B5"), System.IO.File.ReadAllText(@"mealsC/B6"), System.IO.File.ReadAllText(@"mealsC/B7"),  System.IO.File.ReadAllText(@"mealsC/L1"), System.IO.File.ReadAllText(@"mealsC/L2"), System.IO.File.ReadAllText(@"mealsC/L3"), System.IO.File.ReadAllText(@"mealsC/L4"), System.IO.File.ReadAllText(@"mealsC/L5"), System.IO.File.ReadAllText(@"mealsC/L6"), System.IO.File.ReadAllText(@"mealsC/L7"), System.IO.File.ReadAllText(@"mealsC/D1"), System.IO.File.ReadAllText(@"mealsC/D2"), System.IO.File.ReadAllText(@"mealsC/D3"), System.IO.File.ReadAllText(@"mealsC/D4"), System.IO.File.ReadAllText(@"mealsC/D5"), System.IO.File.ReadAllText(@"mealsC/D6"), System.IO.File.ReadAllText(@"mealsC/D7") };

    static string GenerateMealA()
    {
      //Meal Randomizer Anorexia
        var rand = new Random();
        string randomMeal = mealsA[rand.Next(mealsA.Count)];
        return randomMeal;
    }
    static string GenerateMealB()
    {
      //Meal Randomizer Bulimia
        var rand = new Random();
        string randomMeal = mealsB[rand.Next(mealsB.Count)];
        return randomMeal;
    }
    static string GenerateMealC()
    {
      //Meal Randomizer Binge Eating
        var rand = new Random();
        string randomMeal = mealsC[rand.Next(mealsC.Count)];
        return randomMeal;
    }

    //Typewriter Function
    public static void Typewriter(string message)
    {
        for (int x = 0; x < message.Length; x++)
        {
            Console.Write(message[x]);
            Thread.Sleep(20);
        }
        Console.WriteLine("");
    }

    //Fast Typewriter Function
    public static void FastTypewriter(string message)
    {
        for (int x = 0; x < message.Length; x++)
        {
            Console.Write(message[x]);
            Thread.Sleep(2);
        }
        Console.WriteLine("");
    }

    public static void Main(string[] args)
    {
      //Logo
      string logo = System.IO.File.ReadAllText(@"ascii/logo");
      string logoplant = System.IO.File.ReadAllText(@"ascii/logoplant");

        //Diagnosis Variables
        float countAnorexia, countBulimia, countBingeEating, percentAnorexia, percentBulimia, percentBingeEating, percentDiagnosis;
        string diagnosis = "none";
        string response; 
        string chance;
        int choice = 0;

        //Login Variables
        string username, password;
        string usernameCorrect = "PersonInRecovery";
        string passwordCorrect = "SPREAD";

        //Randomizer Variables
        int choiceED1 = 0;
        int choicerandomA;
        string randommealinputA;
        int choicerandomA2 = 0;
        int choicerandomB;
        string randommealinputB;
        int choicerandomB2 = 0;
        int choicerandomC;
        string randommealinputC;
        int choicerandomC2 = 0;

        //Meal Plan Variables
        int choiceED2;
        int MPAchoice;
        int MPBchoice;
        int MPCchoice;

        //Journal Variables
        int pageNumber = 0; 
        int pageEdit;
        string page1 = "...";
        string page2 = "...";
        string page3 = "...";
        string page4 = "...";
        string page5 = "...";
        string page6 = "...";
        string page7 = "...";
        string page8 = "...";
        string page9 = "...";
        string page10 = "...";

        //Consistency Tracker Variables
        int SPREADstreak = 0;
        int dayCounter = 1;
        int consistencyChoice;
        string relapse;

        //Productivity Tracker Variables
        string goal1 = "", goal2 = "", goal3 = "", goal4 = "", goal5 = "", goal6 =
          "", goal7 = "", goal8 = "", goal9 = "", goal10 = "";
        string goal1status = "In Progress";
        string goal2status = "In Progress";
        string goal3status = "In Progress";
        string goal4status = "In Progress";
        string goal5status = "In Progress";
        string goal6status = "In Progress";
        string goal7status = "In Progress";
        string goal8status = "In Progress";
        string goal9status = "In Progress";
        string goal10status = "In Progress";
        bool initialGoal = true;
        int counterPlant = 0;
        int goal;
        string currentPlant = System.IO.File.ReadAllText(@"ascii/currentplant");
        string plant0 = System.IO.File.ReadAllText(@"ascii/plant0");
        string plant1 = System.IO.File.ReadAllText(@"ascii/plant1");
        string plant2 = System.IO.File.ReadAllText(@"ascii/plant2");
        string plant3 = System.IO.File.ReadAllText(@"ascii/plant3");
        string plant4 = System.IO.File.ReadAllText(@"ascii/plant4");
        string plant5 = System.IO.File.ReadAllText(@"ascii/plant5");
        string plant6 = System.IO.File.ReadAllText(@"ascii/plant6");
        string plant7 = System.IO.File.ReadAllText(@"ascii/plant7");
        string plant8 = System.IO.File.ReadAllText(@"ascii/plant8");
        string plant9 = System.IO.File.ReadAllText(@"ascii/plant9");
        string plant10 = System.IO.File.ReadAllText(@"ascii/plant10");

        // Title Screen
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(logo);
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.White;

        Typewriter("Welcome to SPREAD! Your eating disorder recovery companion!");
        Console.WriteLine("");
        Typewriter("SPREAD stands for Supporting, Planning, Recovering from Eating Disorders");
        Typewriter("We aim to provide you comfort and support during your recovery journey!");
        Console.WriteLine("");
        Typewriter("Press any button to continue!");
        Console.ReadKey();
        Console.Clear();

        int LN = 0;
        while (LN <= 3)
        {
            // Login Screen
            Console.WriteLine(System.IO.File.ReadAllText(@"titles/LI"));
            Console.WriteLine("");
            Console.Write("Please enter your username: ");
            username = Console.ReadLine();
            Console.Write("Please enter your password: ");
            password = Console.ReadLine();
            if (username == usernameCorrect && password == passwordCorrect)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Typewriter("Welcome to SPREAD, " + usernameCorrect + "!");
                Thread.Sleep(500);
                LN = 5;
            }
            else
            {
                Console.WriteLine("Invalid Username or Password. Please try again. You have "+(3-LN)+" more attempts.");
                LN++;
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
        if (LN == 4)
            Console.WriteLine("You have reached the maximum number of attempts. Please try again later.");
        Thread.Sleep(2000);

        while (LN == 5)
        {
            if (choice == 0)
            {
                //Main Menu
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(System.IO.File.ReadAllText(@"titles/MainMenu"));
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("");
                Console.Write(@"What would you like to do today, Spreader? Choose the number of your choice!

        [1] Get an Unofficial Diagnosis 
        [2] Meal Randomizer
        [3] Get a Daily Meal Plan
        [4] Journaling
        [5] Consistency Tracker
        [6] Productivity Tracker
        [7] View Profile
        [8] Exit

        Action: ");

                choice = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            else if (choice == 1)
            {
                //Diagnosis QnA
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(System.IO.File.ReadAllText(@"titles/Diagnosis"));
                Typewriter("You have chosen to get diagnosed! You will be given some criteria so that you can discern which disorder you have.");
                Console.ReadKey();
                Console.Clear();

                countAnorexia = 0;
                countBulimia = 0;
                countBingeEating = 0;
              Console.WriteLine(System.IO.File.ReadAllText(@"titles/Diagnosis"));
                Typewriter("If you find that the symptom displayed relates to you, type Y. If not, type N.");
                Console.WriteLine("");

                Typewriter("Symptom 1 of 23");
                Typewriter("Alcohol and Drug Use");
                response = Console.ReadLine();
                if (response == "Y" || response == "y")
                { countBulimia++; }

                Console.Clear();
              Console.WriteLine(System.IO.File.ReadAllText(@"titles/Diagnosis"));
                Console.WriteLine("If you find that the symptom displayed relates to you, type Y. If not, type N.");
                Console.WriteLine("");
                Console.WriteLine("Symptom 2 of 23");
                Typewriter("Anxiety and Depression");
                response = Console.ReadLine();
                if (response == "Y" || response == "y")
                { countAnorexia++; countBulimia++; }

                Console.Clear();
              Console.WriteLine(System.IO.File.ReadAllText(@"titles/Diagnosis"));
                Console.WriteLine("If you find that the symptom displayed relates to you, type Y. If not, type N.");
                Console.WriteLine("");
                Console.WriteLine("Symptom 3 of 23");
                Typewriter("Dangerous amounts of exercising or fasting");
                response = Console.ReadLine();
                if (response == "Y" || response == "y")
                { countAnorexia += 2; countBulimia += 2; }

                Console.Clear();
              Console.WriteLine(System.IO.File.ReadAllText(@"titles/Diagnosis"));
                Console.WriteLine("If you find that the symptom displayed relates to you, type Y. If not, type N.");
                Console.WriteLine("");
                Console.WriteLine("Symptom 4 of 23");
                Typewriter("Dehydration");
                response = Console.ReadLine();
                if (response == "Y" || response == "y")
                { countAnorexia++; }

                Console.Clear();
              Console.WriteLine(System.IO.File.ReadAllText(@"titles/Diagnosis"));
                Console.WriteLine("If you find that the symptom displayed relates to you, type Y. If not, type N.");
                Console.WriteLine("");
                Console.WriteLine("Symptom 5 of 23");
                Typewriter("Denial of Hunger");
                response = Console.ReadLine();
                if (response == "Y" || response == "y")
                { countAnorexia++; }

                Console.Clear();
              Console.WriteLine(System.IO.File.ReadAllText(@"titles/Diagnosis"));
                Console.WriteLine("If you find that the symptom displayed relates to you, type Y. If not, type N.");
                Console.WriteLine("");
                Console.WriteLine("Symptom 6 of 23");
                Typewriter("Eating exorbitant amounts of food in a short amount of time");
                response = Console.ReadLine();
                if (response == "Y" || response == "y")
                { countBulimia += 2; countBingeEating += 2; }

                Console.Clear();
              Console.WriteLine(System.IO.File.ReadAllText(@"titles/Diagnosis"));
                Console.WriteLine("If you find that the symptom displayed relates to you, type Y. If not, type N.");
                Console.WriteLine("");
                Console.WriteLine("Symptom 7 of 23");
                Typewriter("Eating even when you are full and not hungry");
                response = Console.ReadLine();
                if (response == "Y" || response == "y")
                { countBingeEating += 2; }

                Console.Clear();
              Console.WriteLine(System.IO.File.ReadAllText(@"titles/Diagnosis"));
                Console.WriteLine("If you find that the symptom displayed relates to you, type Y. If not, type N.");
                Console.WriteLine("");
                Console.WriteLine("Symptom 8 of 23");
                Typewriter("Eating to the point of discomfort");
                response = Console.ReadLine();
                if (response == "Y" || response == "y")
                { countBingeEating += 2; }

                Console.Clear();
              Console.WriteLine(System.IO.File.ReadAllText(@"titles/Diagnosis"));
                Console.WriteLine("If you find that the symptom displayed relates to you, type Y. If not, type N.");
                Console.WriteLine("");
                Console.WriteLine("Symptom 9 of 23");
                Typewriter("Eating in secret to avoid embarrassment");
                response = Console.ReadLine();
                if (response == "Y" || response == "y")
                { countBulimia += 2; countBingeEating += 2; }

                Console.Clear();
              Console.WriteLine(System.IO.File.ReadAllText(@"titles/Diagnosis"));
                Console.WriteLine("If you find that the symptom displayed relates to you, type Y. If not, type N.");
                Console.WriteLine("");
                Console.WriteLine("Symptom 10 of 23");
                Typewriter("Extreme thinness");
                response = Console.ReadLine();
                if (response == "Y" || response == "y")
                { countAnorexia += 2; }

                Console.Clear();
              Console.WriteLine(System.IO.File.ReadAllText(@"titles/Diagnosis"));
                Console.WriteLine("If you find that the symptom displayed relates to you, type Y. If not, type N.");
                Console.WriteLine("");
                Console.WriteLine("Symptom 11 of 23");
                Typewriter("Extreme stomach pain and constipation");
                response = Console.ReadLine();
                if (response == "Y" || response == "y")
                { countAnorexia++; }

                Console.Clear();
              Console.WriteLine(System.IO.File.ReadAllText(@"titles/Diagnosis"));
                Console.WriteLine("If you find that the symptom displayed relates to you, type Y. If not, type N.");
                Console.WriteLine("");
                Console.WriteLine("Symptom 12 of 23");
                Typewriter("Fear of becoming fat or gaining weight");
                response = Console.ReadLine();
                if (response == "Y" || response == "y")
                { countAnorexia += 2; countBulimia += 2; }

                Console.Clear();
              Console.WriteLine(System.IO.File.ReadAllText(@"titles/Diagnosis"));
                Console.WriteLine("If you find that the symptom displayed relates to you, type Y. If not, type N.");
                Console.WriteLine("");
                Console.WriteLine("Symptom 13 of 23");
                Typewriter("Fear regarding not being able to stop eating");
                response = Console.ReadLine();
                if (response == "Y" || response == "y")
                { countBulimia += 2; }

                Console.Clear();
              Console.WriteLine(System.IO.File.ReadAllText(@"titles/Diagnosis"));
                Console.WriteLine("If you find that the symptom displayed relates to you, type Y. If not, type N.");
                Console.WriteLine("");
                Console.WriteLine("Symptom 14 of 23");
                Typewriter("Feeling shame about eating");
                response = Console.ReadLine();
                if (response == "Y" || response == "y")
                { countBingeEating++; }

                Console.Clear();
              Console.WriteLine(System.IO.File.ReadAllText(@"titles/Diagnosis"));
                Console.WriteLine("If you find that the symptom displayed relates to you, type Y. If not, type N.");
                Console.WriteLine("");
                Console.WriteLine("Symptom 15 of 23");
                Typewriter("Hiding and hoarding food for later");
                response = Console.ReadLine();
                if (response == "Y" || response == "y")
                { countBingeEating++; }

                Console.Clear();
              Console.WriteLine(System.IO.File.ReadAllText(@"titles/Diagnosis"));
                Console.WriteLine("If you find that the symptom displayed relates to you, type Y. If not, type N.");
                Console.WriteLine("");
                Console.WriteLine("Symptom 16 of 23");
                Typewriter("Increased irritability");
                response = Console.ReadLine();
                if (response == "Y" || response == "y")
                { countAnorexia++; }

                Console.Clear();
              Console.WriteLine(System.IO.File.ReadAllText(@"titles/Diagnosis"));
                Console.WriteLine("If you find that the symptom displayed relates to you, type Y. If not, type N.");
                Console.WriteLine("");
                Console.WriteLine("Symptom 17 of 23");
                Typewriter("Lethargy");
                response = Console.ReadLine();
                if (response == "Y" || response == "y")
                { countAnorexia++; countBulimia++; }

                Console.Clear();
              Console.WriteLine(System.IO.File.ReadAllText(@"titles/Diagnosis"));
                Console.WriteLine("If you find that the symptom displayed relates to you, type Y. If not, type N.");
                Console.WriteLine("");
                Console.WriteLine("Symptom 18 of 23");
                Typewriter("Low self-esteem or feeling of hopelessness");
                response = Console.ReadLine();
                if (response == "Y" || response == "y")
                { countBulimia++; }

                Console.Clear();
              Console.WriteLine(System.IO.File.ReadAllText(@"titles/Diagnosis"));
                Console.WriteLine("If you find that the symptom displayed relates to you, type Y. If not, type N.");
                Console.WriteLine("");
                Console.WriteLine("Symptom 19 of 23");
                Typewriter("Obsessive with food preparations such as calorie counting");
                response = Console.ReadLine();
                if (response == "Y" || response == "y")
                { countAnorexia += 2; }

                Console.Clear();
              Console.WriteLine(System.IO.File.ReadAllText(@"titles/Diagnosis"));
                Console.WriteLine("If you find that the symptom displayed relates to you, type Y. If not, type N.");
                Console.WriteLine("");
                Console.WriteLine("Symptom 20 of 23");
                Typewriter("Persistent pursuit for thinness regardless of what is considered healthy");
                response = Console.ReadLine();
                if (response == "Y" || response == "y")
                { countAnorexia += 2; }

                Console.Clear();
              Console.WriteLine(System.IO.File.ReadAllText(@"titles/Diagnosis"));
                Console.WriteLine("If you find that the symptom displayed relates to you, type Y. If not, type N.");
                Console.WriteLine("");
                Console.WriteLine("Symptom 21 of 23");
                Typewriter("Social and emotional withdrawal");
                response = Console.ReadLine();
                if (response == "Y" || response == "y")
                { countAnorexia++; }

                Console.Clear();
              Console.WriteLine(System.IO.File.ReadAllText(@"titles/Diagnosis"));
                Console.WriteLine("If you find that the symptom displayed relates to you, type Y. If not, type N.");
                Console.WriteLine("");
                Console.WriteLine("Symptom 22 of 23");
                Typewriter("Tiredness and decreased energy");
                response = Console.ReadLine();
                if (response == "Y" || response == "y")
                { countBulimia++; }

                Console.Clear();
              Console.WriteLine(System.IO.File.ReadAllText(@"titles/Diagnosis"));
                Console.WriteLine("If you find that the symptom displayed relates to you, type Y. If not, type N.");
                Console.WriteLine("");
                Console.WriteLine("Symptom 23 of 23");
                Typewriter("Unusual eating habits");
                response = Console.ReadLine();
                if (response == "Y" || response == "y")
                { countAnorexia++; countBulimia++; countBingeEating++; }

                percentAnorexia = (countAnorexia / 18) * 100;
                percentBulimia = (countBulimia / 16) * 100;
                percentBingeEating = (countBingeEating / 11) * 100;

                //Determining Diagnosis
                if (percentAnorexia > percentBulimia)
                {
                    if (percentAnorexia > percentBingeEating)
                    { diagnosis = "Anorexia nervosa"; percentDiagnosis = percentAnorexia; }
                    else
                    { diagnosis = "Binge-eating disorder"; percentDiagnosis = percentBingeEating; }
                }
                else
                {
                    if (percentBulimia > percentBingeEating)
                    { diagnosis = "Bulimia nervosa"; percentDiagnosis = percentBulimia; }
                    else
                    { diagnosis = "Binge-eating disorder"; percentDiagnosis = percentBingeEating; }
                }

                if (percentDiagnosis < 30)
                { chance = "LOW"; }
                else if (percentDiagnosis < 70)
                { chance = "MODERATE"; }
                else
                { chance = "HIGH"; }

                Console.Clear();
              Console.WriteLine(System.IO.File.ReadAllText(@"titles/Diagnosis"));
                Typewriter("Diagnosis Results:");
                Console.WriteLine("");
                Typewriter("Anorexia nervosa: " + percentAnorexia + "% of symptoms matched");
                Typewriter("Bulimia nervosa: " + percentBulimia + "% of symptoms matched");
                Typewriter("Binge-eating: " + percentBingeEating + "% of symptoms matched");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Typewriter("You are most likely to have: " + diagnosis);
                Typewriter("Your chance of having this disorder is " + chance);
                Console.ReadKey();
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
              Console.WriteLine(System.IO.File.ReadAllText(@"titles/Diagnosis"));
                if(diagnosis == "Anorexia nervosa")
                {
                    Typewriter(@"Anorexia nervosa is an eating disorder that causes a severe and strong fear of gaining weight. 

For more information, visit https://my.clevelandclinic.org/health/diseases/9794-anorexia-nervosa.");
                }
              else if (diagnosis == "Bulimia nervosa")
                {
                    Typewriter(@"Bulimia nervosa is an eating disorder that causes you to eat large amounts of food at one time (binge) and then get rid of it (purge). 

For more information, visit https://my.clevelandclinic.org/health/diseases/9795-bulimia-nervosa.");
                }
                else if (diagnosis == "Binge-eating disorder")
                {
                    Typewriter(@"Binge eating is when you eat a large amount of food in a short amount of time and feel you can't control what or how much you are eating. Unlike other eating disorders, people who have binge eating disorder do not throw up the food or exercise too much. 

For more information, visit https://my.clevelandclinic.org/health/diseases/17652-binge-eating-disorder.");
                }
                Console.ReadKey();
                Console.Clear();

                choice = 0;
            }

            else if (choice == 2)
            {
                //RANDOMIZER
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(System.IO.File.ReadAllText(@"titles/MR"));
                Typewriter("You have chosen MEAL RANDOMIZER! In this feature you test your ability to overcome the fear of eating and/or find a random healthy meal to try.");
                Typewriter("To begin, choose the disorder you currently have..." + "\n" + "[1] Anorexia" + "\n" + "[2] Bulimia" + "\n" + "[3] Binge Eating");

                Console.WriteLine("");
                Console.Write("Action: ");
                choiceED1 = int.Parse(Console.ReadLine());
                Console.Clear();
              Console.WriteLine(System.IO.File.ReadAllText(@"titles/MR"));

                if (choiceED1 == 1)
                {
                    Typewriter("You have chosen to obtain an Anorexia meal plan!");
                    Typewriter("Would you like to: [1] add a custom meal to the randomizer or [2] skip to getting a meal?");
                    Console.WriteLine("");
                    Console.Write("Action: ");
                    choicerandomA = int.Parse(Console.ReadLine());
                    Console.Clear();
                  Console.WriteLine(System.IO.File.ReadAllText(@"titles/MR"));
                    while (choicerandomA == 1 || choicerandomA == 2 || choicerandomA == 3)
                    {
                        if (choicerandomA == 1)
                        {
                            Typewriter("You have chosen to add a meal! This is to encourage you to overcome your fear foods! Please enter the name of the meal you would like to add to the Randomizer List: ");

                          Console.WriteLine("");
                          Console.Write("Meal Name: ");
                            randommealinputA = Console.ReadLine();
                            mealsA.Add(randommealinputA);
                            Thread.Sleep(1500);
                            choicerandomA = 3;
                            Console.Clear();
                          Console.WriteLine(System.IO.File.ReadAllText(@"titles/MR"));
                        }
                        if (choicerandomA == 3)
                        {
                            Typewriter(@"Please select your next action 
  [1] Add another meal to the randomizer
  [2] Get your randomly generated meal");
                          Console.WriteLine("");
                          Console.Write("Action: ");
                            choicerandomA2 = int.Parse(Console.ReadLine());
                          Console.Clear();
                          Console.WriteLine(System.IO.File.ReadAllText(@"titles/MR"));
                            if (choicerandomA2 == 1)
                                choicerandomA = 1;
                            else if (choicerandomA2 == 2)
                                choicerandomA = 2;
                          }
                        if (choicerandomA == 2)
                            {
                                Typewriter("You have chosen to be given a random meal! Please press any button to get your meal!");
                                Console.ReadKey();
                                Console.WriteLine("");
                                Console.WriteLine(GenerateMealA());
                              Console.WriteLine("");
                                Thread.Sleep(1000);
                                Typewriter("Press any button to go back to the main menu.");
                                Console.ReadKey();
                                Console.Clear();
                                choicerandomA = 4;
                                choice = 0;
                            }

                        }
                    }

                else if (choiceED1 == 2)
                {
                    Typewriter("You have chosen to obtain an Bulimia meal plan!");
                    Typewriter("Would you like to: [1] add a custom meal to the randomizer or [2] skip to getting a meal?");
                  Console.WriteLine("");
                  Console.Write("Action: ");
                    choicerandomB = int.Parse(Console.ReadLine());
                    Console.Clear();
                  Console.WriteLine(System.IO.File.ReadAllText(@"titles/MR"));
                    while (choicerandomB == 1 || choicerandomB == 2 || choicerandomB == 3)
                    {
                        if (choicerandomB == 1)
                        {
                            Typewriter("You have chosen to add a meal! This is to encourage you to overcome your fear foods! Please enter the name of the meal you would like to add to the Randomizer List: ");
                          Console.WriteLine("");
                          Console.Write("Meal Name: ");

                            randommealinputB = Console.ReadLine();
                            mealsB.Add(randommealinputB);
                            Thread.Sleep(1500);
                            choicerandomB = 3;
                            Console.Clear();
                          Console.WriteLine(System.IO.File.ReadAllText(@"titles/MR"));
                        }
                        if (choicerandomB == 3)
                        {
                            Typewriter(@"Please select your next action 
  [1] Add another meal to the randomizer
  [2] Get your randomly generated meal");
                          Console.WriteLine("");
                          Console.Write("Action: ");
                            choicerandomB2 = int.Parse(Console.ReadLine());
                          Console.Clear();
                          Console.WriteLine(System.IO.File.ReadAllText(@"titles/MR"));
                            if (choicerandomB2 == 1)
                                choicerandomB = 1;
                          else if (choicerandomB2 == 2)
                                choicerandomB = 2;
                          }
                        if (choicerandomB == 2)
                            {
                                Typewriter("You have chosen to be given a random meal! Please press any button to get your meal!");
                                Console.ReadKey();
                              Console.WriteLine("");
                                Console.WriteLine(GenerateMealB());
                              Console.WriteLine("");
                                Thread.Sleep(1000);
                                Typewriter("Press any button to go back to the main menu.");
                                Console.ReadKey();
                                Console.Clear();
                                choicerandomB = 4;
                                choice = 0;
                            }

                        }
                }
                else if (choiceED1 == 3)
                {
                    Typewriter("You have chosen to obtain an Binge-eating meal plan!");
                    Typewriter("Would you like to: [1] add a custom meal to the randomizer or [2] skip to getting a meal?");
                  Console.WriteLine("");
                  Console.Write("Action: ");
                    choicerandomC = int.Parse(Console.ReadLine());
                    Console.Clear();
                  Console.WriteLine(System.IO.File.ReadAllText(@"titles/MR"));
                    while (choicerandomC == 1 || choicerandomC == 2 || choicerandomC == 3)
                    {
                        if (choicerandomC == 1)
                        {
                            Typewriter("You have chosen to add a meal! This is to encourage you to overcome your fear foods! Please enter the name of the meal you would like to add to the Randomizer List: ");
                          Console.WriteLine("");
                          Console.Write("Meal Name: ");

                            randommealinputC = Console.ReadLine();
                            mealsC.Add(randommealinputC);
                            Thread.Sleep(1500);
                            choicerandomC = 3;
                            Console.Clear();
                          Console.WriteLine(System.IO.File.ReadAllText(@"titles/MR"));
                        }
                        if (choicerandomC == 3)
                        {
                            Typewriter(@"Please select your next action 
  [1] Add another meal to the randomizer
  [2] Get your randomly generated meal");
                          Console.WriteLine("");
                          Console.Write("Action: ");
                            choicerandomC2 = int.Parse(Console.ReadLine());
                          Console.Clear();
                          Console.WriteLine(System.IO.File.ReadAllText(@"titles/MR"));
                            if (choicerandomC2 == 1)
                                choicerandomC = 1;
                          else if (choicerandomC2 == 2)
                                choicerandomC = 2;
                          }
                        if (choicerandomC == 2)
                            {
                                Typewriter("You have chosen to be given a random meal! Please press any button to get your meal!");
                                Console.ReadKey();
                                Console.WriteLine("");
                                Console.WriteLine(GenerateMealC());
                              Console.WriteLine("");
                                Thread.Sleep(1000);
                                Typewriter("Press any button to go back to the main menu.");
                                Console.ReadKey();
                                Console.Clear();
                                choicerandomC = 4;
                                choice = 0;
                            }

                        }
                }
                }
            else if (choice == 3)
            {    //MEAL PLAN
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(System.IO.File.ReadAllText(@"titles/MealPlan"));
                Typewriter("You have chosen MEAL PLAN! This feature gives you a pre-planned meal plan for the week!");
                Typewriter(@"To begin, please input the disorder that you are currently suffering from.
          [1] Anorexia
          [2] Bulimia
          [3] Binge Eating");
                Console.WriteLine("");
                Console.Write("Action: ");

                choiceED2 = int.Parse(Console.ReadLine());
              Console.Clear();
              Console.WriteLine(System.IO.File.ReadAllText(@"titles/MealPlan"));

                if (choiceED2 == 1)
                {
                  //Anorexia Meal Plans
                    Typewriter("To pick an anorexia recovery meal plan, type a random number from 1-7");
                    Console.WriteLine("");
                    Console.Write("Action: ");
                    MPAchoice = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    if (MPAchoice == 1)
                    {
                      Console.WriteLine("BREAKFAST: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsA/B1"));
                      Console.WriteLine("");
                      Console.WriteLine("LUNCH: ");                                
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsA/L1"));
                      Console.WriteLine("");
                      Console.WriteLine("DINNER: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsA/D1"));
                      Console.WriteLine("");
                    }
                    else if (MPAchoice == 2)
                    {
                      Console.WriteLine("BREAKFAST: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsA/B2"));
                      Console.WriteLine("");
                      Console.WriteLine("LUNCH: ");                                
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsA/L2"));
                      Console.WriteLine("");
                      Console.WriteLine("DINNER: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsA/D2"));
                      Console.WriteLine("");
                    }
                    else if (MPAchoice == 3)
                    {
                      Console.WriteLine("BREAKFAST: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsA/B3"));
                      Console.WriteLine("");
                      Console.WriteLine("LUNCH: ");                                
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsA/L3"));
                      Console.WriteLine("");
                      Console.WriteLine("DINNER: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsA/D3"));
                      Console.WriteLine("");
                    }
                    else if (MPAchoice == 4)
                    {
                      Console.WriteLine("BREAKFAST: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsA/B4"));
                      Console.WriteLine("");
                      Console.WriteLine("LUNCH: ");                                
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsA/L4"));
                      Console.WriteLine("");
                      Console.WriteLine("DINNER: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsA/D4"));
                      Console.WriteLine("");
                    }
                    else if (MPAchoice == 5)
                    {
                      Console.WriteLine("BREAKFAST: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsA/B5"));
                      Console.WriteLine("");
                      Console.WriteLine("LUNCH: ");                                
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsA/L5"));
                      Console.WriteLine("");
                      Console.WriteLine("DINNER: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsA/D5"));
                      Console.WriteLine("");
                    }
                    else if (MPAchoice == 6)
                    {
                      Console.WriteLine("BREAKFAST: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsA/B6"));
                      Console.WriteLine("");
                      Console.WriteLine("LUNCH: ");                                
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsA/L6"));
                      Console.WriteLine("");
                      Console.WriteLine("DINNER: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsA/D6"));
                      Console.WriteLine("");
                    }
                    else if (MPAchoice == 7)
                    {
                      Console.WriteLine("BREAKFAST: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsA/B7"));
                      Console.WriteLine("");
                      Console.WriteLine("LUNCH: ");                                
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsA/L7"));
                      Console.WriteLine("");
                      Console.WriteLine("DINNER: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsA/D7"));
                      Console.WriteLine("");
                    }
                  Typewriter("Press any button to go back to the main menu.");
                  Console.ReadKey();
                  Console.Clear();
                    choice = 0;
                }
                else if (choiceED2 == 2)
                {
                  //Bulimia Meal Plans
                  Typewriter("To pick a bulimia recovery meal plan, type a random number from 1-7");
                  Console.WriteLine("");
                  Console.Write("Action: ");
                  MPBchoice = int.Parse(Console.ReadLine());
                  Console.WriteLine("");

                    if (MPBchoice == 1)
                    {
                      Console.WriteLine("BREAKFAST: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsB/B1"));
                      Console.WriteLine("");
                      Console.WriteLine("LUNCH: ");                                
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsB/L1"));
                      Console.WriteLine("");
                      Console.WriteLine("DINNER: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsB/D1"));
                      Console.WriteLine("");
                    }
                    else if (MPBchoice == 2)
                    {
                      Console.WriteLine("BREAKFAST: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsB/B2"));
                      Console.WriteLine("");
                      Console.WriteLine("LUNCH: ");                                
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsB/L2"));
                      Console.WriteLine("");
                      Console.WriteLine("DINNER: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsB/D2"));
                      Console.WriteLine("");
                    }
                    else if (MPBchoice == 3)
                    {
                      Console.WriteLine("BREAKFAST: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsB/B3"));
                      Console.WriteLine("");
                      Console.WriteLine("LUNCH: ");                                
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsB/L3"));
                      Console.WriteLine("");
                      Console.WriteLine("DINNER: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsB/D3"));
                      Console.WriteLine("");
                    }
                    else if (MPBchoice == 4)
                    {
                      Console.WriteLine("BREAKFAST: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsB/B4"));
                      Console.WriteLine("");
                      Console.WriteLine("LUNCH: ");                                
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsB/L4"));
                      Console.WriteLine("");
                      Console.WriteLine("DINNER: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsB/D4"));
                      Console.WriteLine("");
                    }
                    else if (MPBchoice == 5)
                    {
                      Console.WriteLine("BREAKFAST: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsB/B5"));
                      Console.WriteLine("");
                      Console.WriteLine("LUNCH: ");                                
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsB/L5"));
                      Console.WriteLine("");
                      Console.WriteLine("DINNER: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsB/D5"));
                      Console.WriteLine("");
                    }
                    else if (MPBchoice == 6)
                    {
                      Console.WriteLine("BREAKFAST: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsB/B6"));
                      Console.WriteLine("");
                      Console.WriteLine("LUNCH: ");                                
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsB/L6"));
                      Console.WriteLine("");
                      Console.WriteLine("DINNER: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsB/D6"));
                      Console.WriteLine("");
                    }
                    else if (MPBchoice == 7)
                    {
                      Console.WriteLine("BREAKFAST: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsB/B7"));
                      Console.WriteLine("");
                      Console.WriteLine("LUNCH: ");                                
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsB/L7"));
                      Console.WriteLine("");
                      Console.WriteLine("DINNER: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsB/D7"));
                      Console.WriteLine("");
                    }
                  Typewriter("Press any button to go back to the main menu.");
                  Console.ReadKey();
                  Console.Clear();
                    choice = 0;
                }
                else if (choiceED2 == 3)
                {
                  //BingeEating Meal Plans
                    Typewriter("To pick a binge-eating recovery meal plan, type a random number from 1-7");
                  Console.WriteLine("");
                  Console.Write("Action: ");
                    MPCchoice = int.Parse(Console.ReadLine());
                  Console.WriteLine("");

                    if (MPCchoice == 1)
                    {
                      Console.WriteLine("BREAKFAST: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsC/B1"));
                      Console.WriteLine("");
                      Console.WriteLine("LUNCH: ");                                
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsC/L1"));
                      Console.WriteLine("");
                      Console.WriteLine("DINNER: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsC/D1"));
                      Console.WriteLine("");
                    }
                    else if (MPCchoice == 2)
                    {
                      Console.WriteLine("BREAKFAST: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsC/B2"));
                      Console.WriteLine("");
                      Console.WriteLine("LUNCH: ");                                
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsC/L2"));
                      Console.WriteLine("");
                      Console.WriteLine("DINNER: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsC/D2"));
                      Console.WriteLine("");
                    }
                    else if (MPCchoice == 3)
                    {
                      Console.WriteLine("BREAKFAST: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsC/B3"));
                      Console.WriteLine("");
                      Console.WriteLine("LUNCH: ");                                
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsC/L3"));
                      Console.WriteLine("");
                      Console.WriteLine("DINNER: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsC/D3"));
                      Console.WriteLine("");
                    }
                    else if (MPCchoice == 4)
                    {
                      Console.WriteLine("BREAKFAST: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsC/B4"));
                      Console.WriteLine("");
                      Console.WriteLine("LUNCH: ");                                
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsC/L4"));
                      Console.WriteLine("");
                      Console.WriteLine("DINNER: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsC/D4"));
                      Console.WriteLine("");
                    }
                    else if (MPCchoice == 5)
                    {
                      Console.WriteLine("BREAKFAST: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsC/B5"));
                      Console.WriteLine("");
                      Console.WriteLine("LUNCH: ");                                
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsC/L5"));
                      Console.WriteLine("");
                      Console.WriteLine("DINNER: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsC/D5"));
                      Console.WriteLine("");
                    }
                    else if (MPCchoice == 6)
                    {
                      Console.WriteLine("BREAKFAST: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsC/B6"));
                      Console.WriteLine("");
                      Console.WriteLine("LUNCH: ");                                
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsC/L6"));
                      Console.WriteLine("");
                      Console.WriteLine("DINNER: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsC/D6"));
                      Console.WriteLine("");
                    }
                    else if (MPCchoice == 7)
                    {
                      Console.WriteLine("BREAKFAST: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsC/B7"));
                      Console.WriteLine("");
                      Console.WriteLine("LUNCH: ");                                
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsC/L7"));
                      Console.WriteLine("");
                      Console.WriteLine("DINNER: ");
                      Console.WriteLine(System.IO.File.ReadAllText(@"mealsC/D7"));
                      Console.WriteLine("");
                    }
                  Typewriter("Press any button to go back to the main menu.");
                  Console.ReadKey();
                  Console.Clear();
                    choice = 0;
                }
            }

            else if (choice == 4)
            {
                //Journal
                if (pageNumber == 0)
                {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(System.IO.File.ReadAllText(@"titles/Journal"));
                Typewriter("Welcome to the SPREAD Journal");
                Typewriter("Feel free to log your thoughts, messages to your future self, or anything else you want to express.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("");
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(System.IO.File.ReadAllText(@"titles/Journal"));
                Console.WriteLine("Which page of the journal do you want to view?");

                Console.Write(@"
[1] Page 1
[2] Page 2
[3] Page 3
[4] Page 4
[5] Page 5
[6] Page 6
[7] Page 7
[8] Page 8
[9] Page 9
[10] Page 10
[11] Back to Main Menu

Page Number: ");

                pageNumber = int.Parse(Console.ReadLine());
                Console.Clear();
              Console.WriteLine(System.IO.File.ReadAllText(@"titles/Journal"));

                if (pageNumber == 1)
                {
                    Console.WriteLine("SPREAD Journal");
                    Console.WriteLine("Page 1");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                    Typewriter("Dear Journal,");
                    Typewriter(page1);

                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(@"Do you want to edit this journal page?
[1] Yes
[2] Go Back!

Action: ");

                    pageEdit = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (pageEdit == 1)
                    {
                      Console.WriteLine(System.IO.File.ReadAllText(@"titles/Journal"));
                        Console.WriteLine("SPREAD Journal");
                        Console.WriteLine("Page 1");
                        Console.WriteLine("*press ENTER when done*");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Dear Journal,");
                        page1 = Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        pageNumber = 0;
                    }
                }

                else if (pageNumber == 2)
                {
                    Console.WriteLine("SPREAD Journal");
                    Console.WriteLine("Page 2");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                    Typewriter("Dear Journal,");
                    Typewriter(page2);

                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(@"Do you want to edit this journal page?
[1] Yes
[2] Go Back!

Action: ");

                    pageEdit = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (pageEdit == 1)
                    {
                      Console.WriteLine(System.IO.File.ReadAllText(@"titles/Journal"));
                        Console.WriteLine("SPREAD Journal");
                        Console.WriteLine("Page 2");
                        Console.WriteLine("*press ENTER when done*");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Dear Journal,");
                        page2 = Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        pageNumber = 0;
                    }
                }

                else if (pageNumber == 3)
                {
                    Console.WriteLine("SPREAD Journal");
                    Console.WriteLine("Page 3");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                    Typewriter("Dear Journal,");
                    Typewriter(page3);

                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(@"Do you want to edit this journal page?
[1] Yes
[2] Go Back!

Action: ");

                    pageEdit = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (pageEdit == 1)
                    {
                      Console.WriteLine(System.IO.File.ReadAllText(@"titles/Journal"));
                        Console.WriteLine("SPREAD Journal");
                        Console.WriteLine("Page 3");
                        Console.WriteLine("*press ENTER when done*");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Dear Journal,");
                        page3 = Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        pageNumber = 0;
                    }
                }

                else if (pageNumber == 4)
                {
                    Console.WriteLine("SPREAD Journal");
                    Console.WriteLine("Page 4");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                    Typewriter("Dear Journal,");
                    Typewriter(page4);

                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(@"Do you want to edit this journal page?
[1] Yes
[2] Go Back!

Action: ");

                    pageEdit = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (pageEdit == 1)
                    {
                      Console.WriteLine(System.IO.File.ReadAllText(@"titles/Journal"));
                        Console.WriteLine("SPREAD Journal");
                        Console.WriteLine("Page 4");
                        Console.WriteLine("*press ENTER when done*");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Dear Journal,");
                        page4 = Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        pageNumber = 0;
                    }
                }

                else if (pageNumber == 5)
                {
                    Console.WriteLine("SPREAD Journal");
                    Console.WriteLine("Page 5");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                    Typewriter("Dear Journal,");
                    Typewriter(page5);

                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(@"Do you want to edit this journal page?
[1] Yes
[2] Go Back!

Action: ");

                    pageEdit = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (pageEdit == 1)
                    {
                      Console.WriteLine(System.IO.File.ReadAllText(@"titles/Journal"));
                        Console.WriteLine("SPREAD Journal");
                        Console.WriteLine("Page 5");
                        Console.WriteLine("*press ENTER when done*");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Dear Journal,");
                        page5 = Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        pageNumber = 0;
                    }
                }

                else if (pageNumber == 6)
                {
                    Console.WriteLine("SPREAD Journal");
                    Console.WriteLine("Page 6");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                    Typewriter("Dear Journal,");
                    Typewriter(page6);

                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(@"Do you want to edit this journal page?
[1] Yes
[2] Go Back!

Action: ");

                    pageEdit = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (pageEdit == 1)
                    {
                      Console.WriteLine(System.IO.File.ReadAllText(@"titles/Journal"));
                        Console.WriteLine("SPREAD Journal");
                        Console.WriteLine("Page 6");
                        Console.WriteLine("*press ENTER when done*");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Dear Journal,");
                        page6 = Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        pageNumber = 0;
                    }
                }

                else if (pageNumber == 7)
                {
                    Console.WriteLine("SPREAD Journal");
                    Console.WriteLine("Page 7");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                    Typewriter("Dear Journal,");
                    Typewriter(page7);

                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(@"Do you want to edit this journal page?
            [1] Yes
            [2] Go Back!

            Action: ");

                    pageEdit = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (pageEdit == 1)
                    {
                      Console.WriteLine(System.IO.File.ReadAllText(@"titles/Journal"));
                        Console.WriteLine("SPREAD Journal");
                        Console.WriteLine("Page 7");
                        Console.WriteLine("*press ENTER when done*");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Dear Journal,");
                        page7 = Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        pageNumber = 0;
                    }
                }

                else if (pageNumber == 8)
                {
                    Console.WriteLine("SPREAD Journal");
                    Console.WriteLine("Page 8");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                    Typewriter("Dear Journal,");
                    Typewriter(page8);

                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(@"Do you want to edit this journal page?
            [1] Yes
            [2] Go Back!

            Action: ");

                    pageEdit = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (pageEdit == 1)
                    {
                      Console.WriteLine(System.IO.File.ReadAllText(@"titles/Journal"));
                        Console.WriteLine("SPREAD Journal");
                        Console.WriteLine("Page 8");
                        Console.WriteLine("*press ENTER when done*");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Dear Journal,");
                        page8 = Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        pageNumber = 0;
                    }
                }

                else if (pageNumber == 9)
                {
                    Console.WriteLine("SPREAD Journal");
                    Console.WriteLine("Page 9");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                    Typewriter("Dear Journal,");
                    Typewriter(page9);

                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(@"Do you want to edit this journal page?
            [1] Yes
            [2] Go Back!

            Action: ");

                    pageEdit = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (pageEdit == 1)
                    {
                      Console.WriteLine(System.IO.File.ReadAllText(@"titles/Journal"));
                        Console.WriteLine("SPREAD Journal");
                        Console.WriteLine("Page 9");
                        Console.WriteLine("*press ENTER when done*");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Dear Journal,");
                        page9 = Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        pageNumber = 0;
                    }
                }

                else if (pageNumber == 10)
                {
                    Console.WriteLine("SPREAD Journal");
                    Console.WriteLine("Page 10");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                    Typewriter("Dear Journal,");
                    Typewriter(page10);

                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(@"Do you want to edit this journal page?
            [1] Yes
            [2] Go Back!

            Action: ");

                    pageEdit = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (pageEdit == 1)
                    {
                      Console.WriteLine(System.IO.File.ReadAllText(@"titles/Journal"));
                        Console.WriteLine("SPREAD Journal");
                        Console.WriteLine("Page 10");
                        Console.WriteLine("*press ENTER when done*");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Dear Journal,");
                        page10 = Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        pageNumber = 0;
                    }
                }
                else if (pageNumber == 11)
                {
                  choice = 0;
                  pageNumber = 0;
                }
            }

            else if (choice == 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                //Consistency Tracker
                Console.WriteLine(System.IO.File.ReadAllText(@"titles/CT"));
                Typewriter("Welcome to the Consistency Tracker");
                Typewriter("This will track how many days you have gone without relapsing, aka your SPREAD Streak.");
                Typewriter("This is day " + dayCounter + " of you using the SPREAD app!");
                Console.WriteLine("");
                Typewriter("SPREAD Streak: " + SPREADstreak + " days");
                Console.WriteLine("");
                Thread.Sleep(1000);
                Console.Write(@"What would you like to do?
[1] Update the daily consistency tracker
[2] Go Back

Action: ");

                consistencyChoice = int.Parse(Console.ReadLine());
                Console.Clear();
              Console.WriteLine(System.IO.File.ReadAllText(@"titles/CT"));

                if (consistencyChoice == 1)
                {
                    Console.WriteLine("Day " + dayCounter);
                    Thread.Sleep(500);
                    Console.WriteLine("");
                    Typewriter("Did you relapse? Type Y if Yes and N if No");
                    dayCounter++;
                    relapse = Console.ReadLine();

                    if (relapse == "N" || relapse == "n")
                    {
                        SPREADstreak++;
                        Console.WriteLine("");
                        Typewriter("Good job! Another step towards recovery!");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        SPREADstreak = 0;
                        Console.WriteLine("");
                        Typewriter(@"We're sorry to hear that you've relapsed.
Here are some hotlines to seek professional help.

NCMH Crisis Hotline (Open 24/7)
Call 1553

Bantay Bata Helpline 163 (Open 7AM to 7PM Everyday)
Call 163");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else
                {
                    choice = 0;
                }
            }

            else if (choice == 6)
            {
                // Productivity Tracker
                if (counterPlant == 0)
                { currentPlant = plant0; }
                else if (counterPlant == 1)
                { currentPlant = plant1; }
                else if (counterPlant == 2)
                { currentPlant = plant2; }
                else if (counterPlant == 3)
                { currentPlant = plant3; }
                else if (counterPlant == 4)
                { currentPlant = plant4; }
                else if (counterPlant == 5)
                { currentPlant = plant5; }
                else if (counterPlant == 6)
                { currentPlant = plant6; }
                else if (counterPlant == 7)
                { currentPlant = plant7; }
                else if (counterPlant == 8)
                { currentPlant = plant8; }
                else if (counterPlant == 9)
                { currentPlant = plant9; }
                else if (counterPlant == 10)
                { currentPlant = plant10; }

                if (initialGoal == true)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(System.IO.File.ReadAllText(@"titles/PT"));
                    Typewriter("Welcome to the Productivity Tracker!");
                    Typewriter("Input 10 goals you wish to achieve for yourself. With each goal completed, you will grow a digital plant.");
                    Console.WriteLine("");
                    Typewriter("First, input 10 goals you have:");
                    Console.Write("Goal 1: ");
                    goal1 = Console.ReadLine();
                    Console.Write("Goal 2: ");
                    goal2 = Console.ReadLine();
                    Console.Write("Goal 3: ");
                    goal3 = Console.ReadLine();
                    Console.Write("Goal 4: ");
                    goal4 = Console.ReadLine();
                    Console.Write("Goal 5: ");
                    goal5 = Console.ReadLine();
                    Console.Write("Goal 6: ");
                    goal6 = Console.ReadLine();
                    Console.Write("Goal 7: ");
                    goal7 = Console.ReadLine();
                    Console.Write("Goal 8: ");
                    goal8 = Console.ReadLine();
                    Console.Write("Goal 9: ");
                    goal9 = Console.ReadLine();
                    Console.Write("Goal 10: ");
                    goal10 = Console.ReadLine();
                    initialGoal = false;
                    Console.Clear();
                }

                if (initialGoal == false)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(System.IO.File.ReadAllText(@"titles/PT"));
                    Console.WriteLine("Welcome to the Productivity Tracker!");
                    Console.WriteLine("With each goal of your 10 goals completed, you will little by little grow a digital plant.");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(currentPlant);
                    Console.WriteLine("");
                    Thread.Sleep(500);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Your 10 goals:");
                    Console.WriteLine("[1] " + goal1 + " [" + goal1status + "]");
                    Console.WriteLine("[2] " + goal2 + " [" + goal2status + "]");
                    Console.WriteLine("[3] " + goal3 + " [" + goal3status + "]");
                    Console.WriteLine("[4] " + goal4 + " [" + goal4status + "]");
                    Console.WriteLine("[5] " + goal5 + " [" + goal5status + "]");
                    Console.WriteLine("[6] " + goal6 + " [" + goal6status + "]");
                    Console.WriteLine("[7] " + goal7 + " [" + goal7status + "]");
                    Console.WriteLine("[8] " + goal8 + " [" + goal8status + "]");
                    Console.WriteLine("[9] " + goal9 + " [" + goal9status + "]");
                    Console.WriteLine("[10] " + goal10 + " [" + goal10status + "]");
                    Console.WriteLine("");
                    Console.WriteLine(counterPlant + " of 10 goals completed");
                    Console.WriteLine("");
                    Typewriter("Type the number of a goal you completed, type 0 to go back: ");
                    goal = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (goal == 0)
                    {
                        choice = 0;
                    }
                    else if (goal == 1 && goal1status == "In Progress")
                    {
                        goal1status = "Done";
                        counterPlant++;
                    }
                    else if (goal == 2 && goal2status == "In Progress")
                    {
                        goal2status = "Done";
                        counterPlant++;
                    }
                    else if (goal == 3 && goal3status == "In Progress")
                    {
                        goal3status = "Done";
                        counterPlant++;
                    }
                    else if (goal == 4 && goal4status == "In Progress")
                    {
                        goal4status = "Done";
                        counterPlant++;
                    }
                    else if (goal == 5 && goal5status == "In Progress")
                    {
                        goal5status = "Done";
                        counterPlant++;
                    }
                    else if (goal == 6 && goal6status == "In Progress")
                    {
                        goal6status = "Done";
                        counterPlant++;
                    }
                    else if (goal == 7 && goal7status == "In Progress")
                    {
                        goal7status = "Done";
                        counterPlant++;
                    }
                    else if (goal == 8 && goal8status == "In Progress")
                    {
                        goal8status = "Done";
                        counterPlant++;
                    }
                    else if (goal == 9 && goal9status == "In Progress")
                    {
                        goal9status = "Done";
                        counterPlant++;
                    }
                    else if (goal == 10 && goal10status == "In Progress")
                    {
                        goal10status = "Done";
                        counterPlant++;
                    }
                    else
                    { }
                }
            }

            else if (choice == 7)
            {
                //Profile
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(System.IO.File.ReadAllText(@"titles/Profile"));
                Console.WriteLine("");
                Typewriter("Name: " + usernameCorrect);
                Typewriter("Diagnosis: " + diagnosis);
                Console.WriteLine("");
                Typewriter("Day " + dayCounter + " of using SPREAD");
                Typewriter("SPREAD Streak: " + SPREADstreak + " days");
                Console.WriteLine("");
                Typewriter(counterPlant + " of 10 goals completed");
                Console.WriteLine("");
                FastTypewriter(logoplant);

                Console.WriteLine("");
                Console.WriteLine("Press any button to go back to the menu");
                Console.ReadKey();
                Console.Clear();
                choice = 0;
            }

            else if (choice == 8)
            {
                Console.Clear();
                Typewriter("You have successfully logged out of SPREAD. Thank you for using our service!");
              Console.WriteLine("");
              FastTypewriter(logo);
                LN = 6;
            }
        }
    }
}