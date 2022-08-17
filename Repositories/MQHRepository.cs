using Project_Template_SM22_Csharp.Context;
using Project_Template_SM22_Csharp.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Template_SM22_Csharp.Repositories
{
    public class MQHRepository
    {
        private FpolyDBContext _dbContext;

        public MQHRepository()
        {
            _dbContext = new FpolyDBContext();
        }

        public List<MoiQuanHe> GetAll()
        {
            return _dbContext.MoiQuanHes.ToList(); 
        }
    }
}
