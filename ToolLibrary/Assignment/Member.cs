using System;
namespace Assignment
{
    public class Member: iMember
    {
        public Member(string firstName, string lastName, string contactNumber, string PIN)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ContactNumber = contactNumber;
            this.PIN = PIN;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string PIN { get; set; }

        public string[] Tools
        {
            get;
        }

        public void addTool(iTool aTool)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Member other)
        {
            if (this.LastName.CompareTo(other.LastName) < 0)
                return -1;
            else
                    if (this.LastName.CompareTo(other.LastName) == 0)
                return this.FirstName.CompareTo(other.FirstName);
            else
                return 1;
        }

        public void deleteTool(iTool aTool)
        {
            throw new NotImplementedException();
        }
    }
}
