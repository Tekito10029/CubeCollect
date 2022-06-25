using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random : MonoBehaviour
{
    public GameObject[] Prefabs;

    private BoxCollider area;

    public int count;

    private List<GameObject> gameObjects = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        area = GetComponent<BoxCollider>();

        for (int i = 0; i < count; i++)
        {
            Spawn();
        }
        area.enabled = false;
    }

    private Vector3 RandomPosition()
    {
        Vector3 basePosition = transform.position;
        Vector3 size = area.size;

        float posX = basePosition.x + UnityEngine.Random.Range(-size.x/2f, size.x / 2f);
        float posY = basePosition.y + UnityEngine.Random.Range(-size.y / 2f, -size.y / 2f);
        float posZ = basePosition.z + UnityEngine.Random.Range(-size.z / 2f, size.z / 2f);

        Vector3 SpawnPos = new Vector3(posX, posY, posZ);

        return SpawnPos;
    }

    private void Spawn()
    {
        int selection = UnityEngine.Random.Range(0, Prefabs.Length);
        GameObject selectedObject = Prefabs[selection];
        Vector3 SpawnPos = RandomPosition();

        GameObject instance = Instantiate(selectedObject, SpawnPos, Quaternion.identity);
        gameObjects.Add(instance);
    }
}
