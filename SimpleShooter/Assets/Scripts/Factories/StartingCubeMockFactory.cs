using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingCubeMockFactory : IEntityFactory
{
    private StartingPosition startingPosition;

    public IEntity CreateEntity()
    {
        var newGameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);       
        var newEntity = new CubeMockEntity(newGameObject);
        return newEntity;
    }
}
