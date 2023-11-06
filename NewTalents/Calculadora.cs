using System;
using System.Collections.Generic;
using System.Text;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> _listaHistorico;
        private string _data;

        public Calculadora(string data)
        {
            _listaHistorico = new List<string>();
            _data = data;
        }

        public int Somar(int valorA, int valorB)
        {
            int resultado = valorA + valorB;

            _listaHistorico.Insert(0, $"{valorA} + {valorB} = {resultado} : {_data}");

            return resultado;
        }

        public int Subtrair(int valorA, int valorB)
        {
            int resultado = valorA - valorB;

            _listaHistorico.Insert(0, $"{valorA} - {valorB} = {resultado} : {_data}");

            return resultado;
        }

        public int Multiplicar(int valorA, int valorB)
        {
            int resultado = valorA * valorB;

            _listaHistorico.Insert(0, $"{valorA} x {valorB} = {resultado} : {_data}");

            return resultado;
        }

        public int Dividir(int valorA, int valorB)
        {
            int resultado = valorA / valorB;

            _listaHistorico.Insert(0, $"{valorA} / {valorB} = {resultado} : {_data}");

            return resultado;
        }

        public List<string> Historico()
        {
            if (_listaHistorico.Count > 3)
                _listaHistorico.RemoveRange(3, _listaHistorico.Count - 3);

            return _listaHistorico;
        }
    }
}
