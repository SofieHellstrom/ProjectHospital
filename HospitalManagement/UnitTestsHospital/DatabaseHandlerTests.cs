using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HospitalManagement;

namespace HospitalManagement.Tests
{
    [TestClass]
    public class DatabaseHandlerTests
    {
        [TestMethod]
        public void SinglePatientDatabaseManipulationTest()
        {
            Patient testPatient = new Patient("720524-5033", "Johannes", "Svensson", "Temperaturgatan 51", 41841, "Göteborg", "0768-406023", "none@YourBusiness.com", "B-negativ");
            DatabaseHandler db = new DatabaseHandler();

            bool success = db.AddPatient(testPatient);

            Assert.IsTrue(success);

            Patient testLoadPatient = db.LoadPatient(testPatient.Personnummer);

            Assert.AreEqual(testPatient.FirstName, testLoadPatient.FirstName);
            Patient testNewValuesPatient = new Patient("720524-5033", "Anders", "Svensson", "Temperaturgatan 51", 41841, "Göteborg", "0768-400623", "none@YourBusiness.com", "B-negativ");

            success = db.UpdatePatient(testNewValuesPatient);

            Assert.IsTrue(success);

            testLoadPatient = db.LoadPatient(testPatient.Personnummer);

            Assert.AreEqual(testNewValuesPatient.FirstName, testLoadPatient.FirstName);

            Assert.IsTrue(db.PatientExists(testNewValuesPatient));

            db.DeletePatient(testNewValuesPatient.Personnummer);

            Assert.IsFalse(db.PatientExists(testNewValuesPatient));
        }
    }
}
