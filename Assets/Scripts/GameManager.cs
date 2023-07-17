using System.Collections.Generic;
using Abstract.Command;
using Abstract.Factory;
using Player;
using Realized.AbstractFactory.Config;
using Realized.Command;
using Realized.Factory;
using Realized.Factory.Config;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private IFactory<HerosType> factoryPlayer;
    private IFactory<Enemy> factoryEnemy;
    private Hero player;
    private List<Enemy> Enemies;
    private Invoker playerInvoker;
    private PlayerManager playerManager;
    private EnemyManager enemyManager;

    // Start is called before the first frame update
    void Start()
    {
        playerManager = gameObject.GetComponent<PlayerManager>();
        enemyManager = gameObject.GetComponent<EnemyManager>();
        playerManager.StepNotify += EnemyStep;
        enemyManager.StepNotify += PlayerStep;

        playerManager.Step();
    }

    void EnemyStep()
    {
        enemyManager.Step();
    }

    void PlayerStep()
    {
        playerManager.Step();
    }
}