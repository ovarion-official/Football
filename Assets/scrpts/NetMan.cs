using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetMan : NetworkManager
{

    public GameObject ball;

    public override void OnStartServer()
    {
        ball = Instantiate(spawnPrefabs.Find(prefab => prefab.name == "Ball"));
        NetworkServer.Spawn(ball);
        

    }


}

