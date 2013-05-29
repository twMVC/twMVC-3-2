using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace MvcApplication1.Models.Services
{
    public class ProductsService
    {
        private NorthwindEntities db = new NorthwindEntities();

        //for Search
        public SearchModel SearchModel { get; set; }
        
        //for pager
        public int PageSize
        {
            get
            {
                return 8;
            }
        }
        public int TotalItemCount
        {
            get
            {
                return GetAll().Count();
            }
        }
        public int CurrentPage { get; set; }


        //for dropdown list
        public List<Categories> GetCategoryList()
        {
            return db.Categories.ToList();
        }
        public List<Suppliers> GetSupplierList()
        {
            return db.Suppliers.ToList();
        }

        //
        // GET: /Products/

        public List<Products> GetList()
        {
            return GetAll()
                            .OrderBy(a => a.ProductID)
                        //.OrderByDescending(a => a.ProductID)
                            .Skip(PageSize * CurrentPage)
                            .Take(PageSize)
                            .ToList();
        }

        private IQueryable<Products> GetAll()
        {
            var data = db.Products.Include("Categories").Include("Suppliers").AsQueryable();

            //for Search
            if (!string.IsNullOrEmpty(SearchModel.Product))
                data = data.Where(a => a.ProductName.Contains(SearchModel.Product));
            if (!string.IsNullOrEmpty(SearchModel.Category))
                data = data.Where(a => a.Categories.CategoryName.Contains(SearchModel.Category));

            return data;
        }

        //
        // GET: /Products/Details/5

        public Products GetSingle(int id)
        {
            Products products = db.Products.Single(p => p.ProductID == id);
            return products;
        }

        //
        // POST: /Products/Create

        public void Create(Products products)
        {
            db.Products.AddObject(products);
            db.SaveChanges();
        }

        //
        // POST: /Products/Edit/5

        public void Edit(Products products)
        {
            db.Products.Attach(products);
            db.ObjectStateManager.ChangeObjectState(products, EntityState.Modified);
            db.SaveChanges();
        }

        //
        // POST: /Products/Delete/5

        public void Delete(int id)
        {
            Products products = db.Products.Single(p => p.ProductID == id);
            db.Products.DeleteObject(products);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}