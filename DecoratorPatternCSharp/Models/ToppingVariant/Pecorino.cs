using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrder.Models {
  public class Pecorino : ToppingDecorator {
    public Pecorino(IPizza p) : base(p) { }
    public override string GetDescription() {
      return base.GetDescription() + ", Pecorino";
    }
    public override double Price() {
      return 11100 + base.Price();
    }
  }
}
