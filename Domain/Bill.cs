using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    /// <summary>
    /// Счет, который будет делиться на участников группы
    /// </summary>
    public class Bill
    {
        public int BillId { get; set; }
        public int GroupId { get; set; }
        /// <summary>
        /// Название счета
        /// </summary>
        public string BillName { get; set; }
        /// <summary>
        /// Сумма по счету
        /// </summary>
        public double BillValue { get; set; }
        /// <summary>
        /// ID контакта, который оплачивает счет
        /// </summary>
        public int PayerContactId { get; set; }
        /// <summary>
        /// Список платежей на участиников группы
        /// </summary>
        public List<Payment> Payments { get; set; }
    }
}
