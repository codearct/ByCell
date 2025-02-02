﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Caching
{
    //Generic Cache işlemleri
    public interface ICacheService
    {
        T Get<T>(string key);
        object Get(string key);
        void Add(string key, object data, int duration);
        void Add(string key, object data);
        bool IsAdd(string key);
        void Remove(string key);
        void RemoveByPattern(string pattern);
    }
}
