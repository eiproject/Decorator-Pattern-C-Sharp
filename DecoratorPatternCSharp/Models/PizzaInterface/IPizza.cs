using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrder.Models {
  public interface IPizza {
    string GetDescription();
    double Price() { return 0; }
    int GetSize();
  }
}