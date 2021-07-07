using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrder.Models {
  public class OliveOil : ToppingDecorator {
    public OliveOil(IPizza p) : base(p) { }
    public override string GetDescription() {
      return base.GetDescription() + ", Olive oil";
    }
    public override double Price() {
      return 7400 + base.Price();
    }
  }
}
