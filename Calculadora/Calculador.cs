using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculador
    {
        private List<string> ListaHistorico;
        private string Data;

        public Calculador(string data)
        {
            ListaHistorico = new List<string>();
            Data = data;
        }

        public int somar(int val1, int val2)
        {
            int res = val1 + val2;

            ListaHistorico.Insert(0, "Res: " + res + " - Data: " + Data);

            return res;
        }

        public int subtrair(int val1, int val2)
        {
            int res = val1 - val2;

            ListaHistorico.Insert(0, "Res: " + res + " - Data: " + Data);

            return res;
        }

        public int multiplicar(int val1, int val2)
        {
            int res = val1 * val2;

            ListaHistorico.Insert(0, "Res: " + res + " - Data: " + Data);

            return res;
        }

        public int dividir(int val1, int val2)
        {
            int res = val1 / val2;

            ListaHistorico.Insert(0, "Res: " + res + " - Data: " + Data);
            
            return res;
        }

        public List<string> historico()
        {
            ListaHistorico.RemoveRange(3, ListaHistorico.Count - 3);

            return ListaHistorico;
        }
    }
}