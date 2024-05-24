using DevCard_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevCard_Project.ViewComponents
{
	public class ProjectsViewComponent:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var projects = new List<Project> { 
			
			new Project(1,"تاکسی","درخواست آنلاین برای سفرهای درون شهری","project-1.jpg","snap"),
			new Project(2,"زودفود","تهیه غذای ایرانی و خارجی در سریعترین زمان","project-2.jpg","zodfood"),
			new Project(3,"آموزشگاه","درخواست آموزشگاه آنلاین معتبر با اساتید معتبر ","project-3.jpg","online learn"),
			new Project(4,"فضا پیما","آموزش مهارت های نجوم شناسی و سیارات","project-4.jpg","nasa"),
			
			
			};
			return View("_Projects",projects);
		}
	}
}
