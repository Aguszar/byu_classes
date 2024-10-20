using System;

class Program
{
    static void Main(string[] args){
        Address a1 = new Address("Main", "Salt lake City", "usa");
        Address a2 = new Address("San Martin", "Buenos Aires", "Argentina");

        Customer c1 =  new Customer("John", a1);
        Customer c2 =  new Customer("Juan", a2);

        Order o1 = new Order(c1);
        Order o2 = new Order(c2);

        Product p1 = new Product("soap", "1234", 3.99, 1);
        Product p2 = new Product("Meat", "2345", 6.99, 1);
        Product p3 = new Product("Seeds", "w21q", 1.50, 1);
        
        o1.AddProduct(p1);
        o1.AddProduct(p2);
        o1.AddProduct(p3);
        Console.WriteLine(o1.PackingLabel());
        Console.WriteLine(o1.ShippingLabel());
        Console.WriteLine(o1.TotalCost()+"\n");
        
        o2.AddProduct(p1);
        o2.AddProduct(p2);
        o2.AddProduct(p3);
        Console.WriteLine(o2.PackingLabel());
        Console.WriteLine(o2.ShippingLabel());
        Console.WriteLine(o2.TotalCost());
        

    }
}