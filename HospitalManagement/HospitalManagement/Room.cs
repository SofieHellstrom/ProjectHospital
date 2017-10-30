using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    public class Room
    {
        public string RoomID { get; set; }
        public string RoomFunction { get; set; }
        public int RoomCapacity { get; set; }
        public int RoomMaxCapacity { get; set; }
        public string DepartmentID { get; set; }
        public int CapacityUsed { get; set;  }
        public int AvailableCapacity { get; set; }

        public Room(string id, string function, int cap, int maxCap, string department)
        {
            DatabaseHandler db = new DatabaseHandler();
            this.RoomID = id;
            this.RoomFunction = function;
            this.RoomCapacity = cap;
            this.RoomMaxCapacity = maxCap;
            this.DepartmentID = department;
            this.CapacityUsed = db.LoadRoomNrOfOccupants(id);
            this.AvailableCapacity = RoomCapacity - CapacityUsed;
        }

        public override string ToString()
        {
            return $"{RoomFunction} {RoomID}. Lediga platser: {AvailableCapacity}";
        }

    }
}
