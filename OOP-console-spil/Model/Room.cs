using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Room
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Discription { get; set; }
    public List<Item> Items { get; set; }
    public Room Nord { get; set; }
    public Room Syd { get; set; }
    public Room Øst { get; set; }
    public Room Vest { get; set; }
    public List<Monster> Monsters { get; internal set; }

    public Room (int id, string name, string disciption, List<Item> items, Room nord, Room syd, Room øst, Room vest, List<Monster> monsters)
    {
        Id = id;
        Name = name;
        Discription = disciption;
        Items = items;
        Nord = nord;
        Syd = syd;
        Øst = øst;
        Vest = vest;
        Monsters = new List<Monster>();
    }
    public override string ToString()
    {
        return Discription;
        
    }

    public static implicit operator string(Room v)
    {
        throw new NotImplementedException();
    }
}