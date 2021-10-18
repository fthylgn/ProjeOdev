﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IQuestionDal : IGenericDal<Question>
    {
        List<Question> GetAllQuestionByArticleID(int id);

        List<Question> GetAllQuestionWithArticle(int id);
    }
}
