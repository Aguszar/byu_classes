class Product{
    private string _name;
    private string _productID;
    private double _priceUnit;
    private int _quantity;

    public Product(string name, string productID, double priceUnit, int quantity){
        _name = name;
        _productID = productID;
        _priceUnit = priceUnit;
        _quantity = quantity;
    }

    public double CalculatePrice(){
        return _priceUnit*_quantity;
    }

    public string GetName(){
        return _name;
    } 
    
    public string GetProductID(){
        return _productID;
    } 

    public void GetPriceUnit(){
        Console.WriteLine(_priceUnit);
    } 

    public void GetQuantity(){
        Console.WriteLine(_quantity);
    } 
}