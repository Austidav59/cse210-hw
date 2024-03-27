public class Order
{
    Products product1 = new Products();
    Customer customer1 = new Customer("John doe", false, "123 gray street", 1);
    Customer customer2 = new Customer("linda don", true, "1567 Red Circle", 2);
    private List<string>_order = new List<string>();
    private List<float>_orderPrice = new List<float>();

    
    public Order(string product1, string product2, string product3, string product4, float id1, float id2, float id3, float id4)
    {
        _order.Add(product1);
        _order.Add(product2);
        _order.Add(product3);
        _order.Add(product4);

        _orderPrice.Add(id1);
        _orderPrice.Add(id2);
        _orderPrice.Add(id3);
        _orderPrice.Add(id4);


    }

    public Order(string id1, string id2,float prop1, float prop2)
    {
        _order.Add(id1);
        _order.Add(id2);

        _orderPrice.Add(prop1);
        _orderPrice.Add(prop2);

    }

    public float CalculateOrderCost1()
    {
        if (customer1.GetUsaCheck() == true)
        {
            int total = 5;
            foreach (int price in _orderPrice)
            {
                total = price + total;
            }
            return total;
        }
        else
        {
            int total = 35;
            foreach (int price in _orderPrice)
            {
                total = price + total;
            }
            return total;
        }
    }

    public float CalculateOrderCost2()
    {
        if (customer1.GetUsaCheck() == true)
        {
            int total = 5;
            foreach (int price in _orderPrice)
            {
                total = price + total;
            }
            return total;
        }
        else
        {
            int total = 35;
            foreach (int price in _orderPrice)
            {
                total += price;
            }
            return total;
        }

    }

    public string ListOrderItems()
    {

        for (int i = 0; i < _order.Count(); i++)
        {
            Console.WriteLine($"product id: {i + 1}. : {_order[i]}");

        }
        return "";
    }



    public void DisplayShipingLabel1()
    {
        Console.WriteLine("Final Price");
        Console.WriteLine(CalculateOrderCost1());

        Console.WriteLine("");
        Console.WriteLine("Shipping Label");
        Console.WriteLine(customer1.Getname());
        Console.WriteLine(customer1.Getaddress());
        Console.WriteLine(customer1.Getid());

        Console.WriteLine("");
        Console.WriteLine("Packaging label");
        Console.WriteLine(ListOrderItems());

    }
    public void DisplayShipingLabel2()
    {
         Console.WriteLine("Final Price");
        Console.WriteLine(CalculateOrderCost2());

        Console.WriteLine("");
        Console.WriteLine("Shipping Label");
        Console.WriteLine(customer2.Getname());
        Console.WriteLine(customer2.Getaddress());
        Console.WriteLine(customer2.Getid());

        Console.WriteLine("");
        Console.WriteLine("Packaging label");
        Console.WriteLine(ListOrderItems());


    }


}