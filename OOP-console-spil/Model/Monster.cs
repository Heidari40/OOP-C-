using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    
public class Monster 
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }

    public Monster (int id, string name, string description, int health, int damage)
    {
        Id = id;
        Name = name;
        Description = description;
        Health = health;
        Damage = damage;

    }

    public override string ToString()
    {
        return $"Fjende: {Name}  Description:{Description}";
    }

    public int TakeDamage(int damageTaken)
        {  
            Health -= damageTaken;
            if ( Health < 0) Health = 0;
            return Health;
        
        }
}

