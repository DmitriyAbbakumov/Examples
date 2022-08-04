int count = 0;
double D = 10000; //расстояние между друзьями
int S1 = 1; // скорость первого друга
int S2 = 2; // скорость второго друга
int Sd = 5; //скорость собаки
int F = 2;
double T = 0;

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
