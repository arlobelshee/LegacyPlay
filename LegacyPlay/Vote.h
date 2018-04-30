#pragma once
#include <string>

enum Choice;

class Vote
{
public:
	Vote(Choice choice, const std::string &reason) : Choice(choice), Reason(reason)
	{
	}
	~Vote() = default;
	Vote(const Vote &other) = default;

	Choice Choice;
	std::string Reason;
};
