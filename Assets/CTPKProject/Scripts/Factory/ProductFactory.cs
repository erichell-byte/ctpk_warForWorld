using CTPKProject.Scripts.Pool;
using UnityEngine;

namespace CTPKProject.Scripts.Factory
{
	public class ProductFactory : ProductAbstractFactory
	{
		[SerializeField] private ProductsPool _pool;
		
		public override IProduct Create()
		{
			return _pool.Get();
		}
	}
}