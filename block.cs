namespace Block
{


    public class Block
    {
        public string name;
        public int hardness;
        public int weight;
        public int id;

        public Block(int x, int y, int z)
        {
            this.name = "block";
            this.id = 0;
        }

        public string getname()
        {
            return "block " + this.name;
        }

    }

    public enum DirtBlockStatus
    {
        Bare,
        Grass,
        Tiled,
        Snow,
        Path
    }

    public class Dirt : Block
    {

        public DirtBlockStatus top;
        Dirt(int x, int y, int z) : base(x, y, z)
        {
            this.name = "Dirt";
            this.hardness = 50;
            this.weight = 50;
            this.top = DirtBlockStatus.Bare;
            this.id = 1;


        }


    }

    public class Stone : Block
    {
        Stone(int x, int y, int z) : base(x, y, z)
        {
            this.name = "Stone";
            this.hardness = 100;
            this.weight = 100;
            this.id = 2;

        }
    }

    public enum TreeSpecies
    {
        Maple,
        Oak,

        Pine
    }

    public class TreeTrunk : Block
    {
        public TreeSpecies kind;
        public TreeTrunk(int x, int y, int z, TreeSpecies kind = TreeSpecies.Maple) : base(x, y, z)
        {
            this.name = "TreeTrunk";
            this.hardness = 50;
            this.weight = 50;
            this.kind = kind;
            this.id = 3;
        }


    }

    public class TreeFoliage : Block
    {
        public TreeSpecies kind;
        public TreeFoliage(int x, int y, int z, TreeSpecies kind = TreeSpecies.Maple) : base(x, y, z)
        {
            this.name = "TreeTrunk";
            this.hardness = 10;
            this.weight = 10;
            this.kind = kind;
            this.id = 4;
        }


    }

    public class Water : Block
    {
        public Water(int x, int y, int z) : base(x, y, z)
        {
            this.name = "Water";
            this.hardness = 0;
            this.weight = 10;
            this.id = 5;
        }
    }

    public class Sand : Block
    {
        public Sand(int x, int y, int z) : base(x, y, z)
        {
            this.name = "Sand";
            this.hardness = 20;
            this.weight = 50;
            this.id = 6;
        }
    }
}