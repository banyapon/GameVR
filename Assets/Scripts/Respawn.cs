using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject enemy;
    float timeElapsed = 0;
    float ItemCycle = 1.0f;

    private void Start()
    {
        ItemCycle = Random.Range(1.0f, 5.0f);
    }

    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > ItemCycle)
        {
            GameObject temp;
            temp = (GameObject)Instantiate(enemy);
            Vector3 pos = temp.transform.position;
            temp.transform.position = new Vector3(Random.Range(-30, 30), Random.Range(0, 10), pos.z);
            timeElapsed -= ItemCycle;
        }
    }

}
