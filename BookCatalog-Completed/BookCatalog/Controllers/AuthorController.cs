﻿
using BookCatalog.Filter;
using BookCatalog.Models;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace BookCatalog.Controllers
{
    [UserFilter]
    public class AuthorController : Controller
    {
        private IAuthorService _authorService;
        private IContactService _contactService;
        private IWebHostEnvironment _hostEnviroment;

        public AuthorController(IAuthorService authorService, IContactService contactService, IWebHostEnvironment hostEnviroment)
        {
            _authorService = authorService;
            _contactService = contactService;
            _hostEnviroment = hostEnviroment;
        }
        
        public IActionResult List(string searchString, int page=1)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                var seFi = _authorService.SearchFilter(searchString);
                return View(seFi.ToPagedList(page, 10));
            }

            var model = _authorService.GetAll().ToList();
            
            return View(model.ToPagedList(page, 5));
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Author author )
        {
            if (author.ID == 0)
            {
                var uzanti = Path.GetExtension(author.LogoFile.FileName);
                var yeniresim = Guid.NewGuid() + uzanti;
                var yer = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/" + yeniresim);

                var stream = new FileStream(yer, FileMode.Create);
                author.LogoFile.CopyTo(stream);

                author.Logo = yeniresim;

                _authorService.Add(author);
            }
            else
            {
                _authorService.Update(author);
            }
            return RedirectToAction("List");
        }

        

        [HttpGet]
        public IActionResult Detail(int id)
        {
            var obj = _authorService.GetById(id);
            return View(obj);
        }

        [HttpPost]
        public IActionResult Detail(Author author)
        {
            try
            {
                _authorService.Update(author);
                return RedirectToAction("List");
            }
            catch (Exception)
            {
                return View("ErrorView");
                throw;
            }
            
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var obj = _authorService.GetById(id);
            return View(obj);
        }

        [HttpPost]
        public IActionResult DeletePost(int id)
        {
            var obj = _authorService.GetById(id);
            try
            {
                obj = _authorService.GetById(id);
                _authorService.Delete(obj);
                return RedirectToAction("List");
            }
            catch (Exception)
            {
                ViewBag.ErrorTitle = $"{obj.Name} rolü kullanılmaktadır.";
                ViewBag.ErrorMessage = $"{obj.Name} yazarına ait kitap olduğu için yazar silinemez. Bu yazarı silmek istiyorsanız, lütfen kitaplardan bu yazarı kaldırın ve ardından silmeyi tekrar deneyin.";
                return View("ErrorView");
                throw;
            }
            
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var authorItem = _authorService.GetById(id);
            if (authorItem == null)
            {
                return RedirectToAction("List", "BookCategory");
            }
            return View(authorItem);
        }

        [HttpPost]
        public IActionResult Edit(Author author)
        {
            var model = _authorService.GetById(author.ID);
            if(author.LogoFile != null)
            {
                var uzanti = Path.GetExtension(author.LogoFile.FileName);
                var yeniresim = Guid.NewGuid() + uzanti;
                var yer = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/" + yeniresim);

                var stream = new FileStream(yer, FileMode.Create);
                author.LogoFile.CopyTo(stream);

                model.Logo = yeniresim;
            }
            

            model.ID = author.ID;
            model.Name = author.Name;
            model.About = author.About;
            _authorService.Update(model);
            return RedirectToAction("List");

        }
    }
}
