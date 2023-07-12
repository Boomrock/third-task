using System.Collections;
using System.Collections.Generic;
using Abstract.Factory;
using Player;
using Realized.AbstractFactory.Config;
using Realized.Factory;
using Realized.Factory.Config;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerConfig playerConfig;

    private IFactory<HerosType> factoryPlayer;
    private IFactory<Enemy> factoryEnemy ;
    private Hero player;
    private List<Enemy> Enemies;
     // Start is called before the first frame update
    void Start()
    {
        factoryPlayer = new PlayersFactory(playerConfig);
        var player = factoryPlayer.Create(HerosType.Swordsman);
        Instantiate(player);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
