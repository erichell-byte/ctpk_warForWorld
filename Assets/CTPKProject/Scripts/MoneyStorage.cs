
using System;

[Serializable]
public class MoneyStorage
{
	private int money;

	public event Action<int> OnMoneyChanged; 

	public int Money
	{
		get
		{
			return money;
		}

		set
		{
			if (money - value < 0)
				money = 0;
			else
				money = value;
			OnMoneyChanged?.Invoke(money);
		}
	}
}
