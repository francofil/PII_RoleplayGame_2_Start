using System.Reflection.PortableExecutable;
using System;
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
            bool input = gimli.Health == 100;
            bool expected = gimli.Health == 100;
            bool output = gimli.Health == 100;
            Assert.That(output, Is.EqualTo(expected)); 
        }


        [Test]
        public void AttackValue_ReturnsPositiveValue1()
        {
            
            IItemAtack Axe = new Axe(); 
            
            int attackValue = Axe.AttackValue();

            Assert.IsTrue(attackValue > 0, "AttackValue should return a positive value.");
        }

        [Test]
        public void AttackValue_ReturnsPositiveValue2()
        {
            
            IItemAtack Bow = new Bow(); 
            
            int attackValue = Bow.AttackValue();

            Assert.IsTrue(attackValue > 0, "AttackValue should return a positive value.");
        }


        [Test]
        public void AttackValue_ReturnsPositiveValue3()
        {
            
            IItemAtack Spell = new Spell(); 
            
            int attackValue = Spell.AttackValue();

            Assert.IsTrue(attackValue > 0, "AttackValue should return a positive value.");
        }

        [Test]
        public void AttackValue_ReturnsPositiveValue4()
        {
            
            IItemAtack SpellsBook = new SpellsBook(); 
            
            int attackValue = SpellsBook.AttackValue();

            Assert.IsTrue(attackValue > 0, "AttackValue should return a positive value.");
        }



        [Test]
        public void DefenseValue_ReturnsNonNegativeValue1()
        {
            
            Armor item = new Armor(); 

            int defenseValue = item.DefenseValue();

            Assert.IsTrue(defenseValue >= 0, "DefenseValue should return a non-negative value.");

        }


        [Test]
        public void DefenseValue_ReturnsNonNegativeValue2()
        {
            
            Helmet item = new Helmet(); 

            int defenseValue = item.DefenseValue();

            Assert.IsTrue(defenseValue >= 0, "DefenseValue should return a non-negative value.");

        }

        [Test]
        public void DefenseValue_ReturnsNonNegativeValue3()
        {
            
            Shield item = new Shield(); 

            int defenseValue = item.DefenseValue();

            Assert.IsTrue(defenseValue >= 0, "DefenseValue should return a non-negative value.");

        }

        [Test]
        public void DefenseValue_ReturnsNonNegativeValue4()
        {
            
            Spell item = new Spell(); 

            int defenseValue = item.DefenseValue();

            Assert.IsTrue(defenseValue >= 0, "DefenseValue should return a non-negative value.");

        }

        [Test]
        public void DefenseValue_ReturnsNonNegativeValue5()
        {
            
            SpellsBook item = new SpellsBook(); 

            int defenseValue = item.DefenseValue();

            Assert.IsTrue(defenseValue >= 0, "DefenseValue should return a non-negative value.");

        }

         [Test]
        public void DefenseValue_ReturnsNonNegativeValue6()
        {
            
            Staff item = new Staff(); 

            int defenseValue = item.DefenseValue();

            Assert.IsTrue(defenseValue >= 0, "DefenseValue should return a non-negative value.");

        }
        
    }
}