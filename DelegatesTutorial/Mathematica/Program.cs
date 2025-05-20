Console.WriteLine("Hello, World");

public class Integrator
{
    public double Integrate()
    {
        var start = 0.0;
        var end = 1.0;
        var step = 0.1;

        var sum = 0.0;

        for (var x = start; x < end; x += step)
        {
            var y = x * x;
            sum += y * step;
        }

        return sum;
    }
}
