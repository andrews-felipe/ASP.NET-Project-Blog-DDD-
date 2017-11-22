using AutoMapper;
using ProjetoBlogDDD.Dominio.Entidades;
using ProjetoBlogDDD.Infra.Data.Repositories;
using ProjetoBlogDDD.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoBlogDDD.MVC.Controllers
{
   public class PostController : Controller
   {
        private readonly PostRepository _postRepository = new PostRepository();
        // GET: Post
        public ActionResult Index()
        {
            var postViewModel = Mapper.Map<IEnumerable<Post>, IEnumerable<PostVM>>(_postRepository.GetAll());
            return View(postViewModel);
        }

        // GET: Post/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Post/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Post/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PostVM post)
        {
            if (ModelState.IsValid)
            {
                var usuarioDomain = Mapper.Map<PostVM, Post>(post);
                _postRepository.Add(usuarioDomain);
                return RedirectToAction("Index");
            }

            return View(post);
        }

        // GET: Post/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Post/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Post/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Post/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
