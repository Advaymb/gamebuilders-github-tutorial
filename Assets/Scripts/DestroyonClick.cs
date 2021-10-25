using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyonClick : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(gameObject);
        Debug.Log("Time survived: " + Time.time + "s");
    }
}
