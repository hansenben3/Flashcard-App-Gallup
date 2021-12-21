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

		public static void SaveData(string data)
		{
			BinaryFormatter formatter = new BinaryFormatter();
			FileStream stream = new FileStream(path, FileMode.Create);

			formatter.Serialize(stream, data);
			stream.Close();
		}

		public static string LoadData()
		{
			if (File.Exists(path))
			{
				BinaryFormatter formatter = new BinaryFormatter();
				FileStream stream = new FileStream(path, FileMode.Open);

				string data = formatter.Deserialize(stream) as string;

				stream.Close();
				return data;
			}
			else return null;
		}
	}
}
