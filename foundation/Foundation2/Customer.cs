using System.Security.Cryptography;

class Customer{
    private string _name;
    private Address _address;


    public Customer(string name, Address address){
        _name = name;
        _address = address;
    }

    public bool IsFromUSA(){
        return _address.IsFromUSA();
    }

    public string GetName(){
        return _name;
    }

    public string GetAddress(){
        return _address.GetFullAddress();
    }
}