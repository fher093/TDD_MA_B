using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicaNegocios;

namespace PruebasMAB
{
    [TestClass]
    public class PruebasUnitariasFactorial
    {
        [TestMethod]
        public void Factorial_0()
        { 
            //Arrange: crear el entorno 
            OperacionesMatematicas operaciones = new OperacionesMatematicas();
            //Act: Operacion  
            double resultado = operaciones.CalcularFactorial(0);
            //Assert: verificar los resultados  
            Assert.AreEqual(1, resultado);


        }
        [TestMethod]
        public void Factorial_1()
        {
            //Arrange: crear el entorno 
            OperacionesMatematicas operaciones = new OperacionesMatematicas();
            //Act: Operacion  
            double resultado = operaciones.CalcularFactorial(1);
            //Assert: verificar los resultados  
            Assert.AreEqual(1, resultado);


        }

        [TestMethod]
        public void Factorial_5()
        {
            //Arrange: crear el entorno 
            OperacionesMatematicas operaciones = new OperacionesMatematicas();
            //Act: Operacion  
            double resultado = operaciones.CalcularFactorial(5);
            //Assert: verificar los resultados  
            Assert.AreEqual(120, resultado);


        }

        [TestMethod]
        public void Factorial_6()
        {
            //Arrange: crear el entorno 
            OperacionesMatematicas operaciones = new OperacionesMatematicas();
            //Act: Operacion  
            double resultado = operaciones.CalcularFactorial(6);
            //Assert: verificar los resultados  
            Assert.AreEqual(720, resultado);


        }

        [TestMethod]
        public void Factorial_menos_6()
        {
            //Arrange: crear el entorno 
            OperacionesMatematicas operaciones = new OperacionesMatematicas();
            //Act: Operacion  
            double resultado = operaciones.CalcularFactorial(-6);
            //Assert: verificar los resultados  
            Assert.AreEqual(double.NaN, resultado);


        }
    }
}
