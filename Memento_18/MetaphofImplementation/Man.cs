namespace Memento_18.MetaphofImplementation
{
    public class Man
    {
        public string Сlothes { get; set; }

        public void Dress(Backpack backpack)
        {
            Сlothes = backpack.Сontents;
        }

        public Backpack Undress()
        {
            return new Backpack(Сlothes);
        }
    }
}