﻿using System.Collections.Generic;

namespace Sqlite.Domain
{
    public class Samurai
    {
        public Samurai()
        {
            Quotes = new HashSet<Quote>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public  int? ClanId  { get; set; }

        public virtual Clan Clan { get; set; }
        public virtual ICollection<Quote> Quotes { get; set; }
    }
}