using NUnit.Framework;
using PizzaOrder.Models;
using PizzaOrder.BusinessLogic;
using Moq;

namespace TestOrder {
  public class TestOrderPizzaStandard {
    private IPizza _pizza;
    private Mock<IPizza> _mockPizza;
    [SetUp]
    public void Setup() {
      _mockPizza = new Mock<IPizza>(MockBehavior.Strict);
    }

    [Test]
    public void CheckPrice_PizzaStandard_ShouldBe_15000() {
      _pizza = new PizzaStandard();
      var _expected = 15000;
      Assert.AreEqual(_pizza.Price(), _expected);
    }
    [Test]
    public void CheckSize_SingleSize_ShouldBeStandardAndSingle() {
      _mockPizza.Setup(p => p.GetDescription()).Returns("Pizza Standard");
      _mockPizza.Setup(p => p.GetSize()).Returns(0);

      _pizza = new SingleSize(_mockPizza.Object);
      var _expectedDesc = "Pizza Standard, Single size";
      var _expected = 1;
      Assert.AreEqual(_pizza.GetDescription(), _expectedDesc);
      Assert.AreEqual(_pizza.GetSize(), _expected);
    }
    [Test]
    public void CheckSize_DoubleSize_ShouldBeStandardAndDouble() {
      _mockPizza.Setup(p => p.GetDescription()).Returns("Pizza Standard");
      _mockPizza.Setup(p => p.GetSize()).Returns(0);

      _pizza = new DoubleSize(_mockPizza.Object);
      var _expectedDesc = "Pizza Standard, Double size";
      var _expected = 2;
      Assert.AreEqual(_pizza.GetDescription(), _expectedDesc);
      Assert.AreEqual(_pizza.GetSize(), _expected);
    }
    [Test]
    public void CheckSize_FamilySize_ShouldBeStandardAndFamily() {
      _mockPizza.Setup(p => p.GetDescription()).Returns("Pizza Standard");
      _mockPizza.Setup(p => p.GetSize()).Returns(0);

      _pizza = new FamilySize(_mockPizza.Object);
      var _expectedDesc = "Pizza Standard, Family size";
      var _expected = 5;
      Assert.AreEqual(_pizza.GetDescription(), _expectedDesc);
      Assert.AreEqual(_pizza.GetSize(), _expected);
    }
    [Test]
    public void CheckPrice_Basil_ShouldBeBasilPrice() {
      _mockPizza.Setup(p => p.GetDescription()).Returns("Pizza Standard");
      _mockPizza.Setup(p => p.Price()).Returns(15000);

      _pizza = new Basil(_mockPizza.Object);
      var _expectedDesc = "Pizza Standard, Basil";
      var _expected = 15000 + 10500;
      Assert.AreEqual(_pizza.GetDescription(), _expectedDesc);
      Assert.AreEqual(_pizza.Price(), _expected);
    }
    [Test]
    public void CheckPrice_Mozarella_ShouldBeMozarellaPrice() {
      _mockPizza.Setup(p => p.GetDescription()).Returns("Pizza Standard");
      _mockPizza.Setup(p => p.Price()).Returns(15000);

      _pizza = new Mozarella(_mockPizza.Object);
      var _expectedDesc = "Pizza Standard, Mozarella";
      var _expected = 15000 + 13000;
      Assert.AreEqual(_pizza.GetDescription(), _expectedDesc);
      Assert.AreEqual(_pizza.Price(), _expected);
    }
    [Test]
    public void CheckPrice_OliveOil_ShouldBeOliveOilPrice() {
      _mockPizza.Setup(p => p.GetDescription()).Returns("Pizza Standard");
      _mockPizza.Setup(p => p.Price()).Returns(15000);

      _pizza = new OliveOil(_mockPizza.Object);
      var _expectedDesc = "Pizza Standard, Olive oil";
      var _expected = 15000 + 7400;
      Assert.AreEqual(_pizza.GetDescription(), _expectedDesc);
      Assert.AreEqual(_pizza.Price(), _expected);
    }
    [Test]
    public void CheckPrice_Oregano_ShouldBeOreganoPrice() {
      _mockPizza.Setup(p => p.GetDescription()).Returns("Pizza Standard");
      _mockPizza.Setup(p => p.Price()).Returns(15000);

      _pizza = new Oregano(_mockPizza.Object);
      var _expectedDesc = "Pizza Standard, Oregano";
      var _expected = 15000 + 13200;
      Assert.AreEqual(_pizza.GetDescription(), _expectedDesc);
      Assert.AreEqual(_pizza.Price(), _expected);
    }
    [Test]
    public void CheckPrice_Pecorino_ShouldBePecorinoPrice() {
      _mockPizza.Setup(p => p.GetDescription()).Returns("Pizza Standard");
      _mockPizza.Setup(p => p.Price()).Returns(15000);

      _pizza = new Pecorino(_mockPizza.Object);
      var _expectedDesc = "Pizza Standard, Pecorino";
      var _expected = 15000 + 11100;
      Assert.AreEqual(_pizza.GetDescription(), _expectedDesc);
      Assert.AreEqual(_pizza.Price(), _expected);
    }
    [Test]
    public void CheckPrice_Pepperoni_ShouldBePepperoniPrice() {
      _mockPizza.Setup(p => p.GetDescription()).Returns("Pizza Standard");
      _mockPizza.Setup(p => p.Price()).Returns(15000);

      _pizza = new Pepperoni(_mockPizza.Object);
      var _expectedDesc = "Pizza Standard, Pepperoni";
      var _expected = 15000 + 9500;
      Assert.AreEqual(_pizza.GetDescription(), _expectedDesc);
      Assert.AreEqual(_pizza.Price(), _expected);
    }
    [Test]
    public void CheckPrice_Sauce_ShouldBeSaucePrice() {
      _mockPizza.Setup(p => p.GetDescription()).Returns("Pizza Standard");
      _mockPizza.Setup(p => p.Price()).Returns(15000);

      _pizza = new Sauce(_mockPizza.Object);
      var _expectedDesc = "Pizza Standard, Sauce";
      var _expected = 15000 + 5300;
      Assert.AreEqual(_pizza.GetDescription(), _expectedDesc);
      Assert.AreEqual(_pizza.Price(), _expected);
    }

    [Test]
    public void CheckCombinedPrice_Sauce_ShouldBeSaucePrice() {
      _mockPizza.Setup(p => p.GetDescription()).Returns("Pizza Standard");
      _mockPizza.Setup(p => p.Price()).Returns(15000);

      _pizza = new DoubleSize(_mockPizza.Object);
      _pizza = new Basil(_pizza);
      _pizza = new OliveOil(_pizza);
      _pizza = new Mozarella(_pizza);
      _pizza = new Oregano(_pizza);
      _pizza = new Pecorino(_pizza);
      _pizza = new Pepperoni(_pizza);
      _pizza = new Sauce(_pizza);

      var _expectedDesc = "Pizza Standard, Double size, Basil, Olive oil, Mozarella, Oregano, Pecorino, Pepperoni, Sauce";
      var _expected = 15000 + 70000;
      Assert.AreEqual(_pizza.GetDescription(), _expectedDesc);
      Assert.AreEqual(_pizza.Price(), _expected);
    }
  }
}