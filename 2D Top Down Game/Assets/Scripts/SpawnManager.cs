using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] RoadSegments;

    // Start is called before the first frame update
    void Start()
    {
        GenerateRandomSegements();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GenerateRandomSegements()
    {
        float yValue = 19.2f;
        float segmentGap = 0;
        Vector2 spawnPos = new Vector2(0, segmentGap);

        for(int i = 0; i < 13; i++)
        {
            int index = Random.Range(1, 10);
            segmentGap += yValue;
            spawnPos = new Vector2(0, segmentGap);
            Instantiate(RoadSegments[index], spawnPos, RoadSegments[index].transform.rotation);
        }
        segmentGap += yValue;
        spawnPos = new Vector2(0, segmentGap);
        Instantiate(RoadSegments[0], spawnPos, RoadSegments[0].transform.rotation);
    }
}
