using System;

namespace MVP
{
	public class Model
	{
		private int current;

		public event Action OnCurrentChanged;

		public int Current
		{
			get
			{
				return current;
			}

			set
			{
				if (value == current) return;

				current = value;
				OnCurrentChanged?.Invoke();
			}
		}
	}
}