using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoTabuada
{
    public class ClasseTrabalho
    {
        public float SomarDoisNumeros(float num1, float num2)
        {
            float resultado = num1 + num2;

            return resultado;
        }

        public float Conversor(float metro)
        {
            float milimetro = metro * 1000;
            return milimetro;
        }

        public string Tabuada()
        {
            int multiplicando, multiplicador, produto;
            string ResultadoTaboada = string.Empty;


            for (multiplicando = 1; multiplicando <= 10; multiplicando++)
            {
                for (multiplicador = 1; multiplicador <= 10; multiplicador++)
                {
                    produto = multiplicando * multiplicador;
                    ResultadoTaboada += ($"  {multiplicando} x {multiplicador} = {produto}\n");
                }
                ResultadoTaboada += "\n";


            }
            return ResultadoTaboada;
        }

        public string Tabuada(float num)
        {
            string ResultadoTaboada = string.Empty;
            for (int i = 0; i <= 10; i++)
            {
                float resultado = num * i;
                ResultadoTaboada += ($"  {num} x {i} = {resultado}\n");
            }
            return ResultadoTaboada;
        }

    }
}
