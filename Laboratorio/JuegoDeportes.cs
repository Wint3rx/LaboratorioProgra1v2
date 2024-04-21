using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio
{
    internal class JuegoDeportes : VideoJuego
    {
        public string Deporte { get; set; }
        public bool Multiplayer { get; set; }
        public string mostrardetallesDeportes()
        {
            return ($"El deporte del juego es: {Deporte} Tiene multijugador: {Multiplayer}");
        }
    }
}
