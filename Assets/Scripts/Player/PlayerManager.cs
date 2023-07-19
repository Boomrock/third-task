using System;
using System.Collections;
using Abstract.AbstractCommand;
using Abstract.FSM;
using Realized.AbstractFactory.Config;
using Realized.Factory;
using Realized.Factory.Config;
using Realized.FSM;
using Realized.GameCommand;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public event Action StepNotify;
    [SerializeField] private PlayerConfig playerConfig;
    private History playerHistory;
    private PlayersFactory factoryPlayer;
    private GameObject player;
    private StateMachine stateMachine;

    private void Start()
    {
        factoryPlayer = new PlayersFactory(playerConfig);
        player = factoryPlayer.Create(HerosType.Swordsman);
        playerHistory = new History();
        stateMachine = new StateMachine(new Transition[]
        {
            new Transition(State.IDLE, State.RunOnRight, () => Input.GetKeyDown(KeyCode.D), () =>
            {
                var moveOnRightCommand = new MoveOnRightCommand(playerHistory,
                    player);
                moveOnRightCommand.CommandExecuteNotify += StepNotify;
                moveOnRightCommand.Execute();
                Debug.Log("State.IDLE -> State.RunOnRight");
            }),
            new Transition(State.IDLE, State.RunOnLeft, () => Input.GetKeyDown(KeyCode.A), () =>
            {
                var MoveToBackCommand = new MoveBackCommand(playerHistory,
                    player);
                MoveToBackCommand.CommandExecuteNotify += StepNotify;
                MoveToBackCommand.Execute();
                Debug.Log("State.IDLE -> State.RunOnLeft");
            }),
            new Transition(State.RunOnRight, State.IDLE, () => !Input.anyKeyDown, () =>
            {
                Debug.Log("State.RunOnRight -> State.IDLE");
            }),
            new Transition(State.RunOnLeft, State.IDLE, () => !Input.anyKeyDown, () =>
            {
                Debug.Log("State.RunOnLeft -> State.IDLE");
            })
        });
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            stateMachine.TryTransit(State.RunOnRight);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            stateMachine.TryTransit(State.RunOnLeft);
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            playerHistory.Undo();
        }
        else
        {
            stateMachine.TryTransit(State.IDLE);
        }
    }
    
}
