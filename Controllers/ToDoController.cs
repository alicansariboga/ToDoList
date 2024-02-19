using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoList.Data;
using ToDoList.Models;
using ToDoList.ViewModels;

namespace ToDoList.Controllers
{
    public class ToDoController : Controller
    {
        private readonly BaseDbContext _context;

        public ToDoController(BaseDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var todoItems = _context.ToDoItems
                .Include(x => x.Priority)
                .Where(x => !x.IsDeleted) // get filter if IsDeleted=0
                .ToList(); // include to get priority name
            var priorities = _context.Priorities.ToList();

            var viewModel = new ToDoViewModel
            {
                ToDoItems = todoItems,
                Priorities = priorities,
            };

            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Create(string title, string description, int priority)
        {
            var todoItem = new ToDoItem
            {
                Title = title,
                Description = description,
                PriorityID = priority,
                IsDone = false,
                CreateDate = DateTime.Now,
            };
            _context.ToDoItems.Add(todoItem);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult SoftDelete(int id, DateTime deleteDate)
        {
            var todoItem = _context.ToDoItems.FirstOrDefault(x=>x.ItemID == id);
            if(todoItem == null)
            {
                return View("Error");
                //return NotFound();
            }

            todoItem.IsDeleted = true;
            todoItem.DeleteDate= DateTime.Now;

            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Update(int id, string title, string description, int priority, DateTime updateDate)
        {
            var todoItem = _context.ToDoItems.FirstOrDefault(x => x.ItemID == id);
            if (todoItem == null)
            {
                return View("Error");
            }

            todoItem.Title = title;
            todoItem.Description = description;
            todoItem.PriorityID = priority;
            todoItem.UpdateDate = DateTime.Now;

            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        //Completed
        [HttpPost]
        public IActionResult Complete(int id)
        {
            var todoItem = _context.ToDoItems.FirstOrDefault(x => x.ItemID == id);
            if (todoItem == null)
            {
                return View("Error");
            }

            todoItem.IsDone = true;
            todoItem.CompleteDate = DateTime.Now;

            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
