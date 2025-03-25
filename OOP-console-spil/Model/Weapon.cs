using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Weapon : Item
    {
        public int Damage { get; set; }
        public bool IsRanged { get; set; }
        public string UsesLeft { get; set; }

        public Weapon(int id, string name, string discription,int damage, bool isranged, string usesreft)
        :base(id, name, discription)
        {
            Damage = damage;
            IsRanged = isranged;
            UsesLeft = usesreft;
        }

   
}

