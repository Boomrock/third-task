using System;
using UnityEngine;

public class EnemyManager: MonoBehaviour
{
    public event Action StepNotify;

    public void Step()
    {
        Debug.Log("враг сделал ход");
        StepNotify?.Invoke();
    }

}
