using System;
using System.Collections.Generic;
using System.Text;
using PizzaOrder.Models;

namespace PizzaOrder.BusinessLogic {
  partial class OrderPizza : IOrderPizza {
    void IOrderPizza.ShowResult() {
      _totalPrice = _pizzaOrder.GetSize() * _pizzaOrder.Price();
      Console.WriteLine($"Name: {_pizzaOrder.GetDescription()} Price: Rp.{_totalPrice},00.");
    }
  }
}
