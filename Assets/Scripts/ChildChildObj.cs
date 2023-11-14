using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildChildObj : ChildObj
{
    protected override void Start()
    {
        base.Start();
        base.spawnedObj.GetComponent<MeshRenderer>().material = base.material;
    }
}
