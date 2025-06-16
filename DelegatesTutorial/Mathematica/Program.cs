var intergator = new Integrator();


Console.WriteLine(intergator.Integrate(0.0, 1, 0.01, x => x * x));
Console.WriteLine(intergator.Integrate(0.0, 1, 0.01, x => Math.Sin(x)));

public class Integrator
{
    public double Integrate(double start, double end, double step, Func<double, double> function)
    {
        var sum = 0.0;

        for (var x = start; x < end; x += step)
        {
            var y = function(x);
            sum += y * step;
        }

        return sum;
    }
}