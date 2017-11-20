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
        public int CapacityUsed { get; set; }
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

        public Boolean UpdateSelfInDB()
        {
            DatabaseHandler db = new DatabaseHandler();
            return db.UpdateRoom(this);
        }

        public override bool Equals(object obj)
        {
            //Compare method for Rooms.
            //Returns false if the object passed is null or not a Room
            if (!(obj is Room) || obj == null) return false;

            Room r = obj as Room;
            if (!r.RoomID.Equals(this.RoomID)) return false;
            if (!r.RoomFunction.Equals(this.RoomFunction)) return false;
            if (r.RoomCapacity != this.RoomCapacity) return false;
            if (r.RoomMaxCapacity != this.RoomMaxCapacity) return false;

            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            if (RoomFunction.Equals("Mottagning") || RoomFunction.Equals("Lab"))
            {
                return $"{RoomID} {DepartmentID}";
            }
            else
            {
                return $"{RoomFunction} {RoomID}. Lediga platser: {AvailableCapacity}";
            }
        }

    }
}

