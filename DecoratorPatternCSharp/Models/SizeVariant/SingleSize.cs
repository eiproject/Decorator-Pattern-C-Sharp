using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrder.Models {
  public class SingleSize : SizeDecorator{
    public SingleSize(IPizza p) : base(p) {
    }
    public override string GetDescription() {
      return base.GetDescription() + ", Single size";
    }
    public override int GetSize() {
      return base.GetSize() + 1;
    }
  }
}
