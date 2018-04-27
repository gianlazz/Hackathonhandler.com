﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonManager.PocoModels
{
    class Team
    {
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int PinNumber { get; set; }

        /// <summary>
        /// There could be an issue with this random implementation
        /// if I create a lot of Teams at once then it won't seed properly
        /// as I'd be newing up a Random each time with the same time...
        /// </summary>
        public Team(Random random)
        {
            //Random random = new Random();
            PinNumber = random.Next(0000, 9999);
        }
    }
}
