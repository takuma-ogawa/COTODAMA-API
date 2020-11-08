using System;
using System.Collections.Generic;
using System.Linq;
using COTODAMA_API.Models;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Text.RegularExpressions;

namespace COTODAMA_API.Controllers
{
    public class SearchController : ApiController
    {

        private cotodamaEntities db = new cotodamaEntities();

        [HttpGet]
        public IEnumerable<M_Item> GetItems(string SearchWord)
        {
            
            string[] SearchWordArray = SearchWord.Split(' ');

            string SQlString = $"select * from {nameof(M_Item)} where ";

            string CategoryString = "";

            string ItemString = "or ";
            for (var i = 0; i < SearchWordArray.Length; i++)
            {

                bool JapanWordCheck1 = Regex.IsMatch(SearchWordArray[i], @"^\p{IsHiragana}*$");
                bool JapanWordCheck2 = Regex.IsMatch(SearchWordArray[i], @"^\p{IsKatakana}*$");
                bool JapanWordCheck3 = Regex.IsMatch(SearchWordArray[i], @"^\p{IsCJKUnifiedIdeographs}*$");

                string JapanWordConvert = "";
                if(JapanWordCheck1 || JapanWordCheck2 || JapanWordCheck3)
                {
                    JapanWordConvert = "N";
                }

                if (!(i == SearchWordArray.Length-1))
                {

                    ItemString += $"{nameof(M_Item.MemberName)} like {JapanWordConvert}'%{SearchWordArray[i]}%' or ";

                    CategoryString += $"{nameof(M_Category)}.{nameof(M_Category.CategoryName)} like {JapanWordConvert}'%{SearchWordArray[i]}%' or ";


                }
                else
                {
                    ItemString += $"{nameof(M_Item.MemberName)} like {JapanWordConvert}'%{SearchWordArray[i]}%' ";

                    CategoryString += $"{nameof(M_Category)}.{nameof(M_Category.CategoryName)} like {JapanWordConvert}'%{SearchWordArray[i]}%' ";

                }



            }

            CategoryString = $"exists( select * from {nameof(M_Category)} where {nameof(M_Item)}.{nameof(M_Item.CategoryID)} = {nameof(M_Category)}.{nameof(M_Category.CategoryID)} and({CategoryString})) ";

            SQlString += CategoryString + ItemString;

            IEnumerable<M_Item> result = db.M_Item.SqlQuery(SQlString).OrderBy(r => r.MemberName);


            return result;
        }

    }

}

