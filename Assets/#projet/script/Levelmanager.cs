using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelmanager : MonoBehaviour
{
    public GameObject prefab;
    public GameObject position;
    private Vector3 startPosition;
    
    public int numberBall;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = position.transform.position;
        for(int i = 0; i < numberBall; i++){
            GameObject ball = Instantiate(prefab);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
