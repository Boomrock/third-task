﻿using Abstract.Command;
using UnityEngine;

namespace Realized.Command
{
    public class MoveBackCommand : ICommand<GameObject>
    {
        public GameObject Execute()
        {
            throw new System.NotImplementedException();
        }

        public GameObject Cancle()
        {
            throw new System.NotImplementedException();
        }
    }
}