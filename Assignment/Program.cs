using Assignment.Interface;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01


            //ICircle myCircle = new Circle(5.0);
            //IRectangle myRectangle = new Rectangle(4.0, 6.0);

            //myCircle.DisplayShapeInfo();      
            //myRectangle.DisplayShapeInfo();  

            #endregion

            #region Q02
            IAuthenticationService authService = new BasicAuthenticationService();

            string username = "admin";
            string password = "1234";
            string role = "Admin";

            bool isAuthenticated = authService.AuthenticateUser(username, password);
            bool isAuthorized = authService.AuthorizeUser(username, role);

            Console.WriteLine($"Authenticated: {isAuthenticated}"); 
            Console.WriteLine($"Authorized: {isAuthorized}");       

            #endregion
        }
    }
}
