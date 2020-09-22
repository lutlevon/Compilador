using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEvon
{
    class Token
    {
        public String nombre,valor;
        public int fil, col;

        public Token(String name, int fila,int columna)
        {
            this.nombre = name;
            this.fil = fila;
            this.col = columna;
            this.valor = "";
        }
        public Token(String name, int fila, int columna,String valor)
        {
            this.nombre = name;
            this.fil = fila;
            this.col = columna;
            this.valor = valor;
        }

    }
}
