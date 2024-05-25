using System.ComponentModel.DataAnnotations;

namespace DevCard_Project.Models
{
	public class Contact
	{
		[Required(ErrorMessage ="این فیلد اجباری است.")]
		[MinLength(3,ErrorMessage ="حداقل 3 کاراکتر وارد نمایید")]
		[MaxLength(100,ErrorMessage ="حداکثر100 کاراکتر وارد نمایید")]
		public string Name { get; set; }
		[Required(ErrorMessage = "این فیلد اجباری است.")]
		[EmailAddress(ErrorMessage ="مقدار وارد شده ایمیل صحیح نیست")]

		public string Email { get; set; }
		public string Service { get; set; }
		public string Message { get; set; }
	}
}
