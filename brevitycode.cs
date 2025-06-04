using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brevitycode : MonoBehaviour
{
    public GameObject whiteSquare;
    public Camera cam;
    public Color black;
    public AudioClip blip;
    AudioSource aS;

    void Start()
    {
        cam.clearFlags = CameraClearFlags.SolidColor;
        aS = whiteSquare.GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        gameObject.SetActive(false);
        cam.backgroundColor = black;
        aS.PlayOneShot(blip, 1F);
    }
}
