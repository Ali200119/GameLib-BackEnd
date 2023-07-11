using System;
namespace GameLib.Areas.Admin.ViewModels.Game
{
	public class GameCreateVM
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public string Price { get; set; }
		public string Developer { get; set; }
		public string Publisher { get; set; }
		public bool FavGame { get; set; }
		public bool ForPlayStation { get; set; }
		public bool ForXbox { get; set; }
		public bool ForPC { get; set; }
		public object MyProperty { get; set; }
		public DateTime ReleaseDate { get; set; }
		public string Trailer { get; set; }
		public List<IFormFile> Photos { get; set; }
		public List<int> GamePlatformIdies { get; set; } = new();
		public List<int> GameGenreIdies { get; set; } = new();
	}
}