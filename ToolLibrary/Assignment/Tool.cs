using System;
using System.Collections.Generic;

namespace Assignment
{
    public class Tool: iTool
    {
        public Tool(string name)
        {
            this.Name = name;
            this.Quantity = 1;
            this.AvailableQuantity = 1;
            this.NoBorrowings = 0;
            this.timeBorrowed = 0;
        }

        public string Name { get; set; }
        public int Quantity { get; set; }
        public int AvailableQuantity { get; set; }
        public int NoBorrowings { get; set; }
        public MemberCollection borrowers = new MemberCollection();
        public int timeBorrowed;


        public iMemberCollection GetBorrowers { get { return borrowers; }}

        public void addBorrower(iMember aMember)
        {
            borrowers.add(aMember);
            timeBorrowed += 1;
        }

        public void deleteBorrower(iMember aMember)
        {
            borrowers.delete(aMember);
        }
    }
}
