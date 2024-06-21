namespace DangerBug
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var start = new App();
            start.Run();
        }
    }

    internal class App
    {
        public List<Bug> BugList = new List<Bug>()
        {
            new Edderkopp(false, 8, "Venomous bite", true, "Black Widow"),
            new Edderkopp(false, 8, "Large size", false, "Tarantula"),
            new Edderkopp(false, 8, "Excellent vision", true, "Jumping Spider"),
            new Veps(true, 6, "Aggressive behavior", true, "Yellowjacket"),
            new Veps(true, 6, "Nest building", true, "Paper Wasp"),
            new Veps(true, 6, "Large size", true, "Hornet"),
            new Flått(false, 8, "Lyme disease carrier", true, "Deer Tick"),
            new Flått(false, 8, "Alpha-gal allergy inducer", true, "Lone Star Tick"),
            new Flått(false, 8, "Rocky Mountain spotted fever carrier", true, "Dog Tick"),
            new Flue(true, 6, "Small size", false, "Housefly"),
            new Flue(true, 6, "Metallic appearance", false, "Bluebottle fly"),
            new Flue(true, 6, "Long legs", false, "Crane fly")
        };

        
       
        


        public void InsectList()
        {
            

            Console.Clear();
            Console.Write(@"List of insects:

1- Veps
2- Mygg
3- Husflue 
4- Edderkopp 
5- Flått
6- Exit
Choose an option: ");


            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                {
                    showInsectList(typeof(Veps));
                }
                    break;

                case "2":
                {
                    showInsectList(typeof(Mygg));
                    }
                    break;

                case "3":
                {
                    showInsectList(typeof(Flue));
                }
                    break;

                case "4":
                {
                    showInsectList(typeof(Edderkopp));
                }
                    break;

                case "5":
                {
                    showInsectList(typeof(Flått));
                }
                    break;

                case "6":
                {
                    Console.Clear();
                }
                    break;

                default:
                {
                    InsectList();
                }
                    break;
            }
        }



        public void AddInsect()
        {
            Console.Clear();
            Console.WriteLine("What bug do you want to add?");
            Console.Write(@"List of insects:

            1- Veps
            2- Mygg
            3- Husflue 
            4- Edderkopp 
            5- Flått
            6- Exit
            Choose an option: ");

            string bugtype = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What's the name of this bug?");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Can this bug fly?");
            Console.WriteLine("1. True");
            Console.WriteLine("2. False");
            string canfly = Console.ReadLine();
            bool canflybool = canfly == "1" ? true : false;
            Console.Clear();
            Console.WriteLine("How many legs does this bug have?");
            int legs = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Write an attribute about this bug");
            string attribute = Console.ReadLine();

            Console.WriteLine("Is this bug poisonous?");
            Console.WriteLine("1. True");
            Console.WriteLine("2. False");
            string poison = Console.ReadLine();
            bool poisonbool = poison == "1" ? true : false;
            Console.Clear();

            switch (bugtype)
            {
                case "1":
                {
                    BugList.Add(new Veps(canflybool, legs, attribute, poisonbool, name));
                    break;
                }
                case "2":
                {
                    BugList.Add(new Mygg(canflybool, legs, attribute, poisonbool, name));
                    break;
                }
                case "3":
                {
                    BugList.Add(new Flue(canflybool, legs, attribute, poisonbool, name));
                    break;
                }
                case "4":
                {
                    BugList.Add(new Edderkopp(canflybool, legs, attribute, poisonbool, name));
                    break;
                }
                case "5":
                {
                    BugList.Add(new Flått(canflybool, legs, attribute, poisonbool, name));
                    break;
                }
                case "6":
                    {
                        Console.Clear();
                        break;
                    }
                default:
                    {
                        Console.Clear ();
                        Console.WriteLine("No input!");
                        AddInsect();
                    }
                    break;
            }



        }

        public void showInsectList(Type bugtype)
        {
            List<Bug> filteredList = new List<Bug>();

            foreach (var bug in BugList)
            {
                if (bugtype.IsAssignableFrom(bug.GetType()))
                {
                    filteredList.Add(bug);
                }
            }

            Console.Clear();
            for (int i = 0; i < filteredList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {filteredList[i].GetName()}");
            }

            int userInput = Convert.ToInt32(Console.ReadLine());
            userInput--;
            filteredList[userInput].ShowAttributes();

        }



        public bool Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Options:");
                Console.WriteLine("1- Inspect list");
                Console.WriteLine("2- Add insects");
                Console.WriteLine("3- End session");
                Console.Write("Choose an option: ");



                    var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        {
                            InsectList();
                        }
                        break;

                    case "2":
                        {
                            AddInsect();
                        }
                        break;

                    case "3":
                        {
                            return false;
                        }

                }

            }


        }
    }
}



