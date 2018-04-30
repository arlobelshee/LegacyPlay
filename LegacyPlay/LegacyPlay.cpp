#include "pch.h"
#include "LegacyPlay.h"
#include <vector>
#include <string>
#include "Choice.h"
#include "ElectionResult.h"
#include "Vote.h"

ElectionResult Proposal::AttemptToRatify(std::vector<Vote> votes)
{
	int approvals(0);
	int denials(0);
	std::vector<std::string> objections;
	for each (const Vote &vote in votes)
	{
		switch (vote.Choice)
		{
		case Choice::Approve:
			approvals += 1;
			break;
		case Choice::Deny:
			denials += 1;
			objections.push_back(vote.Reason);
			break;
		case Choice::Abstain:
			break;
		default:
			throw "Impossible";
		}
	}
	if (approvals > denials)
		return ElectionResult::Success(Content, Constraints, objections);
	return ElectionResult::Failure(*this, objections);
}


void computeElection(const Proposal &proposal, const std::vector<Vote> &votes)
{

}
