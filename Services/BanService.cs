using Project_Template_SM22_Csharp.DomainClass;
using Project_Template_SM22_Csharp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Template_SM22_Csharp.Services
{
    public class BanService
    {
        private BanRepositorycs _banRepositorycs;
        //private MQHRepository _mQHRepository;
        List<Ban> _lstBan;

        public BanService()
        {
            _banRepositorycs = new BanRepositorycs();
            //_mQHRepository = new MQHRepository();
            _lstBan = new List<Ban>();
            GetValue();
        }

        public void GetValue()
        {
            _lstBan = _banRepositorycs.GetAll();
        }

       

        public string AddBan(Ban ban)
        {
            if (_banRepositorycs.AddBan(ban))
            {
                GetValue();
                return "Thêm thành công!";
            }
            return "Khong  thành công!";
        }

        public string UpdateBan(Ban ban)
        {
            var x = _banRepositorycs.GetAll().FirstOrDefault(c => c.Ma == ban.Ma);

            if (x == null)
            {
                return "không tìm thấy!";
            }

            if (_banRepositorycs.UpdateBan(ban))
            {
                GetValue();
                return " thành công!";
            }
            return "Khong  thành công!";
        }

        public string DeleteBan(Ban ban)
        {
            var x = _banRepositorycs.GetAll().FirstOrDefault(c => c.Ma == ban.Ma);

            if (x == null)
            {
                return "không tìm thấy!";
            }

            if (_banRepositorycs.DeleteBan(x))
            {
                GetValue();
                return " thành công!";
            }
            return "Khong  thành công!";
        }

        public List<Ban> GetBan()
        {
            return _lstBan;
        }

        public List<Ban> GetBan(Ban input)
        {
            if (input == null) return GetBan();
            return _banRepositorycs.GetAll().Where(c => c.Id == input.Id).ToList();
        }

        public List<Ban> GetBan(string input)
        {
            if (input == null) return GetBan();
            return _banRepositorycs.GetAll().Where(c => c.Ten.ToLower().StartsWith(input.ToLower()) || c.Ma.ToLower().StartsWith(input.ToLower())).ToList();
        }
       /* public List<MoiQuanHe> GetAllMQH()
        {
            return _mQHRepository.GetALl().ToList();
        }*/
    }
}
