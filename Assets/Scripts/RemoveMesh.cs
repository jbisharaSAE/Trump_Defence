using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveMesh : MonoBehaviour
{
    private Renderer myRenderer;

    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
        myRenderer.enabled = false;
    }

    
}
