using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            //string s;
            //string[] starray = new string[]{"Down",
            //                                "I",
            //                                "And",
            //                                "lol"};
            //for (int i = 0; i < starray.Length; i++)
            //{
            //    Console.WriteLine(starray[i]);
            //}
            //Console.ReadKey();
            //for (int i = 0; i < starray.Length - 1; i++)
            //{
            //    for (int j = i; j >= 0; j--)
            //    {
            //        if (String.Compare(starray[j], starray[j + 1]) > 0) // функція Compare()
            //        {
            //            s = starray[j];
            //            starray[j] = starray[j + 1];
            //            starray[j + 1] = s;
            //        }
            //    }
            //} 
            //Console.WriteLine();
            //for (int i = 0; i < starray.Length; i++)
            //{
            //    Console.WriteLine(starray[i]);
            //}

            //2
            //string newstr = null;
            //string str = "prievt lol kek 4ebyrek";
            //Console.WriteLine(str);
            //string[] str2 = str.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            //foreach (var item in str2)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();
            //Console.WriteLine();

            //for (int i = str2.Length - 1; i >= 0; i--)
            //{
            //    newstr += str2[i] + " ";
            //}

            //Console.WriteLine();
            //Console.WriteLine(newstr);

            //3
            //string str = "lol kek 13wsdq. dsa fds esdzf asdf   .dsadsa asda";
            //Console.WriteLine(str);
            //string[] str2 = str.Split(new char[] { '.', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            //string[] str3 = str2[1].Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine();
            //String s10 = String.Join("", str3);
            //Console.WriteLine(s10);
            //string str_point = ".";
            //s10 += ".";
            //str_point += s10;
            //s10 = str_point;
            //Console.WriteLine(s10);
            //str2[1] = s10;
            //String s11 = String.Join("", str2);
            //str = s11;
            //Console.WriteLine();
            //Console.WriteLine(str);

            //4
            //string numb1 = null;
            //string numb2 = null;
            //numb1 = Console.ReadLine().ToString();
            //numb2 = Console.ReadLine().ToString();
            //for (int i = 0; i < length; i++)
            //{

            //}

            //5
            //int number = int.Parse(Console.ReadLine());
            //string str = "prievt lol kek 4ebyrek";
            //Console.WriteLine(str);
            //string[] str2 = str.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            //foreach (var item in str2)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();
            //Console.WriteLine();
            //for (int i = 0; i < str2.Length; i++)
            //{
            //    if(number == i)
            //    {
            //        Console.WriteLine(str2[i][0]);
            //    }
            //}

            //6
            //string str = "jjstr jjstr jjstr jjstr jjlol jpkek asdstr zxstr qwestr";
            //Console.WriteLine(str);
            //string[] str2 = str.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            //foreach (var item in str2)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < str2.Length; i++)
            //{
            //    if (str2[i].Length == 5)
            //    {
            //        str2[i] = str2[i].Remove(2);
            //        str2[i] += "$";
            //    }
            //}

            //String s10 = String.Join(" ", str2);
            //Console.WriteLine(s10);

            //7
            //string word;

            //Console.Write(" enter word: ");

            //word = Console.ReadLine().ToString();
            //int count1 = 0;
            //int count2 = 0;

            //for (int i = 0; i < word.Length; i++)
            //{
            //    if (word[i] >= 65 && word[i] <= 90)
            //    {
            //        count1++;
            //    }
            //    if (word[i] >= 97 && word[i] <= 122)
            //    {
            //        count2++;
            //    }
            //}
            //double count3 = 100 / word.Length;
            //double count4 = count1 * count3;
            //double count5 = count2 * count3;

            //Console.WriteLine(" capital letters:" + count4);
            //Console.WriteLine(" lowercase letters:" + count5);

            //8
            //string str = "sssssss ddddddd fffffff ggggggg";
            //string str2 = "lol";
            //Console.WriteLine(str);
            //string newstr = str.Insert(3, str2);
            //Console.WriteLine(newstr);

            //9
            //string str = "str str str str lol kek str str str";
            //Console.WriteLine(str);
            //str = str.Replace("str", "omg");
            //Console.WriteLine(str);

            //10
            //char[,] arr = new char[8, 8]{ {'d','s','a','f','e','s','d','g' },
            //        { 'x','i','s','v','j','j','v','s' },
            //        { 'k','l','e','a','d','v','z','n' },
            //        { 'm','o','j','g','k','e','y','i' },
            //        { 'g','s','y','a','l','k','o','q' },
            //        { 'f','d','v','l','a','d','y','a' },
            //        { 'f','y','o','d','d','e','h','z' },
            //        { 'a','y','f','q','y','e','l','l' } };

            //for (int i = 0; i < 8; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
            //        Console.Write(arr[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            //bool find = false;
            //int index_i = 0;
            //int index_j = 0;
            //bool isWertical = false;

            //for (int i = 0; i < 8; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
            //        if (arr[i, j] == 'v' && arr[i + 1, j] == 'l' && arr[i + 2, j] == 'a' && arr[i + 3, j] == 'd')
            //        {
            //            index_i = i;
            //            index_j = j;
            //            find = true;
            //            isWertical = true;
            //        }
            //        if (arr[i, j] == 'v' && arr[i - 1, j] == 'l' && arr[i - 2, j] == 'a' && arr[i - 3, j] == 'd')
            //        {
            //            index_i = i;
            //            index_j = j;
            //            find = true;
            //            isWertical = true;
            //        }
            //        if (arr[i, j] == 'v' && arr[i, j + 1] == 'l' && arr[i, j + 2] == 'a' && arr[i, j + 3] == 'd')
            //        {
            //            index_i = i;
            //            index_j = j;
            //            find = true;
            //            isWertical = false;
            //        }
            //        if (arr[i, j] == 'v' && arr[i, j - 1] == 'l' && arr[i, j - 2] == 'a' && arr[i, j - 3] == 'd')
            //        {
            //            index_i = i;
            //            index_j = j;
            //            find = true;
            //            isWertical = false;
            //        }
            //    }
            //}

            //if (find != true)
            //{
            //    Console.WriteLine("There aro no word in arr!");
            //}
            //else
            //{
            //    Console.WriteLine("You find word!");
            //    Console.WriteLine("Number of row = " + index_i);
            //    Console.WriteLine("Number of col = " + index_j);
            //    if(isWertical == true)
            //        Console.WriteLine("Word is wertical");
            //    else
            //        Console.WriteLine("Word is horizontal");
            //}


            //11
            //char[] charsToTrim = {' '};
            //string str = "    Much    Ado   About        Nothing     ";
            //Console.WriteLine(str);
            //string result = str.Trim(charsToTrim);
            //Console.WriteLine(result);
            //string[] str2 = result.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            //String s10 = String.Join("*", str2);
            //Console.WriteLine(s10);

            //12
            //string str = "jjlo jpkeq aaaaaaaaa zxstr qwestr";
            //Console.WriteLine(str);
            //string[] str2 = str.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            //int a = str2[0].Length;
            //int index = 0;

            //Console.WriteLine();
            //for (int i = 0; i < str2.Length; i++)
            //{
            //    Console.WriteLine(str2[i]);
            //}

            //for (int i = 0; i < str2.Length; i++)
            //{
            //    if (a < str2[i].Length)
            //    {
            //        a = str2[i].Length;
            //        index = i;
            //    }
            //}

            //char[] arr = str2[index].ToCharArray();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if(arr[i] == 'a')
            //    {
            //        arr[i] = '$';
            //    }
            //}
            //str2[index] = new string(arr);

            //Console.WriteLine();
            //Console.WriteLine();
            //for (int i = 0; i < str2.Length; i++)
            //{
            //    Console.WriteLine(str2[i]);
            //}

            //13
            //string str = "jjst 123 12.3 jjst 2 jpke 22.2 2345 qwestr";
            //Console.WriteLine(str);
            //string[] str2 = str.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            //foreach (var item in str2)
            //{
            //    Console.WriteLine(item);
            //}

            //string str_int_number = null;
            //string str_double_number = null;
            //string str_new = null;
            //bool str_new_correct = false;
            //bool str_int_correct = false;
            //bool str_double_correct = false;
            //for (int i = 0; i < str2.Length; i++)
            //{
            //    for (int j = 0; j < str2[i].Length; j++)
            //    {
            //        if(str2[i][j] >= 97 && str2[i][j] <= 122 || str2[i][j] >= 65 && str2[i][j] <= 90)
            //        {
            //            str_new_correct = true;
            //            continue;
            //        }
            //        else
            //        {
            //            str_new_correct = false;
            //            break;
            //        }
            //    }
            //    if(str_new_correct == true)
            //    {
            //        str_new += str2[i] + " ";
            //    }

            //    for (int j = 0; j < str2[i].Length; j++)
            //    {
            //        if (str2[i][j] >= 48 && str2[i][j] <= 57)
            //        {
            //            str_int_correct = true;
            //            continue;
            //        }
            //        else
            //        {
            //            str_int_correct = false;
            //            break;
            //        }
            //    }
            //    if (str_int_correct == true)
            //    {
            //        str_int_number += str2[i] + " ";
            //    }

            //    for (int j = 0; j < str2[i].Length; j++)
            //    {
            //        if (str2[i][j] >= 48 && str2[i][j] <= 57)
            //        {
            //            str_double_correct = true;
            //            continue;
            //        }
            //        else if(str2[i][j] == '.')
            //        {
            //            str_double_correct = true;
            //            continue;
            //        }
            //        else
            //        {
            //            str_double_correct = false;
            //            break;
            //        }
            //    }
            //    if (str_double_correct == true)
            //    {
            //        str_double_number += str2[i] + " ";
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine(str_new);
            //Console.WriteLine(str_int_number);
            //Console.WriteLine(str_double_number);


            //14
            //string str = "jjst jjst jjst jjst jjlo jpke asdstr zxstr qwestr";
            //Console.WriteLine(str);
            //string[] str2 = str.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            //for (int i = 0; i < str2.Length; i++)
            //{
            //    if (str2[i].Length < 5)
            //    {
            //        str2[i] = str2[i].Remove(0);
            //    }
            //}

            //String s10 = String.Join(" ", str2);
            //string[] str3 = s10.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            //String s11 = String.Join(" ", str3);
            //Console.WriteLine(s11);

            //14
            //string word;
            //Console.WriteLine(" enter string  :");
            //word = Console.ReadLine();
            //char[] newword = word.ToCharArray();
            //Array.Reverse(newword);
            //string finaltext = new string(newword);

            //if (word == finaltext)
            //{
            //    Console.WriteLine("polyndrome");
            //}
            //else
            //{
            //    Console.WriteLine("not polyndrome");
            //}

            //15
            //string numb1 = "123456789789456";
            //string numb2 = "987654321321213";

        }
    }
}

