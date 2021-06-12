using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeedStore.MediatR.Command;
using WeedStore.MediatR.Query;
using WeedStore.Models.Goods;

namespace WeedStore.Controllers
{
   
    public class ShopController : Controller
    {
        private IMediator _mediator;

        public ShopController(IMediator mediator)
        {
            _mediator = mediator;
        }

       
        [HttpGet]
        public  IActionResult Goods()
        {
            
                var command = new GetGoodsQuery();
                var response = _mediator.Send(command);

                return View(response.Result);
         
            
        }
        [HttpGet]
        public IActionResult Create()
        {
            if (User.IsInRole("admin"))
            {
                return View();
            }
            return NotFound();
        }
        [HttpPost]
     
        public IActionResult Create([FromForm] GoodsModel Goods)
        {
            if (User.IsInRole("admin"))
            {
                var command = new CreateGoodsCommand(Goods);
                _mediator.Send(command);
                return RedirectToAction("Goods", "Shop");
            }
            return NotFound();

        }
        [HttpGet]
            public async Task<IActionResult> Edit(Guid Id)
        {
            var query = new GetSingleGoodsQuery(Id);
            var result = _mediator.Send(query);
           return View(result.Result);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Guid Id,[FromForm] GoodsModel Goods)
        {
            Goods.Id = Id;
            var command = new EditGoodsCommand(Goods);
            await _mediator.Send(command);
            return RedirectToAction("Goods","Shop");
        }
    }
}
