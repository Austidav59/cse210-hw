using System;

class Program
{
    static void Main(string[] args)
    {
        // constructor initialize to 1/1
        Fraction fraction1 = new Fraction();
        fraction1.SetTop(1);
        fraction1.SetBottom(1);

        // constructor initialize to 1
        Fraction fraction2 = new Fraction();
        fraction2.FractionWholeNumber(1);

        // 5/1
        Fraction fraction3 = new Fraction();
        fraction3.SetTop(1);
        fraction3.SetBottom(5);

        // 5
        Fraction fraction4 = new Fraction();
        fraction4.FractionWholeNumber(5);

        // 3/4
        Fraction fraction5 = new Fraction();
        fraction5.SetTop(3);
        fraction5.SetBottom(4);

        // 0.75
        Fraction fraction6 = new Fraction();
        fraction6.GetDecimalValue(3,4);

        //1/3
        Fraction fraction7 = new Fraction();
        fraction7.SetTop(1);
        fraction7.SetBottom(3);

        // 0.3333333
        Fraction fraction8 = new Fraction();
        fraction8.GetDecimalValue(1,3);






    }
}