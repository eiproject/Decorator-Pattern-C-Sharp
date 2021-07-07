using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrder.Models {
  public abstract class ToppingDecorator : IPizza {
    private IPizza _pizza;
    internal ToppingDecorator(IPizza p) {
      this._pizza = p;
    }
    public virtual int GetSize() {
      return this._pizza.GetSize();
    }
    public virtual string GetDescription() {
      return this._pizza.GetDescription();
    }
    public virtual double Price() {
      return this._pizza.Price();
    }
  }
}
