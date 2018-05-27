using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEntity
{
    void SetPosition(StartingPosition startingPosition);
    void Destroy();
}
