using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrder.Models {
  public class Mozarella : ToppingDecorator{
    public Mozarella(IPizza p) : base(p) {
    }
    public override string GetDescription() {
      return base.GetDescription() + ", Mozarella";
    }
    public override double Price() {
      return 13000 + base.Price();
    }
  }
}
