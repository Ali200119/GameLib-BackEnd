using System;
using Domain.Models;

namespace Service.ViewModels
{
	public class GameDetailsVM
	{
		public Dictionary<string, string> SectionHeaders { get; set; }
		public Game Game { get; set; }
	}
}