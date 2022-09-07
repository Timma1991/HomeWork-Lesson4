namespace Building
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            Building building = Creator.create("struct");
            building.SetFloor(666);
            building.SetFlat(6666);
            building.SetEntrance(345346);
            building.SetHeight(32555);
            building.GetFloorHeight();
            building.Print();
            Creator creator = new Creator();
            creator.GetHashCode();
            creator.GetHashCode();
            
        }
    }
} 


