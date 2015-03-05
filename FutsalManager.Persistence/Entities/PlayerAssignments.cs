﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutsalManager.Persistence.Entities
{
    public class PlayerAssignments
    {
        public Guid PlayerId { get; set; }
        public Guid TeamId { get; set; }
        public Guid TournamentId { get; set; }
    }
}
