using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Joao_Maria.Models
{
    public class aluno
    {

        public int dia { get; set; }
        public int qtdMaca { get; set; }
        public int qtdPera { get; set; }

        public aluno(int dia, int maca, int pera)
        {
            this.dia = dia;
            this.qtdMaca = maca;
            this.qtdPera = pera;
        }
    }

    public class saida1
    {
        public int i { get; set; }
        public string fruta { get; set; }

        public saida1(int i, string fruta)
        {
            this.i = i;
            this.fruta = fruta;
        }
    }
}