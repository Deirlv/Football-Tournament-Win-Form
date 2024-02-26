using FootballTournament.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTournament.DAL.Architecture
{
    public interface IService
    {
        public bool AddUniqueTeam(Team team);
        public void Add(object entity);
        public void Remove(object entity);

        public void Update(object entity);

        public List<Team> GetAllTeams();

        public List<Match> GetAllMatches();

        public List<Player> GetAllPlayers();

        public void PrintTeam(Team team);

        public bool IsUniqueTeam(Team team);

        public Team? UniqueFill(string teamName, string teamCity, int victoriesCount, int losesCount, int drawGamesCount, int goals, int goalsMissed);

        public Team? FindTeam(string teamName, string teamCity);

        public Team? FindTeamName(string teamName);

        public Team? FindTeamCity(string teamCity);

        public Team? GetTeamMostVictories();

        public Team? GetTeamMostLoses();

        public Team? GetTeamMostDrawGames();

        public Team? GetTeamMostGoalsScored();

        public Team? GetTeamMostGoalsMissed();

        public Dictionary<string, int> GetTeamGoalDifference();
        public Team? GetTeamById(int teamId);

        public Match? GetMatchById(int matchId);

        public Match? GetMatchByTeamsAndDate(int team1id, int team2id, DateTime date);

        public List<Match>? GetMatchesByDate(DateTime date);

        public List<Match>? GetMatchesByTeam(int teamId);

        public List<Team>? GetTeamsTop3MostPoints();

        public Team? GetTeamMostPoints();

        public List<Team>? GetTeamsTop3LeastPoints();

        public Team? GetTeamLeastPoints();
    }
}
