using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    public class MainWindowData
    {
        //Holds the data and logic for MainWindowForm
        public Employee MyUser { get; set; }
        DatabaseHandler db = new DatabaseHandler();

        public MainWindowData(Employee user)
        {

            this.MyUser = user;

        }
        
    }
}
