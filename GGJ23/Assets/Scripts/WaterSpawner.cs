using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSpawner : MonoBehaviour
{
    [SerializeField]
    float timeToSpawn = 10f;

    [SerializeField]
    GameObject waterDropPrefab;

    Vector3 bottomLeft;
    Vector3 topRight;

    float timeElapsed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        bottomLeft = Camera.main.ScreenToWorldPoint(Vector3.zero);
        topRight = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelWidth, Camera.main.pixelHeight));
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > timeToSpawn)
        {
            SpawnWater();
        }
    }

    void SpawnWater()
    {

    }
}
