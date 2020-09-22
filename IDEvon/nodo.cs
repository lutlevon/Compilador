using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEvon
{
    class nodo
    {
       /* public  List<String> list = new List<String>();
        public  String token = null;
        public  String nombre;
        public  nodo[] nodos = new nodo[3];
        public  static int i = 0;
        public nodo()
        {
            this.nombre = "";
        }
        public nodo(List<String> lista)
        {
            this.list = lista;
        }
        public nodo(String name)
        {
            this.nombre = name;
        }
        public nodo princial()
        {
            nodo temp = null;
            if(list[i] == "main")
            {
                match("main");
                temp = new nodo("main");
                match("{");
                temp.nodos[0] = listaDeclaracion();
                temp.nodos[1] = listaSentencia();
                match("}");
            }
            return temp;
        }
        void match(String tokenEsperado)
        {
            if(tokenEsperado == list[i])
            {
                i++;
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        nodo listaDeclaracion() 
        {
            nodo temp = null;
            temp.nodos[0] = declaracion();
            match(";");
            temp.nodos[1] = declaracion();
            return temp;
        }
        nodo listaSentencia()
        {
            nodo temp = new nodo("lista-sentencias");
            nodo temp2 = null;
            List<nodo> list_nodos =  new List<nodo>();
            temp2 = sentencia();
            list_nodos.Add(temp2);
            while ()
            {

            }
            return temp;
        }
        nodo sentencia()
        {
            nodo temp = null;
            switch (list[i])
            {
                case "if":
                    match("if");
                    match("(");
                    temp.nodos[0] = exp();
                    match(")");
                    temp.nodos[1] = sentBlock();
                    match("[");
                    match("else");
                    temp.nodos[2] = sentBlock();
                    match("]");
                    match("fin");
                    break;
                case "while":
                    match("while");
                    match("(");
                    temp.nodos[0] = exp();
                    match(")");
                    temp.nodos[1] = sentBlock();
                    break;
                case "do":
                    match("do");
                    temp.nodos[0] = sentBlock();
                    match("until");
                    match("(");
                    temp.nodos[1] = exp();
                    match(")");
                    match(";");
                    break;
                case "cin":
                    match("cin");

                    break;
                case "cout":
                    break;
            }
            return temp;
        }
        nodo sentBlock()
        {
            nodo temp = new nodo("sent-block");
            match("{");
            temp.nodos[0] = listaSentencia();
            match("}");
            return temp;
        }
        nodo declaracion()
        {
            nodo temp = new nodo ("declaracion");
            if(list[i] == "int" || list[i] == "float" || list[i] == "bool")
            {

            }
            else
            {
                Console.WriteLine("error");
            }
            temp.nodos[0] = listaVariables(); 

        }
        nodo exp()
        {
            nodo temp = new nodo("exp");
            temp.nodos[0] = expS();
            while(list[i] == "<=" || list[i] == "<" || list[i] == ">" || list[i] == ">="
                || list[i] == "=" || list[i] == "!=")
            {
                switch (list[i])
                {
                    case "<=":
                        match("<=");
                        temp.nodos[1] = expS();
                        break;
                    case "<":
                        match("<");
                        temp.nodos[1] = expS();
                        break;
                    case ">":
                        match(">");
                        temp.nodos[1] = expS();
                        break;
                    case ">=":
                        match(">=");
                        temp.nodos[1] = expS();
                        break;
                    case "=":
                        match("=");
                        temp.nodos[1] = expS();
                        break;
                    case "!=":
                        match("!=");
                        temp.nodos[1] = expS();
                        break;
                }
            }
            return temp;
        }
        nodo expS()
        {
            nodo temp = new nodo("exp-simple");
            temp.nodos[0] = termino();
            while (list[i] == "+" || list[i] == "-")
            {
                switch (list[i])
                {
                    case "+":
                        match("+");
                        temp.nodos[1] = termino();
                        break;
                    case "-":
                        match("-");
                        temp.nodos[1] = termino();
                        break;
                }
            }
            return temp;
        }
       nodo termino()
        {
            nodo temp = new nodo("termino");
            temp.nodos[0] = factor();
            while (list[i] == "*" || list[i] == "/" || list[i] == "%")
            {
                switch (list[i])
                {
                    case "*":
                        match("*");
                        temp.nodos[1] = factor();
                        break;
                    case "/":
                        match("/");
                        temp.nodos[1] = factor();
                        break;
                    case "%":
                        match("%");
                        temp.nodos[1] = factor();
                        break;
                }
            }
            return temp;
        }
        nodo factor()
        {
            nodo temp = new nodo("factor");
            temp.nodos[0] = fin();
            while(list[i] == "^")
            {
                match("^");
                temp.nodos[1] = fin();
            }
            return temp;
        }
        nodo fin()
        {
            nodo temp = new nodo("fin");
            int x = 0;
            if(list[i] == "(")
            {
                match("(");
                temp.nodos[0] = exp();
                match(")");
            }else if (int.TryParse(list[i],out x))
            {
                temp.nodos[1] = new nodo(list[i]);
                i++;
            }else if (list[i] == "id")
            {
                match("id");
                temp.nodos[1] = new nodo("id");
            }
            return temp;
        }*/
    }
}
