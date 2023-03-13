using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCircle : MonoBehaviour
{
    private float timer=0;
    public float timeDuration;
    private float spwanTime = 0;
    public GameObject ball;
    void ResetSpwanTime()
    {
        spwanTime = timer + timeDuration;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(spwanTime <= timer)
        {
            Instantiate(ball , transform );
            ResetSpwanTime();
        }
    }
}
