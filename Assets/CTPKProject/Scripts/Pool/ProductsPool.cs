using CTPKProject.Scripts.View;
using UnityEngine;
using UnityEngine.Pool;

namespace CTPKProject.Scripts.Pool
{
	public class ProductsPool : MonoBehaviour
	{
		[SerializeField] private ProductView _view;

		private ObjectPool<Factory.IProduct> _pool;

		public ProductsPool()
		{
			_pool = new ObjectPool<Factory.IProduct>(Create, OnGet, OnRelease, OnDestroed);
		}

		private void OnDestroed(Factory.IProduct obj)
		{
			obj.Destroy();
		}

		private void OnRelease(Factory.IProduct obj)
		{
			obj.Hide();
		}

		private void OnGet(Factory.IProduct obj)
		{
			obj.Show();
		}

		private Factory.IProduct Create()
		{
			return Instantiate(_view);
		}

		public Factory.IProduct Get()
		{
			return _pool.Get();
		}

		public void Release(Factory.IProduct obj)
		{
			_pool.Release(obj);
		}
	}
}