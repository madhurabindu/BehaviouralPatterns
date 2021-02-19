using System;
using System.Collections;
using System.Data.SqlClient;
using Base.Interface;

namespace Imp.CRMSteps
{
    public class CRMDBHandler : ICRMStep
    {
        private const string SQLInsert = "INSERT INTO {0} (TrackingId, RaisedByEmailId, RequestDescription) VALUES ({1},{2},{3})";
        private const string TableName = "CRM";

        private ICRMStep successor;
        /// <summary>
        /// 
        /// </summary>
        private SqlConnection connection;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbMetadata"></param>
        public CRMDBHandler(Hashtable dbMetadata, ICRMStep next)
        {
            successor = next;
            string connectionString = (string)dbMetadata["connectionString"];
            return;
            // SQL Connection related code
            connection = new SqlConnection(connectionString);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        public void RaiseRequest(CRMData data)
        {
            Console.WriteLine("\nNew Request Raised.. Insert to Database.. ");

            data.CRMStatus = CRMData.Status.New;
            data.DateRaised = DateTime.Now;
            data.TrackingId = "CRM0x00023" + data.OrgDept.Name + "0058";
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = GetSQLCommand(data);
                cmd.Connection = connection;

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch(Exception ex)
            {

            }

            successor?.RaiseRequest(data);
        }

        public CRMData GetStatus(string trackingId)
        {
            CRMData data = GetData(trackingId);

            return data;
        }

        public void EscalateIssue(string trackingId, CRMData data) 
        {
            data = GetData(trackingId);
            successor?.EscalateIssue(trackingId, data);
        }

        private CRMData GetData(string trackingId)
        {
            // Execute SQL Command to fill CMR Data
            return null;
        }

        private string GetSQLCommand(CRMData data)
        {
            // Indicative SQL not real!!
            string sqlCOmmand = string.Format(SQLInsert, TableName, 
                data.TrackingId, 
                data.RaisedByEmail,
                data.RequestDescription);

            return sqlCOmmand;
        }
    }
}
