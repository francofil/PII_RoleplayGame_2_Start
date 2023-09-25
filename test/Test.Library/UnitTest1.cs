using System.Reflection.PortableExecutable;
using System;
namespace RoleplayGame;
using NUnit.Framework;


namespace Test.Library
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Health()
        {
            Dwarf gimli = new Dwarf("Gimli");
            bool input = gimli.Health == 100;
            bool expected = gimli.Health == 100;
            bool output = gimli.Health == 100;
            Assert.AreEqual(output, expected);
            
        }
        [Test]
        public void DefenseValue_ReturnsNonNegativeValue()
        {
            // Arrange
            Item item = new Item(); // Reemplaza 'Item' con tu implementación real si es necesario.

            // Act
            int defenseValue = item.DefenseValue();

            // Assert
            Assert.IsTrue(defenseValue >= 0, "DefenseValue should return a non-negative value.");
        }
    }
}