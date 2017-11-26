using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    public class TestType
    {
        public string TypeID { get; set; }
        public string TypeName { get; set; }


        public TestType(string typeID, string typeName)
        {
            this.TypeID = typeID;
            this.TypeName = typeName;

            //DatabaseHandler db = new DatabaseHandler();

        }

        public override string ToString()
        {
            return $"{TypeID}  -  {TypeName}";
        }

    }
}
