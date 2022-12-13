namespace DZ4
{
    internal class Mounting : GeagraficObject
    {
        private int top;
        public Mounting(int x, int y, string name, int top) : base(x, y, name)
        {
            this.top = top;
        }

        public virtual void GetInformation()
        {
            base.getInformation();
            Console.WriteLine($"Top: {top}");
        }
    }
}
