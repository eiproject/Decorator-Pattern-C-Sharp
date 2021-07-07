using System;
using System.Collections.Generic;
using System.Text;
using PizzaOrder.Models;

namespace PizzaOrder.BusinessLogic {
  partial class OrderPizza : IOrderPizza {
    void IOrderPizza.ChoosingSize() {
      _isLoop = true;
      while (_isLoop) {
        Console.Write("Choose Size Variant: 1) Single 2) Double 3) Family : ");
        string _strInput = Console.ReadLine();
        _userChoice = int.TryParse(_strInput, out _userChoice) ? _userChoice : 99;

        if (_userChoice == (int)_sizeChoices.singleSize) {
          _pizzaOrder = new SingleSize(_pizzaOrder);
          _isLoop = false;
          Console.WriteLine(_strInput + " .. Great! Single Size Pizza choosen.");
        }
        else if (_userChoice == (int)_sizeChoices.doubleSize) {
          _pizzaOrder = new DoubleSize(_pizzaOrder);
          _isLoop = false;
          Console.WriteLine(_strInput + " .. Great! Double Size Pizza choosen.");
        }
        else if (_userChoice == (int)_sizeChoices.FamilySIze) {
          _pizzaOrder = new FamilySize(_pizzaOrder);
          _isLoop = false;
          Console.WriteLine(_strInput + " .. Great! Family Size Pizza choosen.");
        }
        else {
          Console.WriteLine("Wrog input!");
        }
      }
    }
  }
}
