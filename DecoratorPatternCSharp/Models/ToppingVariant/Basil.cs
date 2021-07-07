using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrder.Models {
  public class Basil : ToppingDecorator{
    public Basil(IPizza p) : base(p){
    }
    public override string GetDescription() {
      return base.GetDescription() + ", Basil";
    }
    public override double Price() {
      return 10500 + base.Price();
    }
  }
}
