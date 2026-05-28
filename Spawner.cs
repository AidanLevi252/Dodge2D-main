using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject fallingObjectPrefab;

    float spawnInterval = 1f;
    float timer = 0f;

    void Start()
    {

    }

    void SpawnFallingObject()
    {
        // Generate random horizontal position
        float xPos = Random.Range(-8f, 8f);

        Vector3 spawnPos =
            new Vector3(
                xPos,
                transform.position.y,
                0f
            );

        // Spawn object and store reference
        GameObject fallingObject =
            Instantiate(
                fallingObjectPrefab,
                spawnPos,
                Quaternion.identity
            );

        // Generate random size
        float randomSize =
            Random.Range(0.5f, 1.8f);

        // Apply scale
        fallingObject.transform.localScale =
            Vector3.one * randomSize;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnFallingObject();
            timer = 0f;
        }
    }
}