using NUnit.Framework;
using PizzaOrder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestOrder {
  public class TestOrderPizzaExclusive {
    private IPizza _pizza;
    [SetUp]
    public void Setup() {
    }
    [Test]
    public void Exclusive1() {
      _pizza = new PizzaExclusive();
      _pizza = new SingleSize(_pizza);
      Assert.AreEqual(_pizza.Price() * _pizza.GetSize(), 23000);
    }
    [Test]
    public void Exclusive2() {
      _pizza = new PizzaExclusive();
      _pizza = new FamilySize(_pizza);
      _pizza = new Basil(_pizza);
      _pizza = new Mozarella(_pizza);
      _pizza = new Oregano(_pizza);
      _pizza = new Pecorino(_pizza);
      _pizza = new Sauce(_pizza);
      _pizza = new Sauce(_pizza);
      Assert.AreEqual(_pizza.Price() * _pizza.GetSize(), 407000);
    }
    [Test]
    public void Exclusive3() {
      _pizza = new PizzaExclusive();
      _pizza = new DoubleSize(_pizza);
      _pizza = new Basil(_pizza);
      _pizza = new OliveOil(_pizza);
      _pizza = new Mozarella(_pizza);
      _pizza = new Oregano(_pizza);
      _pizza = new Pecorino(_pizza);
      _pizza = new Pepperoni(_pizza);
      _pizza = new Sauce(_pizza);
      Assert.AreEqual(_pizza.Price() * _pizza.GetSize(), 186000);
    }
    [Test]
    public void Exclusive4() {
      _pizza = new PizzaExclusive();
      _pizza = new FamilySize(_pizza);
      _pizza = new Basil(_pizza);
      _pizza = new OliveOil(_pizza);
      _pizza = new Mozarella(_pizza);
      _pizza = new Oregano(_pizza);
      _pizza = new Pecorino(_pizza);
      _pizza = new Pepperoni(_pizza);
      _pizza = new Sauce(_pizza);
      Assert.AreEqual(_pizza.Price() * _pizza.GetSize(), 465000);
    }
    [Test]
    public void Exclusive5() {
      _pizza = new PizzaExclusive();
      _pizza = new DoubleSize(_pizza);
      _pizza = new Basil(_pizza);
      _pizza = new Mozarella(_pizza);
      _pizza = new Mozarella(_pizza);
      _pizza = new Oregano(_pizza);
      _pizza = new Sauce(_pizza);
      Assert.AreEqual(_pizza.Price() * _pizza.GetSize(), 156000);
    }
    [Test]
    public void Exclusive6() {
      _pizza = new PizzaExclusive();
      _pizza = new SingleSize(_pizza);
      _pizza = new Mozarella(_pizza);
      _pizza = new Oregano(_pizza);
      _pizza = new Pecorino(_pizza);
      _pizza = new Sauce(_pizza);
      _pizza = new Sauce(_pizza);
      Assert.AreEqual(_pizza.Price() * _pizza.GetSize(), 70900);
    }
  }
}
