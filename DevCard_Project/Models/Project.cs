namespace DevCard_Project.Models
{
	public class Project
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public string Desciption { get; set; }
		public string Image { get; set; }
		public string Client { get; set; }

		public Project(long id, string name, string desciption, string image, string client)
		{
			Id = id;
			Name = name;
			Desciption = desciption;
			Image = image;
			Client = client;
		}
	}
}
