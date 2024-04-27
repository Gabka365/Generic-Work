using System;

namespace Generic.Homework;

public class Pair<S, K>
{
    public S s { get; set; }

    public K k { get; set; }

    public string UniteValue { get; set; }

    public Pair(S s, K k)
    {
        if ((s is null) || (k is null))
        {
            try
            {
                throw new ArgumentNullException("s or k");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(1);
            }
        }

        this.s = s;
        this.k = k;
        UniteValue = "";
    }

    public string Unite()
    {
        UniteValue += s.ToString();
        UniteValue += k.ToString();
        return UniteValue;
    }
}
