using Portafolio.Models;

namespace Portafolio.Services
{
    public interface IProjectRepository
    {
        List<Project> GetProjects();
    }
    public class ProjectRepository:IProjectRepository
    {
        public List<Project> GetProjects()
        {
            return new List<Project>() {
            new Project("Amazon", "E-Commerce realizado en AaSP.NET Core", "/Imagenes/amazon.png", "https://amazon.com"),
            new Project("New York Times","Página de noticias en React","/Imagenes/nyt.png","https://nytimes.com"),
            new Project("Reddit","Red social para compartir en comunidades","/Imagenes/reddit.png","https://reddit.com"),
            new Project("Steam","Tienda en línea para comprar videojuegos","/Imagenes/steam.png","https://store.steampowered.com")
            };
        }
    }
}
