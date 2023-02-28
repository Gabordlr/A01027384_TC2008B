using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTesting : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject ball;
    [SerializeField] float delay = 1.0f;
    [SerializeField] float dead = 1.0f;
    
    void Start()
    {
        InvokeRepeating("dropBall", 0.5f, delay);

    } 

    // Update is called once per frame
    void Update()
    {
        
    }

    void dropBall()
    {
        Vector3 pos = new Vector3(Random.Range(-5.0f, 5.0f), 6, 0);
        GameObject obj = Instantiate(ball, pos, Quaternion.identity);
        Destroy(obj, dead);
    }
}