using System;

namespace Payments
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int PaymentAmount { get; set; }
        public int UserId { get; set; }
    }
}
