using System;
using System.Collections.Generic;
using System.Text;

namespace LaComarcapp.Models
{
    public class MenuGrupoModel : List<OpcionesMenuModel>
    {
        public string Grupo { set; get; }

        public MenuGrupoModel(string group)
        {
            Grupo = group;
        }
        public static IList<MenuGrupoModel> All { get; set; }
    }
}
