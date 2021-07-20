using System;
namespace Assignment
{
    public class Tooltype
    {
        public string Name { get; set; }
        public ToolCollection Tools { get; set; }

        public Tooltype(String name) {
            this.Name = name;
            this.Tools = new ToolCollection();
        }
    }
}
