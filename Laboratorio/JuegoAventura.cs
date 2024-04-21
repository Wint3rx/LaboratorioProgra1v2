using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio
{
    internal class JuegoAventura : VideoJuego
    {
        public string TipoDeAventura { get; set; }
        public bool MundoAbierto { get; set; }
        public string mostrardetallesAventura()
        {
            return ($"Que tipo de aventura es: {TipoDeAventura} es mundo abierto: {MundoAbierto}");
        }
    }
}
