using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using COTODAMA_API.Models;
using COTODAMA_API.ViewModel;

namespace COTODAMA_API.Service
{
    public class SampleService
    {
        private cotodamaEntities db = new cotodamaEntities();


        public bool RegisterSample(T_Sample sample)
        {

            try
            {
                db.T_Sample.Add(sample);

                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
         
        }
    }
}