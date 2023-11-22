using Users;
using Payments;

namespace ListItems
{
    public class List
    {

        public static void DisplayTransaction()

        {
            List<User> usersList = [
                new () {UserId =1, Name = "Tayo Akinlaja", Email ="jayetayo@gmail.com"},
                new () {UserId =2, Name = "Bayo Olaoluwa", Email ="bayooluwa@gmail.com"},
                new() {UserId =3, Name = "Tayelowa Kennedy", Email ="kennedy@gmail.com"},
                new() {UserId =4, Name = "Kidwaya Oreoluwa", Email ="kidwaya@gmail.com"},
                new() {UserId =5, Name = "Manuwa Bayode", Email ="medudae@gmail.com"},
            ];

            List<Payment> paymentList = [
                    new () {UserId =1, PaymentAmount = 2000000, PaymentId =01},
                    new () {UserId =2, PaymentAmount = 45000, PaymentId =02},
                    new () {UserId =3, PaymentAmount = 455000, PaymentId =03},
            ];

            foreach (var user in usersList)
            {
                foreach (var payment in paymentList)
                {
                    if (user.UserId == payment.UserId)
                    {
                        Console.WriteLine($"{user.Name}, ${payment.PaymentAmount}.00 ");
                    }
                }
            }

        }
    }
}