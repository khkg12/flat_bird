using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe;
    public float timediff;
    float timer = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; 
        if (timer > timediff)
        {
            GameObject newPipe = Instantiate(pipe);    
            newPipe.transform.position = new Vector3(5,Random.Range(-2.13f, 4.37f),0);
            timer = 0;
            Destroy(newPipe, 10.0f); 
        }
        
    }
}
