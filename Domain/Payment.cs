using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    /// <summary>
    /// Платеж, который должен выплатить каждый из участиников группы за счет
    /// </summary>
    public class Payment
    {
        public int PaymentId { get; set; }
        public int BillId { get; set; }
        /// <summary>
        /// Сумма по итога разделения счета
        /// </summary>
        public double PaymentValue { get; set; }
        /// <summary>
        /// ID контакта-должника
        /// </summary>
        public int DebtorContactId { get; set; }
       
    }
}
