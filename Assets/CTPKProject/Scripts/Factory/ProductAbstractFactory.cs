using UnityEngine;

namespace CTPKProject.Scripts.Factory
{
	public abstract class ProductAbstractFactory : MonoBehaviour
	{
		public abstract IProduct Create();

	}
}