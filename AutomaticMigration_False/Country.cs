﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticMigration_False
{
    public  class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public ICollection<Team> Teams { get; set; }
    }
}
