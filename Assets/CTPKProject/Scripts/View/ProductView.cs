using UnityEngine;

namespace CTPKProject.Scripts.View
{
	public class ProductView : MonoBehaviour, Factory.IProduct
	{
		public void Show()
		{
			gameObject.SetActive(true);
		}

		public void Hide()
		{
			gameObject.SetActive(false);
		}

		public void Destroy()
		{
			Destroy(gameObject);
		}
	}
}