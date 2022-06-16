using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Hero hero = collision.gameObject.GetComponent<Hero>();
        if (hero != null)
        {
            FindObjectOfType<Hero>().Die();
        }
    }
}
