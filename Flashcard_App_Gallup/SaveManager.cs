using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Flashcard_App_Gallup
{
	public static class SaveManager
	{
		private static string savePathString = Environment.GetFolderPath
			(Environment.SpecialFolder.CommonApplicationData);
		private static string path = Path.Combine(savePathString, "save.txt");

		public static void SaveData()
		{

		}

		public static void LoadData()
		{

		}
	}
}
