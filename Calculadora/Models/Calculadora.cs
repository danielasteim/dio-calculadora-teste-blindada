using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    public class Calculadora
    {
        private List<String> _historico;
        private string _data;

        public Calculadora(string data)
        {
            _data = data;
            _historico = new List<String>();
        }
        public int Somar(int numero1, int numero2)
        {
            int res = numero1 + numero2;
            _historico.Insert(0, $"{numero1} + {numero2} = {res}, data: {_data}");
            return res;
        }
        public int Subtrair(int numero1, int numero2)
        {
            int res = numero1 - numero2;
            _historico.Insert(0, $"{numero1} - {numero2} = {res}, data: {_data}");
            return res;
        }
        public int Multiplicar(int numero1, int numero2)
        {
            int res = numero1 * numero2;
            _historico.Insert(0, $"{numero1} * {numero2} = {res}, data: {_data}");
            return res;
        }
        public int Dividir(int numero1, int numero2)
        {
            int res = numero1 / numero2;
            _historico.Insert(0, $"{numero1} / {numero2} = {res}, data: {_data}");
            return res;
        }
        public List<String> Historico()
        {

            _historico.RemoveRange(3, _historico.Count - 3);
            return new List<string>();
        }
    }
}