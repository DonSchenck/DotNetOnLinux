using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Speakr.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Speakr.Controllers
{
    [Route("/submissions")]
    public class SubmissionsController : Controller
    {
        // GET: /<controller>/
        [HttpGet()]
        public IActionResult Index()
        {
            var db = new SubmissionContext();
            return View(db.Submissions);
        }
        // GET: Submissions/Details/5
        [HttpGet("{id}")]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                //return HttpNotFound();
            }

            var _context = new SubmissionContext();
            Submission submission = _context.Submissions.Single(m => m.ID == id);
            if (submission == null)
            {
                //return HttpNotFound();
            }

            return View(submission);
        }

        // GET: Submissions/Create
        [Route("/submissions/create")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Submissions/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Submission submission)
        {
            if (ModelState.IsValid)
            {
                var _context = new SubmissionContext();
                _context.Submissions.Add(submission);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(submission);
        }

        // GET: Submissions/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                //return HttpNotFound();
            }

            var _context = new SubmissionContext();
            Submission submission = _context.Submissions.Single(m => m.ID == id);
            if (submission == null)
            {
                //return HttpNotFound();
            }
            return View(submission);
        }

        // POST: Submissions/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Submission submission)
        {
            if (ModelState.IsValid)
            {
                var _context = new SubmissionContext();
                _context.Update(submission);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(submission);
        }

        // GET: Submissions/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                //return HttpNotFound();
            }

            var _context = new SubmissionContext();
            Submission submission = _context.Submissions.Single(m => m.ID == id);
            if (submission == null)
            {
                //return HttpNotFound();
            }

            return View(submission);
        }

        // POST: Submissions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var _context = new SubmissionContext();
            Submission submission = _context.Submissions.Single(m => m.ID == id);
            _context.Submissions.Remove(submission);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
