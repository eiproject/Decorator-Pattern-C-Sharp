using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrder.Models {
  public class Pepperoni : ToppingDecorator {
    public Pepperoni(IPizza p) : base(p) { }
    public override string GetDescription() {
      return base.GetDescription() + ", Pepperoni";
    }
    public override double Price() {
      return 9500 + base.Price();
    }
  }
}
