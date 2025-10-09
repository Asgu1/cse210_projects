using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order()
    {
        _products = new List<Product>();
        _customer = new Customer();
    }

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public List<Product> GetProducts()
    {
        return _products;
    }

    public void SetProducts(List<Product> products)
    {
        _products = products;
    }

    public Customer GetCustomer()
    {
        return _customer;
    }

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        
        // Calculate the sum of all products
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        // Add shipping cost
        double shippingCost = _customer.IsInUSA() ? 5.0 : 35.0;
        totalCost += shippingCost;

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "PACKING LABEL:\n";
        foreach (Product product in _products)
        {
            packingLabel += $"  {product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "SHIPPING LABEL:\n";
        shippingLabel += $"  {_customer.GetName()}\n";
        shippingLabel += $"  {_customer.GetAddress().GetFullAddress()}";
        return shippingLabel;
    }
}
