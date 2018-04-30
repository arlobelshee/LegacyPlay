using System.Collections.Generic;

namespace c_sharp
{
	public class ElectionResult
	{
		public static ElectionResult Success(string content, string constraints, List<string> objections)
		{
			return new SuccessfulElectionResult(new Agreement(content, constraints), objections);
		}

		public static ElectionResult Failure(Proposal proposal, List<string> objections)
		{
			return new FailedElectionResult(proposal, objections);
		}

		public class SuccessfulElectionResult : ElectionResult
		{
			public SuccessfulElectionResult(Agreement agreement, List<string> objections)
			{
				Agreement = agreement;
				Objections = objections;
			}

			public Agreement Agreement { get; }
			public List<string> Objections { get; }
		}

		public class FailedElectionResult : ElectionResult
		{
			public FailedElectionResult(Proposal proposal, List<string> objections)
			{
				Proposal = proposal;
				Objections = objections;
			}

			public Proposal Proposal { get; }
			public List<string> Objections { get; }
		}
	}
}