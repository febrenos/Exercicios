using System;

namespace NumerosAleatorios
{
    class Program
    {
        private void btnGeraNumeros_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Números Aleatórios");
            private void btnGeraNumero_Click(object sender, EventArgs e)
            {
                Random numAleatorio = new Random();
                int valorInteiro = numAleatorio.Next(10,21);
                double valorQuebrado = numAleatorio.NextDouble();
                lblNumeroIntGerado.Text = valorInteiro.ToString();
                lblNumDoubleGerado.Text = valorQuebrado.ToString();
            }
            // int[] vetor = new int[9];
            // Random Aleatorio = new Random();
            // numero = rndNumero.Next().ToString();

            // for (int i = 0; i <= 10; i++){

            //     System.Console.WriteLine($"{i}");
            //     vetor[i] = int.Parse(Console.ReadLine());
            // }
        }
    }
}
