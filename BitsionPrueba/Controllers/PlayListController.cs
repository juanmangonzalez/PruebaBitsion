using BitsionPrueba.ViewModels;
using LayerBus;
using LayerBus.Interfaces;
using LayerModel.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BitsionPrueba.Controllers
{
    public class PlayListController : Controller
    {
        private readonly IPlayListBus playListBus;
        private readonly IUserBus userBus;
        // GET: PlayList

        //public PlayListController()
        //{ }
        public PlayListController(IPlayListBus playListBus, IUserBus userBus)
        {
            this.playListBus = playListBus;
            this.userBus = userBus;
        }
        public ActionResult Index(PlayListViewModel modelo)
        {
            try 
            { 
            modelo.AllPlayLists = playListBus.GetAll();
            modelo.Users = userBus.GetAll();
            modelo.Users.Insert(0, new User { Nombre = "[Seleccione]", Id = -1 });
           
            ViewBag.Users = modelo.Users;
            }
            catch (Exception ex)
            {
                modelo.MensajeError = $"Ocurrió un error: {ex.Message}";
            }
            return View(modelo);
        }

        public ActionResult Editar(PlayListViewModel modelo)
        {
            //PlayListViewModel modelo = new PlayListViewModel();
            try
            {
                var id = modelo.IdUsuarioSeleccionado;
                modelo.IdUsuarioSeleccionado = id;
                modelo.NombreUsuario = userBus.GetAll().First(u => u.Id == id).Nombre;
                modelo.PlayListsNoSeguidas = playListBus.GetNoSeguidasByUsuario(id);
                modelo.PlayListsSeguidas = playListBus.GetSeguidasByUsuario(id);
            }
            catch (Exception ex)
            {
                modelo.MensajeError = $"Ocurrió un error: {ex.Message}";
            }
            return View(modelo);
        }
    }
}