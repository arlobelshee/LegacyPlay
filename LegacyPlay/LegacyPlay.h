#pragma once
#include <string>
#include <vector>

class Proposal;
class Vote;
class ElectionResult;

class Proposal
{
public:
	Proposal(const std::string &content, const std::string &constraints) : Content(content), Constraints(constraints)
	{
	}
	~Proposal() = default;
	Proposal(const Proposal &other) = default;

	std::string Constraints;
	std::string Content;

	ElectionResult AttemptToRatify(std::vector<Vote> votes);
};
