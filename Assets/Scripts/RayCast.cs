using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{

    public Camera camaraPrincipal;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Rayo();
        }
    }

    void Rayo()
    {
        Ray ray = camaraPrincipal.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitRayo;

        if(Physics.Raycast(ray, out hitRayo, Mathf.Infinity))
        {
            Debug.DrawLine(Camera.main.transform.position, hitRayo.point);
            
            if(hitRayo.transform.gameObject.layer == 6)
            {
                Debug.Log("hit cube1");
                
                
            }

            if(hitRayo.transform.gameObject.layer == 7)
            {
                Debug.Log("hit cube2");
                
            }

            if(hitRayo.transform.gameObject.layer == 8)
            {
                Debug.Log("hit sphere");
                
            }
        } 
    }

    
}
