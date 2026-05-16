using System;
using GOF_patterns.creational;
using GOF_patterns.structural;
using GOF_patterns.behavioral;
using GOF_patterns.functional.decorator;
using GOF_patterns.functional.factory_method;
using GOF_patterns.functional.strategy;
using GOF_patterns.functional.execute_around;

namespace GOF_patterns
{
    public class Program
    {
        static void Main()
        {
            //CreationalRunner.Run();
            //StructuralRunner.Run();
            //BehavioralRunner.Run();

            DecoratorRunner.Run();
            FactoryMethodRunner.Run();
            StrategyRunner.Run();
            ExecuteAroundRunner.Run();
        }
    }
}
