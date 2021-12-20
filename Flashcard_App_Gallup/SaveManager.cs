using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Flashcard_App_Gallup
{
	public static class SaveManager
	{
		public static void SaveData(User user)
		{
			Path path = new Path();
			BinaryFormatter formatter = new BinaryFormatter();
			FileStream stream = new FileStream(path, FileMode.Create);


			formatter.Serialize(stream, data);
			stream.Close();
		}

		public static Data LoadData()
		{
			if (File.Exists(path))
			{
				BinaryFormatter formatter = new BinaryFormatter();
				FileStream stream = new FileStream(path, FileMode.Open);

				UserData data = formatter.Deserialize(stream) as UserData;
				stream.Close();
				return data;
			}
			else
			{
				Debug.LogError("Save file not found in " + path);
				return null;
			}
		}
	}
}
