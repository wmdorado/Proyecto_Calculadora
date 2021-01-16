using NUnit.Framework;
using WebCalculadora.Controllers;

namespace NUnitTestCalculadora
{
    public class TestCalculadora
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSuma1()
        {
            //Arrage=preparacion
            int num1 = 5;
            int num2 = 7;
            int esperado = 12;
            CalculadoraController calc = new CalculadoraController();


            //Act=ejecucion
            int resultado = calc.sumapost(num1, num2);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }
    }
}