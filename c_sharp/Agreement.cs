namespace c_sharp
{
	public class Agreement
	{
		public Agreement(string content, string constraints)
		{
			Content = content;
			Constraints = constraints;
		}

		public string Content { get; }
		public string Constraints { get; }
	}
}