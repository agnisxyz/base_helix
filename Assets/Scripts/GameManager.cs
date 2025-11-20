using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] ringPrefabs;
    public int numberOfRings = 3;
    public float ringSpacing = 1.3f;
    public float startYPosition = 20f;

    void Awake()
    {
        SpawnRings();
    }

    void Update()
    {

    }

    private void SpawnRings()
    {
        for (int i = 0; i < numberOfRings; i++)
        {
            // Calculate Y position with spacing
            float yPos = startYPosition - (i * ringSpacing);
            Vector3 spawnPosition = new Vector3(0, yPos, 0);

            // Use the first ring prefab for all spawns (same ring)
            Quaternion randomRotation = Quaternion.Euler(0, Random.Range(0f, 360f), 0);
            GameObject ring = Instantiate(ringPrefabs[0], spawnPosition, randomRotation);
        }
    }
}
