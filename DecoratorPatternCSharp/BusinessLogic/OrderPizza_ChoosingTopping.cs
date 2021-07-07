using System;
using System.Collections.Generic;
using System.Text;
using PizzaOrder.Models;

namespace PizzaOrder.BusinessLogic {
  partial class OrderPizza : IOrderPizza {
    void IOrderPizza.ChoosingTopping() {
      Console.WriteLine(
        "Choose Size Variant: 1) Basil 2) Mozarella 3) Olive oil" +
        "4) Oregano 5) Pecorino 6) Pepperoni 7) Sauce 99) Done");
      _isLoop = true;
      while (_isLoop) {
        string _strInput = Console.ReadLine();
        _userChoice = int.TryParse(_strInput, out _userChoice) ? _userChoice : 99;
        if (_userChoice == (int)_toppingChoices.basil) {
          _pizzaOrder = new Basil(_pizzaOrder);
          Console.WriteLine(_strInput + " .. Basil topping added.");
        }
        else if (_userChoice == (int)_toppingChoices.mozarella) {
          _pizzaOrder = new Mozarella(_pizzaOrder);
          Console.WriteLine(_strInput + " .. Mozarella topping added.");
        }
        else if (_userChoice == (int)_toppingChoices.oliveOil) {
          _pizzaOrder = new OliveOil(_pizzaOrder);
          Console.WriteLine(_strInput + " .. Olive Oil topping added.");
        }
        else if (_userChoice == (int)_toppingChoices.oregano) {
          _pizzaOrder = new Oregano(_pizzaOrder);
          Console.WriteLine(_strInput + " .. Oregano topping added.");
        }
        else if (_userChoice == (int)_toppingChoices.pecorino) {
          _pizzaOrder = new Pecorino(_pizzaOrder);
          Console.WriteLine(_strInput + " .. Pecorino topping added.");
        }
        else if (_userChoice == (int)_toppingChoices.pepperoni) {
          _pizzaOrder = new Pepperoni(_pizzaOrder);
          Console.WriteLine(_strInput + " .. Pepperoni topping added.");
        }
        else if (_userChoice == (int)_toppingChoices.sauce) {
          _pizzaOrder = new Sauce(_pizzaOrder);
          Console.WriteLine(_strInput + " .. Sauce topping added.");
        }
        else {
          Console.WriteLine("Done!");
          _isLoop = false;
        }
      }
    }
  }
}
