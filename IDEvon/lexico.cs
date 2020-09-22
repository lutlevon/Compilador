using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEvon
{
    class lexico
    {
        public static String salida = null;
        public static String errores = null;
        public static String ruta = null;
        public static int fila = 1;
        public static int col = 1;
        public static List<String> lista;
        public static List<Token> list;
        public lexico()
        {
            salida = null;
            ruta = null;
            errores = null;
            fila = 1;
            col = 1;
            lista = new List<String>();
            list = new List<Token>();
        }
        public void setRuta(String name)
        {
            ruta = name;
        }
        public String getSalida()
        {
            return salida;
        }
        public String getErrores()
        {
            return errores;
        }
        public List<String> getLista()
        {
            return lista;
        }
        public List<Token> getList()
        {
            return list;
        }
        public void principal()
        {
            int counter = 0;
            string line = "";
            String concat = "";
            String token = "";
            char last = ' ';
            int i = 0;
            int tamano;
            int estado = 0;
            int auxEstado = 0;
            int bandera = 0;
            System.IO.StreamReader file = new System.IO.StreamReader(ruta);

            String auxCaracter = "";
            while ((line = file.ReadLine()) != null)
            {
                concat += line + "\n";
            }
            tamano = concat.Length;
            file.Close();
            char[] cadena = concat.ToCharArray();
            char caracter = ' ';

            for (i = 0; i < cadena.Length; i++, col++)
            {
                caracter = cadena[i];
                if (caracter == '\n')
                {
                    fila++;
                    col = 0;
                }

                switch (estado)
                {
                    case 0:
                        if (Char.IsNumber(caracter))
                        {
                            estado = 7;
                            token = caracter.ToString();
                        }
                        else if (Char.IsLetter(caracter))
                        {
                            estado = 1;
                            token = caracter.ToString();
                        }
                        else if (char.IsWhiteSpace(caracter))
                        {
                            estado = 0;
                        }
                        else
                        {
                            switch (caracter)
                            {
                                case ' ':
                                    estado = 0;
                                    break;
                                case '<':
                                    token = caracter.ToString();
                                    estado = 2;
                                    break;
                                case '>':
                                    token = caracter.ToString();
                                    estado = 3;
                                    break;
                                case ':':
                                    token = caracter.ToString();
                                    estado = 4;
                                    break;
                                case '=':
                                    token = caracter.ToString();
                                    estado = 5;
                                    break;
                                case '!':
                                    token = caracter.ToString();
                                    estado = 6;
                                    break;
                                case '+':
                                    token = caracter.ToString();
                                    estado = 9;
                                    break;
                                case '-':
                                    token = caracter.ToString();
                                    estado = 10;
                                    break;
                                case '/':
                                    estado = 11;
                                    break;
                                case '*':
                                        salida += "multiplicacion [*]\n";
                                    lista.Add("*");
                                    Token temp = new Token("*", fila, col);
                                    list.Add(temp);
                                    estado = 0;
                                    break;
                                case '\n':
                                    estado = 0;
                                    break;
                                case '%':
                                    salida += "residuo [%]\n";
                                    lista.Add("%");
                                    Token temp2 = new Token("%", fila, col);
                                    list.Add(temp2);
                                    estado = 0;
                                    break;
                                case '(':
                                    salida += "parentesis que abre [(]\n";
                                    lista.Add("(");
                                    Token temp3 = new Token("(", fila, col);
                                    list.Add(temp3);
                                    estado = 0;
                                    break;
                                case ')':
                                    salida += "parentesis que cierra [)]\n";
                                    lista.Add(")");
                                    Token temp4 = new Token(")", fila, col);
                                    list.Add(temp4);
                                    estado = 0;
                                    break;
                                case '{':
                                    salida += "llave que abre [{]\n";
                                    lista.Add("{");
                                    Token temp5 = new Token("{", fila, col);
                                    list.Add(temp5);
                                    estado = 0;
                                    break;
                                case '}':
                                    salida += "llave que cierra [}]\n";
                                    lista.Add("}");
                                    Token temp6 = new Token("}", fila, col);
                                    list.Add(temp6);
                                    estado = 0;
                                    break;
                                case ';':
                                    salida += "delimitador [;]\n";
                                    lista.Add(";");
                                    Token temp7= new Token(";", fila, col);
                                    list.Add(temp7);
                                    estado = 0;
                                    break;
                                case ',':
                                    salida += "coma [,]\n";
                                    lista.Add(",");
                                    Token temp8 = new Token(",", fila, col);
                                    list.Add(temp8);
                                    estado = 0;
                                    break;
                                default:
                                    token = caracter.ToString();
                                    errores += "caracter invalido ["+token+"] linea: " + fila + "  columna: " + col + "\n";
                                    estado = 0;
                                    token = "";
                                    break;
                            }
                        }
                        break;
                    case 1: //-----------------------------------------------------Estado letras-----------------------------
                        if (Char.IsLetter(caracter))
                        {
                            token += caracter.ToString();
                            estado = 1;
                        }
                        else if (char.IsDigit(caracter))
                        {
                            token += caracter.ToString();
                            estado = 1;
                        }
                        else if (caracter == '_')
                        {
                            token += caracter.ToString();
                            estado = 1;
                        }
                        else
                        {
                            separar(estado, token);
                            estado = 0;
                            i--;
                            col--;
                            token = "";
                            if (caracter == '\n')
                            {
                                fila--;
                            }

                        }
                        break;
                    case 2: //-----------------------------------------------------Estado menor que-----------------------------
                        if (caracter == '=')
                        {
                            token += caracter.ToString();
                            separar(22, token);
                            estado = 0;
                        }
                        else
                        {
                            //se finaliza
                            separar(estado, token);
                            estado = 0;
                            i--;
                            col--;
                            token = "";
                            if (caracter == '\n')
                            {
                                fila--;
                            }
                        }
                        break;
                    case 3://-----------------------------------------------------Estado mayor que--------------------------------
                        if (caracter == '=')
                        {
                            token += caracter.ToString();
                            separar(33, token);
                            estado = 0;
                        }
                        else
                        {
                            //se finaliza
                            separar(estado, token);
                            estado = 0;
                            i--;
                            col--;
                            token = "";
                            if (caracter == '\n')
                            {
                                fila--;
                            }
                        }
                        break;
                    case 4://-----------------------------------------------------Estado dos puntos--------------------------------
                        if (caracter == '=')
                        {
                            token += caracter.ToString();
                            separar(estado, token);
                            estado = 0;
                        }
                        else
                        {
                            //aqui va el error perro
                            separar(44, token);
                            estado = 0;
                            i--;
                            col--;
                            token = "";
                            if (caracter == '\n')
                            {
                                fila--;
                            }
                        }
                        break;
                    case 5://-----------------------------------------------------Estado igual--------------------------------
                        if (caracter == '=')
                        {
                            token += caracter.ToString();
                            separar(estado, token);
                            estado = 0;
                        }
                        else
                        {
                            separar(55, token);
                            estado = 0;
                            i--;
                            col--;
                            token = "";
                            if (caracter == '\n')
                            {
                                fila--;
                            }
                        }
                        break;
                    case 6://-----------------------------------------------------Estado diferente de--------------------------------
                        if (caracter == '=')
                        {
                            token += caracter.ToString();
                            separar(estado, token);
                            estado = 0;
                        }
                        else
                        {
                            //aqui va el error perro
                            separar(66, token);
                            estado = 0;
                            i--;
                            col--;
                            token = "";
                            if (caracter == '\n')
                            {
                                fila--;
                            }
                        }
                        break;
                    case 7://-----------------------------------------------------Estado numeros--------------------------------
                        if (char.IsDigit(caracter))
                        {
                            token += caracter.ToString();
                            estado = 7;
                        }
                        else if (caracter == '.')
                        {
                            token += caracter.ToString();
                            estado = 88;
                        }
                        else
                        {
                            separar(estado, token);
                            estado = 0;
                            i--;
                            col--;
                            token = "";
                            if (caracter == '\n')
                            {
                                fila--;
                            }
                        }
                        break;
                    case 8://-----------------------------------------Estado numeros despues de un punto--------------------------------
                        if (char.IsDigit(caracter))
                        {
                            token += caracter;
                            estado = 8;
                        }
                        else
                        {
                            separar(estado, token);
                            estado = 0;
                            i--;
                            col--;
                            token = "";
                            if (caracter == '\n')
                            {
                                fila--;
                            }
                        }
                        break;
                    case 88:
                        if (char.IsDigit(caracter))
                        {
                            token += caracter;
                            estado = 8;
                        }
                        else
                        {
                            separar(88, token);
                            estado = 0;
                            i--;
                            col--;
                            token = "";
                            if (caracter == '\n')
                            {
                                fila--;
                            }
                        }
                        break;
                    case 9://-----------------------------------------------------Estado suma--------------------------------
                        if (caracter == '+')
                        {
                            token += caracter.ToString();
                            separar(estado, token);
                            estado = 0;
                        }
                        else
                        {
                            separar(99, token);
                            estado = 0;
                            i--;
                            col--;
                            token = "";
                            if (caracter == '\n')
                            {
                                fila--;
                            }
                        }
                        break;
                    case 10://-----------------------------------------------------Estado resta--------------------------------
                        if (caracter == '-')
                        {
                            token += caracter.ToString();
                            separar(estado, token);
                            estado = 0;
                        }
                        else
                        {
                            separar(100, token);
                            estado = 0;
                            i--;
                            col--;
                            token = "";
                            if (caracter == '\n')
                            {
                                fila--;
                            }
                        }
                        break;
                    case 11://-----------------------------------------------------Estado comentarios--------------------------------
                        if (caracter == '/')
                        {
                            estado = 13;

                        }
                        else if (caracter == '*')
                        {
                            estado = 14;
                            bandera = 1;
                        }
                        else
                        {
                            //division
                            separar(11, token);
                            i--;
                            col--;
                            token = "";
                            estado = 0;
                            if (caracter == '\n')
                            {
                                fila--;
                            }
                        }
                        break;
                    case 13:
                        if (caracter == '\n')
                        {
                            estado = 0;
                        }
                        else
                        {
                            estado = 13;
                        }
                        break;
                    case 14:
                        if (caracter == '*')
                        {
                            if (cadena[i + 1] == '/')
                            {
                                estado = 0;
                                bandera = 0;
                                i++;
                            }
                        }
                        else
                        {
                            estado = 14;
                        }
                        break;
                    case 12://------------------------------------------------------Estado * ----------------------------------------
                        if (caracter == '/')
                        {
                            estado = 0;
                        }
                        else
                        {
                            //multipmicacion
                            separar(estado, token);
                            estado = 0;
                            i--;
                            col--;
                            token = "";
                            if (caracter == '\n')
                            {
                                fila--;
                            }
                        }
                        break;
                }

            }
            //System.Console.WriteLine(salida);
            System.IO.StreamWriter File = new System.IO.StreamWriter(@"C:\Users\luisf\Desktop\salida.txt");
            File.Write(salida);
            File.Close();
            File = new System.IO.StreamWriter(@"C:\Users\luisf\Desktop\salidaErrores.txt");
            File.Write(errores);
            File.Close();
        }
        public void separar(int x, String token)
        {
            switch (x)
            {
                case 1:
                    reservadas(token);
                    //salida += "identificador [" + token + "]\n";
                    break;
                case 2:
                    salida += "menor que [" + token + "]\n";
                    lista.Add(token);
                    Token temp = new Token(token, fila, col);
                    list.Add(temp);
                    break;
                case 22:
                    salida += "menor o igual que [" + token + "]\n";
                    lista.Add(token);
                    Token temp2 = new Token(token, fila, col);
                    list.Add(temp2);
                    break;
                case 3:
                    salida += "mayor que [" + token + "]\n";
                    lista.Add(token);
                    Token temp3 = new Token(token, fila, col);
                    list.Add(temp3);
                    break;
                case 33:
                    salida += "mayor o igual que [" + token + "]\n";
                    lista.Add(token);
                    Token temp4 = new Token(token, fila, col);
                    list.Add(temp4);
                    break;
                case 4:
                    salida += "asignacion [" + token + "]\n";
                    lista.Add(token);
                    Token temp5 = new Token(token, fila, col);
                    list.Add(temp5);
                    break;
                case 44:
                    //salida += "se esperaba un [=] linea: " + fila + "  columna: " + col + "\n";
                    errores += "se esperaba un [=] linea: " + fila + "  columna: " + col + "\n";
                    break;
                case 5:
                    salida += "comparacion [" + token + "]\n";
                    lista.Add(token);
                    Token temp6 = new Token(token, fila, col);
                    list.Add(temp6);
                    break;
                case 55:
                   // salida += "se esperaba un [=] linea: " + fila + "  columna: " + col + "\n";
                    errores += "se esperaba un [=] linea: " + fila + "  columna: " + col + "\n";
                    break;
                case 6:
                    salida += "diferente de [" + token + "]\n";
                    lista.Add(token);
                    Token temp8 = new Token(token, fila, col);
                    list.Add(temp8);
                    break;
                case 66:
                   // salida += "se esperaba un [=]  linea: " + fila + "  columna: " + col + "\n";
                    errores += "se esperaba un [=]  linea: " + fila + "  columna: " + col + "\n";
                    break;
                case 7:
                    salida += "numero [" + token + "]\n";
                    lista.Add(token);
                    Token temp7 = new Token(token, fila, col);
                    list.Add(temp7);
                    break;
                case 8:
                    salida += "numero [" + token + "]\n";
                    lista.Add(token);
                    Token temp9 = new Token(token, fila, col);
                    list.Add(temp9);
                    break;
                case 88:
                   // salida += "se esperaba un numero despues del punto [" + token + "] linea: " + fila + "  columna: " + col + "\n";
                    errores += "se esperaba un numero despues del punto [" + token + "] linea: " + fila + "  columna: " + col + "\n";
                    break;
                case 9:
                    salida += "incremento [" + token + "]\n";
                    lista.Add(token);
                    Token temp10 = new Token("+", fila, col);
                    list.Add(temp10);
                    Token temp16 = new Token("1", fila, col);
                    list.Add(temp16);
                    break;
                case 99:
                    salida += "suma [+]\n";
                    lista.Add(token);
                    Token temp11 = new Token("+", fila, col);
                    list.Add(temp11);
                    break;
                case 10:
                    salida += "decremento [" + token + "]\n";
                    lista.Add(token);
                    Token temp12 = new Token("-", fila, col);
                    list.Add(temp12);
                    Token temp17 = new Token("1", fila, col);
                    list.Add(temp17);
                    break;
                case 100:
                    salida += "resta [-]\n";
                    lista.Add(token);
                    Token temp13 = new Token("-", fila, col);
                    list.Add(temp13);
                    break;
                case 12:
                    salida += "multiplicacion [*]\n";
                    lista.Add(token);
                    Token temp14 = new Token("*", fila, col);
                    list.Add(temp14);
                    break;
                case 11:
                    salida += "divicion [/]\n";
                    lista.Add(token);
                    Token temp15 = new Token("/", fila, col);
                    list.Add(temp15);
                    break;

            }
        }
        public void reservadas(string token)
        {
            int bandera = 0;

            if (String.Equals(token, "main") || String.Equals(token, "if") || String.Equals(token, "then") || String.Equals(token, "else") || String.Equals(token, "end") ||
               String.Equals(token, "do") || String.Equals(token, "while") || String.Equals(token, "cin") || String.Equals(token, "cout") || String.Equals(token, "real") ||
               String.Equals(token, "int") || String.Equals(token, "bool") || String.Equals(token, "until") || String.Equals(token, "float"))
            {
                bandera = 1;
            }

            if (bandera == 0)
            {
                salida += "identificador [" + token + "]\n";
                lista.Add("id");
                Token temp = new Token("id", fila, col,token);
                list.Add(temp);
            }
            else
            {
                salida += "Palabra reservada [" + token + "]\n";
                lista.Add(token);
                Token temp2 = new Token(token, fila, col);
                list.Add(temp2);
            }
        }
    }
}
