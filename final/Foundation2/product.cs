public class Products
{
    private List<string>_products = new List<string>();
    private List<float>_productPrices = new List<float>();


    public Products()
    {
        // products available
        _products.Add("Milk");
        _products.Add("Eggs");
        _products.Add("Waffle Mix");
        _products.Add("Cookies");
        _products.Add("water");

        //Prices available
        _productPrices.Add(3.23f);
        _productPrices.Add(6.76f);
        _productPrices.Add(9.76f);
        _productPrices.Add(12.76f);
        _productPrices.Add(15.55f);

    }

    public void Dispayproducts()
    {
        for (int i = 0; i < _products.Count(); i++)
        {
            Console.WriteLine($"{i + 1}. {_products[i]} : ${_productPrices[i]}");

        }
    }


}