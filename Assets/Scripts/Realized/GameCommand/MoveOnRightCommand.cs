﻿using System;
using Abstract.AbstractCommand;
using UnityEngine;
using UnityEngine.UIElements;

namespace Realized.GameCommand
{
    public class MoveOnRightCommand : Command
    {
        private readonly GameObject gameObject;

        public override event Action CommandExecuteNotify;

        public MoveOnRightCommand(IHistory history, GameObject gameObject) : base(history)
        {
            this.gameObject = gameObject;
        }
        
        public override void Execute()
        {
            var position = gameObject.transform.position;
            gameObject.transform.position = new Vector3(position.x + 1, position.y);
            base.Execute();
            CommandExecuteNotify?.Invoke();
        }

        public override void Cancle()
        {
            var position = gameObject.transform.position;
            gameObject.transform.position = new Vector3(position.x - 1, position.y);
        }
    }
}