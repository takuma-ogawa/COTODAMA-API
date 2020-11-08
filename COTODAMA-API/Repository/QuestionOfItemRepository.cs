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
    public class QuestionOfItemRepository
    {
        public T_QuestionOfItem AddByQuestionName(string questionName, int SortID,int MemberID, int ItemID)
        {
            var question = new T_QuestionOfItem
            {
                QuestionName = questionName,
                SortID = SortID,
                ItemID = ItemID,
                MemberID = MemberID,
                RegisterDateTime = DateTime.UtcNow.AddHours(9),
                EditDateTime = DateTime.UtcNow.AddHours(9),
            };

            return question;
        }

      
    }

    public static class QuestionOfItemRepositoryStatic
    {
        public static T_QuestionOfItem EditByQuestionName(this T_QuestionOfItem question,string questionName)
        {
            question.QuestionName = questionName;
            question.EditDateTime = DateTime.UtcNow.AddHours(9);

            return question;
        }
    }
}