using System;
using System.Threading;
using WindowsInput;

class Program
{
    static void Main()
    {
        bool running = true;
        while (running)
        {
            Timer timer = new Timer(PressKey, null, 30000, Timeout.Infinite);
            Console.WriteLine("Esperando 30 segundos");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.Q)
            {
                running = false;
            }
            //Console.ReadLine();
        }


    }

    static void PressKey(object state)
    {
        InputSimulator inputSimulator = new InputSimulator();
        inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_A);
        Console.WriteLine("Tecla A pressionada!");
    }
}
