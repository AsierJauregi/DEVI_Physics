using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float speed = 5.0f;
    private float xInput; 
    private float zInput;
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * zInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * xInput);
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.Layer == LayerMask.LayerToName("Wall")){
            Debug.Log("Collision con pared");
        }  

        if(collision.gameObject.Layer == LayerMask.LayerToName("Death Tile")){
            Debug.Log("Capsule destroyed");
            Destroy(this.gameObject);
        }      
    }
}
