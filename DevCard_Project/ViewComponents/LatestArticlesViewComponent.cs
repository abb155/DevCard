using DevCard_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevCard_Project.ViewComponents
{
	public class LatestArticlesViewComponent:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var articles = new List<Article>
			{
				new Article(1,"آموزش سرچ کنسول","برای سئو صحیح صفحات و کسب دانش در مورد مشکلات صفحات وب سایت سایت خود را به سرچ کنسول گوگل متصل می کنیم","blog-post-thumb-card-1.jpg"),
				new Article(2,"آموزش Asp.net","پکیج آموزشی برنامه نویسی بک اند با Asp.net","blog-post-thumb-card-2.jpg"),
				new Article(3,"آموزش جاوا اسکریپت","برای متخصص شدن در وب با یک زبان برنامه نویسی معتبر می توان شروع کرد","blog-post-thumb-card-3.jpg"),
			};
			return View("_LatestArticles",articles);
		}
	}
}
