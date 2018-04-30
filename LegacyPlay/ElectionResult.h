#pragma once
#include <vector>
#include <string>

class Proposal;

class ElectionResult
{
public:
	static ElectionResult Success(const std::string &content, const std::string &constraints, const std::vector<std::string> &objections);
	static ElectionResult Failure(const Proposal &proposal, const std::vector<std::string> &objections);
};

