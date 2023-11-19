using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management_System
{
    public class Leave
    {

        private int employeeId;
        private String leaveType;
        private DateTime start;
        private DateTime end;

        public Leave(int id, String type, DateTime s, DateTime e)
        {
            employeeId = id;
            leaveType = type;
            start = s;
            end = e;

        }
    }

}
