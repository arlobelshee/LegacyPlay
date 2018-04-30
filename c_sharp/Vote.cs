namespace c_sharp
{
	public class Vote
	{
		public Vote(Choice choice, string reason)
		{
			Choice = choice;
			Reason = reason;
		}

		public Choice Choice { get; }
		public string Reason { get; }
	}
}