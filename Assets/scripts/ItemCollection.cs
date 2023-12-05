using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollection : MonoBehaviour
{
    private int moonCounter = 0;

    [SerializeField] private Text moonCounterText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Moon"))
        {
            Destroy(collision.gameObject);
            moonCounter++;
            moonCounterText.text = "Moons: " + moonCounter;
        }
    }
}
