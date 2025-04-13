// Facade.cs
using System;

namespace DesignPatterns
{
    // 서브시스템 클래스들
    public class CPU
    {
        public void Process()
        {
            Console.WriteLine("CPU is processing data");
        }
    }

    public class Memory
    {
        public void Load()
        {
            Console.WriteLine("Memory is loading data");
        }
    }

    public class HardDrive
    {
        public void Read()
        {
            Console.WriteLine("Hard Drive is reading data");
        }
    }

    // 파사드 클래스
    public class Computer
    {
        private readonly CPU _cpu;
        private readonly Memory _memory;
        private readonly HardDrive _hardDrive;

        public Computer()
        {
            _cpu = new CPU();
            _memory = new Memory();
            _hardDrive = new HardDrive();
        }

        public void Boot()
        {
            Console.WriteLine("Computer is starting...");
            _hardDrive.Read();
            _memory.Load();
            _cpu.Process();
            Console.WriteLine("Computer started successfully");
        }
    }

    public class FacadeDemo
    {
        public static void Run()
        {
            Computer computer = new Computer();
            computer.Boot();
        }
    }
}