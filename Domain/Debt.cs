using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    /// <summary>
    /// Общий долг контакта в конкретной группе
    /// </summary>
    public class Debt
    {
        public int DebtId { get; set; }
        public int GroupId { get; set; }
        /// <summary>
        /// ID должника 
        /// </summary>
        public int DebtorContactId { get; set;}
        /// <summary>
        /// Сумма задолженности
        /// </summary>
        public double DebtTotalValue { get; set; }
    }
}
