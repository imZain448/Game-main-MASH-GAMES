using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    private bool BgActive = false;
    public Image backGround;
    public AudioClip ClickSound;
    // Start is called before the first frame update
    void Start()
    {
        backGround.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(BgActive)
        {
            backGround.enabled = true;
            gameObject.GetComponent<AudioSource>().PlayOneShot(ClickSound);
        }
    }
    private void OnMouseDown()
    {
        BgActive = true;
    }

    private void OnMouseUp()
    {
        BgActive = false;
    }
}
