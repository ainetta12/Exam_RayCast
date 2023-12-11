using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RayCast : MonoBehaviour
{

    public Camera camera;


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
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitRayo;

        if(Physics.Raycast(ray, out hitRayo, Mathf.Infinity))
        {
            Debug.DrawLine(Camera.main.transform.position, hitRayo.point);
            
            if(hitRayo.transform.gameObject.layer == 6)
            {
                Debug.Log("hit cube1");
                SceneManager.LoadScene(1);
                
            }

            if(hitRayo.transform.gameObject.layer == 7)
            {
                Debug.Log("hit cube2");
                SceneManager.LoadScene(2);
                
            }

            if(hitRayo.transform.gameObject.layer == 8)
            {
                Debug.Log("hit sphere");
                SceneManager.LoadScene(3);
                
            }

            
        } 
    }

    
}
