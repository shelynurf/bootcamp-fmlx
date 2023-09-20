namespace Prototype1
{
    public class Cat : ICat
    {
        public string catName;
        public int age;
        public Fur fur;
        public string ownerName;
        object obj;
        

        public Cat(string catName, int age)
        {
            this.catName = catName;
            this.age = age;
        }

        public Cat ShallowCopy()
        {
            return (Cat)this.MemberwiseClone();
        }

        public Cat DeepCopy()
        {
            Cat clone = (Cat)this.MemberwiseClone();
            clone.fur = new Fur(fur.furColor, fur.furPattern);
            return clone;
        }
    }
}