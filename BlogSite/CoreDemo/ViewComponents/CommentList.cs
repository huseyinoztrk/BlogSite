﻿using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    public class CommentList: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    UserName="Murat"
                },
                new UserComment
                {
                    ID=2,
                    UserName="Mesut"
                },
                new UserComment
                {
                    ID=3,
                    UserName="Merve"
                }
            };
            return View(commentvalues);
        }
    }
}
