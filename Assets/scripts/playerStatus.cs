using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerStatus : MonoBehaviour
{

    private Rigidbody2D myrigid;
    private Animator animations;

    // Start is called before the first frame update
    private void Start()
    {
        animations = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Traps"))
        {
            Death();
        }
    }

    private void Death()
    {

        Debug.Log("Death");
        animations.SetTrigger("death");
        
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}


