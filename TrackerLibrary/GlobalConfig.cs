using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig //holds connection information
    {
        // holds everything that implements IDataConnection interface.
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static void InitializedConnections(bool database, bool textFiles)
        {
            if (database)
            {
                // do sth
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }
            if (textFiles)
            {
                //do sth
                TextConnection text = new TextConnection();
                Connections.Add(text);
            }
        }
    }
}
