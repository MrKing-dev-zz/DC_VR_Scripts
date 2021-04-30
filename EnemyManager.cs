using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    //public PlayerHealth playerHealth;       // Reference to the player's heatlh.
    public GameObject enemy;                // The enemy prefab to be spawned.
    public float spawnTime = 3f;            // How long between each spawn.
    public float initDelay = 10f;
    public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
    GameObject[] enemies;
    public int maxEnemies = 30;


    void Start()
    {
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        bool playerexists = (GameObject.FindGameObjectsWithTag("Player") != null);
        if (playerexists = true)
        {
            InvokeRepeating("Spawn", initDelay, spawnTime);

        }
    }


    void Spawn()
    {
        //Populate a list with all of the enemies in the scene.
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        //Run the spawn function only if there are less enemies left in the scene than the maxEnemies specified.
        if (enemies.Length < maxEnemies)
        {
            // Find a random index between zero and one less than the number of spawn points.
            int spawnPointIndex = Random.Range(0, spawnPoints.Length);

            // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
            Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        }
        
    }
}
