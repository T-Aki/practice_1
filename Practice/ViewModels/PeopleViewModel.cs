using System;
using System.Collections.Generic;
using System.Web;
using Practice.Models;

namespace Practice.ViewModels
{
	public class PeopleViewModel
	{
		public List<Person> People { get; set; }
		public PeopleViewModel()
		{
			People = new List<Person>
			{
				new Person(){Id = 1, Age = 24, BirthDay =  new DateTime(1992,1,1), Gender = GenderEnum.Male, Name = "サンプル太郎", Remarks = "hoge"},
				new Person(){Id = 2, Age = 23, BirthDay =  new DateTime(1993,1,1), Gender = GenderEnum.Female, Name = "ビギナー花子", Remarks = "foo"},
				new Person(){Id = 3, Age = 10, BirthDay =  new DateTime(2007,12,1), Gender = GenderEnum.Male, Name = "テスト次郎", Remarks = "bar"},
				new Person(){Id = 4, Age = 20, BirthDay =  new DateTime(1998,4,1), Gender = GenderEnum.Others, Name = "tim", Remarks = ""}
			};
		}
	}
}