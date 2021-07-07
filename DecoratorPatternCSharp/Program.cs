using System;
using PizzaOrder.Models;
using PizzaOrder.BusinessLogic;

namespace PizzaOrder {
  class Run {
    internal Run() {
      IOrderPizza newPizzaOrder = new OrderPizza();
      newPizzaOrder.ChoosingVariant();
      newPizzaOrder.ChoosingSize();
      newPizzaOrder.ChoosingTopping();
      newPizzaOrder.ShowResult();
    }
  }

  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Pizza Order Apps!");
      Run app = new Run();
    }
  }
}
