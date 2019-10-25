using System;

namespace Peso {
    class Program {
        static void Main (string[] args) {
            int Opcao;
            double Pterra;

            Console.WriteLine ("   Gravidade Planeta");
            Console.WriteLine ("1	0,37	Mercúrio:");
            Console.WriteLine ("2	0,88	 Vênus   :");
            Console.WriteLine ("3	0,38	 Marte   :");
            Console.WriteLine ("4	2,64	Júpiter :");
            Console.WriteLine ("5	1,15	Saturno :");
            Console.WriteLine ("6	1,17	 Urano   :");
            Console.WriteLine ("...........................");
            Console.WriteLine ("Digite qual Planeta: ");
            Opcao = int.Parse (Console.ReadLine ());

            switch (Opcao) {
                case 1:
                Console.WriteLine ("Digite seu Peso na Terra: ");
                Pterra = double.Parse (Console.ReadLine ());
                Console.WriteLine("Seu peso em mercúrio é:");
                Console.WriteLine((Pterra/10)*0.37);
                break;

                case 2:
                Console.WriteLine ("Digite seu Peso na Terra: ");
                Pterra = double.Parse (Console.ReadLine ());
                Console.WriteLine("Seu peso em Vênus é:");
                Console.WriteLine((Pterra/10)*0.88);
                break;

                case 3:
                Console.WriteLine ("Digite seu Peso na Terra: ");
                Pterra = double.Parse (Console.ReadLine ());
                Console.WriteLine("Seu peso em Marte é:");
                Console.WriteLine((Pterra/10)*0.38);
                break;

                case 4:
                Console.WriteLine ("Digite seu Peso na Terra: ");
                Pterra = double.Parse (Console.ReadLine ());
                Console.WriteLine("Seu peso em Júpter é:");
                Console.WriteLine((Pterra/10)*2.64);
                break;

                case 5:
                Console.WriteLine ("Digite seu Peso na Terra: ");
                Pterra = double.Parse (Console.ReadLine ());
                Console.WriteLine("Seu peso em Saturno é:");
                Console.WriteLine((Pterra/10)*1.15);
                break;

                case 6:
                Console.WriteLine ("Digite seu Peso na Terra: ");
                Pterra = double.Parse (Console.ReadLine ());
                Console.WriteLine("Seu peso em Urano é:");
                Console.WriteLine((Pterra/10)*1.17);
                break;

                default:
                break;
            }

        }
    }
}