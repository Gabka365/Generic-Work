using Generic.Homework;



ComparablePair<int, int> pair1 = new ComparablePair<int, int>(23, 1);
ComparablePair<int, int> pair2 = new ComparablePair<int, int>(23, 3);

Console.WriteLine($"p1 = ({pair1.t},{pair1.u})");
Console.WriteLine($"p2 = ({pair2.t},{pair2.u})");


int result = pair1.CompareTo(pair2);


if (result == 0)
{
    Console.WriteLine("Пары равны");
}
else
{
    if (result == 1)
    {
        Console.WriteLine($"Больше пара 1 - ({pair1.t},{pair1.u})");
    }
    if (result == -1)
    {
        Console.WriteLine($"Больше пара 2 - ({pair2.t},{pair2.u})");
    }
}

