using System;

namespace NetWork_Food.DB_NetWork_Food.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateTime { get; set; }
    }
}
