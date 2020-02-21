using System;
using System.Collections.Generic;
using System.Text;

namespace src_HeroopQuest.GameClasses
{
    enum HeldType {Barbaar, Dwerg, Elf, Tovenaar}
    class Held
    {
        public string Naam { get; set; }
        public string Bechschrijving { get; private set; }
        public int MaxIntelleigentie { get; private set; }
        public int MaxLichaam { get; private set; }
        public int HuidigIntelligentie { get; set; }
        public int HuidigLichaam { get; set; }
        public HeldType heldType { get; private set; }

        public int AanvalDobellStenen { get; private set; } = 2;
        public int VerdigingDobbelStenen { get; set; } = 2;
        public int LoopDobbelStenen { get; set; } = 2;
    }
}
