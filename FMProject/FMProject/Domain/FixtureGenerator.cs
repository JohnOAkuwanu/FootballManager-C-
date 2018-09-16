using System;
using System.Collections.Generic;
using System.Linq;



namespace FMProject.Domain
{
    public static class FixtureGenerator
    {

        public static List<List<Tuple<string, string>>> CreateFixtures(List<string> teamNames, bool isDoubleRoundRobin = false)
        {
            const string bye = "BYE";
            var oddTeams = teamNames.Count() % 2 == 1;
            if (oddTeams)
            {
                teamNames.Add(bye);
            }
            var result = new List<List<Tuple<string, string>>>();
            GetRoundRobin(teamNames, result);

            if (oddTeams)
            {
                FilterOutByes(bye, result);
            }

            if (isDoubleRoundRobin)
            {
                DoubleRoundRobin(result);
            }

            return result;
            //This  divides the league into two seperate leagues (one league is for the home team and the other is the away team) where the teams from either league are paired up with a team in the other league
        }


        private static void DoubleRoundRobin(List<List<Tuple<string, string>>> result)
        {
            var roundToBeAdded = new List<List<Tuple<string, string>>>();

            var reverseRound = new List<Tuple<string, string>>();
            foreach (var round in result)
            {
                foreach (var fixture in round)
                {
                    reverseRound.Add(System.Tuple.Create(fixture.Item2, fixture.Item1));
                }

                roundToBeAdded.Add(reverseRound);
            }

            result.AddRange(roundToBeAdded);
            //Round encloses all of the pre generated fixtures for the football season. This generates a new gameweek where a new list of fixtures is generated. A round is taken from the list of pair of string called result. From that round a variable called fixture (enclosing a new form of fixtures) is called and presented. As a new round is generalted 
        }


        private static void GetRoundRobin(List<string> teamNames, List<List<Tuple<string, string>>> result)
        {
            int i = new int();
            for (i = 0; i <= teamNames.Count() - 2; i++)

            {
                var middle = teamNames.Count() / 2;
                var firstPart = teamNames.GetRange(0, middle);
                var rest = teamNames.GetRange(middle, middle);
                rest.Reverse();

                if (i % 2 == 1)
                {
                    var zipResult = Zip(firstPart, rest);
                    result.Add(zipResult);
                }
                else
                {
                    var zipResult = Zip(rest, firstPart);
                    result.Add(zipResult);
                }

                teamNames.Insert(1, teamNames[teamNames.Count() - 1]);
                teamNames.RemoveAt(teamNames.Count() - 1);
                //This generates a list of team names which is counted. Substract two to exclude your fixtures. Divide the remaining teams by 2 to find the middle. They use zip to pair the two teams together and shows whether or not a team is home or away
            }
        }


        private static void FilterOutByes(string bye, List<List<Tuple<string, string>>> result)
        {
            foreach (var round in result)
            {
                var toBeRemoved = new List<Tuple<string, string>>();
                foreach (var fixture in round)
                {
                    if (fixture.Item1 == bye | fixture.Item2 == bye)
                    {
                        toBeRemoved.Add(fixture);
                    }
                }
                foreach (var item in toBeRemoved)
                {
                    round.Remove(item);
                    //This searches through the pre generated fixtures created to look for any rounds where both teams have a bye.
                }
            }

        }

        private static List<Tuple<string, string>> Zip(List<string> listA, List<string> listB)
        {
            int i = new int();
            var result = new List<Tuple<string, string>>();
            for (i = 0; i <= listA.Count - 1; i++)
            {
                result.Add(Tuple.Create(listA[i], listB[i]));
            }
            return result;
            //This pairs the two separate leagues together and generates a new list of tuple (pair of strings)
        }
    }
}

