using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using XuanThuLab.Data;
using XuanThuLab.Models;

namespace XuanThuLab.Controllers {

    public class ProductsController : Controller {
        private readonly AppDbContext _context;
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(AppDbContext context, ILogger<ProductsController> logger) {
            _context = context;
            _logger = logger;
        }

        // Hiện thị danh sách sản phẩm, có nút chọn đưa vào giỏ hàng
        // GET: Products
        public IActionResult Index() {
            var products = _context.Products.ToList();
            return View(products);
        }

        /// xóa item trong cart
        [Route("/removecart/{productid:int}", Name = "removecart")]
        public IActionResult RemoveCart([FromRoute] int productid) {
            var cart = GetCartItems();
            var cartitem = cart.Find(p => p.Product.ProductId == productid);
            if(cartitem != null) {
                // Đã tồn tại, tăng thêm 1
                cart.Remove(cartitem);
            }

            SaveCartSession(cart);
            return RedirectToAction(nameof(Cart));
        }

        /// Cập nhật
        [Route("/updatecart", Name = "updatecart")]
        [HttpPost]
        public IActionResult UpdateCart([FromForm] int productid, [FromForm] int quantity) {
            // Cập nhật Cart thay đổi số lượng quantity ...
            var cart = GetCartItems();
            var cartitem = cart.Find(p => p.Product.ProductId == productid);
            if(cartitem != null) {
                // Đã tồn tại, tăng thêm 1
                cartitem.Quanlity = quantity;
            }
            SaveCartSession(cart);
            // Trả về mã thành công (không có nội dung gì - chỉ để Ajax gọi)
            return Ok();
        }

        // Hiện thị giỏ hàng
        [Route("/cart", Name = "cart")]
        public IActionResult Cart() {
            return View(GetCartItems());
        }

        [Route("/checkout")]
        public IActionResult CheckOut() {
            // Xử lý khi đặt hàng
            return View();
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id) {
            if(id == null) {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if(product == null) {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create() {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,Name,Description,Price")] Product product) {
            if(ModelState.IsValid) {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id) {
            if(id == null) {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if(product == null) {
                return NotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,Name,Description,Price")] Product product) {
            if(id != product.ProductId) {
                return NotFound();
            }

            if(ModelState.IsValid) {
                try {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                } catch(DbUpdateConcurrencyException) {
                    if(!ProductExists(product.ProductId)) {
                        return NotFound();
                    } else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id) {
            if(id == null) {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if(product == null) {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id) {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id) {
            return _context.Products.Any(e => e.ProductId == id);
        }

        /// <summary>
        ///
        /// </summary>
        // Key lưu chuỗi json của Cart
        public const string CARTKEY = "cart";

        // Lấy cart từ Session (danh sách CartItem)
        private List<CartItem> GetCartItems() {
            var session = HttpContext.Session;
            string jsoncart = session.GetString(CARTKEY);
            if(jsoncart != null) {
                return JsonConvert.DeserializeObject<List<CartItem>>(jsoncart);
            }
            return new List<CartItem>();
        }

        // Xóa cart khỏi session
        private void ClearCart() {
            var session = HttpContext.Session;
            session.Remove(CARTKEY);
        }

        // Lưu Cart (Danh sách CartItem) vào session
        private void SaveCartSession(List<CartItem> ls) {
            var session = HttpContext.Session;
            string jsoncart = JsonConvert.SerializeObject(ls);
            session.SetString(CARTKEY, jsoncart);
        }

        /// Thêm sản phẩm vào cart
        [Route("addcart/{productid:int}", Name = "addcart")]
        public IActionResult AddToCart([FromRoute] int productid) {
            var product = _context.Products
                .Where(p => p.ProductId == productid)
                .FirstOrDefault();
            if(product == null)
                return NotFound("Không có sản phẩm");

            // Xử lý đưa vào Cart ...
            var cart = GetCartItems();
            var cartitem = cart.Find(p => p.Product.ProductId == productid);
            if(cartitem != null) {
                // Đã tồn tại, tăng thêm 1
                cartitem.Quanlity++;
            } else {
                //  Thêm mới
                cart.Add(new CartItem() { Quanlity = 1, Product = product });
            }

            // Lưu cart vào Session
            SaveCartSession(cart);
            // Chuyển đến trang hiện thị Cart
            return RedirectToAction(nameof(Cart));
        }
    }
}