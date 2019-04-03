using UnityEngine;

public class BlockSpawner : MonoBehaviour {

	public Transform[] spawnPoints;

	public GameObject blockPrefab;
	public int amountToSpawn = 4;
	public float timeBetweenWaves = 1f;

	private float timeToSpawn = 2f;

	public void Update () {

		if (Time.time >= timeToSpawn)
		{
			SpawnBlocks();
			timeToSpawn = Time.time + timeBetweenWaves;
		}

	}

	public void SpawnBlocks ()
	{
		//depending on the length of spawnpoint spawn a block
		//also we ensure that there is a random block that will no spawn
		int randomIndex = Random.Range(0, spawnPoints.Length);

		for (int i = 0; i < spawnPoints.Length; i++)
		{
			if (randomIndex != i)
			{
				Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
			}
		}
	}
	
}
