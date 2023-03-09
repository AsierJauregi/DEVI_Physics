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
        /*if(Input.GetKeyDown(KeyCode.UpArrow)){
            Debug.Log("Flecha Arriba Pulsada");
            );
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            Debug.Log("Flecha Abajo Pulsado");
            transform.position += new Vector3(-1 * speed * Time.deltaTime, 0, 0);
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            Debug.Log("Flecha Izquierda Pulsado");
            transform.position += new Vector3(0, 0, -1 * speed * Time.deltaTime);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            Debug.Log("Flecha Derecha Pulsado");
            transform.position += new Vector3(0, 0, 1 * speed * Time.deltaTime);
        }*/
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * zInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * xInput);
    }
}
