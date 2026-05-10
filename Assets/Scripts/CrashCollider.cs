using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashCollider : MonoBehaviour
{
     [SerializeField] float restartDelay = 1f;
     [SerializeField] ParticleSystem crashParticles;

     Player_Controller player_Controller;

    void Start()
    {
        player_Controller = FindFirstObjectByType<Player_Controller>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        int layerIndex = LayerMask.NameToLayer("Floor");

        if (collision.gameObject.layer == layerIndex)
        {
            player_Controller.DisableControls();
            crashParticles.Play();
            Invoke("ReloadScene", restartDelay);
        }

    }

    
        void ReloadScene()
    {
        SceneManager.LoadScene(0);  
    }

}
