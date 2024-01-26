using ElementFactory.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementFactory.Core.Contracts
{
    public interface IQuestionService
    {
        public Task<Question> LoadQuestion(int id);
    }
}
