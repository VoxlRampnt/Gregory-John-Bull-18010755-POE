using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed = 1;
    private float zoomSize = 5;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {// Controls the movement of the camera on the scene
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))// move camera up
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))// move camera down
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))// move camera right
        {
            transform.position += new Vector3(1, 0) * speed * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))// move camera left
        {
            transform.position += new Vector3(-1, 0) * speed * Time.deltaTime;
        }

        

        //
        //Controls the zoom function of the camera zoom
        if (Input.GetAxis("Mouse ScrollWheel") > 0) //will zoom out 
        {
            zoomSize -= 1;
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0) // will zoom in
        {
            zoomSize += 1;
        }

        GetComponent<Camera>().orthographicSize = zoomSize;
    }
}
