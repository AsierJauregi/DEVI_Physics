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
    [SerializeField]
    public float growths = 1;
    [SerializeField]
    public float growthRate = 1.2f;
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
        if(collision.gameObject.layer == LayerMask.NameToLayer("Wall")){
            Debug.Log("Collision con pared");
        }  

        if(collision.gameObject.layer == LayerMask.NameToLayer("Death Tile")){
            Debug.Log("Capsula destruida");
            Destroy(this.gameObject);
        }
        
        
    }
    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Growing Tile"))
            {
                Debug.Log("Capsula agrandada");
                this.transform.localScale = new Vector3( growthRate * growths, growthRate * growths, growthRate * growths);
                growths *= growthRate;
            }
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log("Capsula destruida");
        Destroy(this.gameObject);
    }
}
