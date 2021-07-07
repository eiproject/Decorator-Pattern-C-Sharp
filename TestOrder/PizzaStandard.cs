using NUnit.Framework;
using PizzaOrder.Models;
using PizzaOrder.BusinessLogic;

namespace TestOrder {
  public class TestOrderPizzaStandard {
    private IPizza _pizza;
    [SetUp]
    public void Setup() {
    }
    [Test]
    public void Standard1() {
      _pizza = new PizzaStandard();
      _pizza = new SingleSize(_pizza);
      Assert.AreEqual(_pizza.Price() * _pizza.GetSize(), 15000);
    }
    [Test]
    public void Standard2() {
      _pizza = new PizzaStandard();
      _pizza = new SingleSize(_pizza);
      _pizza = new Basil(_pizza);
      _pizza = new Mozarella(_pizza);
      _pizza = new Sauce(_pizza);
      Assert.AreEqual(_pizza.Price() * _pizza.GetSize(), 43800);
    }
    [Test]
    public void Standard3() {
      _pizza = new PizzaStandard();
      _pizza = new DoubleSize(_pizza);
      _pizza = new Basil(_pizza);
      _pizza = new Oregano(_pizza);
      _pizza = new Pecorino(_pizza);
      _pizza = new Sauce(_pizza);
      Assert.AreEqual(_pizza.Price() * _pizza.GetSize(), 110200);
    }
    [Test]
    public void Standard4() {
      _pizza = new PizzaStandard();
      _pizza = new FamilySize(_pizza);
      _pizza = new Basil(_pizza);
      _pizza = new Mozarella(_pizza);
      _pizza = new Mozarella(_pizza);
      _pizza = new Oregano(_pizza);
      _pizza = new Pecorino(_pizza);
      _pizza = new Sauce(_pizza);
      Assert.AreEqual(_pizza.Price() * _pizza.GetSize(), 405500);
    }
    [Test]
    public void Standard5() {
      _pizza = new PizzaStandard();
      _pizza = new DoubleSize(_pizza);
      _pizza = new Basil(_pizza);
      _pizza = new OliveOil(_pizza);
      _pizza = new Mozarella(_pizza);
      _pizza = new Oregano(_pizza);
      _pizza = new Pecorino(_pizza);
      _pizza = new Pepperoni(_pizza);
      _pizza = new Sauce(_pizza);
      Assert.AreEqual(_pizza.Price() * _pizza.GetSize(), 170000);
    }
    [Test]
    public void Standard6() {
      _pizza = new PizzaStandard();
      _pizza = new FamilySize(_pizza);
      _pizza = new Basil(_pizza);
      _pizza = new OliveOil(_pizza);
      _pizza = new Mozarella(_pizza);
      _pizza = new Mozarella(_pizza);
      _pizza = new Oregano(_pizza);
      _pizza = new Pecorino(_pizza);
      _pizza = new Pepperoni(_pizza);
      _pizza = new Sauce(_pizza);
      _pizza = new Sauce(_pizza);
      Assert.AreEqual(_pizza.Price() * _pizza.GetSize(), 516500);
    }
  }
}