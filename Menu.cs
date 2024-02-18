using ConsoleApp2;
using System;

public class Menu
{
    private HelloWorld helloWorld;
    private Calcul calcul;
    private Stringi stringi;
    private Recursiondate recursiondate;
    private DateRec daterec;
	public Menu()
	{
        helloWorld = new HelloWorld();
        calcul = new Calcul();
        stringi = new Stringi();
        recursiondate = new Recursiondate();
        daterec = new DateRec();
        while (true)
        {
            Console.WriteLine("\n[0] Exit");
            Console.WriteLine("[1] Hello World!");
            Console.WriteLine("[2] Calc: <formula>");
            Console.WriteLine("[3] Recursion date ");
            Console.WriteLine("[4] Strings");
            string a = (Console.ReadLine());
            Console.Clear();
            switch (a)
            {
                case "0":
                    return;
                    break;
                case "1":
                    helloWorld.HWorld();
                    break;
                case "2":
                    calcul.Calculator();
                    break;
                case "3":
                    daterec.DateTimeRec();
                    break;
                case "4":
                    stringi.Stringin();
                    break;
                //case "5":
                    //daterec.DateTimeRec();
                    //break;
                default:
                    Console.WriteLine("Такого пункта не существует");
                    break;

            }
        }
    }
}
