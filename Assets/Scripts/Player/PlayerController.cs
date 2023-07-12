using Abstract.Factory;
using Realized.AbstractFactory.Config;
using UnityEngine;

namespace Player
{
    public class PlayerController: MonoBehaviour
    {
        private readonly IModel<HerosType> model;
        private readonly PlayerView view;

        public PlayerController(IModel<HerosType> model, PlayerView view)
        {
            this.model = model;
            this.view = view;
        }
        
    }
}