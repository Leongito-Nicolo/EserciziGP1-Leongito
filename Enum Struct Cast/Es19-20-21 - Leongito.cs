public class EnumsStructCast
{
    struct CustomDate
    {
        public int Day;
        public int Month;
        public int Year;

        public CustomDate(int day, int month, int year)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }

        public override string ToString()
        {
            return this.Day + " / " + this.Month + " / " + this.Year;
        }
    }

    struct PlayingCard
    {
        public string Value;
        public string Seed;

        public PlayingCard(string value, string seed)
        {
            this.Value = value;
            this.Seed = seed;
        }

        public override string ToString()
        {
            return this.Value + " of " + this.Seed;
        }
    }

    enum LightState
    {
        Red,
        Yellow,
        Green
    }

    public static void Main(String[] args)
    {
        //19.Dichiarare una struct per rappresentare una data personalizzata.
        CustomDate date = new CustomDate(25, 11, 2001);
        Console.WriteLine("Custom date: " + date.ToString());

        //20. Creare una struct per rappresentare una carta da gioco(valore e seme). 
        PlayingCard card = new PlayingCard("Ace", "Spades");
        Console.WriteLine("Playing card: " + card.ToString());

        //21. Utilizzare un enum in un'istruzione condizionale. 
        LightState light = LightState.Green;

        if (light == LightState.Red)
            Console.WriteLine("Stop!");
        else if (light == LightState.Yellow)
            Console.WriteLine("Caution!");
        else if (light == LightState.Green)
            Console.WriteLine("Go!");

    }
}