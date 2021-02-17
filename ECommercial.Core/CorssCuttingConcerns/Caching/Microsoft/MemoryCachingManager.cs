using System;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Caching.Memory;

namespace ECommercial.Core.CorssCuttingConcerns.Caching.Microsoft
{
    public class MemoryCachingManager : ICacheManager
    {
        protected IMemoryCache Cache{get;set;}
        public MemoryCachingManager(IMemoryCache cache) 
        {
            this.Cache = cache;
               
        }
        public MemoryCachingManager()
        {
            Cache=CreateInstance();
        }
        public IMemoryCache CreateInstance(){
            return new MemoryCache(new MemoryCacheOptions(){ SizeLimit=1024*1024});
        }
        
        public void Add(string key, object data, int cacheTimeMinutes=60)
        {
            if(key!=null && data!=null){
                var entry = Cache.CreateEntry(key);
                entry.Value=data;
                entry.AbsoluteExpirationRelativeToNow=new TimeSpan(cacheTimeMinutes/60,cacheTimeMinutes%60,0);
            }
        }

        public void Clear()
        {
            Cache = CreateInstance();// since .net core, linq queries cant be usable for cache object. So it cant be iterable through all items to remove.
        }

        public T Get<T>(string key)
        {
            return (T)Cache.Get(key);
        }

        public bool IsAdded(string key)
        {
            object x;
            return Cache.TryGetValue(key,out x);
        }

        public void Remove(string key)
        {
            Cache.Remove(key);
        }

    }
}