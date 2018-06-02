using System;
using static System.Console;

namespace VariablesSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "TouchWorld";
            var age = 1;
            var isRabbit = true;
            Type nameType = name.GetType();
            Type ageType = age.GetType();
            Type IsRabbitType = isRabbit.GetType();

            WriteLine($"name is type {nameType }");
            WriteLine($"Age is type {ageType}");
            WriteLine($"IsRabbitType is type {IsRabbitType}");
            ReadKey();
        }
    }
}

