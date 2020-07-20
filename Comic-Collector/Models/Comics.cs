using System;
using SQLite;

namespace ComicCollector.Models
{
    [Table("Comics")]
    public class Comics
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public uint Number { get; set; }
        public string Publisher { get; set; }
        public DateTime PubDate { get; set; }
    }
}
