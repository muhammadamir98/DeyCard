using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeyCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;

namespace DeyCard_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Projects>()
            {
                new Projects(1, "mahsa", "chemistery", "project-1.jpg", "tandis"),
                new Projects(2, "muhammad amir", "mathematics", "project-2.jpg", "tandis"),
                new Projects(3, "hooman", "power", "project-3.jpg", "iran"),
                new Projects(4, "mobina", "law", "project-4.jpg", "iran")
            };
            return View("_Projects", projects);
        }
    }
}