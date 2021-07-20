using System;
using System.Collections.Generic;

namespace Assignment
{
    public class ToolCollection: iToolCollection
    {
        public List<iTool> tools = new List<iTool>();

        public int Number => this.tools.Count;

        public void add(iTool aTool)
        {
            this.tools.Add(aTool);
        }

        public void delete(iTool aTool)
        {
            this.tools.Remove(aTool);

        }

        public bool search(iTool aTool)
        {
            return this.tools.Contains(aTool);
        }

        public iTool[] toArray()
        {
            return this.tools.ToArray();
        }
    }
}
