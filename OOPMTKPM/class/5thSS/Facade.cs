using System;

namespace FacadePattern
{
    // 1️⃣ Subsystems (Hệ thống con)
    public class SubsystemA
    {
        public string OperationA1() => "Subsystem A, Method operation1\n";
        public string OperationA2() => "Subsystem A, Method operation2\n";
    }

    public class SubsystemB
    {
        public string OperationB1() => "Subsystem B, Method operation1\n";
        public string OperationB2() => "Subsystem B, Method operation2\n";
    }

    public class SubsystemC
    {
        public string OperationC1() => "Subsystem C, Method operation1\n";
        public string OperationC2() => "Subsystem C, Method operation2\n";
    }

    // 2️⃣ Facade (Bộ điều phối)
    public class Facade
    {
        private readonly SubsystemA _a;
        private readonly SubsystemB _b;
        private readonly SubsystemC _c;

        public Facade()
        {
            _a = new SubsystemA();
            _b = new SubsystemB();
            _c = new SubsystemC();
        }

        public void Operation1()
        {
            Console.WriteLine("Operation 1:\n" + _a.OperationA1() + _b.OperationB1() + _c.OperationC1());
        }

        public void Operation2()
        {
            Console.WriteLine("Operation 2:\n" + _a.OperationA2() + _b.OperationB2() + _c.OperationC2());
        }
    }
}