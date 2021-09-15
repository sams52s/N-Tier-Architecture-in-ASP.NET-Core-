using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	public class UserTypeService
	{
        public static List<string> GetUserTypesNames()
        {
            return UserTypeRepo.GetUserTypeNames();
        }
        public static List<UserTypeModel> GeUserTypes()
        {
            var UserTypes = UserTypeRepo.GetUserTypes();
            var data = AutoMapper.Mapper.Map<List<user_types>, List<UserTypeModel>>(UserTypes);
            return data;
        }

    }
}
