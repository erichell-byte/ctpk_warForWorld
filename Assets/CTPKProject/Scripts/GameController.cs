
using System;
using UnityEngine;
public class GameController : MonoBehaviour
{
	[SerializeField] private MoneyStorage moneyStorage;
	[SerializeField] private InterfaceController interfaceController;

	public static GameController Instance;

	private void Awake()
	{
		Instance = this;
	}

	private void Start()
	{
		moneyStorage.Money = 100;
	}

	public void AddMoneyChangedListeners(Action<int> newListener)
	{
		moneyStorage.OnMoneyChanged += newListener;
	}

	public void RemoveMoneyChangeListeners(Action<int> newListener)
	{
		moneyStorage.OnMoneyChanged -= newListener;
	}

	public void IncreaseMoney()
	{
		moneyStorage.Money += 1;
	}
	
}