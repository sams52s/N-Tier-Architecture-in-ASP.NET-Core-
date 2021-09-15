using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	 public class UserService
	{
       
        public static void AddUser(UserModel model)
        {
            var data = AutoMapper.Mapper.Map<UserModel, user>(model);
            UserRepo.AddUser(data);
        }
        public static UserModel GetUser(int id)
        {
            var data = UserRepo.GetUser(id);
            var st = AutoMapper.Mapper.Map<user, UserModel>(data);
            return st;
        }
        public static List<UserModel> GetAllUsers()
        {
            var data = UserRepo.GetAllUsers();
            var st = AutoMapper.Mapper.Map<List<user>, List<UserModel>>(data);
            return st;
        }

        public static List<string> GetUserNames()
        {
            var data = UserRepo.GetUserNames();
            return data;
        }
    }
}
