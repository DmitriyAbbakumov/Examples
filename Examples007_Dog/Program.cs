Console.Write("Введите расстояние между друзьями: ");
int D = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите скорость первого друга: ");
int S1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите скорость второго друга: ");
int S2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите скорость собаки: ");
int Sd = Convert.ToInt32(Console.ReadLine());

int count = 0;
int F = 2;
int T = 0;

while (D > 10)
{
    if (F == 1)
    {
        T = D / (S1 + Sd);
        F = 2;
    }
    else
    {
        T = D / (S2 + Sd);
        F = 1;       
    }
    D = D - (S1 + S2)*T;
    count++;
}
Console.Write("Собака пробежала ");
Console.Write(count);
Console.Write(" раз ");
