using ElementFactory.Data;
using ElementFactory.Models.Api;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OpenAI_API;

namespace ElementFactory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpenAIController : ControllerBase
    {
        private readonly OpenAIAPI openAiApi;
        private readonly ApplicationDbContext applicationDbContext;
        private readonly IConfiguration configuration;

        public OpenAIController(ApplicationDbContext applicationDbContext, IConfiguration configuration)
        {
            this.configuration = configuration;
            var openAiApiKey = this.configuration["API"];
            APIAuthentication aPIAuthentication = new APIAuthentication(openAiApiKey);
            openAiApi = new OpenAIAPI(aPIAuthentication);
            this.applicationDbContext = applicationDbContext;
        }

        [HttpGet]
        public IActionResult PassAtomicReactionModel()
        {
            var model = new AtomicReactionModel();

            return RedirectToAction("RedirectInfoToView", "Animations", model);
        }

        [Route("api/OpenAI/FillAtomicReactionModel")]
        public async Task<IActionResult> FillAtomicReactionModel([FromForm]AtomicReactionModel model)
        {
            if (model.FirstElement == null || model.SecondElement == null)
            {
                return RedirectToAction("RedirectInfoToView", "Animations", model);
            }

            var conversation = openAiApi.Chat.CreateConversation();
            conversation.AppendSystemMessage(@"You are an university chemistry lecturer and you should give precise answers!
            You will be given two chemical elements and you have to check if they are atoms aka simple elements form the periodic table.
            If only one of them is not a chemical element then give me the answer No, otherwise check if the reaction between them is possible and if it is give me Yes, otherwise No. ");

            conversation.AppendUserInput($"{model.FirstElement} + {model.SecondElement}");

            var response = await conversation.GetResponseFromChatbotAsync();

            if (response.Contains("No"))
            {
                model.FinalReaction = "Невъзможна атомна рекация!";
            }
            else if(response.Contains("Yes"))
            {

                var conversation2 = openAiApi.Chat.CreateConversation();

                conversation2.AppendUserInput($"Only the solved reaction between ({model.FirstElement}) and ({model.SecondElement}) is:");

                response = await conversation2.GetResponseFromChatbotAsync();

                model.FinalReaction = response;

                model.FirstElement = model.FirstElement.Replace("0", "");
                model.FirstElement = model.FirstElement.Replace("1", "");
                model.FirstElement = model.FirstElement.Replace("2", "");
                model.FirstElement = model.FirstElement.Replace("3", "");
                model.FirstElement = model.FirstElement.Replace("4", "");
                model.FirstElement = model.FirstElement.Replace("5", "");
                model.FirstElement = model.FirstElement.Replace("6", "");
                model.FirstElement = model.FirstElement.Replace("7", "");
                model.FirstElement = model.FirstElement.Replace("8", "");
                model.FirstElement = model.FirstElement.Replace("9", "");

                model.SecondElement = model.SecondElement.Replace("0", "");
                model.SecondElement = model.SecondElement.Replace("1", "");
                model.SecondElement = model.SecondElement.Replace("2", "");
                model.SecondElement = model.SecondElement.Replace("3", "");
                model.SecondElement = model.SecondElement.Replace("4", "");
                model.SecondElement = model.SecondElement.Replace("5", "");
                model.SecondElement = model.SecondElement.Replace("6", "");
                model.SecondElement = model.SecondElement.Replace("7", "");
                model.SecondElement = model.SecondElement.Replace("8", "");
                model.SecondElement = model.SecondElement.Replace("9", "");

                var fElement = await applicationDbContext.ChemicalElements.FirstOrDefaultAsync(x => x.Symbol == model.FirstElement);
                model.FirstElementConfig = fElement?.ElectronConfiuration ?? " ";

                var sElement = await applicationDbContext.ChemicalElements.FirstOrDefaultAsync(x => x.Symbol == model.SecondElement);
                model.SecondElementConfig = sElement?.ElectronConfiuration ?? " ";

            }

            return RedirectToAction("DisplayInfoToView", "Animations", model);
        }
    }
}
