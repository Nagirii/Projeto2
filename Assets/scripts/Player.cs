using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   
    public float speed;
    private float inputX;
    private float inputY;
    private int healthValue;
    public float waitTime = 1f;
    public float fallLimit = 2f;
    SceneData sceneData = new SceneData();

    Rigidbody2D rb;
    Animator anim;
    // Start is called before the first frame update
    
    void Start()
    {
     //getting the component
     rb = GetComponent<Rigidbody2D>();
     anim = GetComponent<Animator>();
     healthValue = sceneData.healthCount;   

    }

    void Update(){
    if (rb.velocity.y < fallLimit){
        anim.SetInteger("State", 0);
      }
    }
    
    
        void KillPlayer(){
            AudioManager.instance.PlaySoundHealthLoss(gameObject);
                SFXManager.instance.ShowDieParticles(gameObject);
                DestroyPlayer();
        }
        void StopTapeAndMusic(){ 
             Camera.main.GetComponentInChildren<AudioSource>().mute=true;
                LevelManager.instance.SetTapeSpeed(0);
        }
    
        //player colliding with coin
    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Coin")){
            SFXManager.instance.ShowCoinParticles(other.gameObject);
            AudioManager.instance.PlaySoundCoinPickup(other.gameObject);
            Destroy(other.gameObject);
            LevelManager.instance.IncrementCoinCount();
            Impulse(10);
        }
          
        //player losing health
        else if(other.gameObject.layer == LayerMask.NameToLayer("Enemies")) {
            AudioManager.instance.PlaySoundHealthLoss(gameObject);
            KillPlayer();
            StopTapeAndMusic();
            LevelManager.instance.ShowGOPanel();
        }
        
        else if(other.gameObject.CompareTag("Gift")){
            StopTapeAndMusic();
            AudioManager.instance.PlaySoundComplete(gameObject);
            DestroyPlayer();
            LevelManager.instance.ShowLCPanel();
            
    

        }
    } 
    
    void Impulse(float force){
        rb.velocity = Vector3.zero;
        rb.AddForce(Vector3.up * force, ForceMode2D.Impulse);
        anim.SetInteger("State", 1);
    }
    void DestroyPlayer (){
        Camera.main.GetComponent<CameraFollow>().TurnOff();
        Destroy(gameObject);
    }

    
}
 