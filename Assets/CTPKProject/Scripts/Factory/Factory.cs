using UnityEngine;

public abstract class Factory : MonoBehaviour
{
	[SerializeField] protected Enemy enemyPrefab;
	public abstract Enemy CreateEnemy();
}

public interface IProduct
{
	
}

public class EnemyFactory : Factory
{
	public override Enemy CreateEnemy()
	{
		var enemy = Instantiate(enemyPrefab);
		return enemy;
	}
}

public class PropsFactory : Factory
{
	public override Enemy CreateEnemy()
	{
		throw new System.NotImplementedException();
	}
}
