using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrder.BusinessLogic {
  public interface IOrderPizza { 
    void ChoosingVariant();
    void ChoosingSize();
    void ChoosingTopping();
    void ShowResult();
  }
}
