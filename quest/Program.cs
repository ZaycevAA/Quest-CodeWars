using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] i2 = new string[] { "A", "A", "A", "A", "A", "A", "A", "A", "A" };
            int[] i = new int[] {  20, -5, 2, 3, 15, 0 };
            int[] i3 = new int[] { 1, 2, 3, 4, 3, 2, 1 };
            int[] i4 = new int[] { 1};
            string a = "    ";
           
            Console.WriteLine(FindEvenIndex(i));
            Console.WriteLine(FindEvenIndex(i3));
            Console.WriteLine(FindEvenIndex(i4));
            Console.ReadLine();
        }
       
            
        
        public static int FindEvenIndex(int[] arr)
        {
            //return Enumerable.Range(0,arr.Length).ToList().FindIndex(i=>arr[..i].sum())
            int a, b,c=0;
            if (arr.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    a = 0;
                    b = 0;
                    for (int i2 = 0; i2 <=i; i2++)
                    {
                        a += arr[i2];
                    }
                    for (int i2 = arr.Length - 1; i2 >= i; i2--)
                    {
                        b += arr[i2];
                    }
                    if (b == a)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }


        //////////
        //public static string GetReadableTime(int seconds)
        //{
        //    var s = new TimeSpan(0, 0, seconds);
        //    return seconds < 359999? string.Format("{0:00}:{1:00}:{2:00}", (int)s.TotalHours,s.Minutes,s.Seconds ) : "99:59:59";
        //}

        ///////////
        //public static bool IsPrime(int n)
        //{

        //    for (int i = 2; i < n / 1000; i++)
        //    {
        //        if (n % i == 0)
        //        {
        //            return false;
        //        }
        //    }
        //    return (n < 2) || (n != 2 && n % 2 == 0) || (n != 3 && n % 3 == 0) || (n != 5 && n % 5 == 0) || (n != 7 && n % 7 == 0) ? false : true;
        //}






        ///////////
        //public static int[] InvertValues(int[] input)
        //{
        //    return input.Select(i =>-i).ToArray();
        //}





        ///////////////
        //public static int Enough(int cap, int on, int wait)
        //{
        //    cap = cap - on - wait;
        //    return cap <= 0 ?Math.Abs(cap) : 0;
        //}





        ////////////
        //public static int Litres(double time)=> (int) (time / 2);




        ///////////
        //public static double Index(int[] array, int n)
        //{
        //    return array.Length<=n--&&n>=0?Math.Pow(array[n],n):-1;
        //}




        /////////////
        //public static int UnluckyDays(int year)
        //{
        //    int a =0;
        //    for (int i = 1; i <=12; i++)
        //    {
        //       a+=(int)(new DateTime(year, i, 13)).DayOfWeek == 5 ? 1 : 0;
        //    }
        //    return a;
        //}
        //public static int UnluckyDays2(int year)
        //{
        //    return Enumerable.Range(1,12).Select(i=>(int) new DateTime(year,i,13).DayOfWeek).Count(i=>i==5);
        //}






        ////////////////
        //public static int summation(int num)
        //{
        //    return num*++num/2;
        //   
        //}
        //public static int summation2(int num)
        //{
        //    if (num != 0)
        //    {
        //        return num + summation(num - 1);
        //    }
        //    else
        //    {
        //        return 0;
        //
        //    } 
        //}
        //public static int summation3(int num)
        //{
        //    return Enumerable.Range(1, num).Sum();
        //}





        ///////////
        //public static double SumArray(double[] array)
        //{
        //    double a = 0;
        //    foreach (var item in array)
        //    {
        //        a += item;
        //    }
        //    return a;
        //}
        //public static double SumArray2(double[] array)
        //{
        //    return array.Sum();
        //}





        ////////
        //public static string Solution(string str)
        //{
        //    char[] a = str.ToCharArray();
        //    Array.Reverse(a);
        //    return new string(a);
        //}
        //public static string Solution2(string str)
        //{
        //    return string.Concat(str.Reverse());
        //}




        //////////////
        //public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable ) 
        //{
        //    List<T> a =iterable!=null? iterable.ToList():new List<T>{};
        //    T s = default(T);
        //    for (int i = 0; i < a.Count(); i++)
        //    {
        //        if (a[i] != null)
        //        {
        //            if ((s!=null?s.ToString():"") == a[i].ToString())
        //            {
        //                a.RemoveAt(i);
        //                i--;
        //            }
        //            else
        //            {
        //                s = a[i];
        //            }
        //        }
        //    }
        //    return a;
        //}
        //public static IEnumerable<T> UniqueInOrder2<T>(IEnumerable<T> iterable)
        //{
        //    T a = default(T);
        //    foreach (T item in iterable)
        //    {
        //        if (item.Equals(a))
        //        {
        //            a = item;
        //            yield return a;
        //        }
        //    }
        //}





        ///////////////
        //public static string stockSummary(string[] lstOfArt, string[] lstOf1stLetter)
        //{
        //    string sum = "";
        //    foreach (var item in lstOf1stLetter)
        //    {
        //        sum += $"- ({item} : {lstOfArt.Where(i => i.StartsWith(item)).Select(i => int.Parse(i.Remove(0, i.IndexOf(" ")))).Sum()}) ";
        //    }
        //    return lstOfArt.Length != 0 && lstOf1stLetter.Length != 0 ? sum.Trim(new char[] { '-', ' ' }) : "";
        //}
        //public static string stockSummary2(String[] lstOfArt, String[] lstOf1stLetter) =>
        //    lstOfArt.Any() ? string.Join(" - ", lstOf1stLetter.Select(c => string.Format("({0} : {1})", c,
        //    lstOfArt.Where(v => v.StartsWith(c)).Select(i => int.Parse(i.Remove(0, i.IndexOf(" ")))).Sum()))) : "";








        ///////////
        //public static int Past(int h, int m, int s) => h < 24 && m < 60 && s < 60 ? ((h * 60 + m) * 60 + s) * 1000 : 0;
        //public static int Past2(int h, int m, int s) => (int)(new TimeSpan(h, m, s).TotalMilliseconds);






        ///////
        //public static string CreatePhoneNumber(int[] numbers)
        //{
        //    string number = "(";
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        number += numbers[i] + (i == 2 ? ") " : "") + (i == 5 ? "-" : "");
        //    }
        //    return number;
        //}
        //public static string CreatePhoneNumber2(int[] numbers)
        //{
        //    return string.Format("{0:(000) 000-0000}", long.Parse(string.Concat(numbers)));
        //}
        //public static string CreatePhoneNumber3(int[] numbers)
        //{
        //    return long.Parse(string.Concat(numbers)).ToString("0:(000) 000-0000");
        //}









        /////////
        //public static int Solution(int value)
        //{
        //    int summ = 0;
        //    for (int i = 0; i < value; i++)
        //    {
        //        if (i % 3 == 0 || i % 5 == 0)
        //            summ += i;
        //    }
        //    return summ;
        //}
        //public static int Solution2(int value) => Enumerable.Range(0, value).Where(i => i % 3 == 0 || i % 5 == 0).Sum();
        //public static int Solution3(int value)
        //{
        //    return Enumerable.Range(0, value).Where(i => i % 3 == 0 || i % 5 == 0).Sum();
        //}


        ///////
        //public static string AlphabetPosition(string text)
        //{
        //    string Text2 = "";
        //    foreach (char chara in text.ToLower())
        //    {
        //        int a = (int)chara - 96;
        //        if (a > 0 && a < 27)
        //        {
        //            Text2 += " " + a;
        //        }
        //    }
        //    return Text2.TrimStart(' ');
        //}
    }

}
