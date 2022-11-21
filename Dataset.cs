using System;

class Dataset
{
    // Function to calculate speed
    static double cal_speed(double dist, double time)
    {
        Console.WriteLine(" Distance(km) : " + dist);
        Console.WriteLine(" Time(hr) : " + time);

        return dist / time;
    }

    // Function to calculate distance 
    static double cal_dis(double speed, double time)
    {
        Console.WriteLine(" Time(hr) : " + time);
        Console.WriteLine(" Speed(km / hr) : " + speed);

        return speed * time;
    }

    // Function to calculate time taken
    static double cal_time(double dist, double speed)
    {
        Console.WriteLine(" Distance(km) : " + dist);
        Console.WriteLine(" Speed(km / hr) : " + speed);

        return dist / speed;
    }

    
    public static void Main()
    {
        // Calling function cal_speed()
        Console.WriteLine(" The calculated Speed(km / hr) is : " +
                        cal_speed(45.9, 2.0));

        // Calling function cal_dis()
        Console.WriteLine(" The calculated Distance(km) : " +
                    cal_dis(62.9, 2.5));

        // Calling function cal_time()
        Console.WriteLine(" The calculated Time(hr) : " +
                cal_time(48.0, 4.5));
    }
}
