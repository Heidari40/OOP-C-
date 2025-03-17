using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Weapon : Item
    {
        public int Damage { get; set; }
        public bool IsRanged { get; set; }
        public string UsesLeft { get; set; }

        public Weapon(int id, string name, int lavel,int damage, bool isranged, string usesreft)
        :base(id, name, lavel)
        {
            Damage = damage;
            IsRanged = isranged;
            UsesLeft = usesreft;
        }

   
}

