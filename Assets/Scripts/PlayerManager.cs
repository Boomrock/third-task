using System;
using System.Collections;
using Abstract.Command;
using Realized.AbstractFactory.Config;
using Realized.Command;
using Realized.Factory;
using Realized.Factory.Config;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerManager:MonoBehaviour
{
    public event Action StepNotify; 
    [SerializeField] private  PlayerConfig playerConfig;
    private Invoker playerInvoker;
    private PlayersFactory factoryPlayer;
    private bool isPlayersStep;

    private void Start()
    {
        factoryPlayer = new PlayersFactory(playerConfig);
        var player = factoryPlayer.Create(HerosType.Swordsman);

        playerInvoker = new Invoker();
        playerInvoker.Subscribe(player);
    }

    public void Step()
    {
        isPlayersStep = true;
    }
    void Update()
    {
        if(doStep() && isPlayersStep)
        {
            StepNotify?.Invoke();
            isPlayersStep = false;
        }
    } 
    private ICommand<GameObject> Atack = new AtackCommand();
    private ICommand<GameObject> Defens = new DefensCommand();
    private ICommand<GameObject> MoveToForward = new MoveForwardCommand();
    private ICommand<GameObject> MoveToBack = new MoveBackCommand();
    private ICommand<GameObject> currentCommand;
    bool doStep()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            currentCommand = MoveToBack;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            currentCommand = MoveToForward;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            currentCommand = Atack;
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            currentCommand = Defens;
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            playerInvoker.Undo();
        }
        else
        {
            currentCommand = null;
        }

        if (currentCommand is not null)
        {
            playerInvoker.Execute(currentCommand);
            return true;
        }

        return false;
    }
    
}
