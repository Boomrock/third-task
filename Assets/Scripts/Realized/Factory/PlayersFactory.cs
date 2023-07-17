using System;
using Abstract.Factory;
using Player;
using Realized.AbstractFactory.Config;
using UnityEngine;

namespace Realized.Factory
{
    
    public class PlayersFactory:Factory<HerosType>
    {
        public PlayersFactory(IConfig<HerosType> config) : base(config){}
        
        public override GameObject Create(HerosType type)
        {
            var gameObject = new GameObject("Player");
            var model = config.Get(type);
            var view = gameObject.AddComponent<PlayerView>();
            view.SetParametrs(model);
            var playerController = gameObject.AddComponent<PlayerController>();
            playerController.SetParametrs(model, view);
            return gameObject;
        }
    }
}