using System;
using System.Collections.Generic;
using System.Text;
using PizzaOrder.Models;

namespace PizzaOrder.BusinessLogic {
  partial class OrderPizza : IOrderPizza{
    void IOrderPizza.ChoosingVariant() {
      _isLoop = true;
      while (_isLoop) {
        Console.Write("Choose Pizza Variant: 1) Standard 2) Exclusive : ");
        string _strInput = Console.ReadLine();
        _userChoice = int.TryParse(_strInput, out _userChoice) ? _userChoice : 99;
        
        if (_userChoice == (int)_variantChoices.standard) {
          _pizzaOrder = new PizzaStandard();
          _isLoop = false;
          Console.WriteLine(_strInput + " .. Great! Standar Pizza choosen.");
        }
        else if (_userChoice == (int)_variantChoices.exclusive) {
          _pizzaOrder = new PizzaExclusive();
          _isLoop = false;
          Console.WriteLine(_strInput + " .. Great! Exclusive Pizza choosen.");
        }
        else {
          Console.WriteLine("Wrog input!");
        }
      }
    }
  }
}
