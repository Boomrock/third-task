using System;
using Abstract.Factory;
using Realized.AbstractFactory.Config;

namespace Realized.Factory.Config
{
    [Serializable]
    public class HerosModel:Model<HerosType>
    {
        
        public HerosType Type;
        public override HerosType GetTypeModel()
        {
            return Type;
        }
    }
}