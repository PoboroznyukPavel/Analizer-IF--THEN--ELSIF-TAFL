using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_по_ТАФЯ_вар_18
{
    /* {
     case (State.NX):
                         {
                             if (number0.Contains(sc))
                             {
                                 name1 += sc.ToString();
                                 
                                 if (Int16.TryParse(name1, out t))
                                 {
                                     error = "Ошибка, число не в диапазоне [-32768..32767]";
                                 }
                             }
                             else
                             if (sc == '.')
                             {
                                 sta = State.NX3;
                                 name2 = sc.ToString();
                             }
                             else
                                 if (sc == ' ')
                             {
                                 sta = State.SP2;
                                 qq.name = name1;
                                 qq.type = "CARDINAL";
                                  q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                             }
                             else
                                 error = "Ошибка, ожидался THEN, либо сравнение";
                         }
                         break;
                     case (State.NX1):
                         {
                             if (sc == '.')
                             {
                                 sta = State.NX3;
                                 name2 = sc.ToString();
                             }
                             else
                                 if (sc == ' ')
                             {
                                 sta = State.SP2;
                                 qq.name = name1;
                                 qq.type = "CARDINAL";
                                  q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                             }
                             else
                                 error = "Ошибка, ожидался THEN, либо выражение";
                         }
                         break;
                     case (State.NX2):
                         {
                             if (sc == '0')
                             {
                                 name1 += sc;
                                 sta = State.NX1;
                             }
                             else
                                 if (number.Contains(sc))
                             {
                                 name1 += sc;
                                 sta = State.NX;
                             }
                             else
                                 error = "Ошибка, ожидался THEN, либо выражение";
                         }
                         break;
                     case (State.NX3):
                         {
                             if (number0.Contains(sc))
                             {
                                 name2 += sc;
                                 if (name2.Length > 15)
                                     error = "Ошибка: должно быть не более 15 символов в мантисе";
                             }
                             else
                                 if (sc == ' ')
                             {
                                 qq.type = "Real";
                                 qq.name = name1 + name2;
                                  q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                 sta = State.SP2;
                             }
                             else
                                 error = "Ошибка, ожидался THEN, либо выражение";
                         }
                         break;
 }*///NX..NX3
    /* {
   case (State.IDX):
                         {
                             if (letter.Contains(sc) || number0.Contains(sc))
                             {
                                 name1 += sc;
                                 if (name1.Length > 8)
                                     error = "Ошибка, имя идентификатора длиннее 8";
                             }
                             else
                                 if (sc == ' ')
                             {
                                 if (!keyWords.Contains(name1))
                                 {
                                     qq.type = "id";
                                     qq.name = name1;
                                      q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                     sta = State.IDX1;
                                 }
                                 else
                                     error = "Ошибка, название переменной не может совпадать с ключевыми словами";
                             }
                             else
                                 if (sc == '[')
                                 sta = State.IDX2;
                             else
                                 error = "Ошибка, недопустимый символ в Идентификаторе";
                         }
                         break;
                     case (State.IDX1):
                         {
                             if (sc == ' ') ;
                             else
                                 if (sc == '[')
                                 sta = State.IDX2;
                             else
                                 error = "Ошибка, ожидался пробел, либо '['";
                         }
                         break;
                     case (State.IDX2):
                         {
                             if (sc == ' ') ;
                             else
                                 if (sc == '0')
                             {
                                 name2 = sc.ToString();
                                 sta = State.IDX5;
                             }
                             else
                             if (sc == '-')
                                 {
                                 name2 = sc.ToString();
                                 sta = State.IDX8;
                                 }
                             else
                                 if (letter.Contains(sc))
                             {
                                 name2 = sc.ToString();
                                 sta = State.IDX3;
                             }
                             else
                                 if (number.Contains(sc))
                             {
                                 name2 = sc.ToString();
                                 sta = State.IDX4;
                             }
                             else
                                 error = "Ошибка, недопустимый символ в обозначении номера массива";
                         }
                         break;
                     case (State.IDX3):
                         {
                             if (sc == ' ')
                             {
                                 if (!keyWords.Contains(name2))
                                 {
                                     qq.type = "id";
                                     qq.name = name2;
                                      q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                     sta = State.IDX6;
                                 }
                                 else
                                     error = "Ошибка, название переменной не может совпадать с ключевыми словами";
                             }
                             else
                                 if (letter.Contains(sc) || number0.Contains(sc))
                             {
                                 name2 += sc;
                                 if (name2.Length > 8)
                                     error = "Ошибка, имя идентификатора длиннее 8";
                             }
                             else
                                 if (sc == ']')
                             {
                                 if (!keyWords.Contains(name2))
                                 {
                                     qq.type = "id";
                                     qq.name = name2;
                                      q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                     sta = State.IDX7;
                                 }
                                 else
                                     error = "Ошибка, название переменной не может совпадать с ключевыми словами";
                             }
                             else
                                 error = "Ошибка, неверный символ в обозначении номера массива";
                         }
                         break;
                     case (State.IDX4):
                         {
                             if (sc == ' ')
                             {
                                 
                                 if (Int16.TryParse(name2, out t))
                                 {
                                     qq.type = "CARDINAL";
                                     qq.name = name2;
                                      q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                     sta = State.IDX6;
                                 }
                                 else
                                     error = "Ошибка, число не в диапазоне [-32768..32767]";
                             }
                             else
                                 if (number0.Contains(sc))
                             {
                                 name2 += sc;
                             }
                             else
                                 if (sc == ']')
                             {
                                 
                                 if (Int16.TryParse(name2, out t))
                                 {
                                     qq.type = "CARDINAL";
                                     qq.name = name2;
                                      q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                     sta = State.IDX7;
                                 }
                                 else
                                     error = "Ошибка, число не в диапазоне [-32768..32767]";
                             }
                             else
                                 error = "Ошибка, ожидался пробел, цифра, либо закрывающая скобка";
                         }
                         break;
                     case (State.IDX5):
                         {
                             if (sc == ' ')
                             {
                                 qq.type = "CARDINAL";
                                 qq.name = name2;
                                  q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                 sta = State.IDX6;
                             }
                             else
                                 if (sc == ']')
                             {
                                 qq.type = "CARDINAL";
                                 qq.name = name2;
                                  q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                 sta = State.IDX7;
                             }
                             else
                                 error = "Ошибка, ожидался пробел, либо закрывающая скобка";
                         }
                         break;
                     case (State.IDX6):
                         {
                             if (sc == ' ') ;
                             else
                                 if (sc == ']')
                                     sta = State.IDX7;
                             else
                                 error = "Ошибка, ожидался пробел, либо закрывающая скобка";
                         }
                         break;
                     case (State.IDX7):
                         {
                             if (sc == ' ')
                                 sta = State.SP2;
                             else
                                 error = "Ошибка, ожидался пробел";
                         }
                         break;
                     case (State.IDX8):
                         {
                             if (number.Contains(sc))
                             {
                                 name1 += sc;
                                 sta = State.SP2;
                             }
                             else
                                 error = "Ошибка, ожидалась цифра";
                         }
                         break;
  }*///IDX..IDX8

    /*
            • id — идентификатор языка Modula-2, начинается с буквы или знака подчеркивания, далее
    могут следовать буквы, цифры и знаки подчеркивания. Ограничения:
    – имеет длину не более 8 символов;
    – не является зарезервированным словом: IF , THEN , ELSIF , ELSE, END , OR ,
    NOT, AND .
    • int-numb — целое число в диапазоне -32768 – 32767;
    • fix-point-numb — число с фиксированной точкой;
    • real-numb — число с плавающей точкой.

            Построить и вывести на печать по завершении анализа таблицы идентификаторов и кон-
    стант (Указывать тип констант. Константы индексов — CARDINAL, остальные константы —
    REAL).

            • Учесть перечисленные ограничения на идентификаторы и константы.
    • Сообщать об ошибках, когда число цифр в мантиссе более 15.       
    • Сообщать об ошибках при анализе, указывая курсором место ошибки и ее содержание.
    */


    public class Analizer
    {
        static char[] letter = "abcdefghijklmnopqrstuvwxyz_".ToCharArray();
        static char[] number0 = "1234567890".ToCharArray();
        static char[] number = "123456789".ToCharArray();
        static string[] keyWords = { "then", "else", "not", "and", "or", "if", "elsif", "end" };

        private enum State { S, IF1, IF2, SP1, SP2, SP3, SP4, SP5, SP6, SP7, SP8, SP9, SP10, ID1, ID11, ID12, ID13, ID14, ID15, ID16, ID17, ID18, N1, N11, N12, N13, ID2, ID21, ID22, ID23, ID24, ID25, ID26, ID27, N2, N21, N22, N23, ID3, ID31, ID32, ID33, ID34, ID35, ID36, ID37, N3, N31, N32, N33, ID4, ID41, ID42, ID43, ID44, ID45, ID46, ID47, N4, N41, N42, N43, ID5, ID51, ID52, ID53, ID54, ID55, ID56, ID57, ID6, ID61, ID62, ID63, ID64, ID65, ID66, ID67, ID28, ID38, ID48, ID58, ID68, R1, R2, R3, NT1, NT2, NT3, A1, A2, A3, OR1, OR2, T1, T2, T3, T4, E1, E2, E3, E4, ES, K1, K2, K3, K4, END1, END2, END3, F };
        public struct Q
        {
            public string type;
            public string name;
        }

        static int k = 0;
        static int i;
        static LinkedList<Q> ll = new LinkedList<Q>();
        static LinkedListNode<Q> q = new LinkedListNode<Q>(qq);
        static Q qq = new Q();

        public string[] Table
        {
            get
            {
                string[] s = new string[ll.Count+1];
                int v = 0;
                q = ll.First;
                while ((q = q.Next) != null)
                {
                    s[v] = q.Value.type;
                    s[v] += "  ";
                    s[v] += q.Value.name;
                    v++;
                }
                return s;
            }
        }
        
        public int GetLastPos()
        {
            return k;
        }

        public string Analize(string str)
        {
            i = 0;
            ll = new LinkedList<Q>();
            Q qq = new Q();
            qq.name = "";
            qq.type = "";
            q = new LinkedListNode<Q>(qq);


            ll.AddFirst(q);
            short t = 0;
           
            string name1 = "";
            string name2 = "";
            char sc = ' ';
            State sta = State.S;
            int len = str.Length;
            while ((sta != State.F) && (i < len))
            {
                sc = str[i];
                i++;
                k = i;
                switch (sta)
                {
                    case (State.S):
                        {
                            if (sc == 'i')
                                sta = State.IF1;
                            else
                                return "Ошибка: Цепочка должна начинаться с ключевого слова \"IF\"";
                        }
                        break;
                    case (State.IF1):
                        {
                            if (sc == 'f')
                                sta = State.IF2;
                            else
                                return "Ошибка: Цепочка должна начинаться с ключевого слова \"IF\"";
                        }
                        break;
                    case (State.IF2):
                        {
                            if (sc == ' ')
                                sta = State.SP1;
                            else
                                return "Ошибка: после ключевого слова \"IF\" ожидался пробел";
                        }
                        break;
                    case (State.SP1):
                        {
                            if (letter.Contains(sc))
                            {
                                name1 = sc.ToString();
                                sta = State.ID1;
                            }
                            else
                                if (number.Contains(sc))
                            {
                                sta = State.N1;
                                name1 = sc.ToString();
                            }
                            else
                                if (sc == '-')
                            {
                                sta = State.N12;
                                name1 = sc.ToString();
                            }
                            else
                                if (sc == '0')
                            {
                                sta = State.N11;
                                name1 = sc.ToString();
                            }
                            else
                                if (sc == ' ') ;
                            else
                                return "Ошибка: Идентификатор должен начинаться с буквы, либо символа нижнего подчёркивания, а число - с цифры, либо знака \'-\'";
                        }
                        break;
                    case (State.N1):
                        {
                            if (number0.Contains(sc))
                            {
                                name1 += sc.ToString();
                                if (!Int16.TryParse(name1, out t))
                                {
                                    return "Ошибка, число не в диапазоне [-32768..32767]";
                                }
                            }
                            else
                            if (sc == '.')
                            {
                                sta = State.N13;
                                name2 = sc.ToString();
                            }
                            else
                                if (sc == ' ')
                            {
                                sta = State.SP2;
                                qq.name = name1;
                                qq.type = "Real";
                                q = new LinkedListNode<Q>(qq);
                                 q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                            }
                            else
                                 if (sc == '&' || sc == '#' || sc == '~' || sc == '=')
                            {
                                qq.name = name1;
                                qq.type = "Real";
                                q = new LinkedListNode<Q>(qq);
                                 q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                sta = State.R3;
                            }
                            else
                                if (sc == '<')
                            {
                                qq.type = "Real";
                                qq.name = name1;
                                q = new LinkedListNode<Q>(qq);
                                 q = new LinkedListNode<Q>(qq);  q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                sta = State.R2;
                            }
                            else
                                if (sc == '>')
                            {
                                qq.type = "Real";
                                qq.name = name1;
                                q = new LinkedListNode<Q>(qq);
                                ll.AddFirst(q);
                                sta = State.R1;
                            }
                            else
                                return "Ошибка, ожидался THEN, либо сравнение";
                        }
                        break;
                    case (State.N11):
                        {
                            if (sc == '.')
                            {
                                sta = State.N13;
                                name2 = sc.ToString();
                            }
                            else
                                if (sc == ' ')
                            {
                                sta = State.SP2;
                                qq.name = name1;
                                qq.type = "Real";
                                 q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                            }
                            else
                                if (sc == '&' || sc == '#' || sc == '~' || sc == '=')
                            {
                                qq.type = "Real";
                                qq.name = name1;
                                 q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                sta = State.R3;
                            }
                            else
                                if (sc == '<')
                            {
                                qq.type = "Real";
                                qq.name = name1;
                                 q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                sta = State.R2;
                            }
                            else
                                if (sc == '>')
                            {
                                qq.type = "Real";
                                qq.name = name1 + name2;
                                 q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                sta = State.R1;
                            }
                            else
                                return "Ошибка, ожидался THEN, либо выражение";
                        }
                        break;
                    case (State.N12):
                        {
                            if (sc == '0')
                            {
                                name1 += sc;
                                sta = State.N11;
                            }
                            else
                                if (number.Contains(sc))
                            {
                                name1 += sc;
                                sta = State.N1;
                            }
                            else
                                return "Ошибка, ожидался THEN, либо выражение";
                        }
                        break;
                    case (State.N13):
                        {
                            if (number0.Contains(sc))
                            {
                                name2 += sc;
                                if (name2.Length > 15)
                                    return "Ошибка: должно быть не более 15 символов в мантисе";
                            }
                            else
                                if (sc == ' ')
                            {
                                qq.type = "Real";
                                qq.name = name1 + name2;
                                 q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                sta = State.SP2;
                            }
                            else
                                 if (sc == '&' || sc == '#' || sc == '~' || sc == '=')
                            {
                                qq.type = "Real";
                                qq.name = name1 + name2;
                                 q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                sta = State.R3;
                            }
                            else
                                if (sc == '<')
                            {
                                qq.type = "Real";
                                qq.name = name1 + name2;
                                 q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                sta = State.R2;
                            }
                            else
                                if (sc == '>')
                            {
                                qq.type = "Real";
                                qq.name = name1 + name2;
                                 q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                sta = State.R1;
                            }
                            else
                                return "Ошибка, ожидался THEN, либо выражение";
                        }
                        break;
                    case (State.ID1):
                        {
                            if (letter.Contains(sc) || number0.Contains(sc))
                            {
                                name1 += sc;
                                if (name1.Length > 8)
                                    return "Ошибка, имя идентификатора длиннее 8";
                            }
                            else
                                if (sc == ' ')
                            {
                                if (!keyWords.Contains(name1))
                                {
                                    qq.type = "id";
                                    qq.name = name1;
                                    q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.ID11;
                                }
                                else
                                    return "Ошибка, название переменной не может совпадать с ключевыми словами";
                            }
                            else
                                if (sc == '[')
                            {
                                qq.type = "id";
                                qq.name = name1;
                                q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                sta = State.ID12;
                            }
                            else
                                if (sc == '&' || sc == '#' || sc == '~' || sc == '=')
                            {
                                if (!keyWords.Contains(name1))
                                {
                                    qq.type = "id";
                                    qq.name = name1;
                                     q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.R3;
                                }
                                else
                                    return "Ошибка, название переменной не может совпадать с ключевыми словами";
                            }
                            else
                                if (sc == '<')
                            {
                                if (!keyWords.Contains(name1))
                                {
                                    qq.type = "id";
                                    qq.name = name1;
                                     q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.R2;
                                }
                                else
                                    return "Ошибка, название переменной не может совпадать с ключевыми словами";
                            }
                            else
                                if (sc == '>')
                            {
                                if (!keyWords.Contains(name1))
                                {
                                    qq.type = "id";
                                    qq.name = name1;
                                     q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.R1;
                                }
                                else
                                    return "Ошибка, название переменной не может совпадать с ключевыми словами";
                            }
                            else
                                return "Ошибка, недопустимый символ в Идентификаторе";
                        }
                        break;
                    case (State.ID11):
                        {
                            if (sc == ' ') ;
                            else
                                if (sc == '[')
                                sta = State.ID12;
                            else
                                if (sc == '&' || sc == '#' || sc == '~' || sc == '=')
                                sta = State.R3;
                            else
                                if (sc == '<')
                                sta = State.R2;
                            else
                                if (sc == '>')
                                sta = State.R1;
                            else
                                if (sc == 't')
                                sta = State.T1;
                            else
                                if (sc == 'a')
                                sta = State.A1;
                            else
                                if (sc == 'o')
                                sta = State.OR1;
                            else
                                return "Ошибка, ожидался пробел, либо '['";
                        }
                        break;
                    case (State.ID12):
                        {
                            if (sc == ' ') ;
                            else
                                if (sc == '0')
                            {
                                name2 = sc.ToString();
                                sta = State.ID15;
                            }
                            else
                            if (sc == '-')
                                {
                                name2 = sc.ToString();
                                sta = State.ID18;
                                }
                            else
                                if (letter.Contains(sc))
                            {
                                name2 = sc.ToString();
                                sta = State.ID13;
                            }
                            else
                                if (number.Contains(sc))
                            {
                                name2 = sc.ToString();
                                sta = State.ID14;
                            }
                            else
                                return "Ошибка, недопустимый символ в обозначении номера массива";
                        }
                        break;
                    case (State.ID13):
                        {
                            if (sc == ' ')
                            {
                                if (!keyWords.Contains(name2))
                                {
                                    qq.type = "id";
                                    qq.name = name2;
                                     q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.ID16;
                                }
                                else
                                    return "Ошибка, название переменной не может совпадать с ключевыми словами";
                            }
                            else
                                if (letter.Contains(sc) || number0.Contains(sc))
                            {
                                name2 += sc;
                                if (name2.Length > 8)
                                    return "Ошибка, имя идентификатора длиннее 8";
                            }
                            else
                                if (sc == ']')
                            {
                                if (!keyWords.Contains(name2))
                                {
                                    qq.type = "id";
                                    qq.name = name2;
                                     q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.ID17;
                                }
                                else
                                    return "Ошибка, название переменной не может совпадать с ключевыми словами";
                            }
                            else
                                return "Ошибка, неверный символ в обозначении номера массива";
                        }
                        break;
                    case (State.ID14):
                        {
                            if (sc == ' ')
                            {
                                if (Int16.TryParse(name2, out t))
                                {
                                    qq.type = "CARDINAL";
                                    qq.name = name2;
                                     q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.ID16;
                                }
                                else
                                    return "Ошибка, число не в диапазоне [-32768..32767]";
                            }
                            else
                                if (number0.Contains(sc))
                            {
                                name2 += sc;
                            }
                            else
                                if (sc == ']')
                            {
                                if (Int16.TryParse(name2, out t))
                                {
                                    qq.type = "CARDINAL";
                                    qq.name = name2;
                                     q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.ID17;
                                }
                                else
                                    return "Ошибка, число не в диапазоне [-32768..32767]";
                            }
                            else
                                return "Ошибка, ожидался пробел, цифра, либо закрывающая скобка";
                        }
                        break;
                    case (State.ID15):
                        {
                            if (sc == ' ')
                            {
                                qq.type = "CARDINAL";
                                qq.name = name2;
                                 q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                sta = State.ID16;
                            }
                            else
                                if (sc == ']')
                            {
                                qq.type = "CARDINAL";
                                qq.name = name2;
                                 q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                sta = State.ID17;
                            }
                            else
                                return "Ошибка, ожидался пробел, либо закрывающая скобка";
                        }
                        break;
                    case (State.ID16):
                        {
                            if (sc == ' ') ;
                            else
                                if (sc == ']')
                                    sta = State.ID17;
                            else
                                return "Ошибка, ожидался пробел, либо закрывающая скобка";
                        }
                        break;
                    case (State.ID17):
                        {
                            if (sc == ' ')
                                sta = State.SP2;
                            else
                                 if (sc == '&' || sc == '#' || sc == '~' || sc == '=')
                                sta = State.R3;
                            else
                                if (sc == '<')
                                sta = State.R2;
                            else
                                if (sc == '>')
                                sta = State.R1;
                            else
                                return "Ошибка, ожидался пробел, либо сравнение";
                        }
                        break;
                    case (State.ID18):
                        {
                            if (number.Contains(sc))
                            {
                                name2 += sc;
                                sta = State.ID14;
                            }
                            else
                                return "Ошибка, ожидалась цифра";
                        }
                        break;
                    case (State.SP2):
                        {
                            if (sc == 't')
                                sta = State.T1;
                            else
                                if (sc == 'A')
                                sta = State.A1;
                            else
                                if (sc == 'O')
                                sta = State.OR1;
                            else
                                if (sc == '&' || sc == '#' || sc == '~' || sc == '=')
                                sta = State.R3;
                            else
                                if (sc == '<')
                                sta = State.R2;
                            else
                                if (sc == '>')
                                sta = State.R1;
                            else
                                if (sc == ' ') ;
                            else
                                return "Ошибка, ожидался THEN, либо сравнение";
                        }
                        break;
                    case (State.A1):
                        {
                            if (sc == 'N')
                                sta = State.A2;
                        }
                        break;
                    case (State.A2):
                        {
                            if (sc == 'D')
                                sta = State.A3;
                        }
                        break;
                    case (State.A3):
                        {
                            if (sc == ' ')
                                sta = State.SP3;
                        }
                        break;
                    case (State.OR1):
                        {
                            if (sc == 'R')
                                sta = State.OR2;
                        }
                        break;
                    case (State.OR2):
                        {
                            if (sc == ' ')
                                sta = State.SP3;
                        }
                        break;
                    case (State.NT1):
                        {
                            if (sc == 'O')
                                sta = State.NT2;
                        }
                        break;
                    case (State.NT2):
                        {
                            if (sc == 't')
                                sta = State.NT3;
                        }
                        break;
                    case (State.NT3):
                        {
                            if (sc == ' ')
                                sta = State.SP3;
                        }
                        break;
                    case (State.R1):
                        {
                            if (sc == '=')
                                sta = State.R3;
                            else
                                if (sc == ' ')
                                sta = State.SP3;
                            else
                                 if (letter.Contains(sc))
                            {
                                name1 = sc.ToString();
                                sta = State.ID2;
                            }
                            else
                                if (number.Contains(sc))
                            {
                                sta = State.N2;
                                name1 = sc.ToString();
                            }
                            else
                                if (sc == '-')
                            {
                                sta = State.N22;
                                name1 = sc.ToString();
                            }
                            else
                                if (sc == '0')
                            {
                                sta = State.N21;
                                name1 = sc.ToString();
                            }
                            else
                                return "Ошибка, ожидалась буква, цифра, пробел, либо сравнение";
                        }
                        break;
                    case (State.R2):
                        {
                            if (sc == '=' || sc == '>')
                                sta = State.R3;
                            else
                                if (sc == ' ')
                                sta = State.SP3;
                            else
                                if (letter.Contains(sc))
                            {
                                name1 = sc.ToString();
                                sta = State.ID2;
                            }
                            else
                                if (number.Contains(sc))
                            {
                                sta = State.N2;
                                name1 = sc.ToString();
                            }
                            else
                                if (sc == '-')
                            {
                                sta = State.N22;
                                name1 = sc.ToString();
                            }
                            else
                                if (sc == '0')
                            {
                                sta = State.N21;
                                name1 = sc.ToString();
                            }
                            else
                                return "Ошибка, ожидалась буква, цифра, пробел, либо сравнение";
                        }
                        break;
                    case (State.R3):
                        {
                            if (sc == ' ')
                                sta = State.SP3;
                            else
                            if (letter.Contains(sc))
                            {
                                name1 = sc.ToString();
                                sta = State.ID2;
                            }
                            else
                                if (number.Contains(sc))
                            {
                                sta = State.N2;
                                name1 = sc.ToString();
                            }
                            else
                                if (sc == '-')
                            {
                                sta = State.N22;
                                name1 = sc.ToString();
                            }
                            else
                                if (sc == '0')
                            {
                                sta = State.N21;
                                name1 = sc.ToString();
                            }
                            else
                                return "Ошибка, ожидался пробел, буква, либо цифра";
                        }
                        break;
                    case (State.SP3):
                        {
                            if (letter.Contains(sc))
                            {
                                name1 = sc.ToString();
                                sta = State.ID2;
                            }
                            else
                                if (number.Contains(sc))
                            {
                                sta = State.N2;
                                name1 = sc.ToString();
                            }
                            else
                                if (sc == '-')
                            {
                                sta = State.N22;
                                name1 = sc.ToString();
                            }
                            else
                                if (sc == '0')
                            {
                                sta = State.N21;
                                name1 = sc.ToString();
                            }
                            else
                                if (sc == ' ') ;
                            else
                                return "Ошибка, Идентификатор должен начинаться с буквы, либо символа нижнего подчёркивания, а число - с цифры, либо знака \'-\'";
                        }
                        break;
                    case (State.ID2):
                        {
                            if (letter.Contains(sc) || number0.Contains(sc))
                            {
                                name1 += sc;
                                if (name1.Length > 8)
                                    return "Ошибка, имя идентификатора длиннее 8";
                            }
                            else
                                if (sc == ' ')
                            {
                                if (!keyWords.Contains(name1))
                                {
                                    qq.type = "id";
                                    qq.name = name1;
                                     q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.ID21;
                                }
                                else
                                    return "Ошибка, название переменной не может совпадать с ключевыми словами";
                            }
                            else
                                if (sc == '[')
                            {
                                qq.type = "id";
                                qq.name = name1;
                                q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                sta = State.ID22;
                            }
                            else
                                return "Ошибка, недопустимый символ в Идентификаторе";
                        }
                        break;
                    case (State.ID21):
                        {
                            if (sc == ' ') ;
                            else
                                if (sc == '[')
                                sta = State.ID22;
                            else
                            if (sc == 't')
                                sta = State.T1;
                            else
                                return "Ошибка, ожидался пробел, либо '['";
                        }
                        break;
                    case (State.ID22):
                        {
                            if (sc == ' ') ;
                            else
                                if (sc == '0')
                            {
                                name2 = sc.ToString();
                                sta = State.ID25;
                            }
                            else
                            if (sc == '-')
                            {
                                name2 = sc.ToString();
                                sta = State.ID28;
                            }
                            else
                                if (letter.Contains(sc))
                            {
                                name2 = sc.ToString();
                                sta = State.ID23;
                            }
                            else
                                if (number.Contains(sc))
                            {
                                name2 = sc.ToString();
                                sta = State.ID24;
                            }
                            else
                                return "Ошибка, недопустимый символ в обозначении номера массива";
                        }
                        break;
                    case (State.ID23):
                        {
                            if (sc == ' ')
                            {
                                if (!keyWords.Contains(name2))
                                {
                                    qq.type = "id";
                                    qq.name = name2;
                                     q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.ID26;
                                }
                                else
                                    return "Ошибка, название переменной не может совпадать с ключевыми словами";
                            }
                            else
                                if (letter.Contains(sc) || number0.Contains(sc))
                            {
                                name2 += sc;
                                if (name2.Length > 8)
                                    return "Ошибка, имя идентификатора длиннее 8";
                            }
                            else
                                if (sc == ']')
                            {
                                if (!keyWords.Contains(name2))
                                {
                                    qq.type = "id";
                                    qq.name = name2;
                                     q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.ID27;
                                }
                                else
                                    return "Ошибка, название переменной не может совпадать с ключевыми словами";
                            }
                            else
                                return "Ошибка, неверный символ в обозначении номера массива";
                        }
                        break;
                    case (State.ID24):
                        {
                            if (sc == ' ')
                            {
                                if (Int16.TryParse(name2, out t))
                                {
                                    qq.type = "CARDINAL";
                                    qq.name = name2;
                                     q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.ID26;
                                }
                                else
                                    return "Ошибка, число не в диапазоне [-32768..32767]";
                            }
                            else
                                if (number0.Contains(sc))
                            {
                                name2 += sc;
                            }
                            else
                                if (sc == ']')
                            {
                                if (Int16.TryParse(name2, out t))
                                {
                                    qq.type = "CARDINAL";
                                    qq.name = name2;
                                     q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.ID27;
                                }
                                else
                                    return "Ошибка, число не в диапазоне [-32768..32767]";
                            }
                            else
                                return "Ошибка, ожидался пробел, цифра, либо закрывающая скобка";
                        }
                        break;
                    case (State.ID25):
                        {
                            if (sc == ' ')
                            {
                                qq.type = "CARDINAL";
                                qq.name = name2;
                                 q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                sta = State.ID26;
                            }
                            else
                                if (sc == ']')
                            {
                                qq.type = "CARDINAL";
                                qq.name = name2;
                                 q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                sta = State.ID27;
                            }
                            else
                                return "Ошибка, ожидался пробел, либо закрывающая скобка";
                        }
                        break;
                    case (State.ID26):
                        {
                            if (sc == ' ') ;
                            else
                                if (sc == ']')
                                sta = State.ID27;
                            else
                                return "Ошибка, ожидался пробел, либо закрывающая скобка";
                        }
                        break;
                    case (State.ID27):
                        {
                            if (sc == ' ')
                                sta = State.SP4;
                            else
                                return "Ошибка, ожидался пробел";
                        }
                        break;
                    case (State.ID28):
                        {
                            if (number.Contains(sc))
                            {
                                name2 += sc;
                                sta = State.ID24;
                            }
                            else
                                return "Ошибка, ожидалась цифра";
                        }
                        break;
                    case (State.N2):
                        {
                            if (number0.Contains(sc))
                            {
                                name1 += sc.ToString();
                                if (!Int16.TryParse(name1, out t))
                                {
                                    return "Ошибка, число не в диапазоне [-32768..32767]";
                                }
                            }
                            else
                            if (sc == '.')
                            {
                                sta = State.N23;
                                name2 = sc.ToString();
                            }
                            else
                                if (sc == ' ')
                            {
                                sta = State.SP4;
                                qq.name = name1;
                                qq.type = "Real";
                                 q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                            }
                            else
                                return "Ошибка, ожидался пробел, либо запятая";
                        }
                        break;
                    case (State.N21):
                        {
                            if (sc == '.')
                            {
                                sta = State.N23;
                                name2 = sc.ToString();
                            }
                            else
                                if (sc == ' ')
                            {
                                sta = State.SP4;
                                qq.name = name1;
                                qq.type = "Real";
                                 q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                            }
                            else
                                return "Ошибка, ожидался пробел, либо запятая";
                        }
                        break;
                    case (State.N22):
                        {
                            if (sc == '0')
                            {
                                name1 += sc;
                                sta = State.N21;
                            }
                            else
                                if (number.Contains(sc))
                            {
                                name1 += sc;
                                sta = State.N2;
                            }
                            else
                                return "Ошибка, ожидался 0, либо цифра";
                        }
                        break;
                    case (State.N23):
                        {
                            if (number0.Contains(sc))
                            {
                                name2 += sc;
                                if (name2.Length > 15)
                                    return "Ошибка: должно быть не более 15 символов в мантисе";
                            }
                            else
                                if (sc == ' ')
                            {
                                qq.type = "Real";
                                qq.name = name1 + name2;
                                 q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                sta = State.SP4;
                            }
                            else
                                return "Ошибка, ожидался пробел, либо цифра";
                        }
                        break;
                    case (State.SP4):
                        {
                            if (sc == ' ') ;
                            else
                            if (sc == 't')
                                sta = State.T1;
                            else
                                return "Ошибка, ожидался THEN";
                        }
                        break;
                    case (State.T1):
                        {
                            if (sc == 'h')
                                sta = State.T2;
                            else
                                return "Ошибка, ожидался THEN";
                        }
                        break;
                    case (State.T2):
                        {
                            if (sc == 'e')
                                sta = State.T3;
                            else
                                return "Ошибка, ожидался THEN";
                        }
                        break;
                    case (State.T3):
                        {
                            if (sc == 'n')
                                sta = State.T4;
                            else
                                return "Ошибка, ожидался THEN";
                        }
                        break;
                    case (State.T4):
                        {
                            if (sc == ' ')
                                sta = State.SP5;
                            else
                                return "Ошибка, ожидался пробел после THEN";
                        }
                        break;
                    case (State.SP5):
                        {
                            if (sc == ' ') ;
                            else
                                 if (letter.Contains(sc))
                                {
                                name1 = sc.ToString();
                                sta = State.ID3;
                            }
                            else
                                return "Ошибка, ожидался идентификатор";

                        }
                        break;
                    case (State.ID3):
                        {
                            if (letter.Contains(sc) || number0.Contains(sc))
                            {
                                name1 += sc;
                                if (name1.Length > 8)
                                    return "Ошибка, имя идентификатора длиннее 8";
                            }
                            else
                                if (sc == ' ')
                                /*    {
                                        if (!keyWords.Contains(name1))
                                        {
                                            qq.type = "id";
                                            qq.name = name1;
                                             q = new LinkedListNode<Q>(qq);
                                            ll.AddLast(q);

                                        }
                                        else
                                            return "Ошибка, название переменной не может совпадать с ключевыми словами";
                                            }*/
                                sta = State.ID31;

                            else
                                if (sc == '[')
                            {
                                qq.type = "id";
                                qq.name = name1;
                                q = new LinkedListNode<Q>(qq);
                                ll.AddLast(q);
                                sta = State.ID32;
                            }
                            else
                                if (sc == ':')
                            {
                                if (!keyWords.Contains(name1))
                                {
                                    qq.type = "id";
                                    qq.name = name1;
                                    q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.K1;
                                }
                                else
                                    return "Ошибка, название переменной не может совпадать с ключевыми словами";
                            }
                            else
                                return "Ошибка, недопустимый символ в Идентификаторе";
                        }
                        break;
                    case (State.ID31):
                        {
                            if (sc == ' ') ;
                            else
                                if (sc == '[')
                                sta = State.ID32;
                            else
                                 if (sc == ':')
                            {
                                if (!keyWords.Contains(name1))
                                {
                                    qq.type = "id";
                                    qq.name = name1;
                                     q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.K1;
                                }
                                else
                                    return "Ошибка, название переменной не может совпадать с ключевыми словами";
                            }
                            else
                            return "Ошибка, ожидался пробел, либо '['";
                        }
                        break;
                    case (State.ID32):
                        {
                            if (sc == ' ') ;
                            else
                                if (sc == '0')
                            {
                                name2 = sc.ToString();
                                sta = State.ID35;
                            }
                            else
                            if (sc == '-')
                            {
                                name2 = sc.ToString();
                                sta = State.ID38;
                            }
                            else
                                if (letter.Contains(sc))
                            {
                                name2 = sc.ToString();
                                sta = State.ID33;
                            }
                            else
                                if (number.Contains(sc))
                            {
                                name2 = sc.ToString();
                                sta = State.ID34;
                            }
                            else
                                return "Ошибка, недопустимый символ в обозначении номера массива";
                        }
                        break;
                    case (State.ID33):
                        {
                            if (sc == ' ')
                            {
                                if (!keyWords.Contains(name2))
                                {
                                    qq.type = "id";
                                    qq.name = name2;
                                     q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.ID36;
                                }
                                else
                                    return "Ошибка, название переменной не может совпадать с ключевыми словами";
                            }
                            else
                                if (letter.Contains(sc) || number0.Contains(sc))
                            {
                                name2 += sc;
                                if (name2.Length > 8)
                                    return "Ошибка, имя идентификатора длиннее 8";
                            }
                            else
                                if (sc == ']')
                            {
                                if (!keyWords.Contains(name2))
                                {
                                    qq.type = "id";
                                    qq.name = name2;
                                     q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.ID37;
                                }
                                else
                                    return "Ошибка, название переменной не может совпадать с ключевыми словами";
                            }
                            else
                                return "Ошибка, неверный символ в обозначении номера массива";
                        }
                        break;
                    case (State.ID34):
                        {
                            if (sc == ' ')
                            {
                                if (Int16.TryParse(name2, out t))
                                {
                                    qq.type = "CARDINAL";
                                    qq.name = name2;
                                     q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.ID36;
                                }
                                else
                                    return "Ошибка, число не в диапазоне [-32768..32767]";
                            }
                            else
                                if (number0.Contains(sc))
                            {
                                name2 += sc;
                            }
                            else
                                if (sc == ']')
                            {
                                
                                if (Int16.TryParse(name2, out t))
                                {
                                    qq.type = "CARDINAL";
                                    qq.name = name2;
                                     q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.ID37;
                                }
                                else
                                    return "Ошибка, число не в диапазоне [-32768..32767]";
                            }
                            else
                                return "Ошибка, ожидался пробел, цифра, либо закрывающая скобка";
                        }
                        break;
                    case (State.ID35):
                        {
                            if (sc == ' ')
                            {
                                qq.type = "CARDINAL";
                                qq.name = name2;
                                 q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                sta = State.ID36;
                            }
                            else
                                if (sc == ']')
                            {
                                qq.type = "CARDINAL";
                                qq.name = name2;
                                 q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                sta = State.ID37;
                            }
                            else
                                return "Ошибка, ожидался пробел, либо закрывающая скобка";
                        }
                        break;
                    case (State.ID36):
                        {
                            if (sc == ' ') ;
                            else
                                if (sc == ']')
                                sta = State.ID37;
                            else
                                return "Ошибка, ожидался пробел, либо закрывающая скобка";
                        }
                        break;
                    case (State.ID37):
                        {
                            if (sc == ' ')
                                sta = State.SP6;
                            else
                                if (sc == ':')
                                sta = State.K1;
                            else
                                return "Ошибка, ожидался пробел";
                        }
                        break;
                    case (State.ID38):
                        {
                            if (number.Contains(sc))
                            {
                                name2 += sc;
                                sta = State.ID34;
                            }
                            else
                                return "Ошибка, ожидалась цифра";
                        }
                        break;
                    case (State.SP6):
                        {
                            if (sc == ' ') ;
                            else
                                if (sc == ':')
                                sta = State.K1;
                            else
                                return "Ошибка, ожидалось присвоение";
                        }
                        break;
                    case (State.K1):
                        {
                            if (sc == '=')
                                sta = State.K2;
                            else
                                return "Ошибка, ожидалось присвоение";
                        }
                        break;
                    case (State.K2):
                        {
                            if (letter.Contains(sc))
                            {
                                name1 = sc.ToString();
                                sta = State.ID4;
                            }
                            else
                                 if (number.Contains(sc))
                            {
                                sta = State.N3;
                                name1 = sc.ToString();
                            }
                            else
                                 if (sc == '-')
                            {
                                sta = State.N32;
                                name1 = sc.ToString();
                            }
                            else
                                 if (sc == '0')
                            {
                                sta = State.N31;
                                name1 = sc.ToString();
                            }
                            else
                                 if (sc == ' ') ;
                            else
                                return "Ошибка: Идентификатор должен начинаться с буквы, либо символа нижнего подчёркивания, а число - с цифры, либо знака \'-\'";
                        }
                        break;
                    case (State.ID4):
                        {
                            if (letter.Contains(sc) || number0.Contains(sc))
                            {
                                name1 += sc;
                                if (name1.Length > 8)
                                    return "Ошибка, имя идентификатора длиннее 8";
                            }
                            else
                                if (sc == ' ')
                            {
                                if (!keyWords.Contains(name1))
                                    /* {
                                         qq.type = "id";
                                         qq.name = name1;
                                          q = new LinkedListNode<Q>(qq); ll.AddLast(q);

                                     }*/
                                    sta = State.ID41;
                                else
                                    return "Ошибка, название переменной не может совпадать с ключевыми словами";
                            }
                            else
                                if (sc == '[')
                            {
                                qq.type = "id";
                                qq.name = name1;
                                q = new LinkedListNode<Q>(qq);
                                ll.AddLast(q);
                                sta = State.ID42;
                            }
                            else
                                return "Ошибка, недопустимый символ в Идентификаторе";
                        }
                        break;
                    case (State.ID41):
                        {
                            if (sc == ' ') ;
                            else
                                if (sc == '[')
                                sta = State.ID42;
                            else
                                 if (sc == 'e')
                            {
                                if (!keyWords.Contains(name1))
                                {
                                    qq.type = "id";
                                    qq.name = name1;
                                     q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.E1;
                                }
                                else
                                    return "Ошибка, название переменной не может совпадать с ключевыми словами";
                            }
                            else
                                return "Ошибка, ожидался пробел, либо '['";
                        }
                        break;
                    case (State.ID42):
                        {
                            if (sc == ' ') ;
                            else
                                if (sc == '0')
                            {
                                name2 = sc.ToString();
                                sta = State.ID45;
                            }
                            else
                            if (sc == '-')
                            {
                                name2 = sc.ToString();
                                sta = State.ID48;
                            }
                            else
                                if (letter.Contains(sc))
                            {
                                name2 = sc.ToString();
                                sta = State.ID43;
                            }
                            else
                                if (number.Contains(sc))
                            {
                                name2 = sc.ToString();
                                sta = State.ID44;
                            }
                            else
                                return "Ошибка, недопустимый символ в обозначении номера массива";
                        }
                        break;
                    case (State.ID43):
                        {
                            if (sc == ' ')
                            {
                                if (!keyWords.Contains(name2))
                                {
                                    qq.type = "id";
                                    qq.name = name2;
                                     q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.ID46;
                                }
                                else
                                    return "Ошибка, название переменной не может совпадать с ключевыми словами";
                            }
                            else
                                if (letter.Contains(sc) || number0.Contains(sc))
                            {
                                name2 += sc;
                                if (name2.Length > 8)
                                    return "Ошибка, имя идентификатора длиннее 8";
                            }
                            else
                                if (sc == ']')
                            {
                                if (!keyWords.Contains(name2))
                                {
                                    qq.type = "id";
                                    qq.name = name2;
                                     q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.ID47;
                                }
                                else
                                    return "Ошибка, название переменной не может совпадать с ключевыми словами";
                            }
                            else
                                return "Ошибка, неверный символ в обозначении номера массива";
                        }
                        break;
                    case (State.ID44):
                        {
                            if (sc == ' ')
                            {
                                
                                if (Int16.TryParse(name2, out t))
                                {
                                    qq.type = "CARDINAL";
                                    qq.name = name2;
                                     q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.ID46;
                                }
                                else
                                    return "Ошибка, число не в диапазоне [-32768..32767]";
                            }
                            else
                                if (number0.Contains(sc))
                            {
                                name2 += sc;
                            }
                            else
                                if (sc == ']')
                            {
                                
                                if (Int16.TryParse(name2, out t))
                                {
                                    qq.type = "CARDINAL";
                                    qq.name = name2;
                                     q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.ID47;
                                }
                                else
                                    return "Ошибка, число не в диапазоне [-32768..32767]";
                            }
                            else
                                return "Ошибка, ожидался пробел, цифра, либо закрывающая скобка";
                        }
                        break;
                    case (State.ID45):
                        {
                            if (sc == ' ')
                            {
                                qq.type = "CARDINAL";
                                qq.name = name2;
                                 q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                sta = State.ID46;
                            }
                            else
                                if (sc == ']')
                            {
                                qq.type = "CARDINAL";
                                qq.name = name2;
                                 q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                sta = State.ID47;
                            }
                            else
                                return "Ошибка, ожидался пробел, либо закрывающая скобка";
                        }
                        break;
                    case (State.ID46):
                        {
                            if (sc == ' ') ;
                            else
                                if (sc == ']')
                                sta = State.ID47;
                            else
                                return "Ошибка, ожидался пробел, либо закрывающая скобка";
                        }
                        break;
                    case (State.ID47):
                        {
                            if (sc == ' ')
                                sta = State.SP7;
                            else
                                return "Ошибка, ожидался пробел";
                        }
                        break;
                    case (State.ID48):
                        {
                            if (number.Contains(sc))
                            {
                                name2 += sc;
                                sta = State.ID44;
                            }
                            else
                                return "Ошибка, ожидалась цифра";
                        }
                        break;
                    case (State.N3):
                        {
                            if (number0.Contains(sc))
                            {
                                name1 += sc.ToString();
                                if (!Int16.TryParse(name1, out t))
                                {
                                    return "Ошибка, число не в диапазоне [-32768..32767]";
                                }
                            }
                            else
                            if (sc == '.')
                            {
                                sta = State.N33;
                                name2 = sc.ToString();
                            }
                            else
                                if (sc == ' ')
                            {
                                sta = State.SP7;
                                qq.name = name1;
                                qq.type = "Real";
                                 q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                            }
                            else
                                return "Ошибка, ожидался THEN, либо сравнение";
                        }
                        break;
                    case (State.N31):
                        {
                            if (sc == '.')
                            {
                                sta = State.N33;
                                name2 = sc.ToString();
                            }
                            else
                                if (sc == ' ')
                            {
                                sta = State.SP7;
                                qq.name = name1;
                                qq.type = "Real";
                                 q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                            }
                            else
                                return "Ошибка, ожидался THEN, либо выражение";
                        }
                        break;
                    case (State.N32):
                        {
                            if (sc == '0')
                            {
                                name1 += sc;
                                sta = State.N31;
                            }
                            else
                                if (number.Contains(sc))
                            {
                                name1 += sc;
                                sta = State.N3;
                            }
                            else
                                return "Ошибка, ожидался THEN, либо выражение";
                        }
                        break;
                    case (State.N33):
                        {
                            if (number0.Contains(sc))
                            {
                                name2 += sc;
                                if (name2.Length > 15)
                                    return "Ошибка: должно быть не более 15 символов в мантисе";
                            }
                            else
                                if (sc == ' ')
                            {
                                qq.type = "Real";
                                qq.name = name1 + name2;
                                 q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                sta = State.SP7;
                            }
                            else
                                return "Ошибка, ожидался THEN, либо выражение";
                        }
                        break;
                    case (State.SP7):
                        {
                            if (sc == ' ') ;
                            else
                                if (sc == 'e')
                                sta = State.E1;
                            else
                                return "Ошибка, ожидался else";
                        }
                        break;
                    case (State.E1):
                        {
                            if (sc == 'n')
                                sta = State.END2;
                            else
                                if (sc == 'l')
                                sta = State.E2;
                            else
                                return "Ошибка, ожидался else, end, либо elsif";
                        }
                        break;
                    case (State.E2):
                        {
                            if (sc == 's')
                                sta = State.E3;
                            else
                                return "Ошибка, ожидался else, end, либо elsif";
                        }
                        break;
                    case (State.E3):
                        {
                            if (sc == 'e')
                                sta = State.E4;
                            else
                                if (sc == 'i')
                                sta = State.IF1;
                            else
                                return "Ошибка, ожидался else, end, либо elsif";
                        }
                        break;
                    case (State.E4):
                        {
                            if (sc == ' ')
                                sta = State.SP8;
                            else
                                return "Ошибка, ожидался пробел";
                        }
                        break;
                    case (State.SP8):
                        {
                            {
                                if (sc == ' ') ;
                                else
                                     if (letter.Contains(sc))
                                {
                                    name1 = sc.ToString();
                                    sta = State.ID5;
                                }
                                else
                                    return "Ошибка, ожидался идентификатор";
                            }
                        }
                        break;
                    case (State.ID5):
                        {
                            if (letter.Contains(sc) || number0.Contains(sc))
                            {
                                name1 += sc;
                                if (name1.Length > 8)
                                    return "Ошибка, имя идентификатора длиннее 8";
                            }
                            else
                                if (sc == ' ')
                                sta = State.ID51;
                            /* {
                                 if (!keyWords.Contains(name1))
                                 {
                                     qq.type = "id";
                                     qq.name = name1;
                                      q = new LinkedListNode<Q>(qq); ll.AddLast(q);

                                 }

                                 else
                                     return "Ошибка, название переменной не может совпадать с ключевыми словами";
                             }*/
                            else
                                if (sc == '[')
                            {
                                qq.type = "id";
                                qq.name = name1;
                                q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                sta = State.ID52;
                            }
                            else
                                if (sc == ':')
                            {
                                if (!keyWords.Contains(name1))
                                {
                                    qq.type = "id";
                                    qq.name = name1;
                                    q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.K3;
                                }
                                else
                                    return "Ошибка, название переменной не может совпадать с ключевыми словами";
                            }
                            else
                                return "Ошибка, недопустимый символ в Идентификаторе";
                        }
                        break;
                    case (State.ID51):
                        {
                            if (sc == ' ') ;
                            else
                                if (sc == '[')
                            {
                                qq.type = "id";
                                qq.name = name1;
                                q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                sta = State.ID52;
                            }
                            else
                                 if (sc == ':')
                            {
                                if (!keyWords.Contains(name1))
                                {
                                    qq.type = "id";
                                    qq.name = name1;
                                    q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.K3;
                                }
                                else
                                    return "Ошибка, название переменной не может совпадать с ключевыми словами";
                            }
                            else
                                return "Ошибка, ожидался пробел, либо '['";
                        }
                        break;
                    case (State.ID52):
                        {
                            if (sc == ' ') ;
                            else
                                if (sc == '0')
                            {
                                name2 = sc.ToString();
                                sta = State.ID55;
                            }
                            else
                            if (sc == '-')
                            {
                                name2 = sc.ToString();
                                sta = State.ID58;
                            }
                            else
                                if (letter.Contains(sc))
                            {
                                name2 = sc.ToString();
                                sta = State.ID53;
                            }
                            else
                                if (number.Contains(sc))
                            {
                                name2 = sc.ToString();
                                sta = State.ID54;
                            }
                            else
                                return "Ошибка, недопустимый символ в обозначении номера массива";
                        }
                        break;
                    case (State.ID53):
                        {
                            if (sc == ' ')
                            {
                                if (!keyWords.Contains(name2))
                                {
                                    qq.type = "id";
                                    qq.name = name2;
                                     q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.ID56;
                                }
                                else
                                    return "Ошибка, название переменной не может совпадать с ключевыми словами";
                            }
                            else
                                if (letter.Contains(sc) || number0.Contains(sc))
                            {
                                name2 += sc;
                                if (name2.Length > 8)
                                    return "Ошибка, имя идентификатора длиннее 8";
                            }
                            else
                                if (sc == ']')
                            {
                                if (!keyWords.Contains(name2))
                                {
                                    qq.type = "id";
                                    qq.name = name2;
                                     q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.ID57;
                                }
                                else
                                    return "Ошибка, название переменной не может совпадать с ключевыми словами";
                            }
                            else
                                return "Ошибка, неверный символ в обозначении номера массива";
                        }
                        break;
                    case (State.ID54):
                        {
                            if (sc == ' ')
                            {
                                if (Int16.TryParse(name2, out t))
                                {
                                    qq.type = "CARDINAL";
                                    qq.name = name2;
                                     q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.ID56;
                                }
                                else
                                    return "Ошибка, число не в диапазоне [-32768..32767]";
                            }
                            else
                                if (number0.Contains(sc))
                            {
                                name2 += sc;
                            }
                            else
                                if (sc == ']')
                            {
                                
                                if (Int16.TryParse(name2, out t))
                                {
                                    qq.type = "CARDINAL";
                                    qq.name = name2;
                                     q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.ID57;
                                }
                                else
                                    return "Ошибка, число не в диапазоне [-32768..32767]";
                            }
                            else
                                return "Ошибка, ожидался пробел, цифра, либо закрывающая скобка";
                        }
                        break;
                    case (State.ID55):
                        {
                            if (sc == ' ')
                            {
                                qq.type = "CARDINAL";
                                qq.name = name2;
                                 q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                sta = State.ID56;
                            }
                            else
                                if (sc == ']')
                            {
                                qq.type = "CARDINAL";
                                qq.name = name2;
                                 q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                sta = State.ID57;
                            }
                            else
                                return "Ошибка, ожидался пробел, либо закрывающая скобка";
                        }
                        break;
                    case (State.ID56):
                        {
                            if (sc == ' ') ;
                            else
                                if (sc == ']')
                                sta = State.ID57;
                            else
                                return "Ошибка, ожидался пробел, либо закрывающая скобка";
                        }
                        break;
                    case (State.ID57):
                        {
                            if (sc == ' ')
                                sta = State.SP9;
                            else
                                if (sc == ':')
                                sta = State.K3;
                            else
                                return "Ошибка, ожидался пробел";
                        }
                        break;
                    case (State.ID58):
                        {
                            if (number.Contains(sc))
                            {
                                name2 += sc;
                                sta = State.ID54;
                            }
                            else
                                return "Ошибка, ожидалась цифра";
                        }
                        break;
                    case (State.SP9):
                        {
                            if (sc == ' ') ;
                            else
                                if (sc == ':')
                                sta = State.K3;
                            else
                                return "Ошибка, ожидалось присвоение";
                        }
                        break;
                    case (State.K3):
                        {
                            if (sc == '=')
                                sta = State.K4;
                            else
                                return "Ошибка, ожидалдось присвоение";
                        }
                        break;
                    case (State.K4):
                        {
                            if (letter.Contains(sc))
                            {
                                name1 = sc.ToString();
                                sta = State.ID6;
                            }
                            else
                                 if (number.Contains(sc))
                            {
                                sta = State.N4;
                                name1 = sc.ToString();
                            }
                            else
                                 if (sc == '-')
                            {
                                sta = State.N42;
                                name1 = sc.ToString();
                            }
                            else
                                 if (sc == '0')
                            {
                                sta = State.N41;
                                name1 = sc.ToString();
                            }
                            else
                                 if (sc == ' ') ;
                            else
                                return "Ошибка: Идентификатор должен начинаться с буквы, либо символа нижнего подчёркивания, а число - с цифры, либо знака \'-\'";
                        }
                        break;
                    case (State.ID6):
                        {
                            if (letter.Contains(sc) || number0.Contains(sc))
                            {
                                name1 += sc;
                                if (name1.Length > 8)
                                    return "Ошибка, имя идентификатора длиннее 8";
                            }
                            else
                                if (sc == ' ')
                                sta = State.ID61;
                          /*  {
                                if (!keyWords.Contains(name1))
                                {
                                    qq.type = "id";
                                    qq.name = name1;
                                    q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    
                                }
                                else
                                    return "Ошибка, название переменной не может совпадать с ключевыми словами";
                            }*/
                            else
                                if (sc == '[')
                            {
                                qq.type = "id";
                                qq.name = name1;
                                q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                sta = State.ID62;
                            }
                            else
                                return "Ошибка, недопустимый символ в Идентификаторе";
                        }
                        break;
                    case (State.ID61):
                        {
                            if (sc == ' ') ;
                            else
                                if (sc == '[')
                            {
                                qq.type = "id";
                                qq.name = name1;
                                q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                sta = State.ID62;
                            }
                            else
                                 if (sc == 'e')
                            {
                                if (!keyWords.Contains(name1))
                                {
                                    qq.type = "id";
                                    qq.name = name1;
                                    q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.END1;
                                }
                                else
                                    return "Ошибка, название переменной не может совпадать с ключевыми словами";
                            }
                            else
                                return "Ошибка, ожидался пробел, либо '['";
                        }
                        break;
                    case (State.ID62):
                        {
                            if (sc == ' ') ;
                            else
                                if (sc == '0')
                            {
                                name2 = sc.ToString();
                                sta = State.ID65;
                            }
                            else
                            if (sc == '-')
                            {
                                name2 = sc.ToString();
                                sta = State.ID68;
                            }
                            else
                                if (letter.Contains(sc))
                            {
                                name2 = sc.ToString();
                                sta = State.ID63;
                            }
                            else
                                if (number.Contains(sc))
                            {
                                name2 = sc.ToString();
                                sta = State.ID64;
                            }
                            else
                                return "Ошибка, недопустимый символ в обозначении номера массива";
                        }
                        break;
                    case (State.ID63):
                        {
                            if (sc == ' ')
                            {
                                if (!keyWords.Contains(name2))
                                {
                                    qq.type = "id";
                                    qq.name = name2;
                                     q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.ID66;
                                }
                                else
                                    return "Ошибка, название переменной не может совпадать с ключевыми словами";
                            }
                            else
                                if (letter.Contains(sc) || number0.Contains(sc))
                            {
                                name2 += sc;
                                if (name2.Length > 8)
                                    return "Ошибка, имя идентификатора длиннее 8";
                            }
                            else
                                if (sc == ']')
                            {
                                if (!keyWords.Contains(name2))
                                {
                                    qq.type = "id";
                                    qq.name = name2;
                                     q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.ID67;
                                }
                                else
                                    return "Ошибка, название переменной не может совпадать с ключевыми словами";
                            }
                            else
                                return "Ошибка, неверный символ в обозначении номера массива";
                        }
                        break;
                    case (State.ID64):
                        {
                            if (sc == ' ')
                            {
                                
                                if (Int16.TryParse(name2, out t))
                                {
                                    qq.type = "CARDINAL";
                                    qq.name = name2;
                                     q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.ID66;
                                }
                                else
                                    return "Ошибка, число не в диапазоне [-32768..32767]";
                            }
                            else
                                if (number0.Contains(sc))
                            {
                                name2 += sc;
                            }
                            else
                                if (sc == ']')
                            {
                                if (Int16.TryParse(name2, out t))
                                {
                                    qq.type = "CARDINAL";
                                    qq.name = name2;
                                     q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                    sta = State.ID67;
                                }
                                else
                                    return "Ошибка, число не в диапазоне [-32768..32767]";
                            }
                            else
                                return "Ошибка, ожидался пробел, цифра, либо закрывающая скобка";
                        }
                        break;
                    case (State.ID65):
                        {
                            if (sc == ' ')
                            {
                                qq.type = "CARDINAL";
                                qq.name = name2;
                                 q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                sta = State.ID66;
                            }
                            else
                                if (sc == ']')
                            {
                                qq.type = "CARDINAL";
                                qq.name = name2;
                                 q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                sta = State.ID67;
                            }
                            else
                                return "Ошибка, ожидался пробел, либо закрывающая скобка";
                        }
                        break;
                    case (State.ID66):
                        {
                            if (sc == ' ') ;
                            else
                                if (sc == ']')
                                sta = State.ID67;
                            else
                                return "Ошибка, ожидался пробел, либо закрывающая скобка";
                        }
                        break;
                    case (State.ID67):
                        {
                            if (sc == ' ')
                                sta = State.SP10;
                            else
                                return "Ошибка, ожидался пробел";
                        }
                        break;
                    case (State.ID68):
                        {
                            if (number.Contains(sc))
                            {
                                name2 += sc;
                                sta = State.ID64;
                            }
                            else
                                return "Ошибка, ожидалась цифра";
                        }
                        break;
                    case (State.N4):
                        {
                            if (number0.Contains(sc))
                            {
                                name1 += sc.ToString();
                                
                                if (!Int16.TryParse(name1, out t))
                                {
                                    return "Ошибка, число не в диапазоне [-32768..32767]";
                                }
                            }
                            else
                            if (sc == '.')
                            {
                                sta = State.N43;
                                name2 = sc.ToString();
                            }
                            else
                                if (sc == ' ')
                            {
                                sta = State.SP10;
                                qq.name = name1;
                                qq.type = "Real";
                                 q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                            }
                            else
                                return "Ошибка, ожидался пробел, либо запятая";
                        }
                        break;
                    case (State.N41):
                        {
                            if (sc == '.')
                            {
                                sta = State.N43;
                                name2 = sc.ToString();
                            }
                            else
                                if (sc == ' ')
                            {
                                sta = State.SP10;
                                qq.name = name1;
                                qq.type = "Real";
                                 q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                            }
                            else
                                return "Ошибка, ожидался пробел, либо запятая";
                        }
                        break;
                    case (State.N42):
                        {
                            if (sc == '0')
                            {
                                name1 += sc;
                                sta = State.N41;
                            }
                            else
                                if (number.Contains(sc))
                            {
                                name1 += sc;
                                sta = State.N4;
                            }
                            else
                                return "Ошибка, ожидалося 0, либо цифра";
                        }
                        break;
                    case (State.N43):
                        {
                            if (number0.Contains(sc))
                            {
                                name2 += sc;
                                if (name2.Length > 15)
                                    return "Ошибка: должно быть не более 15 символов в мантисе";
                            }
                            else
                                if (sc == ' ')
                            {
                                qq.type = "Real";
                                qq.name = name1 + name2;
                                 q = new LinkedListNode<Q>(qq); ll.AddLast(q);
                                sta = State.SP10;
                            }
                            else
                                return "Ошибка, ожидался пробел, либо цифра";
                        }
                        break;
                    case (State.SP10):
                        {
                            if (sc == 'e')
                                sta = State.END1;
                            else
                                if (sc == ' ') ;
                            else
                                return "Ошибка, ожидался end";
                        }
                        break;
                    case (State.END1):
                        {
                            if (sc == 'n')
                                sta = State.END2;
                            else
                                return "Ошибка, ожидался end";
                        }
                        break;
                    case (State.END2):
                        {
                            if (sc == 'd')
                                sta = State.END3;
                            else
                                return "Ошибка, ожидался end";
                        }
                        break;
                    case (State.END3):
                        {
                            if (sc == ';')
                                sta = State.F;
                            else
                                return "Ошибка, ожидалось \';\'";
                        }
                        break;
                    default:
                        {
                            return "Default Неизвестная Ошибка при анализе!";
                        }
                       
                }
                
            }
            return "";
        }

    }
}
