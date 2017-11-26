using NUnit.Framework;
using LibreriaMatematica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasUnitarias
{
    [TestFixture]
    public class PruebasUnitarias
    {
        [Test]
        public void PruebaNumeroPar()
        {
            //Arrange
           int numero = 2;

            //Act
            bool resultado = LibreriaMatematica.LibreriaMatematica.EsPar(numero);

            //Assert
            bool expected = true;
            Assert.AreEqual(expected, resultado);

        }
        [Test]
        public void PruebaNumeroPrimo()
        {

            //Arrange
            int numero = 5;

            //Act
            bool resultado = LibreriaMatematica.LibreriaMatematica.EsPrimo(numero);

            //Asert
            bool expected = true;
            Assert.AreEqual(expected, resultado);
        }
    }
}
