﻿using resourceEdge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resourceEdge.Domain.Abstracts
{
    public interface IQuestions : GenericInterface<Questions>
    {
        IEnumerable<Questions> GetAllUserQuestion(string userId);
        IEnumerable<Questions> GetAllQuestionsEagerly(string properties);
    }
}