using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D rig;
    public GameObject gameoverFinal;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rig.velocity = Vector2.up * speed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameoverFinal.SetActive(true);
        Time.timeScale = 0;
    }
}
