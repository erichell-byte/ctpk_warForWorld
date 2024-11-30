using System;

namespace MVP
{
	public class Presenter : IDisposable
	{
		private View _view;
		private Model _model;

		public Presenter(View view)
		{
			_view = view;
			_model = new Model();

			_view.Clicked += OnViewClicked;
			_model.OnCurrentChanged += OnCurrentChanged;
		}

		private void OnCurrentChanged()
		{
			_view.UpdateLabel(_model.Current);
		}

		private void OnViewClicked()
		{
			_model.Current++;
		}

		public void Dispose()
		{
			_view.Clicked -= OnViewClicked;
			_model.OnCurrentChanged -= OnCurrentChanged;
		}
	}
}