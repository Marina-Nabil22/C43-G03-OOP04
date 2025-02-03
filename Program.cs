using OOP_04_Assignment.First_Project;
using OOP_04_Assignment.Q_01;
using OOP_04_Assignment.Q_02;
using OOP_04_Assignment.Q_03;
using OOP_04_Assignment.Second_project;
using OOP_04_Assignment.Third_Project;
using System.Security.Cryptography.X509Certificates;

namespace OOP_04_Assignment
{
 
    internal class Program
    {
        public static void print(_3D_Point[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            #region Q1
            //IShape circle = new Circle() { radius=10};
            //circle.DisplayShapeInfo();
            //IShape rec = new Rectangle() { Dim1=10,Dim2=20};
            //rec.DisplayShapeInfo(); 
            #endregion

            #region Q2
            //IAuthenticationService authenticationService=new BasicAuthenticationService();
            //Console.WriteLine( authenticationService.AuthenticateUser("Marina","1223"));
            //Console.WriteLine(authenticationService.AuthorizeUser("Marina", "Developer"));
            //Console.WriteLine(authenticationService.AuthorizeUser("Marina", "HR"));

            #endregion

            #region Q3
            //INotificationService notificationService=new EmailNotificationService();
            //notificationService.SendNotification("Marina", "this is an email");
            //INotificationService notificationService1=new SmsNotificationService();
            //notificationService1.SendNotification("Marina", "this is a SMS");
            //INotificationService notificationService2=new PushNotificationService();
            //notificationService2.SendNotification("Marina", "this is a Notification"); 
            #endregion

            //_3D_Point P1= new _3D_Point();
            //P1.ReadPointFromUser();
            //_3D_Point P2 = new _3D_Point();
            //P2.ReadPointFromUser();


            #region 4.	Try to use  ==
            // not valid >> to use == must overload the opreator == and !=
            //if (P1 == P2)
            //{
            //    Console.WriteLine("Equals");
            //} 
            #endregion

            #region 5.	Define an array of points and sort this array based on X & Y coordinates.
            //int size;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("enter size of array");
            //    flag = int.TryParse(Console.ReadLine(), out size);

            //} while (!flag);
            //_3D_Point[] points = new _3D_Point[size];
            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine("Enter coordinate");
            //    points[i]=_3D_Point.ReadPointFromUser();
            //}
            //print(points);
            //Console.WriteLine("after sort");
            //Array.Sort(points,new _3D_Point());
            //print(points); 
            #endregion


            #region Modify the program so that you do not have to create an instance of class to call the four methods.
            //Console.WriteLine(Maths.Add(1,2));
            //Console.WriteLine(Maths.Subtract(1, 2));
            //Console.WriteLine(Maths.Multiply(1, 2));
            //Console.WriteLine(Maths.Divide(2, 2));


            #endregion


            #region Ask  the user to input their type (Regular, Premium, or Guest).

            //Console.WriteLine("Enter the Type");
            //string? type = Console.ReadLine();

            //User user;
            //if (type == "Regular")
            //   user= new RegularUser();
            //else if (type == "Premium")
            //   user= new PremiumUser();
            //else
            //   user= new GuestUser(); 


            #endregion


            #region Allows the user to input product details (price and quantity).
           
            //Console.WriteLine("Enter price");
            //decimal price = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Enter quantity");
            //int quantity = int.Parse(Console.ReadLine());

            //Discount discount=user.GetDiscount();
            //decimal Disamount = discount.CalculateDiscount(price, quantity);
            //Console.WriteLine(Disamount);

            //Console.WriteLine((price * quantity) - Disamount);
            #endregion
          

        }
    }
}