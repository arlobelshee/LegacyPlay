#include "pch.h"
#include "ElectionResult.h"

ElectionResult ElectionResult::Success(const std::string & content, const std::string & constraints, const std::vector<std::string>& objections)
{
	return ElectionResult();
}

ElectionResult ElectionResult::Failure(const Proposal & proposal, const std::vector<std::string>& objections)
{
	return ElectionResult();
}
