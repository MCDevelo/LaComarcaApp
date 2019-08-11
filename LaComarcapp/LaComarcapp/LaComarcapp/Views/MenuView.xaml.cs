using LaComarcapp.Models;
using LaComarcapp.Views;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LaComarcapp.Views
{
    public partial class MenuView : ContentPage
    {
        public MenuView()
        {
            InitializeComponent();

            ListViewMenu.ItemsSource = opcionesMenus;
        }

        public List<MenuGrupoModel> opcionesMenus = new List<MenuGrupoModel>
        {
            new MenuGrupoModel("")
            {
               new OpcionesMenuModel
               {
                   ID = 0,
                   Icono = "menu_feed.png",
                   Titulo = "Noticias",
                   TipoVista = typeof(NoticiasView),
                   Visible = true
               },
               new OpcionesMenuModel
               {
                   ID = 1,
                   Icono = "menu_sessions.png",
                   Titulo = "Sesiones",
                   TipoVista = typeof(SesionesView),
                   Visible = true
               },
               new OpcionesMenuModel
               {
                   ID = 2,
                   Icono = "menu_events.png",
                   Titulo = "Eventos",
                   TipoVista = typeof(EventosView),
                   Visible = true
               }

            },
            new MenuGrupoModel("Información")
            {
                new OpcionesMenuModel
               {
                   ID = 0,
                   Icono = "menu_sponsors.png",
                   Titulo = "Patrocinadores",
                   TipoVista = typeof(PatrocinadoresView),
                   Visible = true
               },
               new OpcionesMenuModel
               {
                   ID = 1,
                   Icono = "menu_info.png",
                   Titulo = "Sobre la Comunidad",
                   TipoVista = typeof(SobreView),
                   Visible = true
               },
               new OpcionesMenuModel
               {
                   ID = 2,
                   Icono = "menu_settings.png",
                   Titulo = "Ajustes",
                   TipoVista = typeof(AjustesView),
                   Visible = true
               }
            }
        };
    }
}