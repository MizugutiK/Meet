using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
  float px;

    void Update()
    {
        px = GameObject.Find("Player").transform.position.x;
        this.transform.position = new Vector3(px+4, 0,-10); ;

       
    }

}