using System;
using System.IO;
using UnityEngine;

public class FileSaver : ISaver<PlayerModel>
{
	private string fileName = "gameSave.hcsd";
	
	public void Save(PlayerModel value)
	{
		using var sw = new StreamWriter(Path.Combine(Application.persistentDataPath, fileName));
		sw.WriteLine(value.Health);
		sw.WriteLine(value.Experince);
		sw.WriteLine(value.Apples);
	}

	public PlayerModel Load()
	{
		var  model = new PlayerModel();
		
		using var sr = new StreamReader(Path.Combine(Application.persistentDataPath, fileName));
		while (!sr.EndOfStream)
		{
			model.Health = Convert.ToInt32(sr.ReadLine());
			model.Experince = Convert.ToInt32(sr.ReadLine());
			model.Apples = Convert.ToInt32(sr.ReadLine());
		}

		return model;
	}
}
