using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBall : MonoBehaviour
{
    public GameObject sphere;
    public GameObject position;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Basket"))
        {
            sphere.transform.position = position.transform.position;
            rb = sphere.GetComponent<Rigidbody>();
            rb.velocity = new Vector3(0,0,0);
        }
    }
}
