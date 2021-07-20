using System;
namespace Assignment
{
    public class Category
    {
        public string Name { get; set; }
        public Tooltype[] Types { get; set; }

        public Category(String name, Tooltype[] types)
        {
            this.Name = name;
            this.Types = types;
        }
    }

}
