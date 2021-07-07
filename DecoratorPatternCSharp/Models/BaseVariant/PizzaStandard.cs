using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrder.Models {
  public class PizzaStandard : IPizza {
    string IPizza.GetDescription() {
      return "Pizza Standard";
    }
    int IPizza.GetSize() {
      return 0;
    }
    double IPizza.Price() {
      return 15000;
    }
  }
}