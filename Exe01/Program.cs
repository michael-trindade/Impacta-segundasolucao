namespace Exe01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //quero cadastrar 2 alunos e suas duas notas
            //quero calcular a média destas notas
            //se média maior 6 aprovado senão reprovado

            string aluno1 = "Michael";
            string aluno2 = "Andrea";

            double a1n1 = 8.0;
            double a1n2 = 7.0;
            double a2n1 = 8.5;
            double a2n2 = 7.5;

            double ma1 = (a1n1 + a1n2) / 2;
            double ma2 = (a2n1 + a2n2) / 2;

            //Aluno 1
            if(ma1 > 6)
            {
                Console.WriteLine($"Aluno1 {aluno1}: Aprovado - Média: {ma1}");
            }
            else
            {
                Console.WriteLine($"Aluno1 {aluno1}: Reprovado - Média: {ma1}");
            }

            //Aluno 2
            if (ma2 > 6)
            {
                Console.WriteLine($"Aluno2 {aluno2}: Aprovado - Média: {ma2}");
            }
            else
            {
                Console.WriteLine($"Aluno2 {aluno2}: Reprovado - Média: {ma2}");
            }
        }
    }
}