namespace FilterBox
{
    public class Foo
    {
        public Foo(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}