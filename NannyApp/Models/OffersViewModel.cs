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
        public NannyOffer NannyOffer { get; set; }
        public ParentOffer ParentOffer { get; set; }
    }
}