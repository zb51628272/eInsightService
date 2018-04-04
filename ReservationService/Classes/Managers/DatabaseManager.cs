using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ReservationService.Classes.Managers
{
    internal class DatabaseManager
    {
        private readonly string ConnString = "Data Source=QHB-CRMDB012.CENTRALSERVICES.LOCAL;Initial Catalog=eInsightCRM_RedLion_QA;User ID=sadev;Password=QWer1234";

        public DatabaseManager()
        {

        }

        public Customer GetCustomerForReservation(int reservationID)
        {
            string query = $@"SELECT c.CustomerID, c.FirstName, c.LastName
                              FROM dbo.D_CUSTOMER_STAY s WITH (NOLOCK)
                              JOIN dbo.D_CUSTOMER c WITH(NOLOCK) ON c.CustomerID = s.CustomerID
                              WHERE s.SourceStayID = {reservationID}";

            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Customer
                        {
                            CustomerID = reader.GetInt32(0),
                            FirstName = reader.GetString(1),
                            LastName = reader.GetString(2)
                        };
                    }
                }
            }

            return null;
        }
    }
}
