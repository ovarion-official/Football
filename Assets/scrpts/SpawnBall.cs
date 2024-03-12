using UnityEngine;
using Mirror;

public class SpawnPoint : NetworkBehaviour 
{

    public GameObject spawnPoint;
    public GameObject objToSpawn;

	void Start () 
    {

        Instantiate(objToSpawn, spawnPoint.transform.position, Quaternion.identity);
        
	}
}
