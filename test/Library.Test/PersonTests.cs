using NUnit.Framework;
using System.IO;
using System;
using DEBUG_TEST_PERSON;



namespace Tests
{
    public class Tests
    {
        private Person person;
        [SetUp]
        
        public void Setup()
        {
            this.person= new Person("John Doe", "1.234.567-8");
            
        }

        [Test]
        public void Person() // Cambiá el nombre para indicar qué estás probando
        {
            using (var sw = new StringWriter())
         {
            Console.SetOut(sw);
            DEBUG_TEST_PERSON.IdUtils(person.ID);

            var result = sw.ToString().Trim();
            Assert.AreEqual(true, result);
         }
            
            // Insertá tu código  de pruebaaquí
        }
    }
}