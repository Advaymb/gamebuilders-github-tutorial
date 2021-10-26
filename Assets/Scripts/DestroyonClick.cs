using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyonClick : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit)) {
                if (hit.transform.name == "Player")
                {
                    Destroy(gameObject);
                    Debug.Log("Time survived: " + Time.time + "s");
                }
            }
        }
        
    }
}
