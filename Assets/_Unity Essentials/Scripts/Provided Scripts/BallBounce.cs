using UnityEngine;

public class BallBounce : MonoBehaviour
{
    private AudioSource bounceAudio;
    
    void Start()
    {
        bounceAudio = GetComponent<AudioSource>();
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > 2f && bounceAudio != null)
            bounceAudio.Play();
    }
}
