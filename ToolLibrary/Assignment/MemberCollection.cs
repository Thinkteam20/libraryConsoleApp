using System;
namespace Assignment
{
    public class Node
    {
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }
        public iMember member { get; set; }
    }

    public class MemberCollection: iMemberCollection
    {
        public Node Root { get; set; }

        public int Number
        {
            get; set;// get number of member in the library.
        }

        public void add(iMember aMember)
        {
            Node before = null, after = this.Root;

            while (after != null)
            {
                before = after;
                if (compareTo(aMember,after.member) < 0) 
                    after = after.LeftNode;
                else 
                    after = after.RightNode;
            }

            Node newNode = new Node();
            newNode.member = aMember;

            if (this.Root == null)//Tree is empty
                this.Root = newNode;
            else
            {
                if (compareTo(aMember, before.member) < 0)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }
            //Number++;
        }
        public string mobileNumber(iMember aMember)
        {
            if (this.FindContact(aMember, this.Root) != null)
            {
                
                return ("Phone number is :" + this.FindContact(aMember, this.Root).member.ContactNumber);
            }
            return "Invalid entry";
        }

        public bool search(iMember aMember)
        {
            if (this.Find(aMember, this.Root) != null) {
                return true;
            }
            return false;
        }

        private Node Find(iMember aMember, Node parent)
        {
            if (parent != null)
            {
                if (aMember.FirstName == parent.member.FirstName && aMember.LastName == parent.member.LastName
                    && aMember.ContactNumber == parent.member.ContactNumber && aMember.PIN == parent.member.PIN
                    ) {
                    return parent;
                }

                if (compareTo(aMember, parent.member) < 0)
                {
                    return Find(aMember, parent.LeftNode);
                }
                else {
                    return Find(aMember, parent.RightNode);
                }
            }
            return null;
        }

        private Node FindContact(iMember aMember, Node parent)
        {
            if (parent != null)
            {
                if (aMember.FirstName == parent.member.FirstName && aMember.LastName == parent.member.LastName)
                {
                    return parent;
                }

                if (compareTo(aMember, parent.member) < 0)
                {
                    return Find(aMember, parent.LeftNode);
                }
                else
                {
                    return Find(aMember, parent.RightNode);
                }
            }
            return null;
        }

        public void delete(iMember aMember)
        {
            this.Root = Remove(this.Root, aMember);
        }
        private Node Remove(Node parent, iMember aMember)
        {
            Console.WriteLine("Deleting member");
            Console.WriteLine("aMember name: " + aMember.LastName);
            Console.WriteLine("parent.member name: " + parent.member.LastName);

            if (parent == null) return parent;

            if (aMember.FirstName == parent.member.FirstName && aMember.LastName == parent.member.LastName
                    && aMember.ContactNumber == parent.member.ContactNumber && aMember.PIN == parent.member.PIN) {
                Console.Write("Member to delete: " + parent.member.LastName);
                // node with only one child or no child  
                if (parent.LeftNode == null)
                    return parent.RightNode;
                else if (parent.RightNode == null)
                    return parent.LeftNode;

                // node with two children: Get the inorder successor (smallest in the right subtree)  
                parent.member = MinValue(parent.RightNode);

                // Delete the inorder successor  
                parent.RightNode = Remove(parent.RightNode, parent.member);
            }
            else if (compareTo(aMember, parent.member) == -1) {
                Console.WriteLine("left");
                

                parent.LeftNode = Remove(parent.LeftNode, aMember);
            } else if (compareTo(aMember, parent.member) == 1)
            {
                Console.WriteLine("right");
                parent.RightNode = Remove(parent.RightNode, aMember);

            } 

            return parent;
        }

        private iMember MinValue(Node node)
        {
            iMember minv = node.member;

            while (node.LeftNode != null)
            {
                minv = node.LeftNode.member;
                node = node.LeftNode;
            }

            return minv;
        }

        public iMember[] toArray()
        {
            throw new NotImplementedException();
        }

        private int compareTo(iMember memberOne, iMember memberTwo) {
            if (Convert.ToInt32(memberOne.ContactNumber) < Convert.ToInt32(memberTwo.ContactNumber))
                return -1;
            else
                return 1;
        }
        /*
        public void InOrderTraverse()
        {
            Console.Write("InOrder: ");
            InOrderTraverse(root);
            Console.WriteLine();
        }

        private void InOrderTraverse(BTreeNode root)
        {
            if (root != null)
            {
                InOrderTraverse(root.LChild);
                Console.Write(root.Member);
                InOrderTraverse(root.RChild);
            }
        }
        */

        public void DisplayMemberWithTraversePreOrder(Node Root)
        {
            if (Root != null)
            {
                Console.WriteLine(Root.member.FirstName + " " + Root.member.LastName);
                DisplayMemberWithTraversePreOrder(Root.LeftNode);
                DisplayMemberWithTraversePreOrder(Root.RightNode);
            }
        }

        public void DisplayMemberWithTraverseInOrder(Node Root)
        {
            if (Root != null)
            {
                DisplayMemberWithTraverseInOrder(Root.LeftNode);
                Console.WriteLine(Root.member.FirstName + " " + Root.member.LastName);
                DisplayMemberWithTraverseInOrder(Root.RightNode);
            }
        }

        internal void DisplayMemberWithTraverseInOrder()
        {
            throw new NotImplementedException();
        }
    }
}
