﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackathonManager.DTO;

namespace HackathonManager
{
    public class SrndMentorCsvDtoConverter
    {
        /* [0] = event
        * [1] = type
        * [2] = lastname
        * [3] = firstname
        * [4] = email
        * [5] = age
        * [6] = promocode
        * [7] = paid
        * [8] = parentname
        * [9] = parentemail
        * [10] = parentphone
        * [11] = parentphonealt
        * [12] = checkedin
        * [13] = created
        */

        public List<Mentor> Parse(string csv)
        {
            var mentors = new List<Mentor>();
            var mentorCsvLines = new List<string>();

            using (var reader = new StringReader(csv))
            {
                for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                {
                    //Skip the first header line
                    if (line.Contains("event"))
                        continue;
                    mentorCsvLines.Add(line);
                }
            }

            foreach (var mentor in mentorCsvLines)
            {
                mentors.Add(new Mentor
                {
                    GuidId = new Guid

                });
            }

            return null;
        }
    }
}
