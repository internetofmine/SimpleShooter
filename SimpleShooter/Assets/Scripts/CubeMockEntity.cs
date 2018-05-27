using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMockEntity : IEntity
{
    private GameObject entityGameObject;
    public CubeMockEntity(GameObject entityGameObject)
    {
        this.entityGameObject = entityGameObject;
    }

    public void SetPosition(StartingPosition playerStartingPosition)
    {
        entityGameObject.transform.position = new Vector3(playerStartingPosition.positionX, playerStartingPosition.positionY);
    }

    public void Destroy()
    {
        GameObject.Destroy(entityGameObject);
    }
}
