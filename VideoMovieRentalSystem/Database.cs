using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace VideoMovieRentalSystem
{
    public class Database
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataAdapter adp;
        private string connstr;

        public Database()
        {
            string s = "Database.mdf";
            string s1 = new Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath;
            for (int i = 0; i < 4; i++)
            {
                s1 = Path.GetDirectoryName(s1);
            }
            s1 = Path.Combine(s1, s);
            if (File.Exists(s1))
            {
                connstr = string.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0};Integrated Security=True", s1);
            }
            else
            {
                connstr = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            }
            conn = new SqlConnection(connstr);
        }

        public string CheckConnection()
        {
            return conn.State.ToString();
        }

        public void AddCustomer(Customer obj)
        {
            string Query = "INSERT INTO [Customer] VALUES (@FirstName, @LastName, @Address, @Phone)";
            cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@FirstName", obj.FirstName);
            cmd.Parameters.AddWithValue("@LastName", obj.LastName);
            cmd.Parameters.AddWithValue("@Address", obj.Address);
            cmd.Parameters.AddWithValue("@Phone", obj.Phone);
            ExecuteNonQuery();
        }

        public void UpdateCustomer(Customer obj)
        {
            string Query = "UPDATE [Customer] SET [FirstName] = @FirstName, [LastName] = @LastName, [Address] = @Address, [Phone] = @Phone WHERE [CustID] = @CustID";
            cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@FirstName", obj.FirstName);
            cmd.Parameters.AddWithValue("@LastName", obj.LastName);
            cmd.Parameters.AddWithValue("@Address", obj.Address);
            cmd.Parameters.AddWithValue("@Phone", obj.Phone);
            cmd.Parameters.AddWithValue("@CustID", obj.CustID);
            ExecuteNonQuery();
        }

        public void DeleteCustomer(string CustID)
        {
            string Query = "DELETE FROM [Customer] WHERE [CustID] = @CustID";
            cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@CustID", CustID);
            ExecuteNonQuery();
        }

        public DataTable GetCustomers()
        {
            string Query = "SELECT * FROM [Customer]";
            cmd = new SqlCommand(Query, conn);
            return Execute();
        }

        public DataTable GetCustomer(string CustID)
        {
            string Query = "SELECT * FROM [Customer] WHERE [CustID] = @CustID";
            cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@CustID", CustID);
            return Execute();
        }

        public DataTable GetBestCustomers()
        {
            string Query = "SELECT *, ISNULL((SELECT COUNT(RMID) FROM RentedMovies WHERE CustIDFK = CustID), 0) AS RentedMovies FROM Customer ORDER BY RentedMovies DESC";
            cmd = new SqlCommand(Query, conn);
            return Execute();
        }

        public void AddMovie(Movie obj)
        {
            string Query = "INSERT INTO [Movies] VALUES (@Rating, @Title, @Year, @Rental_Cost, @Copies, @Plot, @Genre)";
            cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@Rating", obj.Rating);
            cmd.Parameters.AddWithValue("@Title", obj.Title);
            cmd.Parameters.AddWithValue("@Year", obj.Year);
            cmd.Parameters.AddWithValue("@Rental_Cost", obj.Rental_Cost);
            cmd.Parameters.AddWithValue("@Copies", obj.Copies);
            cmd.Parameters.AddWithValue("@Plot", obj.Plot);
            cmd.Parameters.AddWithValue("@Genre", obj.Genre);
            ExecuteNonQuery();
        }

        public void UpdateMovie(Movie obj)
        {
            string Query = "UPDATE [Movies] SET [Rating] = @Rating, [Title] = @Title, [Year] = @Year, [Rental_Cost] = @Rental_Cost, [Copies] = @Copies, [Plot] =  @Plot, [Genre] = @Genre WHERE [MovieID] = @MovieID";
            cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@Rating", obj.Rating);
            cmd.Parameters.AddWithValue("@Title", obj.Title);
            cmd.Parameters.AddWithValue("@Year", obj.Year);
            cmd.Parameters.AddWithValue("@Rental_Cost", obj.Rental_Cost);
            cmd.Parameters.AddWithValue("@Copies", obj.Copies);
            cmd.Parameters.AddWithValue("@Plot", obj.Plot);
            cmd.Parameters.AddWithValue("@Genre", obj.Genre);
            cmd.Parameters.AddWithValue("@MovieID", obj.MovieID);
            ExecuteNonQuery();
        }

        public void DeleteMovie(string MovieID)
        {
            string Query = "DELETE FROM [Movies] WHERE [MovieID] = @MovieID";
            cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@MovieID", MovieID);
            ExecuteNonQuery();
        }

        public DataTable GetMovies()
        {
            string Query = "SELECT * FROM [Movies]";
            cmd = new SqlCommand(Query, conn);
            return Execute();
        }

        public DataTable GetMovie(string MovieId)
        {
            string Query = "SELECT * FROM [Movies] WHERE [MovieID] = @MovieID";
            cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@MovieID", MovieId);
            return Execute();
        }

        public DataTable GetBestMovies()
        {
            string Query = "SELECT *, ISNULL((SELECT COUNT (RMID) FROM RentedMovies WHERE MovieIDFK = MovieID), 0) AS TimesRented FROM Movies ORDER BY TimesRented DESC";
            cmd = new SqlCommand(Query, conn);
            return Execute();
        }

        public void InsertRental(string MovieID, string CustID, string DateRented)
        {
            string Query = "INSERT INTO [RentedMovies] (MovieIDFK, CustIDFK, DateRented) VALUES (@MovieIDFK, @CustIDFK, @DateRented)";
            cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@MovieIDFK", MovieID);
            cmd.Parameters.AddWithValue("@CustIDFK", CustID);
            cmd.Parameters.AddWithValue("@DateRented", DateRented);
            ExecuteNonQuery();
        }

        public void UpdateRental(string DateReturned, string RMID)
        {
            string Query = "UPDATE [RentedMovies] SET [DateReturned] = @DateReturned WHERE [RMID] = @RMID";
            cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@DateReturned", DateReturned);
            cmd.Parameters.AddWithValue("@RMID", RMID);
            ExecuteNonQuery();
        }

        public int GetAvaliableCopies(int MovieID)
        {
            string Query = "SELECT (SELECT Copies FROM Movies WHERE MovieID = @MovieID) - (SELECT ISNULL(COUNT(MovieIDFK), 0) FROM RentedMovies WHERE MovieIDFK = @MovieID AND DateReturned IS NULL)";
            cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@MovieID", MovieID);
            return Convert.ToInt32(Execute().Rows[0][0]);
        }

        public DataTable GetAllPendingRentals()
        {
            string Query = "SELECT RMID, Customer.FirstName, Customer.LastName, Customer.[Address], Movies.Title, Movies.Rental_Cost, RentedMovies.DateRented, RentedMovies.DateReturned FROM RentedMovies INNER JOIN Movies ON RentedMovies.MovieIDFK = Movies.MovieID INNER JOIN Customer ON RentedMovies.CustIDFK = Customer.CustID WHERE RentedMovies.DateReturned IS NULL";
            cmd = new SqlCommand(Query, conn);
            return Execute();
        }

        public void ExecuteNonQuery()
        {
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable Execute()
        {
            DataTable table = new DataTable();
            adp = new SqlDataAdapter(cmd);
            adp.Fill(table);
            return table;
        }
    }
}
