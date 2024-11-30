using System;
using TMPro;
using UnityEngine;


namespace MVC
{
	public class View : MonoBehaviour
	{
		[SerializeField] private TMP_Text _numberLabel;
		private Model _model;

		public event Action Clicked;

		public void SetModel(Model model)
		{
			_model = model;
			_model.OnCurrentChanged += UpdateLabel;
			UpdateLabel();
		}

		private void OnDestroy()
		{
			_model.OnCurrentChanged -= UpdateLabel;
		}

		private void UpdateLabel()
		{
			_numberLabel.text = _model.Current.ToString();
		}

		public void OnClick()
		{
			Clicked?.Invoke();
		}
	}
	
	
}