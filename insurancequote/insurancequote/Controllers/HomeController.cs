using insurancequote.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace insurancequote.Controllers
{
    public class HomeController : Controller
    {
        private readonly string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Quotes;
                                             Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                             TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                             MultiSubnetFailover=False";
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(string FirstName, string LastName,
                                   DateTime? DateOfBirth, string EmailAddress,
                                   int? CarYear, string CarMake, string CarModel,
                                   int? Tickets, bool FullCoverage, bool Dui)
        {
            if (string.IsNullOrEmpty(FirstName) ||
                string.IsNullOrEmpty(LastName) ||
                DateOfBirth == null ||
                string.IsNullOrEmpty(EmailAddress) ||
                CarYear == null ||
                string.IsNullOrEmpty(CarMake) ||
                string.IsNullOrEmpty(CarModel) ||
                Tickets == null)
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {

                string queryString = @"INSERT INTO Quotes (FirstName, LastName, DateOfBirth, EmailAddress, 
                                      CarMake, CarModel, CarYear, Tickets, FullCoverage, Dui, QuoteDate, 
                                      QuoteAmount) VALUES (@FirstName, @LastName, @DateOfBirth, @EmailAddress, 
                                      @CarMake, @CarModel, @CarYear, @Tickets, @FullCoverage, @Dui, 
                                      @QuoteDate, @QuoteAmount)";

                using (var connection = new SqlConnection(connString))
                {
                    
                    var command = new SqlCommand(queryString, connection);
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                    command.Parameters.Add("@DateOfBirth", SqlDbType.DateTime);
                    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);
                    command.Parameters.Add("@CarMake", SqlDbType.VarChar);
                    command.Parameters.Add("@CarModel", SqlDbType.VarChar);
                    command.Parameters.Add("@CarYear", SqlDbType.Int);
                    command.Parameters.Add("@Tickets", SqlDbType.Int);
                    command.Parameters.Add("@FullCoverage", SqlDbType.Bit);
                    command.Parameters.Add("@Dui", SqlDbType.Bit);
                    command.Parameters.Add("@QuoteDate", SqlDbType.DateTime);
                    command.Parameters.Add("@QuoteAmount", SqlDbType.Decimal);

                    command.Parameters["@FirstName"].Value = FirstName;
                    command.Parameters["@LastName"].Value = LastName;
                    if (DateOfBirth.HasValue) command.Parameters["@DateOfBirth"].Value = DateOfBirth;
                    command.Parameters["@EmailAddress"].Value = EmailAddress;
                    command.Parameters["@CarMake"].Value = CarMake;
                    command.Parameters["@CarModel"].Value = CarModel;
                    command.Parameters["@CarYear"].Value = CarYear;
                    command.Parameters["@Tickets"].Value = Tickets;
                    command.Parameters["@FullCoverage"].Value = FullCoverage;
                    command.Parameters["@Dui"].Value = Dui;
                    command.Parameters["@QuoteDate"].Value = DateTime.Now;

                    // Calculate quote amount
                    double? BaseQuote = 50;
                    var age = DateTime.Today.Year - DateOfBirth.Value.Year;
                    if (age < 25 || age > 100) BaseQuote += 25;
                    if (age < 18) BaseQuote += 100;
                    if (CarYear < 2000 || CarYear > 2015) BaseQuote += 25;
                    if (CarMake == "Porsche") BaseQuote += 25;
                    if (CarMake == "Porsche" && CarModel == "911 Carrera") BaseQuote += 25;
                    BaseQuote += Tickets * 10;
                    if (Dui) BaseQuote += (BaseQuote * .25);
                    if (FullCoverage) BaseQuote += (BaseQuote * .50);
                    command.Parameters["@QuoteAmount"].Value = BaseQuote;
                    
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();


                }
                return RedirectToAction("Quote");
            }

        }
        public ActionResult Admin()
        {
            string queryString = @"SELECT Id, FirstName, LastName, DateOfBirth, EmailAddress, CarMake, 
                                 CarModel, CarYear, Tickets, FullCoverage, Dui, QuoteDate, QuoteAmount from Quotes ORDER BY Id DESC";
            var signups = new List<Quote>();

            using (var connection = new SqlConnection(connString))
            {
                var command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read()) 
                {
                    var signup = new Quote();
                    signup.Id = Convert.ToInt32(reader["Id"]);
                    signup.FirstName = reader["FirstName"].ToString();
                    signup.LastName = reader["LastName"].ToString();
                    signup.DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                    signup.EmailAddress = reader["EmailAddress"].ToString();
                    signup.CarMake = reader["CarMake"].ToString();
                    signup.CarModel = reader["CarModel"].ToString();
                    signup.CarYear = Convert.ToInt32(reader["CarYear"]);
                    signup.Tickets = Convert.ToInt32(reader["Tickets"]);
                    signup.FullCoverage = Convert.ToBoolean(reader["FullCoverage"]);
                    signup.Dui = Convert.ToBoolean(reader["Dui"]);
                    signup.QuoteDate = Convert.ToDateTime(reader["QuoteDate"]);
                    signup.QuoteAmount = Convert.ToDecimal(reader["QuoteAmount"]);
                    signups.Add(signup);

                }
            }
            return View(signups);
        }
        public ActionResult Quote()
        {


            string queryString = @"SELECT TOP 1 Id, FirstName, LastName, DateOfBirth, EmailAddress, CarMake, 
                                 CarModel, CarYear, Tickets, FullCoverage, Dui, QuoteDate, QuoteAmount from Quotes ORDER BY Id DESC";
            var signups = new List<Quote>();

            using (var connection = new SqlConnection(connString))
            {
                var command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var signup = new Quote();
                    signup.Id = Convert.ToInt32(reader["Id"]);
                    signup.FirstName = reader["FirstName"].ToString();
                    signup.LastName = reader["LastName"].ToString();
                    signup.DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                    signup.EmailAddress = reader["EmailAddress"].ToString();
                    signup.CarMake = reader["CarMake"].ToString();
                    signup.CarModel = reader["CarModel"].ToString();
                    signup.CarYear = Convert.ToInt32(reader["CarYear"]);
                    signup.Tickets = Convert.ToInt32(reader["Tickets"]);
                    signup.FullCoverage = Convert.ToBoolean(reader["FullCoverage"]);
                    signup.Dui = Convert.ToBoolean(reader["Dui"]);
                    signup.QuoteDate = Convert.ToDateTime(reader["QuoteDate"]);
                    signup.QuoteAmount = Convert.ToDecimal(reader["QuoteAmount"]);
                    signups.Add(signup);

                }

            }
            
            return View(signups);
        }



    }
}