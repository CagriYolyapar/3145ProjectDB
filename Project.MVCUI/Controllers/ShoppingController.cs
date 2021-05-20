using PagedList;
using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.MVCUI.VMClasses;
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

        //Sayfalama işlemleri yapmak icin Pagination kütüphanesinden yararlanıyoruz(PagedList)
        public ActionResult ShoppingList(int? page,int? categoryID) //nullable int vermemizin sebebi aslında buradaki int'in sayfa sayımızı temsil edecek olmasıdır...Ancak birisi direkt alısveriş sayfasına ulastıgında sayfa sayısını göndermeyeceginden bu sekilde de Action'in calısabilmesini istiyoruz...
        {

            //string a = "Mehmet";
            //a = null;
            //string b = a??"Cagri"; //Eger a null ise b'ye Cagri at ... null degilse b'ye git a'nın degerini at demektir...
            //page??1

            //Alt tarafta page?? demek page null geliyorsa demektir...
            PAVM pavm = new PAVM
            {
                PagedProducts = categoryID == null? _pRep.GetActives().ToPagedList(page??1,9):_pRep.Where(x=>x.CategoryID==categoryID).ToPagedList(page??1,9),
                Categories = _cRep.GetActives()
            };

            if (categoryID != null) TempData["catID"] = categoryID;

            return View(pavm);
        }
    }
}