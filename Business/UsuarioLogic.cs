using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Business.Logic
{
    public class UsuarioLogic:BusinessLogic
    {
        public Data.Database.UsuarioAdapter usuarioData { get; set; }

        public UsuarioLogic()
        {
            UsuarioLogic usuarioData = new UsuarioLogic();
        }

        public Business.Entities.Usuario GetOne(int id){
            return (usuarioData.GetOne(id));
        }
        public List<Business.Entities.Usuario> GetAll() {
            return (usuarioData.GetAll());
        }

        public void Delete(int id) {
            usuarioData.Delete(id);
        }
        public void Save(Business.Entities.Usuario user) {
            usuarioData.Save(user);
        }
    }
    
    
}
