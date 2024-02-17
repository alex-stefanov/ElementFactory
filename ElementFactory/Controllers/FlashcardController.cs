using ElementFactory.Data;
using ElementFactory.Data.Models;
using ElementFactory.Models.Flashcard;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace ElementFactory.Controllers
{
    public class FlashcardController:Controller
    {
        private readonly ApplicationDbContext data;

        private readonly UserManager<User> userManager;

        public FlashcardController(ApplicationDbContext _data
            ,UserManager<User> _userManager)
        {
            this.data = _data;
            this.userManager = _userManager;
        }

        public async Task<IActionResult> ViewAllFlashcards() 
        {
            var user = await userManager.FindByNameAsync(User.Identity.Name);
            if (user != null)
            {
                var flashcards = user.
                 Flashcards
                 .Where(x=>x.IsActive)
                 .Select(fc => new FlashcardViewModel()
                    {
                      Title = fc.Title,
                      Content = fc.Content,
                    })
                 .ToList();

                return View(flashcards);
            }
            return RedirectToAction("Error");     
        }

        public IActionResult AddFlashcard()
            => View();

        [HttpPost]
        public async Task<IActionResult> AddFlashcard(FlashcardViewModel model)
        {
            var flashcard = new Flashcard()
            {
                Title = model.Title,
                Content = model.Content
            };
            var user = await userManager.FindByNameAsync(User.Identity.Name);
            if(user != null)
            {      
                await data.Flashcards.AddAsync(flashcard);
                user.Flashcards.Add(flashcard);
                await data.SaveChangesAsync();
                return RedirectToAction("ViewAllFlashcards");
            }
            return RedirectToAction("Error");
            
           
        }

        public async Task<IActionResult> EditFlashcard(int id)
        {
            var flashcard = await data.Flashcards.FindAsync(id);
            if(flashcard != null)
            {
                return View(new FlashcardViewModel()
                {
                    Title = flashcard.Title,
                    Content = flashcard.Content,
                });
            }
            return View("Error"); 
        }

        [HttpPost]
        public async Task<IActionResult> EditFlashcard
            (int id, FlashcardViewModel model)
        {
            var flashcard = await data.Flashcards.FindAsync(id);

            if (flashcard != null)
            {
                flashcard.Title = model.Title;
                flashcard.Content = model.Content;
                await data.SaveChangesAsync();
                return RedirectToAction("ViewAllFlashcards");
            }
            return View("Error");      
        }

        [HttpPost]
        public async Task<IActionResult> DeleteFlashcard(int id)
        {
            var flashcard= await data.Flashcards.FindAsync(id);

            if (flashcard != null)
            {
                flashcard.IsActive = false;
                return RedirectToAction("ViewAllFlashcards");
            }
            return View("Error");
        }
    }
}
