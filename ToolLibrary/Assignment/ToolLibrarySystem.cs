using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment
{
    public class ToolLibrarySystem : iToolLibrarySystem
    {
        public Category[] categories { get; set; }
        public MemberCollection registerMembers { get; set; }
        public Member currentUser { get; set; }

        public ToolLibrarySystem(Category[] categories, MemberCollection registerMembers, Member currentUser)
        {
            this.categories = categories;
            this.registerMembers = registerMembers;
            this.currentUser = currentUser;
        }

        public void add(iTool aTool)
        {
            Console.WriteLine("Select the category");
            for (int i = 0; i < categories.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + categories[i].Name);
            }
            Console.Write("Select the option from menu: ");

            int categoryIndex = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Select the tool type");
            Console.WriteLine("=============================");
            for (int i = 0; i < categories[categoryIndex].Types.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + categories[categoryIndex].Types[i].Name);
            }
            Console.WriteLine("Selection option from menu");
            int typeIndex = Convert.ToInt32(Console.ReadLine()) - 1;
            categories[categoryIndex].Types[typeIndex].Tools.add(aTool);
            Console.WriteLine("Tool successfully added to library");
            Console.WriteLine("");
            Console.WriteLine("Hit enter to continue");
            Console.ReadLine();
        }

        public void add(iTool aTool, int quantity)
        {
            throw new NotImplementedException();
        }

        public void add(iMember aMember)
        {
            registerMembers.add(aMember);
            Console.WriteLine($"{aMember.FirstName + aMember.LastName} successfully added to membercollection");
            Console.WriteLine("");
            Console.WriteLine("Hit enter to continue");
            Console.ReadLine();
        }

        public void borrowTool(iMember aMember, iTool aTool)
        {
            throw new NotImplementedException();
        }

        public void delete(iTool aTool)
        {
            throw new NotImplementedException();
        }

        public void delete(iTool aTool, int quantity)
        {
            throw new NotImplementedException();
        }

        public void delete(iMember aMember)
        {
            registerMembers.delete(aMember);
            Console.WriteLine("");
            Console.WriteLine("Hit enter to continue");
            Console.ReadLine();
        }

        public void displayBorrowingTools(iMember aMember)
        {
            throw new NotImplementedException();
        }

        public void displayTools(string aToolType)
        {
            throw new NotImplementedException();
        }

        public void displayTopTHree()
        {
            List<Tool> allTools = new List<Tool>();
            for (int i = 0; i < categories.Length; i++)
            {
                for (int j = 0; j < categories[i].Types.Length; j++)
                {
                    for (int k = 0; k < categories[i].Types[j].Tools.Number; k++)
                    {
                        allTools.Add((Tool)categories[i].Types[j].Tools.tools[k]);
                    }
                }
            }
            List<Tool> SortedList = allTools.OrderByDescending(o => o.timeBorrowed).ToList();
            Console.WriteLine("Top 3 most borrowed tools");
            Console.WriteLine("================================");
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine(j + 1 + ". " + SortedList[j].Name + ". Number of time borrowed: " + SortedList[j].timeBorrowed);
            }
            Console.WriteLine("Press enter to go back to menu");
            Console.ReadLine();
        }

        public string[] listTools(iMember aMember)
        {
            throw new NotImplementedException();
        }

        public void returnTool(iMember aMember, iTool aTool)
        {
            throw new NotImplementedException();
        }
    }
}
