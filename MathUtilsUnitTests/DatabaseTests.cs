using Microsoft.Data.SqlClient;

namespace MathUtilsUnitTests
{
    [TestFixture]
    public class DatabaseTests
    {
        private SqlConnection dbConn;
        [SetUp]
        public void SetUp()
        {
            //connection String
            string connectionString = "Server=DESKTOP-OF4115M\\MSSQLSERVER01;Database=MyStore;User Id=sa;Password=12345;TrustServerCertificate=True;";

            dbConn = new SqlConnection(connectionString);
            dbConn.Open();
        }

        //them max time millisecond, neu duration vuot qua max time thi ket qua se fail
        [Test, MaxTime(800)]
        public void TestConnection_IsOpen()
        {
            //Kiem tra xem ket noi co mo thanh cong hay khong
            Assert.That(dbConn.State, Is.EqualTo(System.Data.ConnectionState.Open));
        }

        [TearDown]
        public void TearDown()
        {
            //Dong ket noi sau moi lan kiem thu
            if (dbConn != null && dbConn.State == System.Data.ConnectionState.Open)
            {
                dbConn.Close();
                dbConn.Dispose();
            }
        }


    }
}
