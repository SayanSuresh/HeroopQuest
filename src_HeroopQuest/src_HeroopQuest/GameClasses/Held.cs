using System;
using System.Collections.Generic;
using System.Text;

namespace src_HeroopQuest.GameClasses
{
    enum HeldType {Barbaar, Dwerg, Elf, Tovenaar}
    class Held
    {
        public Held(HeldType type, string naam)
        {
            Naam = naam;
          heldType = type;
            switch (type)
            {
                case HeldType.Barbaar:
                    AanvalDobellStenen = 3;
                    MaxIntelleigentie = 2;
                    MaxLichaam = 8;
                    break;
                case HeldType.Dwerg:
                    MaxIntelleigentie = 2;
                    MaxLichaam = 8;
                    break;
                case HeldType.Elf:
                    MaxIntelleigentie = 2;
                    MaxLichaam = 8;
                    break;
                case HeldType.Tovenaar:
                    MaxIntelleigentie = 2;
                    MaxLichaam = 8;
                    break;
                default:
                    break;
            }
            HuidigIntelligentie = MaxIntelleigentie;
            HuidigLichaam = MaxLichaam;
        }

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
