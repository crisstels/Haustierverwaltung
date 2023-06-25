namespace ZooTiere
{
    public abstract class Haustier
    {
        public string Name { get { return _Name; } }
        protected string _Name;

        public string Besitzer { get { return _Besitzer; } }
        protected string _Besitzer;


        // Early-Binding, nur Prototyp
        public abstract void Pflegen();

        public override string ToString()
        {
            return this.GetType() + " - " + _Name;
        }


    }
}