using UnityEngine;

public class BlockSpawner : MonoBehaviour {

	public Transform[] spawnPoints;

	public GameObject blockPrefab;
	public int amountToSpawn = 4;
	public float timeBetweenWaves = 1f;

	private float timeToSpawn = 2f;
	// here we keep time of how the long the game is going
	// then depending on the time to spawn which is 2, it will spawn a block
	// now i made an infiniteloop by looping with time betweenvaes ensuring that blocks keep spawning
	public void Update () {

		if (Time.time >= timeToSpawn)
		{
			SpawnBlocks(); // here we spwan some blocks
			timeToSpawn = Time.time + timeBetweenWaves;
		}

	}

	public void SpawnBlocks ()
	{
		//depending on the length of spawnpoint spawn a block
		//also we ensure that there is a random block that will not spawn so we assign randomindex to a random spwan points
		int randomIndex = Random.Range(0, spawnPoints.Length);

		for (int i = 0; i < spawnPoints.Length; i++) // for each spawn point we will spawn a block prefab
		{
			if (randomIndex != i) // when it is not equal to above spwan a block
			{
				Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity); // here we get the game object we want to spwan
				// we assign i as we want to get all the spwan point 
			}
		}
	}
	
}
