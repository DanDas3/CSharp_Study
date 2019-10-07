using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercMod5Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno();
            Aluno aluno2 = new Aluno();
            Aluno aluno3 = new Aluno();
            Turma t = new Turma();
            aluno1.Prova1 = new Prova();
            aluno1.Prova2 = new Prova();
            aluno1.Prova1.NotaParte1 = 4.0;
            aluno1.Prova1.NotaParte2 = 2.5;
            aluno1.Prova2.NotaParte1 = 1.0;
            aluno1.Prova2.NotaParte2 = 7.0;
            Console.WriteLine("Nota prova1: " + aluno1.Prova1.CalcularNotaTotal());
            Console.WriteLine("Nota prova2: " + aluno1.Prova2.CalcularNotaTotal());
            Console.WriteLine("Média aluno: " + aluno1.CalcularMedia());

            aluno2.Prova1 = new Prova();
            aluno2.Prova2 = new Prova();
            aluno2.Prova1.NotaParte1 = 6.5;
            aluno2.Prova1.NotaParte2 = 3.5;
            aluno2.Prova2.NotaParte1 = 0.0;
            aluno2.Prova2.NotaParte2 = 3.0;
            Console.WriteLine("Nota prova1: " + aluno2.Prova1.CalcularNotaTotal());
            Console.WriteLine("Nota prova2: " + aluno2.Prova2.CalcularNotaTotal());
            Console.WriteLine("Média aluno: " + aluno2.CalcularMedia());

            aluno3.Prova1 = new Prova();
            aluno3.Prova2 = new Prova();
            aluno3.Prova1.NotaParte1 = 5.0;
            aluno3.Prova1.NotaParte2 = 4.0;
            aluno3.Prova2.NotaParte1 = 6.0;
            aluno3.Prova2.NotaParte2 = 1.5;
            Console.WriteLine("Nota prova1: " + aluno3.Prova1.CalcularNotaTotal());
            Console.WriteLine("Nota prova2: " + aluno3.Prova2.CalcularNotaTotal());
            Console.WriteLine("Média aluno: " + aluno3.CalcularMedia());

            t.Aluno1 = aluno1;
            t.Aluno2 = aluno2;
            t.Aluno3 = aluno3;

            Console.WriteLine("Média da turma: " + t.CalcularMedia());
            Console.WriteLine("Pressione alguma tecla para continuar...");
            Console.ReadLine();
        }
    }
}
