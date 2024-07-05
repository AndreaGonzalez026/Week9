using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private Animator playerAnim;
    public ParticleSystem explosionParticle;
    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver = false;
    
    // Start is called before the first frame update
    void Start()
    {
      playerRb =  GetComponent<Rigidbody>();
      playerAnim = GetComponent<Animator>();
      Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space) && isOnGround && isOnGround && !gameOver) 
      {
      playerRb.AddForce(Verctor3.up * 10 jumpForce, ForceMode.Impulse);
      isOnGround = false;
      animator.SetTrigger("Jump_trig");
      }
    }

    private void OnCollisionEnter(Collision collision other)
    {
    if(collision.gameObject.CompareTag("Ground"))
       {
        isOnGround = true;
       } 
       
       else if(collision.gameObjet.CompareTag("Obstacle"))
       {
          Debug.Log("Game Over");
          gameOver = true;
          playerAnim.SetBool("Death_b", true);
          playerAnim.SetInteger"DeathType_int", 1)
          explosionParticle.Play();
       }
    }
}
