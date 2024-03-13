using UnityEngine;
using Mirror;

public class SpawnPoint : NetworkBehaviour 
{

    public GameObject spawnPoint;
    public GameObject objToSpawn;

	public override void OnStartServer()
    {

        Instantiate(objToSpawn, spawnPoint.transform.position, Quaternion.identity);
        
	}
}
