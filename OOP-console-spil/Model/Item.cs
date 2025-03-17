using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Item 

    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }

    public Item(int Id, string name, int level)
    {
        this.Id = Id;
        Name = name;
        Level = level;
    }
            public override string ToString()
        {
            return $"Name: { Name} Description: {Level}";
        }
    
    }

