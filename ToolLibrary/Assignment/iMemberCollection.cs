// Binary Search Tree 
/*This class must use a Binary Search Tree as a class member 
 to store a collection of Member objects.
 */
/*
 An object of this class can be used to store all
those registered members or to store a collection
of members who are currently renting a particular
tool.
 */


using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    //The specification of MemberCollection ADT, which is used to store and manipulate a collection of members
    
    public interface iMemberCollection
    {
        int Number // get the number of members in the community library
        {
            get;
        }

        void add(iMember aMember); //add a new member to this member collection, make sure there are no duplicates in the member collection

        void delete(iMember aMember); //delete a given member from this member collection, a member can be deleted only when the member currently is not holding any tool

        Boolean search(iMember aMember); //search a given member in this member collection. Return true if this memeber is in the member collection; return false otherwise.

        iMember[] toArray(); //output the memebers in this collection to an array of iMember

    }
}
