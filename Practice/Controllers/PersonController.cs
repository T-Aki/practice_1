using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Practice.Models;
using Practice.ViewModels;

namespace Practice.Controllers
{
	public class PersonController : Controller
	{ 
		public static PeopleViewModel members = new PeopleViewModel();
		public ActionResult Index()
		{
			return View(members);
		}
		public ActionResult Edit(int id)
		{
			Person member = members.People[id - 1];
			return View(member);
		}
		[HttpPost]
		public ActionResult Edit(int id, Person member)
		{
			try
			{
				members.People[id - 1].Age = member.Age;
				members.People[id - 1].BirthDay = member.BirthDay;
				members.People[id - 1].Gender = member.Gender;
				members.People[id - 1].Name = member.Name;
				members.People[id - 1].Remarks = member.Remarks;
				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}
		public ActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Create(Person member)
		{
			try
			{
				members.People.Add(member);
				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}
	}
}
