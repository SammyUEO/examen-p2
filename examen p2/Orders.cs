using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

public class Order
{
    public string Customer { get; set; }
    public DateTime Date { get; set; }
    public decimal Total { get; set; }

    public Order(string customer, DateTime date, decimal total)
    {
        Customer = customer;
        Date = date;
        Total = total;
    }
}
