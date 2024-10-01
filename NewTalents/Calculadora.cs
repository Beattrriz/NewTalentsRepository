using System;
using System.Collections.Generic;
using System.Text;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string data;

        public Calculadora(string data = null)
        {
            listaHistorico = new List<string>();
            this.data = data ?? DateTime.Now.ToString("dd/MM/yyyy");
        }

        public void InserirNaLista(int resultado)
        {
            listaHistorico.Insert(0, $"Res: {resultado} - data: {data}");
        }

        public int Somar(int num1, int num2)
        {
            var res = num1 + num2;

            InserirNaLista(res);

            return res;
        }

        public int Subtrair(int num1, int num2)
        {
            var res = num1 - num2;

            InserirNaLista(res);

            return res;
        }

        public int Multiplicar(int num1, int num2)
        {
            var res = num1 * num2;

            InserirNaLista(res);

            return res;
        }

        public int Dividir(int num1, int num2)
        {
            var res = num1 / num2;

            InserirNaLista(res);

            return res;
        }

        public List<string> Historico()
        {

            listaHistorico.RemoveRange(3, listaHistorico.Count -3);
            return listaHistorico;
        }
    }
}
