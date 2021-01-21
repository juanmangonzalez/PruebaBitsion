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
            this.userBus= userBus;
        }
        public ActionResult Index(PlayListViewModel modelo)
        {
            modelo.AllPlayLists = playListBus.GetAll();
            modelo.Users = userBus.GetAll();
            modelo.Users.Insert(0, new User { Nombre = "[Seleccione]", Id = -1 });
            //ViewBag.Users = modelo.Users;
            return View(modelo);
        }
    }
}