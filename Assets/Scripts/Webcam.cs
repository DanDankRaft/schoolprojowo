using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Webcam : MonoBehaviour
{
    public Sprite wcamOutput;
    // Start is called before the first frame update
    public void EnableWebcam()
    {
        WebCamTexture wtexture = new WebCamTexture();
        wtexture.Play();
        GetComponent<MeshRenderer>().material.mainTexture = wtexture;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
