using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrder.Models {
  public class PizzaExclusive : IPizza {
    string IPizza.GetDescription() {
      return "Pizza Exclusive";
    }
    int IPizza.GetSize() {
      return 0;
    }
    double IPizza.Price() {
      return 23000;
    }
  }
}
