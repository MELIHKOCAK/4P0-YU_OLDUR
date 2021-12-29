using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playadudio : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip blink;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.Play();
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag =="ParaSes")
        {
            audioSource.PlayOneShot(blink, .7f);
        }
    }

}
