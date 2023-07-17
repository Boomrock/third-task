using System;

namespace Abstract.Factory
{
    public interface IConfig<T> where T : Enum
    {
        public void Init();
        public Model<T> Get(T type);
    }
}