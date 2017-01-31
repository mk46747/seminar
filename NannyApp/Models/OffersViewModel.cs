using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NannyApp.Model;
using NannyApp.Model.Repositories;
using NannyApp.Model.Factories;
using NannyApp.DAL;
using NannyApp.DAL.Repositories;
using NHibernate;

namespace NannyApp.Models
{
    public class OffersViewModel
    {
        public int IdOffer { get; set; }
        public Nanny Nanny { get; set; }
        public Parent Parent{ get; set; }
        public double Price { get; set; }
        public string City { get; set; }
        public DateTime Deadline { get; set; }
    }
}