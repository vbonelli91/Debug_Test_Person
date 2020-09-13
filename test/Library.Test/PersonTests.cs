using NUnit.Framework;
using System.IO;
using System;
using DEBUG_TEST_PERSON;



namespace Tests
{
    public class Tests
    {
        private Person person;
        private IdUtils id;
        [SetUp]
        
        public void Setup()
        {
           this.person = new Person("Maria Rodriguez","4.679.436-2");

            
        }

        [Test]
        public void validarId() // Cambiá el nombre para indicar qué estás probando
        {   
            person.ID="12";
            Assert.AreEqual(person.ID,"4.679.436-2");

            person.ID="1.391.395-7";
            Assert.AreEqual(person.ID,"1.391.395-7");

         }
        
        [Test]
        public void validarName() // Cambiá el nombre para indicar qué estás probando
        {
            person.Name="";
            Assert.AreEqual(person.Name,"Maria Rodriguez");

         }
            // Insertá tu código  de pruebaaquí
        }
    
}