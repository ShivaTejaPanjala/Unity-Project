using UnityEngine;

public class BlockImpact : MonoBehaviour
{
    private AudioSource impactAudio;
    
    void Start()
    {
        impactAudio = GetComponent<AudioSource>();
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("Ball") && impactAudio != null)
            impactAudio.Play();
    }
}
