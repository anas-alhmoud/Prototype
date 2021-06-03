using System;

namespace Prototype
{
    public class IdInfo
    {
        public IdInfo(string info)
        {
            Info = info;
        }
        public string Info { get; set; }
    }
    public class Legend
    {
        public Legend(string name, int age)
        {
            Name = name;
            Age = age;
            Id = new IdInfo("id-info1");
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public IdInfo Id { get; set; }

        public Legend DeepCopy()
        {
            Legend copy = (Legend) this.MemberwiseClone();
            copy.Id = new IdInfo("id-info2");
            return copy;
        }
        public Legend Copy()
        {
            return (Legend) this.MemberwiseClone();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Legend Saud = new Legend("Saud", 24);
            Console.WriteLine("Saud " + Saud.Id.Info);
            Legend Anas = Saud.Copy();
            Console.WriteLine("Anas " + Anas.Id.Info);
            Console.WriteLine("--------------------");
            Anas.Id = new IdInfo("id-info-modifed2");
            Console.WriteLine("Saud " + Saud.Id.Info);
            Console.WriteLine("Anas " + Anas.Id.Info);

        }
    }
}
