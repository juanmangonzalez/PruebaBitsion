using LayerBus.Interfaces;
using LayerDataAccess;
using LayerDataAccess.Implementaciones;
using LayerDataAccess.Interfaces;
using LayerModel.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerBus.Implementaciones
{
    public class UserBus : IUserBus
    {
        private readonly IContext context;
        private readonly IUserDBRepository userRepository;

        public UserBus(IContext context)
        {
            this.context = context;
            this.userRepository = new UserDBRepository(context);
        }
        public List<User> GetAll()
        {
            List<User> result = new List<User>();
            var listUserDB =userRepository.GetAll();
            foreach (var usr in listUserDB)
            {
                result.Add(new User
                {
                    Id = usr.Id,
                    Nombre = usr.Nombre
                });
            }
            return result;
        }
    }
}
