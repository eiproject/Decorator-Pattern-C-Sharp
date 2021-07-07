using System;
using System.Collections.Generic;
using System.Text;
using PizzaOrder.Models;

namespace PizzaOrder.BusinessLogic {
  partial class OrderPizza : IOrderPizza{
    private double _totalPrice;
    private int _userChoice;
    private bool _isLoop = true;
    private IPizza _pizzaOrder;
    private enum _variantChoices {
      standard = 1,
      exclusive = 2
    }
    private enum _sizeChoices {
      singleSize = 1,
      doubleSize,
      FamilySIze = 3
    }
    private enum _toppingChoices {
      basil = 1,
      mozarella,
      oliveOil,
      oregano,
      pecorino,
      pepperoni,
      sauce = 7,
      done = 99
    }
    internal OrderPizza() {
      
    }
  }
}
