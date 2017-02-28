using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Web;
using System.ComponentModel;
using System.Reflection;

namespace Practice.Models
{
	public class Person
	{
		[Display(Name = "ID")]
		public int Id { get; set; }

		[Display(Name = "名前")]
		[Required(ErrorMessage = "名前を入力してください")]
		public string Name { get; set; }

		[Display(Name = "年齢")]
		[Range(0,120,ErrorMessage = "0~120の範囲を入力してください")]
		public byte Age { get; set; }

		[Display(Name = "生年月日")]
		[Required(ErrorMessage = "生年月日を入力してください")]
		public DateTime BirthDay { get; set; }

		[Display(Name = "性別")]
		[EnumDataType(typeof(GenderEnum))]
		public GenderEnum Gender { get; set; }

		[Display(Name = "備考")]
		public string Remarks { get; set; }
	}

	public enum GenderEnum
	{
		Male,
		Female,
		Others
	}
	public static class GenderExt
	{
		public static string GetDescription(this GenderEnum value)
		{
			string[] values = { "男性", "女性", "その他" };
			return values[(int)value];
		}
	}
}
