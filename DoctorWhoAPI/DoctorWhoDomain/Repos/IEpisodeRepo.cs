namespace DoctorWhoDomain.Repos
{
    public interface IEpisodeRepo<T> : IRepo<T> where T : class
    {
        public void AddCompanionToEpisodeAsync(Episode episode, Companion companion);
        public void AddEnemyToEpisodeAsync(Episode episode, Enemy enemy);
    }
}