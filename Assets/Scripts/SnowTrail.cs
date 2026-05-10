using UnityEngine;

public class SnowTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem snowParticles;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hit something");

        int layerIndex = LayerMask.NameToLayer("Floor");

        if (collision.gameObject.layer == layerIndex)
        {
            Debug.Log("Hit floor");
            snowParticles.Play();
        }
    }


    void OnCollisionExit2D(Collision2D collision)
     {
        int layerIndex = LayerMask.NameToLayer("Floor");

        if (collision.gameObject.layer == layerIndex)
        {
            snowParticles.Stop();
        }
    }

}



    
