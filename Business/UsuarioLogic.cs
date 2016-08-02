using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class UsuarioLogic : BusinessLogic
    {
        public Data.Database.UsuarioAdapter UsuarioData { get; set; }

        public List<Usuario> GetAll()
        {
          return (UsuarioData.GetAll());   
        }
       public Business.Entities.Usuario GetOne(int id)
        {
            return (UsuarioData.GetOne(id));
        }
        public void Delete(int id)
        {
            UsuarioData.Delete(id);
        }
        public void Save(Business.Entities.Usuario user)
        {
            UsuarioData.Save(user);
        }
        public UsuarioLogic() 
        {
            this.UsuarioData =  new  Data.Database.UsuarioAdapter();
        }
    }
}
