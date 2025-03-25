using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Item

{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    

    public Item(int Id, string name, string description)
    {
        this.Id = Id;
        Name = name;
        Description = description;
    }


    public override string ToString()
    {
        return $"Name: { Name} Description: {Description}";
    }

}

