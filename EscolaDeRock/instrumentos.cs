using System;

namespace EscolaDeRock.Models
{
    class InstrumentoMusical
    {
        string[] notas = { "Dó","Ré","Mi","Fá","Sol","Lá","Si"};

        public string TocaMusica()
        {
            int nota = new Random().Next(notas.Length - 1);
            return notas[nota];
        }
    }
}
