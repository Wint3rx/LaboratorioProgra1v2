﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio
{
    internal class VideoJuego
    {
        private string titulo;
        private string desarrolladora;
        private double calificacion;
        private int anioLanzamiento;
        private bool jugando;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Desarrolladora
        {
            get { return desarrolladora; }
            set { desarrolladora = value; }
        }

        public double Calificacion
        {
            get { return calificacion; }
            set
            {
                if (value > 0 && value < 11)
                {
                    calificacion = value;
                } else
                {
                    Console.WriteLine("La calificación debe estar entre 0 y 10");
                }
                    
            }
        }

        public int AnioLanzamiento
        {
            get { return anioLanzamiento; }
            set
            {
                if (value <= 2024)
                {
                    anioLanzamiento = value;
                }
                else
                {
                    Console.WriteLine("No estamos en el futuro amigo >:)");
                }
            }
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Título: " + Titulo);
            Console.WriteLine("Desarrolladora: " + Desarrolladora);
            Console.WriteLine("Calificación: " + Calificacion);
            Console.WriteLine("Año de Lanzamiento: " + AnioLanzamiento);
        }

        public static void saludo()
        {
            Console.WriteLine("Hi Gamer:");
        }


        public void IniciarPartida()
        {
            jugando = true;
            Console.WriteLine("¡Partida iniciada!");
        }

        public void DetenerPartida()
        {
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Escape)
                    break;
            }
            Console.WriteLine("Partida detenida.");
        }

        public void TerminarJuego()
        {
            if (jugando)
            {
                jugando = false;
                Console.WriteLine("Juego terminado.");
            }
            else
            {
                Console.WriteLine("No hay partida en curso.");
            }
        }

    }
}