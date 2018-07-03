using System;
using System.Collections.Generic;

namespace Money
{
    public class Category
    {
        public string name { get; set; }

        public Guid id { get; set; }

        public Guid parent { get; set; }

        public Category() { }

        public List<Category> GetChildren(Category cat, List<Category> list)
        {
            List<Category> children = new List<Category>();
            foreach (Category c in list)
                if (c.parent == cat.id)
                    children.Add(c);

            return children;
        }
    }
}