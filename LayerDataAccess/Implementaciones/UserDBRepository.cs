using LayerDataAccess.Entidades;
using LayerDataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerDataAccess.Implementaciones
{
    public class UserDBRepository : BaseRepository<UserDB, Int32>, IUserDBRepository
    {
        public UserDBRepository(IContext context) : base(context)
        {
        }
    }
}
