
using static block.Block.Block;


public class Map
{
    public Block[,] map;
    public int size;


    public Map(int size)
    {
        this.size = size;
        this.map = new Block[size, size];
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                this.map[i, j] = new Block(i, j, 0);
            }
        }
    }

    public void printMap()
    {
        string id;
        for (int i = 0; i < this.size; i++)
        {
            string s = "";
            for (int j = 0; j < this.size; j++)
            {

                id = Convert.ToString(this.map[i, j].id);
                s = s + id;
                s = s + " ";
            }
            Console.WriteLine(s);
        }
    }
}
Map map;
map = new Map(20);
map.printMap();

