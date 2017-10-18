using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    public class PatientRegistryData
    {
        //Class to store data related to PatientRegistryForm
        public string UserID { get; set; }

        public PatientRegistryData(string user)
        {
            UserID = user;
        }

    }
}
