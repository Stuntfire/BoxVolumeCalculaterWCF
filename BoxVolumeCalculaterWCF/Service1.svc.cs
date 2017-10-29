using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.ModelBinding;

namespace BoxVolumeCalculaterWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        //Connectionstring to the HotelDB-database
        private String databaseString = "Server=tcp:hotelserver01.database.windows.net,1433;Initial Catalog=HotelDB;Persist Security Info=False;User ID=sailor;Password=ZAQ12wsx;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        //Calculates the volume of a triangle
        public double GetVolume(double length, double width, double height)
        {
            double getVolume = length * width * height;

            InsertData(DateTime.Today, "Volume", getVolume, length, width, height);

            return getVolume;
        }

        //Calculates a side in a triangle
        public double GetSide(double volume, double side1, double side2)
        {
            double getSide = volume / (side1 * side2);

            InsertData(DateTime.Now, "Side", volume, getSide, side2, side1);

            return getSide;
        }

        //Insert data to HotelDB-database in the Boxvolume-table
        private void InsertData(DateTime time, string request, double volume, double length, double width, double height)
        {
            string sqlStr = "INSERT INTO Boxvolume (Time, Request, Volume, Length, Width, Height) VALUES(@time, @request, @volume, @length, @width, @height)";

            using (SqlConnection sqlConnection = new SqlConnection(databaseString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand(sqlStr, sqlConnection);

                command.Parameters.AddWithValue("@time", time);
                command.Parameters.AddWithValue("@request", request);
                command.Parameters.AddWithValue("@volume", volume);
                command.Parameters.AddWithValue("@length", length);
                command.Parameters.AddWithValue("@width", width);
                command.Parameters.AddWithValue("@height", height);

                command.ExecuteNonQuery();
            }
        }
    }
}
