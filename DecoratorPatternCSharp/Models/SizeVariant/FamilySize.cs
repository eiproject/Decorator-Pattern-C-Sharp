using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrder.Models {
  public class FamilySize : SizeDecorator{
    public  FamilySize(IPizza p) : base(p) {
    }
    public override string GetDescription() {
      return base.GetDescription() + ", Family size";
    }
    public override int GetSize() {
      return base.GetSize() + 5;
    }
  }
}
