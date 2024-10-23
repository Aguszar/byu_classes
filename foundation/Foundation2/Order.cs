class Order{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer){
        _customer = customer;
        _products = [];
    }
    
    public Order(Customer customer, List<Product> products){
        _customer = customer;
        _products = products;
    }

    public void AddProduct(Product product){
        _products.Add(product);
    }

    /* cost without shipping*/
    public double CalculateCost(){
        /* cost without shipping*/

        double sum = 0;
        foreach (Product p in _products){
            sum += p.CalculatePrice();
        }
        return sum;
    }

    public double TotalCost(){
        if (_customer.IsFromUSA()){
            return 5+CalculateCost();
        }else{
            return 35+CalculateCost();
        }
    }

    public string PackingLabel(){
        string label = "";

        foreach (Product p in _products){
            label += ":"+p.GetName()+","+p.GetProductID();
        }

        return label;
    }

    public string ShippingLabel(){
        return _customer.GetName()+":"+_customer.GetAddress();
    }

    public void GetCustomer(){
        Console.WriteLine(_customer.GetName());
    }

}