using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order("milk","eggs","Waffle Mix","Cookies",3.23f,6.76f,9.76f,12.76f);
        Order order2 = new Order("Waffle Mix","Cookies",3.23f,6.76f);

        order1.DisplayShipingLabel1();
        order2.DisplayShipingLabel2();


    }
}