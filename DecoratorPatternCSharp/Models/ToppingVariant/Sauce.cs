using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrder.Models {
  public class Sauce : ToppingDecorator {
    public Sauce(IPizza p) : base(p) { }
    public override string GetDescription() {
      return base.GetDescription() + ", Sauce";
    }
    public override double Price() {
      return 5300 + base.Price();
    }
  }
}
