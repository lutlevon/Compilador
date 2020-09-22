using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDEvon
{
    class Sintactico
    {
        List<Token> list = new List<Token>();
        public int contador;
        string errores = "";
        static bool banderaElse = false;
        static bool banderaEnd = false;
        static bool banderaKey = false;
        static bool banderaWhile = false;
        int banderanum = 0;
        public Sintactico()
        {
            this.contador = 0;
            banderaElse = false;
            banderaEnd = false;
            banderaKey = false;
            banderaWhile = false;
            this.errores = "";
        }
        public Sintactico(List<Token> lista)
        {
            this.list = lista;
            banderaElse = false;
            banderaEnd = false;
            banderaKey = false;
            banderaWhile = false;
            this.errores = "";
        }
        public TreeNode principal()
        {
            contador = 0;
            TreeNode raiz = null;
            return raiz;
        }
        public string getErrores()
        {
            return errores;
        }
        bool match(String Etoken)
        {
            bool bandera = true;
            Console.WriteLine(banderaWhile+"  "+contador);
            Console.WriteLine(banderaKey+ "  "+contador);
            if(contador <= list.Count() - 1)
            {
                if (list[contador].nombre == Etoken && contador <= list.Count())
                {
                    contador++;
                }
                else
                {
                    Console.WriteLine("error token que hay: " + list[contador].nombre + list[contador].valor + " token esperado: " + Etoken + " linea: " + list[contador].fil + " columna :" + list[contador].col);
                    errores += "error llego:  " + list[contador].nombre + " " + list[contador].valor + " token esperado: " + Etoken + "  linea: " + list[contador].fil + " columna :" + list[contador].col + "\n";
                    if (list[contador].nombre == "else")
                    {
                        contador++;
                    }
                    bandera = false;
                }
               
            }
            else  if(banderaKey == true)
            {
                Console.WriteLine("aqui se llama la funcion papi: " + contador + "  " + banderanum);
                errores += "error se esperaba } " + " linea: " + list[list.Count() - 1].fil + " columna: " + (list[list.Count() - 1].col + 1) + "\n";
                bandera = false;
            }
            return bandera;
        }
        public TreeNode main()
        {
            bool bandera = true;
            contador = 0;
            for(int i = 0; i< list.Count(); i++)
            {
                Console.WriteLine(list[i].nombre);
            }
            TreeNode raiz = new TreeNode("main");
            if (match("main") == false) { return raiz; }
            if (match("{") == false) { return raiz; }
            raiz.Nodes.Add(lista_declaracion());
            raiz.Nodes.Add(lista_sentencias());
            banderanum = 1;
            if (match("}") == false) { return raiz; }
            return raiz;
        }
        TreeNode lista_declaracion()
        {
            TreeNode temp = new TreeNode("lista-declaracion");
            temp.Nodes.Add(declaracion());
            if (match(";") == false ) { 
               while(list[contador].nombre == "int" || list[contador].nombre == "float" || list[contador].nombre == "bool"){
                    temp.Nodes.Add(declaracion());
                    if (match(";") == false) { return temp; }
                }
                    return temp;
            }
            while (list[contador].nombre == "int" || list[contador].nombre == "float" || list[contador].nombre == "bool")
            {
                temp.Nodes.Add(declaracion());
               if (match(";") == false) { return temp; }
            }
            return temp;
        }
        TreeNode declaracion()
        {
            TreeNode temp = new TreeNode("declaracion");
            TreeNode tm = null;
            switch (list[contador].nombre)
            {
                case "int":
                    if (match("int") == false) { return temp; }
                    tm = new TreeNode("int");
                    tm.Nodes.Add(lista_variables());
                    break;
                case "float":
                    if (match("float") == false) { return temp; }
                    tm = new TreeNode("float");
                    tm.Nodes.Add(lista_variables());
                    break;
                case "bool":
                    if (match("bool") == false) { return temp; }
                    tm = new TreeNode("bool");
                    tm.Nodes.Add(lista_variables());
                    break;
            }
            temp.Nodes.Add(tm);
            return temp;
        }
        TreeNode lista_variables()
        {
            TreeNode temp = new TreeNode("lista-variables");
            if (match("id") == false) { return temp; }
            temp.Nodes.Add(list[contador - 1].valor);
            while (list[contador].nombre == ",")
            {
                if (match(",") == false) { return temp; }
                if (match("id") == false) { return temp; }
                temp.Nodes.Add(list[contador - 1].valor);
            }
            return temp;

        }
        TreeNode lista_sentencias()
        {
            TreeNode temp = new TreeNode("lista-sentencias");
            temp.Nodes.Add(sentencia());
            while (list[contador].nombre != "end" && list[contador].nombre != "else" && list[contador].nombre != "}" &&  list[contador].nombre != ";" && list[contador].nombre != "until" && contador<list.Count()-1)
            {
                Console.WriteLine("super contador: " + contador + " tamaño: " + list.Count()) ;
                temp.Nodes.Add(sentencia());
                if(contador >= list.Count() - 1)
                {
                    banderaKey = true;
                }
                if(banderaKey == true)
                {
                    return temp;
                }
                if (banderaElse == true && list[contador].nombre== "else")
                {
                    contador++;
                    banderaElse = false;
                }
                if (banderaEnd == true && (list[contador].nombre == "end" || list[contador].nombre == ";"))
                {
                    if (list[contador + 1].nombre == ";")
                    {
                        contador = contador + 2;
                        banderaEnd = false;
                    }
                    else
                    {
                        contador++;
                        banderaEnd = false;
                    } 
                }
                Console.WriteLine("aqui que hay? " + list[contador].nombre+banderaElse);
            }
            return temp;
        }
        TreeNode sentencia()
        {
            TreeNode temp = null;
            TreeNode temp2 = null;
            Console.WriteLine("el token sentencia es: " + list[contador].nombre);
            switch (list[contador].nombre)
            {
                case "if":
                    if (match("if") == false) { return temp = new TreeNode("error"); }
                    if (match("(") == false) { banderaElse = true; banderaEnd = true; return temp = new TreeNode("error"); }
                    temp = new TreeNode("if");
                    temp.Nodes.Add(exp());
                    if (match(")") == false) { banderaElse = true; banderaEnd = true; return temp; }
                    if (match("then") == false) { banderaElse = true; banderaEnd = true; return temp; }
                    temp2 = new TreeNode("then");
                    temp.Nodes.Add(temp2);
                    temp.Nodes[1].Nodes.Add(sentBlock());
                    if (match("else") == false) { return temp; }
                    temp2 = new TreeNode("else");
                    temp.Nodes.Add(temp2);
                    temp.Nodes[2].Nodes.Add(sentBlock());
                    if (match("end") == false) { return temp; }
                    if (match(";") == false) { return temp; }
                    break;
                case "while":
                    if (match("while") == false) { return temp = new TreeNode("error"); }
                    if (match("(") == false) { return temp = new TreeNode("error"); }
                    temp = new TreeNode("while");
                    temp.Nodes.Add(exp());
                    if (match(")") == false) { return temp; }
                    if (match("{") == false) { return temp; }
                    temp.Nodes.Add(sentBlock());
                    banderanum = 2;
                    Console.WriteLine("que pedoo: " + contador+ " "+(list.Count()-1));
                    if(contador == list.Count() - 1)
                    {
                        banderaWhile = true;
                    }
                    if (match("}") == false) { return temp; }
                    break;
                case "do":
                    if (match("do") == false) { return temp = new TreeNode("error"); }
                    temp = new TreeNode("do");
                    temp.Nodes.Add(sentBlock());
                    if (match("until") == false) { return temp; }
                    if (match("(") == false) { return temp; }
                    temp2 = new TreeNode("until");
                    temp.Nodes.Add(temp2);
                    temp.Nodes[1].Nodes.Add(exp());
                    if (match(")") == false) { return temp; }
                    if (match(";") == false) { return temp; }
                    break;
                case "cin":
                    if (match("cin") == false) { return temp = new TreeNode("error"); }
                    if (match("id") == false) { return temp = new TreeNode("error"); }
                    if (match(";") == false) { return temp = new TreeNode("error"); }
                    temp = new TreeNode("cin");
                    temp.Nodes.Add(list[contador-2].nombre);
                    temp.Nodes[0].Nodes.Add(list[contador - 2].valor);
                    break;
                case "cout":
                    if (match("cout") == false) { return temp = new TreeNode("error"); }
                    temp = new TreeNode("cout");
                    temp.Nodes.Add(exp());
                    if (match(";") == false) { return temp; }
                    break;
                case "id":
                    if (match("id") == false) { return temp = new TreeNode("error"); }
                    if((list[contador].nombre == "+" || list[contador].nombre == "-") && list[contador+1].nombre == "1"){
                        contador--;
                        temp = new TreeNode();
                        temp = exp();
                        if (match(";") == false) { return temp; }
                        break;
                    }
                    if (match(":=") == false) { return temp = new TreeNode("error"); }
                    temp = new TreeNode(":=");
                    temp.Nodes.Add(list[contador - 2].nombre);
                    temp.Nodes[0].Nodes.Add(list[contador - 2].valor);
                    temp.Nodes.Add(exp());
                    if (match(";") == false) { return temp; }
                    break;
                default:
                    while (list[contador].nombre != ";" && list[contador].nombre != "then" && list[contador].nombre != "else" && contador < list.Count()-1)
                    {
                        contador++;
                    }
                    Console.WriteLine("antes: " +list[contador].nombre);
                    contador++;
                    Console.WriteLine("despues: "+ list[contador].nombre + "aqui tambien: "+contador);
                    return temp = new TreeNode("error");
                    int x = 0;
                    
                /*case "{":
                    match("{");
                    temp = new TreeNode("sen-block");
                    temp.Nodes.Add(sentBlock());
                    match("}");
                    break;*/
            }   
            return temp;
        }
        TreeNode sentBlock()
        {
            TreeNode temp = new TreeNode("sent-block");
            //match("{");
            temp.Nodes.Add(lista_sentencias());
           // match("}");
            return temp;
        }
        TreeNode exp()
        {
            TreeNode temp = new TreeNode("exp");
            TreeNode temp2 = null;
            temp = expS();
            while (list[contador].nombre == "<=" || list[contador].nombre == "<" || list[contador].nombre == ">" ||
              list[contador].nombre == ">=" || list[contador].nombre == "==" || list[contador].nombre == "!=")
            {
                switch (list[contador].nombre)
                {
                    case "<=":
                        if (match("<=") == false) { return temp; }
                        temp2 = new TreeNode("<=");
                        temp2.Nodes.Add(temp);
                        temp2.Nodes.Add(expS());
                        temp = temp2;
                        break;
                    case "<":
                        if (match("<") == false) { return temp; }
                        temp2 = new TreeNode("<");
                        temp2.Nodes.Add(temp);
                        temp2.Nodes.Add(expS());
                        temp = temp2;
                        break;
                    case ">":
                        if (match(">") == false) { return temp; }
                        temp2 = new TreeNode(">");
                        temp2.Nodes.Add(temp);
                        temp2.Nodes.Add(expS());
                        temp = temp2;
                        break;
                    case ">=":
                        if (match(">=") == false) { return temp; }
                        temp2 = new TreeNode(">=");
                        temp2.Nodes.Add(temp);
                        temp2.Nodes.Add(expS());
                        temp = temp2;
                        break;
                    case "==":
                        if (match("==") == false) { return temp; }
                        temp2 = new TreeNode("==");
                        temp2.Nodes.Add(temp);
                        temp2.Nodes.Add(expS());
                        temp = temp2;
                        break;
                    case "!=":
                        if (match("!=") == false) { return temp; }
                        temp2 = new TreeNode("!=");
                        temp2.Nodes.Add(temp);
                        temp2.Nodes.Add(expS());
                        temp = temp2;
                        break;
                }
            }
            return temp;
        }
        TreeNode expS()
        {
            TreeNode temp = new TreeNode("exp");
            TreeNode temp2 = null;
            temp = termino();
            while (list[contador].nombre == "+" || list[contador].nombre == "-")
            {
                switch (list[contador].nombre)
                {
                    case "+":
                        if (match("+") == false) { return temp; }
                        temp2 = new TreeNode("+");
                        temp2.Nodes.Add(temp);
                        temp2.Nodes.Add(termino());
                        temp = temp2;
                        break;
                    case "-":
                        if (match("-") == false) { return temp; }
                        temp2 = new TreeNode("-");
                        temp2.Nodes.Add(temp);
                        temp2.Nodes.Add(termino());
                        temp = temp2;
                        break;
                }
            }
            return temp;
        }
        TreeNode termino()
        {
            TreeNode temp = new TreeNode("temino");
            TreeNode temp2 = null;
            temp = factor();
            while (list[contador].nombre == "*" || list[contador].nombre == "/" || list[contador].nombre == "%")
            {
                switch (list[contador].nombre)
                {
                    case "*":
                        if (match("*") == false) { return temp; }
                        temp2 = new TreeNode("*");
                        temp2.Nodes.Add(temp);
                        temp2.Nodes.Add(factor());
                        temp = temp2;
                        break;
                    case "/":
                        if (match("/") == false) { return temp; }
                        temp2 = new TreeNode("/");
                        temp2.Nodes.Add(temp);
                        temp2.Nodes.Add(factor());
                        temp = temp2;
                        break;
                    case "%":
                        if (match("%") == false) { return temp; }
                        temp2 = new TreeNode("%");
                        temp2.Nodes.Add(temp);
                        temp2.Nodes.Add(factor());
                        temp = temp2;
                        break;
                }
            }

            return temp;
        }
        TreeNode factor()
        {
            TreeNode temp = new TreeNode("factor");
            TreeNode temp2 = null;
            temp = fin();

            while(list[contador].nombre == "^")
            {
                if (match("^") == false) { return temp; }
                temp2 = new TreeNode("^");
                temp2.Nodes.Add(temp);
                temp2.Nodes.Add(fin());
                temp = temp2;
            }
            return temp;
        }
        TreeNode fin()
        {
            Console.WriteLine("el token es: " + list[contador].nombre);
            TreeNode temp = null;
            int x = 0;
            float y = 0;
            if (int.TryParse(list[contador].nombre, out x) || float.TryParse(list[contador].nombre, out y))
            {
                temp = new TreeNode(list[contador].nombre);
                if (contador < list.Count() - 1)
                {
                    contador++;
                    
                }
            }
            else if (list[contador].nombre == "(")
            {
                if (match("(") == false) { return temp = new TreeNode("error"); }
                temp = new TreeNode();
                temp.Nodes.Add(exp());
                if (match(")") == false) { return temp; }
            }
            else if (list[contador].nombre == "id")
            {
                if (contador < list.Count() - 1)
                {
                    temp = new TreeNode(list[contador].nombre);
                    temp.Nodes.Add(list[contador].valor);
                    contador++;
                }
            }
            else
            {
                return temp = new TreeNode("error");
            }
            return temp;
        }
    }
    
}
