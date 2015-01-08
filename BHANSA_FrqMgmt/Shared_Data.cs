using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BHANSA_FrqMgmt
{
    public static class Shared_Data
    {
        public static bool New_Data_Has_Arrived = false;
        public static List<string> Received_Data_List_From_CWP1 = new List<string>();
        public static List<string> Received_Data_List_From_CWP2 = new List<string>();
        public static List<string> Received_Data_List_From_CWP3 = new List<string>();
        public static List<string> Received_Data_List_From_Server = new List<string>();
    }
}
