using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollection : MonoBehaviour
{
    PlayerController player_scripts;
    [SerializeField] private AudioSource growSoundEffect;

    private void Start()
    {
        player_scripts = GetComponent<PlayerController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Food"))
        {
            growSoundEffect.Play();
            Destroy(collision.gameObject);
            Grow();
            
        }
    }

    private void Grow()
    {
        transform.localScale = new Vector2(transform.localScale.x * 1.1f, transform.localScale.y * 1.1f);
        player_scripts.movementSpeed *= 1.1f;
        player_scripts.jumpForce *= 1.15f;
        player_scripts.groundCheckRadius *= 1.05f;
    }
}
