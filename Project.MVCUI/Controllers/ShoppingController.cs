using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Controllers
{
    public class ShoppingController : Controller
    {
        OrderRepository _oRep;
        ProductRepository _pRep;
        CategoryRepository _cRep;
        OrderDetailRepository _odRep;

        public ShoppingController()
        {
            _oRep = new OrderRepository();
            _pRep = new ProductRepository();
            _cRep = new CategoryRepository();
            _odRep = new OrderDetailRepository();
        }
        // GET: Shopping
        public ActionResult ShoppingList()
        {
            return View();
        }
    }
}