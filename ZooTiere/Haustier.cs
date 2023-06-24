namespace ZooTiere
{
    public abstract class Haustier
    {
        public string Name { get { return _Name; } set { _Name = value; } }
        protected string _Name;

        // Early-Binding, nur Prototyp
        public abstract void Pflegen();


    }
}