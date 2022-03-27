using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA_CARRITO.Clases
{
    internal class Carro
    {
        public string Marca { get; }
        public int Modelo { get; }
        public String Color { get; set; }

        private int Encendido = 0;
        private int Apagado = 0;
        private int velocidad_actual = 0;
        private const int MAXVELOCIDAD = 150;



        public Carro(string _marca, int _modelo, string _color)
        {
            Marca = _marca;
            Modelo = _modelo;
            Color = _color;
            Encendido = 0;
            this.velocidad_actual = 0;
        }


        public string GetVelocidadActual()
        {
            return $"Vamos a {velocidad_actual} KPH";
        }


        public void EncenderMotor()
        {
            if (Encendido == 0)
            {
                Console.WriteLine("Listo para correr, runn runn");
                Encendido = 1;
                this.velocidad_actual = 0;
            }
            else
            {
                Console.WriteLine("Orales!!! ya esta encendido tu nave");
            }
        }


        public string acelerar()
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = $"no puedo acelerar con el carro apagado";
                return mensaje;
            }

            velocidad_actual += 10;
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                mensaje = $"Vas a {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = $"{velocidad_actual}KPH oye tranquilo viejo vas al maximo de velocidad";
            }

            Console.WriteLine(mensaje);
            return mensaje;

        }



        public string acelerar(int CuantosKPH)
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = $"no puedo acelerar con el carro apagado";
                return mensaje;
            }

            velocidad_actual += CuantosKPH;
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                mensaje = $"Vas a {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = $"{velocidad_actual}KPH oye tranquilo viejo vas al maximo de velocidad";
            }

            Console.WriteLine(mensaje);
            return mensaje;

        }
        public string Desacelerar()
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = $"no puedo desacelerar con el carro apagado";
                return mensaje;
            }

            velocidad_actual -= 10;
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                mensaje = $"Vas a {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = $"{velocidad_actual}KPH oye tranquilo viejo vas al maximo de velocidad";
            }

            Console.WriteLine(mensaje);
            return mensaje;

        }



        public string Desacelerar(int CuantosKPH)
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = $"no puedo desacelerar con el carro apagado";
                return mensaje;
            }

            velocidad_actual -= CuantosKPH;
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                mensaje = $"Vas a {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = $"{velocidad_actual}KPH oye tranquilo viejo vas al maximo de velocidad";
            }

            Console.WriteLine(mensaje);
            return mensaje;
        }
        public string Frenar()
        {
            string mensaje = "";

            velocidad_actual = 0;
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                mensaje = $"Vas a {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = $"{velocidad_actual} Vas demasiado rapido, cuidado no hagarran los frenos";
            }

            Console.WriteLine(mensaje);
            return mensaje;

        }
        public void ApagarMotor()
        {
            if (Apagado == 0)
            {
                Console.WriteLine("Se apago ");
                Apagado = 1;
                this.velocidad_actual = 0;
            }
            else
            {
                Console.WriteLine("El motor ya se apago viejo, tranquilo");
            }
        }
        public void Bocinar()
        {
            Console.WriteLine("Beeeppp Beeepp el carro pesa");
        }
    }
}
    
