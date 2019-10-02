using System;

namespace mateodragao
{
    class Program
    {
        
        static void Main(string[] args) {

            bool jogadorNaoDesistiu = true;
            do{


                Console.Clear();
                System.Console.WriteLine("==============================");
                System.Console.WriteLine("       Mate o Dragão!");
                System.Console.WriteLine("==============================");

                System.Console.WriteLine(" 1 - Start Game");
                System.Console.WriteLine(" 0 - Back Game");

                string opcaoJogador = Console.ReadLine();

                switch (opcaoJogador) {
                    case "1":
                        Console.Clear();
                    
                        Guerreiro guerreiro = CriarGuerreiro();

                        Dragao dragao = new Dragao();
                        dragao.nome = "Pepino";
                        dragao.forca = 5;
                        dragao.Destreza = 1;
                        dragao.Inteligencia = 3;
                        dragao.vida = 300;
                    
                        /*INICIO - Primeiro Diálogo */
                        CriarDialogo(guerreiro.Nome, $"{dragao.nome}, seu louco! Vim-lhe derrotar você! ");
                        CriarDialogo(dragao.Nome, "seu louco! Vim-lhe devorara comendo suas entranhas! ");

                        FinalizarDialogo();

                        /*FIM - Primeiro Diálogo */

                        /*INICIO - segundo Diálogo */
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Eu sou {guerreiro.sobrenome} ó criatura submissa!");
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Vim de {guerreiro.cidadeNatal} para te derrotar criatura moribunda! ");
                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: QUEM? ONDE? Fritarei você e usarei sua pele como tapete da minha casa");

                        System.Console.WriteLine("Narrador :Hora do Show BIULLLL!");

                        System.Console.WriteLine();
                        System.Console.WriteLine("aperte ENTER para prosseguir");
                        System.Console.ReadLine();

                        /*FIM - segundo Diálogo */
                        Console.Clear();

                        bool jogadorAtacaPrimeiro = guerreiro.Destreza > dragão.Destreza ? true : false;

                        int poderAtaqueGuerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;
                        
                        bool jogadorNaoCorreu = true;
                        if (jogadorAtacaPrimeiro)
                        {
                        System.Console.WriteLine("**Turno Do jogador**");
                        System.Console.WriteLine("Escolha uma ação:");
                        System.Console.WriteLine("1 - Atacar");
                        System.Console.WriteLine("2 - Fugir");

                            string opcaoBatalhaJogador = Console.ReadLine();

                            switch(opcaoBatalhaJogador){

                                case "1":
                                    Random geradorNumeroAleatorio = new Random();
                                    int geradorNumerojogador = geradorNumeroAleatorio.Next(0, 5);
                                    int geradorNumeroDragao = geradorNumeroAleatorio.Next(0, 5);
                                    int guerreiroDestrezatotal = guerreiro.Destreza + numeroAleatoriojogador;
                                    int dragaoDestrezatotal = Dragao.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezatotal > dragaoDestrezatotal) {
                                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Toma essa, lagarto da Africa!");
                                        dragao.Vida -= poderAtaqueGuerreiro + 5;
                                        System.Console.WriteLine($"HP Dragao: {dragao.Vida}");
                                        System.Console.WriteLine($"HP guerreiro: {guerreiro.Vida}");
                                    }

                                    else
                                    {
                                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Errouuu! Animal de teta morfético!");
                                    }

                                    System.Console.WriteLine();
                                    System.Console.WriteLine("Aperte ENTER para proseguir");
                                    System.Console.ReadLine();

                                    Console.clear();
                                break;
                                case  "2":
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: simbora fi");
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}: simbora fi");
                                    jogadorNaoCorreu = false;
                                break;
                            }
                        }

                        if (guerreiro.Vida <= 0)
                        {
                            System.Console.WriteLine("Você perdeu!");
                        }
                        if (dragao.Vida <= 0)
                        {
                            System.Console.WriteLine("Você venceu!");
                        }

                        System.Console.WriteLine();
                        System.Console.WriteLine("aperte ENTER para prosseguir");
                        Console.ReadLine();

                        while(guerreiro.vida > 0 && dragao.Vida > 0 && jogadorNoaCorreu){
                            Console.Clear();
                            System.Console.WriteLine("*Turno Dragão*");
                            

                            if (guerreiroDestrezatotal > dragaoDestrezatotal) {
                                System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Toma essa, lagarto da Africa!");
                                dragao.Vida -= dragao.forca;
                                System.Console.WriteLine($"HP Dragao: {dragao.Vida}");
                                System.Console.WriteLine($"HP guerreiro: {guerreiro.Vida}");

                                Random geradorNumeroAleatorio = new Random();
                                int geradorNumerojogador = geradorNumeroAleatorio.Next(0, 5);
                                int geradorNumeroDragao = geradorNumeroAleatorio.Next(0, 5);
                                int guerreiroDestrezatotal = guerreiro.Destreza + numeroAleatoriojogador;
                                int dragaoDestrezatotal = Dragao.Destreza + numeroAleatorioDragao;
                            }

                        else{

                                System.Console.WriteLine($"Errouuu! Animal de teta morfético!");
                                        System.Console.WriteLine("**Turno Do jogador**");
                            System.Console.WriteLine("Escolha uma ação:");
                            System.Console.WriteLine("1 - Atacar");
                            System.Console.WriteLine("2 - Fugir");

                            string opcaoBatalhaJogador = Console.ReadLine();

                            switch(opcaoBatalhaJogador)
                            {
                                case "1":
                                    Random geradorNumeroAleatorio = new Random();
                                    int geradorNumerojogador = geradorNumeroAleatorio.Next(0, 5);
                                    int geradorNumeroDragao = geradorNumeroAleatorio.Next(0, 5);
                                    int guerreiroDestrezatotal = guerreiro.Destreza + numeroAleatoriojogador;
                                    int dragaoDestrezatotal = Dragao.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezatotal > dragaoDestrezatotal) {
                                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Toma essa, lagarto da Africa!");
                                        dragao.Vida -= poderAtaqueGuerreiro + 5;
                                        System.Console.WriteLine($"HP Dragao: {dragao.Vida}");
                                        System.Console.WriteLine($"HP guerreiro: {guerreiro.Vida}");
                                    }

                                    else
                                    {
                                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Errouuu! Animal de teta morfético!");
                                    }

                                    System.Console.WriteLine();
                                    System.Console.WriteLine("Aperte ENTER para proseguir");
                                    System.Console.ReadLine();

                                    Console.clear();
                                break;
                                case  "2":
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: simbora fi");
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}: simbora fi");
                                    jogadorNaoCorreu = false;
                                break;
                                


                            }
                        }
                        case "0":
                            jogadorNaoDesistiu = false;
                            System.Console.WriteLine("GAME OVER");
                        break;
                            default:
                            System.Console.WriteLine("Comando inválido,cretino!");
                            System.Console.WriteLine("(Use seu cérebro para pensar)");
                        break;
                }
            } while (jogadorNaoDesistiu); //true vai se repetindo ::: false é uma vez e para
        }
        

        public static void CriarDialogo(string nome, string frase)
        {
            System.Console.WriteLine($"{nome.ToUpper()}: {frase}");
        }

        public static void CriarDialogo(string nome, string frase)
        {
        System.Console.WriteLine();
                    System.Console.WriteLine("aperte ENTER para prosseguir");
                    System.Console.ReadLine();
                    Console.Clear();
        }

        public staic void CriarGuerreiro(){
            Guerreiro guerreiro = new Guerreiro();
            guerreiro.Nome = "LUKE";
            guerreiro.Sobrenome ="O Caveira";
            guerreiro.Cidadenatal = "São Paulo";
            guerreiro.DataNascimento = "1990";
            guerreiro.FerramentaAtaque = "espada encandescente";
            guerreiro.FerramentProtecao = "escudo titanio";
            guerreiro.forca = "3";
            guerreiro.Destreza = "1";
            guerreiro.Insteligencia = "3";
            guerreiro.Vida = "20";
        }
    }
}
