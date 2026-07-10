
class Example2
{
    static void Main(string[] args)
    {
        int totalPower = 0;
        int maintenance = 0;
        int normal = 0;
        int efficient = 0;

        for (int lightNumber = 1; lightNumber <= 30; lightNumber++)
        {
            int power = 80 + (lightNumber * 5);

            totalPower = totalPower + power;

            if (power > 180)
            {
                Console.WriteLine("Light " + lightNumber + " : " + power + " W - Maintenance Required");
                maintenance++;
            }
            else if (power >= 140 && power <= 180)
            {
                Console.WriteLine("Light " + lightNumber + " : " + power + " W - Normal Operation");
                normal++;
            }
            else
            {
                Console.WriteLine("Light " + lightNumber + " : " + power + " W - Energy Efficient");
                efficient++;
            }
        }

        double averagePower = (double)totalPower / 30;

        Console.WriteLine("Total Power Consumed : " + totalPower + " W");
        Console.WriteLine("Average Power Consumption : " + averagePower + " W");
        Console.WriteLine("Maintenance Required : " + maintenance);
        Console.WriteLine("Normal Operation : " + normal);
        Console.WriteLine("Energy Efficient : " + efficient);
    }
}