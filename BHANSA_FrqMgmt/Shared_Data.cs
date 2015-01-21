using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BHANSA_FrqMgmt
{
    public static class Shared_Data
    {
        public static bool Is_Connected = false;
        
        public static bool Server_Client_Mode_Changed = false;
        
        public static bool New_Distribution_Requested = false;
        
        public static bool Update_Log_Window = false;
        public static bool Update_Main_Data_Display = false;

        public static List<string> Received_Data_List_From_CWP1 = new List<string>();
        public static List<string> Received_Data_List_From_CWP2 = new List<string>();
        public static List<string> Received_Data_List_From_CWP3 = new List<string>();
        
        public static List<string> Received_Data_List_From_Server = new List<string>();

        public static string Last_Data_Out = "";

        public static void Data_To_Distribute(string Data_String)
        {
            Last_Data_Out = Data_String;
        }

        // General Settings
        public static string Position_Name = "N/A";
        public static bool I_Am_Server = true;

    }
}
