namespace ECommercial.Core.CorssCuttingConcerns.Caching
{
    public interface ICacheManager
    {
         T Get<T>(string key);
         void Add(string key,object data,int cacheTimeMinutes);
         bool IsAdded(string key);
         void Remove(string key);
         void Clear();
    }
}