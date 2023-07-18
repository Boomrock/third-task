using System.Collections.Generic;
using Abstract.AbstractCommand;
using Abstract.Factory;
using Player;
using Realized.AbstractFactory.Config;
using Realized.Factory;
using Realized.Factory.Config;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private PlayerManager playerManager;

    // Start is called before the first frame update
    void Start()
    {
        playerManager = gameObject.GetComponent<PlayerManager>();
        playerManager.StepNotify += PlayerStep;
    }

    void PlayerStep()
    {
        Debug.Log("player make a step");
    }
}