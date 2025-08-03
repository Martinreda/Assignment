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
            //IAuthenticationService authService = new BasicAuthenticationService();

            //string username = "admin";
            //string password = "1234";
            //string role = "Admin";

            //bool isAuthenticated = authService.AuthenticateUser(username, password);
            //bool isAuthorized = authService.AuthorizeUser(username, role);

            //Console.WriteLine($"Authenticated: {isAuthenticated}"); 
            //Console.WriteLine($"Authorized: {isAuthorized}");       

            #endregion

            #region Q03
            //string recipient = "user@example.com";
            //string message = "Welcome to our platform!";

            //INotificationService emailService = new EmailNotificationService();
            //INotificationService smsService = new SmsNotificationService();
            //INotificationService pushService = new PushNotificationService();

            //emailService.SendNotification(recipient, message);
            //smsService.SendNotification(recipient, message);
            //pushService.SendNotification(recipient, message);
            #endregion

            #region Q04

            //Discount d1 = new PercentageDiscount(10);
            //Discount d2 = new FlatDiscount(50);
            //Discount d3 = new BuyOneGetOneDiscount();

            //decimal price = 200;
            //int quantity = 3;

            //Console.WriteLine($"{d1.Name}: {d1.CalculateDiscount(price, quantity)}");
            //Console.WriteLine($"{d2.Name}: {d2.CalculateDiscount(price, quantity)}");
            //Console.WriteLine($"{d3.Name}: {d3.CalculateDiscount(price, quantity)}");



            //Part 03 

            //User user1 = new RegularUser("Ahmed");
            //User user2 = new PremiumUser("Sara");
            //User user3 = new GuestUser("Visitor");

            //decimal price = 300;
            //int quantity = 2;

            //Console.WriteLine($"{user1.Name} has {user1.GetDiscount().Name}: Discount = {user1.GetDiscount().CalculateDiscount(price, quantity)}");
            //Console.WriteLine($"{user2.Name} has {user2.GetDiscount().Name}: Discount = {user2.GetDiscount().CalculateDiscount(price, quantity)}");
            //Console.WriteLine($"{user3.Name} has {user3.GetDiscount().Name}: Discount = {user3.GetDiscount().CalculateDiscount(price, quantity)}");


            // Part 04 

            Console.WriteLine("Enter user type (Regular / Premium / Guest):");
            string userType = Console.ReadLine().Trim().ToLower();

            User user;

            switch (userType)
            {
                case "regular":
                    user = new RegularUser("Regular User");
                    break;
                case "premium":
                    user = new PremiumUser("Premium User");
                    break;
                case "guest":
                    user = new GuestUser("Guest User");
                    break;
                default:
                    Console.WriteLine("Invalid user type.");
                    return;
            }

            Console.Write("Enter product price: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal price) || price < 0)
            {
                Console.WriteLine("Invalid price.");
                return;
            }

            Console.Write("Enter quantity: ");
            if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity <= 0)
            {
                Console.WriteLine("Invalid quantity.");
                return;
            }

            Discount discount = user.GetDiscount();
            decimal discountAmount = discount.CalculateDiscount(price, quantity);
            decimal totalPrice = price * quantity;
            decimal finalPrice = totalPrice - discountAmount;

            Console.WriteLine($"\nUser Type: {user.GetType().Name}");
            Console.WriteLine($"Discount Type: {discount.Name}");
            Console.WriteLine($"Total Price Before Discount: ${totalPrice}");
            Console.WriteLine($"Discount Amount: ${discountAmount}");
            Console.WriteLine($"Final Price After Discount: ${finalPrice}");
            #endregion
        }
    }
}
