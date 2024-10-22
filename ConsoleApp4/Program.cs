using System.Data;

namespace ConsoleApp4
{
    class Card
    {
        public long number { get; set; }
        public string FIO { get; set; }
        public int CVC { get; set; }
        public int stopDate { get; set; }

        public Card()
        {
            number = 0;
            FIO = " ";
            CVC = 0;
            stopDate = 0;
        }
        public void Input(long number, string FIO, int CVC, int stopDate)
        {
            try
            {
                this.number = number;
                this.FIO = FIO;
                if (CVC < 100 || CVC > 999) 
                {
                    throw new Exception("Incorrect CVC");
                }
                else
                {
                    this.CVC = CVC;
                }
                this.stopDate = stopDate;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Print()
        {
            Console.WriteLine($"Number: {number}\nFIO: {FIO}\nCVC: {CVC}\nStopdate: {stopDate}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card();
            card.Input(4024007123874108, "Ivan Mlanar", 431, 0);
            card.Print();
        }
    }
}
