using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField]
    private float force = 5000;
    public GameObject bullet;
    private int raycastTarget;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)){
            GameObject newBullet = Instantiate(bullet);
            newBullet.transform.position = this.gameObject.transform.position;
            newBullet.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
        }
    }
    private void FixedUpdate()
    {
        raycastTarget = 1 << 10;
        raycastTarget = ~raycastTarget;
        RaycastHit hit;

        if (Physics.Raycast(this.gameObject.transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, raycastTarget))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.green);
            Debug.Log("Is hitting Layer " + LayerMask.LayerToName(hit.collider.gameObject.layer));
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
        }
    }
}
