namespace Domain
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public string ContactDescription { get; set; } = string.Empty;
        /// <summary>
        /// Список групп, в которых состоит контакт
        /// </summary>
        public List<Group> Groups { get; set; }  = new List<Group>();
        /// <summary>
        /// Список долгов контакта по группам
        /// </summary>
        public List<Debt> Debts { get; set; }
    }
}