using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrder.Models {
  public class DoubleSize : SizeDecorator {
    public DoubleSize(IPizza p) : base(p) { }
    public override string GetDescription() {
      return base.GetDescription() + ", Double size";
    }
    public override int GetSize() {
      return base.GetSize() + 2;
    }
  }
}
