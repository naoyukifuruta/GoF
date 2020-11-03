
namespace ChainOfResponsibility
{
    public class Trouble
    {
        public int Number { get; private set; }

        public Trouble(int number)
        {
            this.Number = number;
        }
    }
}
