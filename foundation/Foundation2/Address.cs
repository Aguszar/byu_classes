class Address{
    private string _street;
    private string _city;
    private string _country;
    
    public Address(string street, string city, string country){
        _street = street;
        _city = city;
        _country = country;
    }

    public bool IsFromUSA(){
        return _country.ToLower() == "usa" || _country.ToLower() == "united states of america";
    }

    public void GetStreet(){
        Console.WriteLine(_street);
    }

    public void GetCity(){
        Console.WriteLine(_city);
    }

    public void GetCountry(){
        Console.WriteLine(_country);
    }

    public string GetFullAddress(){
        return ($"{_street}, {_city}, {_country}");
    }
}