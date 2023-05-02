using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Group
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public string GroupDescription { get; set; } = string.Empty;
        /// <summary>
        /// Список участиников группы
        /// </summary>
        public List<Contact> Contacts { get; set; } = new List<Contact>();
        /// <summary>
        /// Список счетов
        /// </summary>
        public List<Bill> Bills { get; set; }
        /// <summary>
        /// Общая сумма счетов по группе
        /// </summary>
        public double TotalSum { get; set; }
        /// <summary>
        /// Список кто сколько должен по сумме счетов в группе
        /// </summary>
        public List<Debt> Debts { get; set; }

    }
}