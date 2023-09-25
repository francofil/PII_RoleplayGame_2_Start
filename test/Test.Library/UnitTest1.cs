using System.Reflection.PortableExecutable;
using System;
using NUnit.Framework;
using RoleplayGame; // Añade el espacio de nombres necesario aquí

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
            Assert.That(output, Is.EqualTo(expected));
            
        }


        [Test]
        public void DefenseValue_ReturnsNonNegativeValue()
        {
            
            Armor item = new Armor(); 

            int defenseValue = item.DefenseValue();

            Assert.IsTrue(defenseValue >= 0, "DefenseValue should return a non-negative value.");
        }
    }
}