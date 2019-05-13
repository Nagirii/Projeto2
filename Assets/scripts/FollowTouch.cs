using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTouch : MonoBehaviour
{
     public GameObject particles;
     public float lerpRate = 4f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1")){
            Vector3 aux = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 InitialPosition = transform.position;
            Vector3 FinalPosition = new Vector3(aux.x, transform.position.y, 0);

            transform.position = Vector3.Lerp(InitialPosition, FinalPosition, lerpRate * Time.deltaTime);
        }
        
    }
}
