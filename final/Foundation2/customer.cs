using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class Customer
{
    private string _name;
    private bool _inUsa;
    private string _address;
    private int _customerId;
    
    public Customer(string name, bool inusa, string address, int id)
    {
        _customerId = id;
        _address = address;
        _inUsa = inusa;
        _name = name;

    }

    public  bool GetUsaCheck()
    {
        return _inUsa;
    }

    public  string Getaddress()
    {
        return _address;
    }
    public  string Getname()
    {
        return _name;
    }
    public  int Getid()
    {
        return _customerId;
    }

}