    using Prototype1;

    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new("Milo", 5);
            cat.fur = new Fur("Black", "Solid");
            cat.ownerName = "Budi";
            Cat catShallow = cat.ShallowCopy();
            Cat catDeep = cat.DeepCopy();
            // Console.WriteLine($"{cat.catName} is {cat.ownerName}'s {cat.age} years old Cat that have {cat.fur.furColor} and {cat.fur.furPattern} fur");
            // Console.WriteLine($"{catShallow.catName} is {catShallow.ownerName}'s {catShallow.age} years old Cat that have {catShallow.fur.furColor} and {catShallow.fur.furPattern} fur");
            // Console.WriteLine($"{catDeep.catName} is {catDeep.ownerName}'s {catDeep.age} years old Cat that have {catDeep.fur.furColor} and {catDeep.fur.furPattern} fur");

            catShallow.catName = "Mili";
            // catDeep.catName = "Mila";
            // catShallow.fur.furColor = "orange";
            catDeep.fur.furColor = "orange";

            Console.WriteLine($"{cat.catName} is {cat.ownerName}'s {cat.age} years old Cat that have {cat.fur.furColor} and {cat.fur.furPattern} fur");
            Console.WriteLine($"{catShallow.catName} is {catShallow.ownerName}'s {catShallow.age} years old Cat that have {catShallow.fur.furColor} and {catShallow.fur.furPattern} fur");
            Console.WriteLine($"{catDeep.catName} is {catDeep.ownerName}'s {catDeep.age} years old Cat that have {catDeep.fur.furColor} and {catDeep.fur.furPattern} fur");
        }
    }
