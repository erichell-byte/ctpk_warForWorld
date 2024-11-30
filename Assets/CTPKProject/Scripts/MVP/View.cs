using System;
using TMPro;
using UnityEngine;

namespace MVP
{
	public class View : MonoBehaviour
	{
		[SerializeField] private TMP_Text _numberLabel;

		private IDisposable _presenter; 
		
		public event Action Clicked;
		private void Start()
		{
			_presenter = new Presenter(this);
		}

		private void OnDestroy()
		{
			_presenter.Dispose();
		}

		public void UpdateLabel(int value)
		{
			_numberLabel.text = value.ToString();
		}

		public void OnClick()
		{
			Clicked?.Invoke();
		}
	}
}