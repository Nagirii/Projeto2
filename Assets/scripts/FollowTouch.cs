using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTouch : MonoBehaviour
{
     public GameObject particles;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)){
            Vector3 aux = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 position = new Vector3(aux.x, aux.y, 0);
            Instantiate(particles, position, Quaternion.identity);
        }
        
    }
}
