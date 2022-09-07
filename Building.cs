//2. * Для реализованного класса создать новый класс Creator, который будет являться фабрикой объектов класса здания.
//Для этого изменить модификатор доступа к конструкторам класса, в новый созданный класс добавить перегруженные фабричные методы CreateBuild для создания объектов класса здания.
//В классе Creator все методы сделать статическими, конструктор класса сделать закрытым.
//Для хранения объектов класса здания в классе Creator использовать хеш-таблицу.
//Предусмотреть возможность удаления объекта здания по его уникальному номеру из хеш-таблицы.
//Создать тестовый пример, работающий с созданными классами.
using System.Collections;
namespace Building
{
    abstract class Building
    {
        private float Height;
        private int Floor;
        private int Flat;
        private int Entrance;
        private int Number;
        private static int LastNumber = 100; 
        
        public Building()
        {
            this.Height = 123;
            this.Floor = 9;
            this.Flat = 36;
            this.Entrance = 9;
            this.Number = LastNumber++;
        }

        public float GetHeight()
        {
            return Height;
        }

        public void SetHeight(float value)
        {
            Height = value;
        }

        public int GetFloor()
        {
            return Floor;
        }

        public void SetFloor(int value)
        {
            Floor = value;
        }

        public int GetFlat()
        {
            return Flat;
        }

        public void SetFlat(int value)
        {
            Flat = value;
        }

        public int GetEntrance()
        {
            return Entrance;
        }

        public void SetEntrance(int value)
        {
            Entrance = value;
        }

        public int GetNumber()
        {
            return Number;
        }
        public abstract float GetFloorHeight();

        public abstract void Print();
    }
}

