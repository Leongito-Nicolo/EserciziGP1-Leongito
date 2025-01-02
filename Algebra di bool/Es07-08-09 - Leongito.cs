public class AlgebraBool
{
    public static void Main(String[] args)
    {
        //7. Creare un programma che utilizza if-else nidificati.
        int potions = 5, potionRestore = 3, health = 10, currentHealth = 3;

        if(potions > 0)
        {
            if(currentHealth < health)
            {
                if((currentHealth + potionRestore) > health)
                    currentHealth = health;
                else
                    currentHealth += potionRestore;
            }
        }

        //8. Utilizzare un'espressione switch per valutare un valore booleano.
        bool value = true;

        switch (value)
        {
            case true:
                Console.WriteLine("The value is true");
                break;
            case false:
                Console.WriteLine("The value is false");
                break;
        }

        //9. Creare un'istruzione if-else che utilizza un'espressione con operatori di confronto.
        int a = 0, b = 0;

        if (a == b)
            Console.WriteLine("The numbers are equal");
        else
            Console.WriteLine("The numbers are not equal");

    }
}
