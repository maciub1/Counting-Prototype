using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    bool left = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z >= 4)
        {
            left = true;
        }else if(transform.position.z <= -4)
        {
            left = false;
        }
        if (left)
        {
            transform.Translate(-Vector3.forward * Time.deltaTime * speed);
        }
        else
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

    }
}
