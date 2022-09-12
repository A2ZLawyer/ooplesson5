using System;
using ooplesson5task1;

namespace ooplesson1task1
{
    class Program
    {
        private static void print(object outtext)
        {
            Console.WriteLine("════════╕\n Задача: " + outtext);
        }

        public static void Main()
        {
            print("IsNan 2/0 ? " + new Rational(2, 0).IsNan);
            Rational r35 = new Rational(1, 4);
            Rational r36 = new Rational(-2, 4);
            //Умножаем рациональную дробь на число
            print("Умножаем рациональную дробь " + r35 + " на число 4\n" + r35 * 4);

            //Складываем рациональные дроби
            Rational sumdr = r35 + r36;
            print("Складываем рациональные дроби " + r35 + " и " + r36 + " \n" + sumdr);

            //Вычитаем рациональные дроби
            Rational razn = new Rational(1, 2) - new Rational(1, 4);
            print("---Вычитаем рациональные дроби: " + razn);

            //Складываем рациональные дроби NaN
            print("Складываем рациональные дроби NaN: " + (new Rational(1, 2) + new Rational(1, 0)).IsNan);

            //Вычитаем рациональные дроби NaN
            print("Вычитаем рациональные дроби NaN: " + (new Rational(1, 2) - new Rational(1, 0)).IsNan);

            //Умножаем рациональные дроби NaN
            print("Умножаем рациональные дроби NaN: " + (new Rational(1, 2) * new Rational(1, 0)).IsNan);

            //Делим рациональные дроби NaN
            print("Делим рациональные дроби NaN: " + (new Rational(1, 2) / new Rational(1, 0)).IsNan);

            //Умножаем рациональные дроби
            print("Умножаем рациональные дроби: " + (new Rational(-1, 3) * new Rational(1, 2)));

            //Делим рациональные дроби
            print("Делим рациональные дроби: " + (new Rational(1, 7) / new Rational(-1, 2)));

            //Делим рациональные дроби на 0
            print("Делим рациональные дроби на 0: " + (new Rational(1, 6) / new Rational(0, 5)).IsNan);

            int aa = (int)new Rational(5, 1);
            print("Преобразуем в int: " + aa);

            float v = new Rational(1, 2);
            print("Преобразуем во float: " + v);

            Rational rr = 4;
            print("Число " + rr.Numerator + " в рациональную дробь: " + rr);
        }
    }
}