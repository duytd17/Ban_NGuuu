using Project_Template_SM22_Csharp.Context;
using Project_Template_SM22_Csharp.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Template_SM22_Csharp.Repositories
{
    public class BanRepositorycs
    {
        private FpolyDBContext _dbContext;
        private List<Ban> _lstBan;

        public BanRepositorycs()
        {
            _dbContext = new FpolyDBContext();
            _lstBan = new List<Ban>();
        }

        public List<Ban> GetAll()
        {
            return _dbContext.Bans.ToList();
        }

        public bool AddBan(Ban ban)
        {
            if (ban == null) return false;
          //  ban.Id = Guid.NewGuid();
            _dbContext.Bans.Add(ban);
            _dbContext.SaveChanges();
            return true;
            
        }
        public bool UpdateBan(Ban ban)
        {
            if (ban == null) return false;
            var temp = _dbContext.Bans.FirstOrDefault(c => c.Ma == ban.Ma);
            temp.Ten = ban.Ten;
            temp.Ma = ban.Ma;
            temp.GioiTinh = ban.GioiTinh;
            temp.TrangThai = ban.TrangThai;
            _dbContext.Bans.Update(temp);
            _dbContext.SaveChanges();
            return true;

        }

        public bool DeleteBan(Ban ban)
        {
            if (ban == null) return false;
            //var temp = _dbContext.Bans.FirstOrDefault(c => c.Id == ban.Id);//xoa theo id
            _dbContext.Bans.Remove(ban);
            _dbContext.SaveChanges();
            return true;

        }
    }
}
