namespace ExternalBase.C0re.Structs_Variables
{
    struct Entity
    {
        public int Base;
        public int Dormant;
        public int Health;
        public int Team;
        public int GlowIndex;

        internal class Arrays
        {
            public static Entity[] Entity = new Entity[64];
        }
    }
}
