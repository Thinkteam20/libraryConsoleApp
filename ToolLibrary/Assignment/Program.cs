using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MemberCollection registerMembers = new MemberCollection();
            Member currentUser = null;
            

            Category gardeningTools =
                new Category("Gardening tools",
                new Tooltype[] {
                    new Tooltype("Line Trimmers"),
                    new Tooltype("Lawn Mowers"),
                    new Tooltype("Hand Tools"),
                    new Tooltype("Wheelbarrows"),
                    new Tooltype("Garden Power Tools")
                });

            Category flooringTools =
                new Category("Flooring tools",
                new Tooltype[] {
                    new Tooltype("Scrapers"),
                    new Tooltype("Floor Lasers"),
                    new Tooltype("Floor Levelling Tools"),
                    new Tooltype("Floor Levelling Materials"),
                    new Tooltype("Floor Hand Tools"),
                    new Tooltype("Tiling Tools")
                });

            Category fencingTools =
                new Category("Fencing tools",
                new Tooltype[] {
                    new Tooltype("Hand Tools"),
                    new Tooltype("Electric Fencing"),
                    new Tooltype("Steel Fencing Tools"),
                    new Tooltype("Power Tools"),
                    new Tooltype("Fencing Accessories")
                });

            Category measuringTools =
                new Category("Measuring tools",
                new Tooltype[] {
                    new Tooltype("Distance Tools"),
                    new Tooltype("Lawn Mowers"),
                    new Tooltype("Measuring Jugs"),
                    new Tooltype("Temperature & Humidity Tools"),
                    new Tooltype("Levelling Tools")
                });

            Category cleaningTools =
                new Category("Cleaning tools",
                new Tooltype[] {
                    new Tooltype("Draining"),
                    new Tooltype("Car Cleaning"),
                    new Tooltype("Vacuum"),
                    new Tooltype("Pressure Cleaners"),
                    new Tooltype("Pool Cleaning"),
                    new Tooltype("Floor Cleaning")
                });

            Category paintingTools =
                new Category("Painting tools",
                new Tooltype[] {
                    new Tooltype("Sanding Tools"),
                    new Tooltype("Brushes"),
                    new Tooltype("Rollers"),
                    new Tooltype("Paint Removal Tools"),
                    new Tooltype("Paint Scrapers"),
                    new Tooltype("Sprayers")
                });
            
            Category electronicTools =
                new Category("Electronic tools",
                new Tooltype[] {
                    new Tooltype("Voltage Tester"),
                    new Tooltype("Oscilloscopes"),
                    new Tooltype("Thermal Imaging"),
                    new Tooltype("Data Test Tool"),
                    new Tooltype("Insulation Testers")
                });

            Category electricityTools =
                new Category("Electricity tools",
                new Tooltype[] {
                    new Tooltype("Test Equipment"),
                    new Tooltype("Safety Equipment"),
                    new Tooltype("Basic Hand tools"),
                    new Tooltype("Circuit Protection"),
                    new Tooltype("Cable Tools")
                });

            Category automotiveTools =
                new Category("Automotive tools",
                new Tooltype[] {
                    new Tooltype("Jacks"),
                    new Tooltype("Air Compressors"),
                    new Tooltype("Battery Chargers"),
                    new Tooltype("Socket Tools"),
                    new Tooltype("Braking"),
                    new Tooltype("Drivetrain")
                });
            Category[] categories = new Category[] {
                gardeningTools,
                flooringTools,
                fencingTools,
                measuringTools,
                cleaningTools,
                paintingTools,
                electronicTools,
                electricityTools,
                automotiveTools
            };

            ToolLibrarySystem toolLibrarySystem = new ToolLibrarySystem(categories, registerMembers, currentUser);

            MainMenu(toolLibrarySystem);
        }

        static void MainMenu(ToolLibrarySystem toolLibrarySystem)
        {
            Console.Clear();
            Console.WriteLine("=========main menu==========");
            Console.WriteLine("1. Staff Login");
            Console.WriteLine("2. Member Login");
            Console.WriteLine("0. Exit");
            Console.WriteLine("===========================");
            Console.WriteLine("");
            Console.WriteLine("Please Make a selection (1-2, or 0 to exit):");
            string myoption;
            myoption = Console.ReadLine();
            switch (myoption)
            {
                case "1":
                    StaffLogin(toolLibrarySystem);
                    break;
                case "2":
                    MemberLogin(toolLibrarySystem);
                    break;
                case "0":
                    Exit();
                    break;
            }
        }
        static void StaffLogin(ToolLibrarySystem toolLibrarySystem)
        {
            Console.Clear();
            var logins = new[] { new { name = "TLstaff", password = "staff" } };
            Console.Write("Enter your ID: ");
            string id = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Enter your Password: ");
            string password = Console.ReadLine();
            Console.WriteLine("");
      
            if (logins[0].name == id && logins[0].password == password)
            
            {
                Console.Clear();
                Console.WriteLine("=========Staff menu==========");
                Console.WriteLine("1. Add a new tool");
                Console.WriteLine("2. Add new pieces of an existing tool");
                Console.WriteLine("3. Remove some pieces of a tool");
                Console.WriteLine("4. Register a new member");
                Console.WriteLine("5. Remove a member");
                Console.WriteLine("6. Find the contact number of a member");
                Console.WriteLine("0. Return to main menu");
                Console.WriteLine("===============================");
                Console.WriteLine("");
                Console.WriteLine("Please Make a selection (1-6, or 0 to return to the main menu):");
                string myoption;
                myoption = Console.ReadLine();
                switch (myoption)
                {
                    case "1":
                        AddNewTool(toolLibrarySystem);
                        break;
                    case "2":
                        AddNewPiece(toolLibrarySystem);
                        break;
                    case "3":
                        RemoveNewPiece(toolLibrarySystem);
                        Exit();
                        break;
                    case "4":
                        RegiMemner(toolLibrarySystem);
                        //registerMembers.add(new Member("Chen", "Lu", "0478843585", "1234"));
                        //registerMembers.add(new Member("p", "j", "0", "1234"));
                        //MainMenu(toolLibrarySystem);
                        break;
                    case "5":
                        RemoveMember(toolLibrarySystem);
                        Exit();
                        break;
                    case "6":
                        //registerMembers.search(new Member("Chen", "Lu", "0", "0"));
                        FindContactNo(toolLibrarySystem);
                        Exit();
                        break;
                    case "0":
                        MainMenu(toolLibrarySystem);
                        break;
                }
            }
            else
            {
                Console.WriteLine("given ID and password is wrong check your staff ID and password");
            }


            
        }
        static void MemberLogin(ToolLibrarySystem toolLibrarySystem)
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Enter your last name: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Enter your contact number: ");
            string contactNumber = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Enter your pin: ");
            string pin = Console.ReadLine();
            Console.WriteLine("");

            Member tempMember = new Member(firstName, lastname, contactNumber, pin);
            if (toolLibrarySystem.registerMembers.search(tempMember) == true)
            {
                toolLibrarySystem.currentUser = tempMember;
                Console.Clear();
                Console.WriteLine("=========Member menu==========");
                Console.WriteLine("1. Display all the tools of a tool type");
                Console.WriteLine("2. Borrow a tool");
                Console.WriteLine("3. Return a tool"); 
                Console.WriteLine("4. List all the tools that I am renting");
                Console.WriteLine("5. Display top three (3) most frequentely rented tools");
                Console.WriteLine("0. Return to main menu");
                Console.WriteLine("===============================");
                Console.WriteLine("");
                Console.WriteLine("Please Make a selection (1-6, or 0 to return to the main menu):");
                string myoption;
                myoption = Console.ReadLine();
                switch (myoption)
                {
                    case "1":
                        DisplayAllTool(toolLibrarySystem);
                        break;
                    case "2":
                        BrrowingTools(toolLibrarySystem);
                        break;
                    case "3":
                        ReturningTools(toolLibrarySystem);
                        Exit();
                        break;
                    case "4":
                        Exit();
                        break;
                    case "5":
                        toolLibrarySystem.displayTopTHree();
                        MainMenu(toolLibrarySystem);

                        Exit();
                        break;
                    case "0":
                        MainMenu(toolLibrarySystem);
                        break;
                }
            }
            else {
                Console.WriteLine("Invalid member details. Please try again");
                MemberLogin(toolLibrarySystem);
            }
        }
        static void Exit()
        {
            System.Environment.Exit(0);
        }
        static void RegiMemner(ToolLibrarySystem toolLibrarySystem)
        {
            Console.Clear();
            Console.Write("Enter member First name");
            Console.WriteLine("");
            String fname = Console.ReadLine();
            Console.Write("Enter member Last name");
            Console.WriteLine("");
            String lname = Console.ReadLine();
            Console.Write("Enter member mobile number");
            Console.WriteLine("");
            String mobile = Console.ReadLine();
            Console.Write("Enter member pin");
            Console.WriteLine("");
            String pin = Console.ReadLine();
            Member newMember = new Member(fname, lname, mobile, pin);
            toolLibrarySystem.add(newMember);
            MainMenu(toolLibrarySystem);
        }
        static void RemoveMember(ToolLibrarySystem toolLibrarySystem)
        {
            Console.Clear();
            Console.Write("Enter member First name");
            Console.WriteLine("");
            String fname = Console.ReadLine();
            Console.Write("Enter member Last name");
            Console.WriteLine("");
            String lname = Console.ReadLine();
            Console.Write("Enter member mobile number");
            Console.WriteLine("");
            String mobile = Console.ReadLine();
            Console.Write("Enter member pin");
            Console.WriteLine("");
            String pin = Console.ReadLine();
            Member deleteMember = new Member(fname, lname, mobile, pin);
            toolLibrarySystem.delete(deleteMember);
            MainMenu(toolLibrarySystem);
        }
        static void FindContactNo(ToolLibrarySystem toolLibrarySystem)
        {
            Console.Clear();
            Console.Write("Enter member First name");
            Console.WriteLine("");
            String fname = Console.ReadLine();
            Console.Write("Enter member Last name");
            Console.WriteLine("");
            String lname = Console.ReadLine();
            Console.WriteLine(toolLibrarySystem.registerMembers.mobileNumber(new Member(fname, lname, "0", "0")));
            Console.WriteLine("");
            Console.WriteLine("Hit enter to continue");
            Console.ReadLine();

            MainMenu(toolLibrarySystem);
        }
        static void DisplayAllTool(ToolLibrarySystem toolLibrarySystem)
        {
            Console.Clear();
            Console.Write("Display tools by Tool category");
            Console.WriteLine("=============================================");
            Console.WriteLine("Select the category");
            for (int i = 0; i < toolLibrarySystem.categories.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + toolLibrarySystem.categories[i].Name);
            }
            Console.Write("Select the option from menu: ");
            int categoryIndex = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Select the tool type");
            Console.WriteLine("=============================");
            for (int i = 0; i < toolLibrarySystem.categories[categoryIndex].Types.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + toolLibrarySystem.categories[categoryIndex].Types[i].Name);
            }
            Console.WriteLine("Selection option from menu");

            int typeIndex = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine("");
            Console.WriteLine("Tool type List of Tools");
            Console.WriteLine("=======================================");
            Console.WriteLine("===Tool name=======available======Total");
            Console.WriteLine("=======================================");
            for (int i = 0; i < toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.Number; i++)
            {
                
                Console.WriteLine(i + 1 + ". " + toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.tools[i].Name +
                    ", Available: " + toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.tools[i].AvailableQuantity +
                    ", Total: " + toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.tools[i].Quantity);
                Console.WriteLine("=============================");
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Hit enter to continue");
            Console.ReadLine();

            MainMenu(toolLibrarySystem);
        }
        static void AddNewTool(ToolLibrarySystem toolLibrarySystem)
        {
            Console.Clear();
            Console.Write("Enter name for the new tool: ");
            Console.WriteLine("");
            String newToolName = Console.ReadLine();
            Tool newTool = new Tool(newToolName);
            toolLibrarySystem.add(newTool);
            MainMenu(toolLibrarySystem);
        }
        static void AddNewPiece(ToolLibrarySystem toolLibrarySystem)
        {
            Console.Clear();
            Console.WriteLine("Tool Library System - Update Existing Tool Stock Level");
            Console.WriteLine("");
            Console.WriteLine("========================================================");
            Console.WriteLine("");

            for (int i = 0; i < toolLibrarySystem.categories.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + toolLibrarySystem.categories[i].Name);
            }
            Console.WriteLine("");

            Console.Write("Select a tool category: ");
            int categoryIndex = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine("");

            Console.WriteLine("Tool Type List");
            Console.WriteLine("=============================");
            for (int i = 0; i < toolLibrarySystem.categories[categoryIndex].Types.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + toolLibrarySystem.categories[categoryIndex].Types[i].Name);
            }
            Console.Write("Enter the tool type: ");
            int typeIndex = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine("");

            Console.WriteLine("Tool Type List of Tools");
            Console.WriteLine("=============================");
            for (int i = 0; i < toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.Number; i++)
            {
                Console.WriteLine(i + 1 + ". " + toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.tools[i].Name +
                    ", Available: " + toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.tools[i].AvailableQuantity +
                    ", Total: " + toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.tools[i].Quantity);
            }
            Console.WriteLine("");
            Console.Write("Select a tool to update: ");
            int toolIndex = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine("");
            Console.Write("Enter the quantity to add into the library: ");
            int numberOfQuantity = Convert.ToInt32(Console.ReadLine());
            toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.tools[toolIndex].Quantity += numberOfQuantity;
            Console.WriteLine("");
            Console.WriteLine("Updated the quantity of " + toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.tools[toolIndex].Name
                + " in the library to " + toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.tools[toolIndex].Quantity);


            Console.WriteLine("");
            Console.WriteLine("Hit enter to continue");
            Console.ReadLine();

            MainMenu(toolLibrarySystem);
        }
        static void RemoveNewPiece(ToolLibrarySystem toolLibrarySystem)
        {
            Console.Clear();
            Console.WriteLine("Tool Library System - Update Existing Tool Stock Level");
            Console.WriteLine("");
            Console.WriteLine("========================================================");
            Console.WriteLine("");

            for (int i = 0; i < toolLibrarySystem.categories.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + toolLibrarySystem.categories[i].Name);
            }
            Console.WriteLine("");

            Console.Write("Select a tool category: ");
            int categoryIndex = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine("");

            Console.WriteLine("Tool Type List");
            Console.WriteLine("=============================");
            for (int i = 0; i < toolLibrarySystem.categories[categoryIndex].Types.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + toolLibrarySystem.categories[categoryIndex].Types[i].Name);
            }
            Console.Write("Enter the tool type: ");
            int typeIndex = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine("");

            Console.WriteLine("Tool Type List of Tools");
            Console.WriteLine("=============================");
            for (int i = 0; i < toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.Number; i++)
            {
                Console.WriteLine(i + 1 + ". " + toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.tools[i].Name +
                    ", Available: " + toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.tools[i].AvailableQuantity +
                    ", Total: " + toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.tools[i].Quantity);
            }
            Console.WriteLine("");
            Console.Write("Select a tool to update: ");
            int toolIndex = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine("");
            Console.Write("Enter the quantity to remove from the library: ");
            int numberOfQuantity = Convert.ToInt32(Console.ReadLine());
            toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.tools[toolIndex].Quantity -= numberOfQuantity;
            toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.tools[toolIndex].AvailableQuantity -= numberOfQuantity;
            Console.WriteLine("");
            Console.WriteLine("Updated the quantity of " + toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.tools[toolIndex].Name
                + " in the library to " + toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.tools[toolIndex].Quantity);


            Console.WriteLine("");
            Console.WriteLine("Hit enter to continue");
            Console.ReadLine();

            MainMenu(toolLibrarySystem);
        }
        static void BrrowingTools(ToolLibrarySystem toolLibrarySystem)
        {
            Console.Clear();
            Console.Write("Library System - Borrow Tool From Tool Library");
            Console.WriteLine("=============================================");
            //String newToolName = Console.ReadLine();
            Console.WriteLine("Select the category");
            for (int i = 0; i < toolLibrarySystem.categories.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + toolLibrarySystem.categories[i].Name);
            }
            Console.Write("Select the option from menu: ");
            int categoryIndex = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Select the tool type");
            Console.WriteLine("=============================");
            for (int i = 0; i < toolLibrarySystem.categories[categoryIndex].Types.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + toolLibrarySystem.categories[categoryIndex].Types[i].Name);
            }
            Console.WriteLine("Selection option from menu");

            int typeIndex = Convert.ToInt32(Console.ReadLine()) - 1;

            for (int i = 0; i < toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.Number; i++)
            {
                Console.WriteLine(i + 1 + ". " + toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.tools[i].Name +
                    ", Available: " + toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.tools[i].AvailableQuantity +
                    ", Total: " + toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.tools[i].Quantity);
            }
            Console.WriteLine("");
            Console.Write("Select a tool item you want to borrow: ");
            int toolIndex = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine("");
            Console.Write("Enter the quantity to borrow from the library: ");
            int numberOfQuantity = Convert.ToInt32(Console.ReadLine());
            toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.tools[toolIndex].Quantity -= numberOfQuantity;
            toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.tools[toolIndex].AvailableQuantity -= numberOfQuantity;
            toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.tools[toolIndex].addBorrower(toolLibrarySystem.currentUser);


            Console.WriteLine("");
            Console.WriteLine("Updated the quantity of " + toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.tools[toolIndex].Name
                + " in the library to " + toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.tools[toolIndex].Quantity);
            

            Console.WriteLine("");
            Console.WriteLine("Hit enter to continue");
            Console.ReadLine();

            MainMenu(toolLibrarySystem);
        }
        static void ReturningTools(ToolLibrarySystem toolLibrarySystem)
        {
            Console.Clear();
            Console.Write("Library System - Borrow Tool From Tool Library");
            Console.WriteLine("=============================================");
            //String newToolName = Console.ReadLine();
            Console.WriteLine("Select the category");
            for (int i = 0; i < toolLibrarySystem.categories.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + toolLibrarySystem.categories[i].Name);
            }
            Console.Write("Select the option from menu: ");
            int categoryIndex = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Select the tool type");
            Console.WriteLine("=============================");
            for (int i = 0; i < toolLibrarySystem.categories[categoryIndex].Types.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + toolLibrarySystem.categories[categoryIndex].Types[i].Name);
            }
            Console.WriteLine("Selection option from menu");

            int typeIndex = Convert.ToInt32(Console.ReadLine()) - 1;

            for (int i = 0; i < toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.Number; i++)
            {
                Console.WriteLine(i + 1 + ". " + toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.tools[i].Name +
                    ", Available: " + toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.tools[i].AvailableQuantity +
                    ", Total: " + toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.tools[i].Quantity);
            }
            Console.WriteLine("");
            Console.Write("Select a tool to update: ");
            int toolIndex = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine("");
            Console.Write("Enter the quantity to add into the library: ");
            int numberOfQuantity = Convert.ToInt32(Console.ReadLine());
            toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.tools[toolIndex].Quantity += numberOfQuantity;
            toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.tools[toolIndex].AvailableQuantity = numberOfQuantity;
            toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.tools[toolIndex].addBorrower(toolLibrarySystem.currentUser);

            Console.WriteLine("");
            Console.WriteLine("Updated the quantity of " + toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.tools[toolIndex].Name
                + " in the library to " + toolLibrarySystem.categories[categoryIndex].Types[typeIndex].Tools.tools[toolIndex].Quantity);

            

            Console.WriteLine("");
            Console.WriteLine("Hit enter to continue");
            Console.ReadLine();

            MainMenu(toolLibrarySystem);
        }
    }
}
