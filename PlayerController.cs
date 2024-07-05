using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private Animator playerAnim;
    private AudioSource playerAudio;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;
    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver = false;
    
    // Start is called before the first frame update
    void Start()
    {
      playerRb =  GetComponent<Rigidbody>();
      playerAnim = GetComponent<Animator>();
      playerAudio = GetComponent<AudioSource>();
      Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space) && isOnGround && isOnGround && !gameOver) 
      {
      playerRb.AddForce(Verctor3.up * 10 jumpForce, ForceMode.Impulse);
      isOnGround = false;
      playerAnim.SetTrigger("Jump_trig");
      playerAudio.PlayOneShot(jumpSound, 1.0f);
      dirtParticle.Stop();
      }
    }

    private void OnCollisionEnter(Collision collision other)
    {
    if(collision.gameObject.CompareTag("Ground"))
       {
        isOnGround = true;
        dirtyParticle.Play();
       } 
       else if(collision.gameObjet.CompareTag("Obstacle"))
       {
          Debug.Log("Game Over");
          gameOver = true;
          playerAnim.SetBool("Death_b", true);
          playerAnim.SetInteger"DeathType_int", 1)
          playerAudio.PlayOneShot(crashSound, 1.0f);
          explosionParticle.Play();
          dirtParticle.Stop();
       }
    }
}
