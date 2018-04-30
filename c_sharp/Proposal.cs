using System.Collections.Generic;
using System.Linq;

namespace c_sharp
{
	public class Proposal
	{
		public Proposal(string content, string constraints)
		{
			Content = content;
			Constraints = constraints;
		}

		public string Constraints { get; }
		public string Content { get; }

		public ElectionResult AttemptToRatify(List<Vote> votes)
		{
			var sum = votes.Select(v => v.Choice == Choice.Approve
					? 1
					: (v.Choice == Choice.Deny ? -1 : 0))
				.Sum();
			var objections = votes
				.Where(v => v.Choice == Choice.Deny)
				.Select(v => v.Reason)
				.ToList();

			if (sum > 0)
			{
				return ElectionResult.Success(Content, Constraints,
					objections);
			}
			return ElectionResult.Failure(this, objections);
		}
	}

	public enum Choice
	{
		Approve,
		Deny,
		Abstain
	}
}
