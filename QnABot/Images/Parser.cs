using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net.Mime;
using System.Security.Cryptography.X509Certificates;

namespace QnABot.Images
{
    public class Parser
    {
        List<ImageProperties> imageData = new List<ImageProperties>();
        public  List<ImageProperties> Images => imageData;

        public Parser()
        {
            Parse();
        }

        public void Parse()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "bigboi300.database.windows.net";
            builder.UserID = "bigboi300";
            builder.Password = "Qawsedyrfx2$";
            builder.InitialCatalog = "CSBot";

            List<object> info = new List<object>();
            
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {

                String sql = "SELECT Number, urlPath, RightAnswer FROM [dbo].[Images]";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ImageProperties images = new ImageProperties
                            {
                                Number = reader.GetInt32(0),
                                url = reader.GetString(1),
                                RightAnswer = reader.GetInt32(2)
                            };
                            imageData.Add( images);
                        }
                    }
                }
            }
        }
    }
}
