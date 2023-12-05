using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCollision : MonoBehaviour
{
    public ParticleSystem collisionParticles; // Reference to the Particle System

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Activate the particle effect when the player collides with the door
            Debug.Log("hellow");
            collisionParticles.Play();

            // Additional actions like disabling player movement, triggering UI, etc., can be added here.
        }
    }
}


