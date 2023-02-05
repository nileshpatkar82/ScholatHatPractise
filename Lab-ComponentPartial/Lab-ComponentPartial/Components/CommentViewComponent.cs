using Lab_ComponentPartial.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_ComponentPartial.Components
{
    public class CommentViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        
        { 
            HttpClient client = new HttpClient(); 
            ICollection<CommentViewModel> comments = 
                client.GetFromJsonAsync<ICollection<CommentViewModel>>
                ("https://jsonplaceholder.typicode.com/comments?postId=" + id).Result; 
            
            return View("~/views/components/comments.cshtml", comments); 
        }
    }
}
