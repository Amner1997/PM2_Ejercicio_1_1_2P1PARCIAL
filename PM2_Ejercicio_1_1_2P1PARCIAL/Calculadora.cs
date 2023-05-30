﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PM2_Ejercicio_1_1_2P1PARCIAL
{
    internal class Calculadora
    {
        public double Sumar(double numero1, double numero2)
        {
            return numero1 + numero2;
        }

        public double Restar(double numero1, double numero2)
        {
            return numero1 - numero2;
        }

        public double Dividir(double numero1, double numero2)
        {
            if (numero2 == 0)
            {
                throw new DivideByZeroException("No se puede dividir entre cero.");
            }

            return numero1 / numero2;
        }

        public double Multiplicar(double numero1, double numero2)
        {
            return numero1 * numero2;
        }
    }
}
