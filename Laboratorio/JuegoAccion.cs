using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio
{
    internal class JuegoAccion : VideoJuego
    {
        public string clasificacion {  get; set; }
        public bool shooter { get; set; }
        public string Detalleshooter()
        {
            return ($"es shooter: {shooter}");
        }
        public string Clasificacion()
        {
            List<string> clasificaciones = new List<string>();

            clasificaciones.Add("E - Para todos");
            clasificaciones.Add("T - Adolescente");
            clasificaciones.Add("M - Maduro");
            clasificaciones.Add("AO - Solo adultos");

            foreach (string clasificacion in clasificaciones)
            {
                Console.WriteLine(clasificacion);
            }

            return ($"La clasificacion del juego es: {clasificacion}");
        }
    }
}
