using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCanos : MonoBehaviour
{
    public GameObject cano;
    public float height;
    public float maxTime = 1f;
    private float time = 0;
    void Start()
    {
        GameObject newcano = Instantiate(cano);
        newcano.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(time > maxTime)
        {
            GameObject newcano = Instantiate(cano);
            newcano.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newcano, 6f);
            time = 0;
        }
        time += Time.deltaTime;
    }
}
