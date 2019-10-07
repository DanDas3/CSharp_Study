using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercMod5Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo t = new Triangulo();
            Quadrado q = new Quadrado();
            Circunferencia c = new Circunferencia();
            Trapezio tr = new Trapezio();

            t.AlturaTri = 10.5;
            t.BaseTri = 4.0;
            t.CalculaArea();

            q.Lado = 10.0;
            q.CalculaArea();

            c.Raio = 5.4;
            c.CalculaArea();

            tr.BaseMaior = 15.6;
            tr.BaseMenor = 5.0;
            tr.AlturaTrap = 7.0;
            tr.CalculaArea();

            Console.WriteLine("Area do triangulo de altura " + t.AlturaTri + " base " + t.BaseTri + ": " + t.AreaTri);
            Console.WriteLine("Area do quadrado de lado: " + q.Lado + ": " + q.AreaQuad);
            Console.WriteLine("Area da circunferência de raio " + c.Raio + ": " + c.AreaCirc);
            Console.WriteLine("Area do triapézio de altura " + tr.AlturaTrap + " e bases " + tr.BaseMenor + ", " + tr.BaseMaior +": " + tr.AreaTrap);

            Console.WriteLine("Pressione alguma tecla para continuar...");
            Console.ReadLine();
        }
    }
}
