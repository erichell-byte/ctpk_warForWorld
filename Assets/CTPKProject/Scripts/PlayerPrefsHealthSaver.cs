
using UnityEngine;

public class PlayerPrefsHealthSaver : ISaver<float>
{
	private const string HealthKey = "PlayerHealth";
	private const float HealthPoint = 100f;
	
	public void Save(float amount)
	{
		PlayerPrefs.SetFloat(HealthKey, amount);
		PlayerPrefs.Save();
	}

	public float Load()
	{
		return PlayerPrefs.GetFloat(HealthKey, HealthPoint);
	}
}
