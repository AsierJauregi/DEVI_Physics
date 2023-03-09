using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public bool isOnGround = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround){
            Debug.Log("Espacio Pulsado");
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * 200);
            isOnGround = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground")){
            isOnGround =  true;
        }        
    }
}
