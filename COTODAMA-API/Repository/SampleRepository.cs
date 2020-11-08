using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using COTODAMA_API.Models;
using COTODAMA_API.ViewModel;

namespace COTODAMA_API.Repository
{
    public class SampleRepository
    {

    }

    public static class SampleRepositoryStatic
    {
        public static T_Sample Add(this T_Sample sample)
        {

            sample.RegisterDateTime = DateTime.UtcNow.AddHours(9);
            sample.EditDateTime = DateTime.UtcNow.AddHours(9);


            return sample;
        }

    }

}