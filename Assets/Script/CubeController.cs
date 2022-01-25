using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 5;
    public float scale = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //Cube Rotation
            if (Input.GetKey("left"))
            {
                transform.Rotate(0, 3, 0);
            }
            if (Input.GetKey("right"))
            {
                transform.Rotate(0, -3, 0);
            }
        //Cube Size OR Scale Increase
        if (Input.GetKey(KeyCode.Space))
        {
            transform.localScale = transform.localScale + new Vector3(scale, scale, scale);
        }
        else if(transform.localScale.x > 1 && transform.localScale.y > 1 && transform.localScale.z > 1)
        {
            transform.localScale = transform.localScale + new Vector3(-scale, -scale,-scale);
        }

    }
}
