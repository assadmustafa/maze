using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerReversed : MonoBehaviour
{
    [SerializeField]
    GameObject door;
    [SerializeField]
    GameObject button;
    bool isOpened = false;

    private void OnTriggerEnter(Collider other)
    {
        // Get the Renderer component from the new cube
        var cubeRenderer = button.GetComponent<Renderer>();

        if (!isOpened)
        {
            isOpened = true;// Call SetColor using the shader property name "_Color" and setting the color to red
            cubeRenderer.material.SetColor("_Color", Color.green);
            //this.button.transform.position += new Vector3(0, -1, 0);
            door.transform.position += new Vector3(0, 1, 0);
        }
    }
}
