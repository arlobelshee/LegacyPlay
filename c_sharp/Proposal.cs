using System;
using System.Collections.Generic;

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
			var approvals = 0;
			var denials = 0;
			var objections = new List<string>();
			foreach (var vote in votes)
				switch (vote.Choice)
				{
					case Choice.Approve:
						approvals += 1;
						break;
					case Choice.Deny:
						denials += 1;
						objections.Add(vote.Reason);
						break;
					case Choice.Abstain:
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}
			if (approvals > denials)
				return ElectionResult.Success(Content, Constraints, objections);
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