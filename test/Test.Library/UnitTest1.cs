using System.Reflection.PortableExecutable;
using NUnit.Framework;
using RoleplayGame;


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
            bool input = 100;
            bool expected = Health==100;
            bool output = Health==100;
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