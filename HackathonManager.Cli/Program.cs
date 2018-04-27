﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackathonManager.DIContext;

namespace HackathonManager.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add new mentors to the system:");
            var mentor = new DTO.Mentor();
            Console.WriteLine("Name:");
            mentor.Name = Console.ReadLine();
            Console.WriteLine("Age(accepts integer):");
            mentor.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Description:");
            mentor.Description = Console.ReadLine();
            Console.WriteLine("PhoneNumber:");
            mentor.PhoneNumber = Console.ReadLine();
            mentor.IsAvailable = true;
            mentor.IsPresent = true;

            try
            {
                var db = Context.GetMLabsMongoDbRepo();
                db.Add(mentor);

                var mentorFromDb = db.Single<DTO.Mentor>(x => x.PhoneNumber == mentor.PhoneNumber);

                var SmsService = Context.GetTwilioSmsService();
                Console.WriteLine(SmsService.SendSms(uint.Parse(mentorFromDb.PhoneNumber), Console.ReadLine()));
            }
            catch (Exception)
            {

                throw;
            }

            Console.ReadKey();
        }
    }
}
