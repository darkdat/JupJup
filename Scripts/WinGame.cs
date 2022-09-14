using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private AudioSource winSoundEffect;
    private Animator anim;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Win"))
        {
            PlayerManager.isWin = true;
            Win();
        }
    }
    private void Win()
    {
        rb.bodyType = RigidbodyType2D.Static;
        winSoundEffect.Play();
        anim.SetBool("isWin", PlayerManager.isWin);
    }
}
