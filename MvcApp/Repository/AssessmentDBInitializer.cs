using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MvcApp.Models;

namespace MvcApp.Repository
{
    public class AssessmentDBInitializer : DropCreateDatabaseAlways<AssessmentContext>
    {
        protected override void Seed(AssessmentContext context)
        {
            IList<Client> Clients = new List<Client>();

            Clients.Add(new Client() { Surname = "Ndlovu", FirstName = "Mike Ndlovu", IDType = "Identity Document ", IdNumber = "8003187373090", DateOfBirth = Convert.ToDateTime("1980-03-18") });
            Clients.Add(new Client() { Surname = "Bloggs", FirstName = "Joe Peter", IDType = "Identity Document ", IdNumber = "7202025074084", DateOfBirth = Convert.ToDateTime("1982-02-02") });

            foreach (Client client in Clients)
                context.Clients.Add(client);

            context.SaveChanges();

        }
    }
}