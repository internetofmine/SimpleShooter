using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatSceneManager : MonoBehaviour {

    public StartingPosition playerStartingPosition;

    List<IEntity> playerEntityPool;

    IEntityFactory entityFactory;

	void OnEnable () {
        InitializeEntityFactory();
        InitializePlayerEntityPool();
        InitializePlayer(playerStartingPosition);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void InitializePlayer(StartingPosition playerStartingPosition)
    {
        var playerEntity = entityFactory.CreateEntity();
        playerEntity.SetPosition(playerStartingPosition);
        playerEntityPool.Add(playerEntity);
    }

    private void OnDisable()
    {
        CleanupPlayerEntityPool();
    }

    private void CleanupPlayerEntityPool()
    {
        for(int i = playerEntityPool.Count - 1; i >= 0; i--)
        {
            playerEntityPool[i].Destroy();
        }
    }

    private void InitializePlayerEntityPool()
    {
        playerEntityPool = new List<IEntity>();
    }

    private void InitializeEntityFactory()
    {
        entityFactory = new StartingCubeMockFactory();
    }
}
