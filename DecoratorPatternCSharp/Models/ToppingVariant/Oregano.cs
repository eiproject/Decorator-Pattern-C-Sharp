using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrder.Models {
  public class Oregano : ToppingDecorator {
    public Oregano(IPizza p) : base(p) { }
    public override string GetDescription() {
      return base.GetDescription() + ", Oregano";
    }
    public override double Price() {
      return 13200 + base.Price();
    }
  }
}
