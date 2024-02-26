using FootballTournament.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTournament.DAL.Architecture
{
    public class Service : IService
    {
        private readonly Repository _repository;

        public Service(TournamentContext context)
        {
            _repository = new Repository(context);
        }

        public bool AddUniqueTeam(Team team)
        {
            if (IsUniqueTeam(team))
            {
                _repository.Add(team);
                return true;
            }
            return false;
        }
        public void Add(object entity)
        {
            _repository.Add(entity);
        }
        public void Remove(object entity)
        {
            _repository.Delete(entity);
        }

        public void Update(object entity)
        {
            _repository.Update(entity);
        }

        public List<Team> GetAllTeams()
        {
            return _repository.GetAll<Team>();
        }

        public List<Match> GetAllMatches()
        {
            return _repository.GetAll<Match>();
        }

        public List<Player> GetAllPlayers()
        {
            return _repository.GetAll<Player>();
        }

        public void PrintTeam(Team team)
        {
            Console.WriteLine($"Team: {team.Name}, City: {team.City}, Wins: {team.Victories}, Loses: {team.Loses}, Draws: {team.Draws}, Goals: {team.Goals}, Goals Missed: {team.GoalsMissed}");
        }

        public bool IsUniqueTeam(Team team)
        {
            var standings = _repository.GetAll<Team>();
            var exist_standing = standings.FirstOrDefault(s => s.Name == team.Name);

            if (exist_standing == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Team? UniqueFill(string teamName, string teamCity, int victoriesCount, int losesCount, int drawGamesCount, int goals, int goalsMissed)
        {
            var team = new Team
            {
                Name = teamName,
                City = teamCity,
                Victories = victoriesCount,
                Loses = losesCount,
                Draws = drawGamesCount,
                Goals = goals,
                GoalsMissed = goalsMissed
            };

            bool is_unique = IsUniqueTeam(team);

            if (is_unique)
            {
                return team;
            }
            else
            {
                return null;
            }
        }

        public Team? FindTeam(string teamName, string teamCity)
        {
            return _repository.GetAll<Team>().FirstOrDefault(s => s.Name == teamName && s.City == teamCity);
        }

        public Team? FindTeamName(string teamName)
        {
            return _repository.GetAll<Team>().FirstOrDefault(s => s.Name == teamName);
        }

        public Team? FindTeamCity(string teamCity)
        {
            return _repository.GetAll<Team>().FirstOrDefault(s => s.City == teamCity);
        }

        public Team? GetTeamMostVictories()
        {
            return _repository.GetAll<Team>().OrderByDescending(s => s.Victories).FirstOrDefault();
        }

        public Team? GetTeamMostLoses()
        {
            return _repository.GetAll<Team>().OrderByDescending(s => s.Loses).FirstOrDefault();
        }

        public Team? GetTeamMostDrawGames()
        {
            return _repository.GetAll<Team>().OrderByDescending(s => s.Draws).FirstOrDefault();
        }

        public Team? GetTeamMostGoalsScored()
        {
            return _repository.GetAll<Team>().OrderByDescending(s => s.Goals).FirstOrDefault();
        }

        public Team? GetTeamMostGoalsMissed()
        {
            return _repository.GetAll<Team>().OrderByDescending(s => s.GoalsMissed).FirstOrDefault();
        }

        public Dictionary<string, int> GetTeamGoalDifference()
        {
            var goal_difference = new Dictionary<string, int>();

            var teams = _repository.GetAll<Team>();

            foreach (var team in teams)
            {
                goal_difference.Add(team.Name, team.Goals - team.GoalsMissed);
            }

            return goal_difference;
        }
        public Team? GetTeamById(int teamId)
        {
            return _repository.GetById<Team>(teamId);
        }

        public Match? GetMatchById(int matchId)
        {
            return _repository.GetById<Match>(matchId);
        }

        public Player? GetPlayerById(int playerId)
        {
            return _repository.GetById<Player>(playerId);
        }

        public Match? GetMatchByTeamsAndDate(int team1id, int team2id, DateTime date)
        {
            Match? found_match = null;
            foreach (var match in _repository.GetAll<Match>())
            {
                if (match.Team1Id == team1id && match.Team2Id == team2id && match.Date == date)
                {
                    found_match = match;
                }
            }
            return found_match;
        }

        public List<Match>? GetMatchesByDate(DateTime date)
        {
            List<Match> matches = new List<Match>();
            foreach (var match in _repository.GetAll<Match>())
            {
                if (match.Date == date)
                {
                    matches.Add(match);
                }
            }
            return matches.Count != 0 ? matches : null;
        }

        public List<Match>? GetMatchesByTeam(int teamId)
        {
            List<Match> matches = new List<Match>();
            foreach (var match in _repository.GetAll<Match>())
            {
                if (match.Team1Id == teamId || match.Team2Id == teamId)
                {
                    matches.Add(match);
                }
            }
            return matches.Count != 0 ? matches : null;
        }

        public List<Team>? GetTeamsTop3MostPoints()
        {
            var top3TeamsByPoints = _repository.GetAll<Team>()
                .OrderByDescending(s => s.Victories * 3 + s.Draws)
                .Take(3)
                .ToList();
            if (top3TeamsByPoints.Count == 0)
            {
                return null;
            }
            return top3TeamsByPoints;
        }

        public Team? GetTeamMostPoints()
        {
            var topTeamByPoints = _repository.GetAll<Team>()
                .OrderByDescending(s => s.Victories * 3 + s.Draws)
                .FirstOrDefault();
            return topTeamByPoints;
        }

        public List<Team>? GetTeamsTop3LeastPoints()
        {
            var top3TeamsByPoints = _repository.GetAll<Team>()
                .OrderBy(s => s.Victories * 3 + s.Draws)
                .Take(3)
                .ToList();
            if (top3TeamsByPoints.Count == 0)
            {
                return null;
            }
            return top3TeamsByPoints;
        }

        public Team? GetTeamLeastPoints()
        {
            var topTeamByPoints = _repository.GetAll<Team>()
                .OrderBy(s => s.Victories * 3 + s.Draws)
                .FirstOrDefault();
            return topTeamByPoints;
        }
    }
}
