using System;

namespace FirstClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg1 = new Message();
            msg1.setMessage("Ular");
            msg1.ShowMessage();
            Message msg2 = new Message();
            msg2.TitleMessage = "Title?";
            Console.WriteLine(msg2.TitleMessage);
        }
    }
}
