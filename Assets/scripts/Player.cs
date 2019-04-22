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
    SceneData sceneData = new SceneData();

    Rigidbody2D rb;
    // Start is called before the first frame update
    
    void Start()
    {
     //getting the component
     rb = GetComponent<Rigidbody2D>();
     healthValue = sceneData.healthCount;   

    }

    // Update is called once per frame

    private void Update(){
        
    }
    void FixedUpdate()
    {
        //storing player input on the X axis
        inputX = Input.GetAxisRaw("Horizontal");
        print (inputX);

        //storing player input on the Y axis
        inputY = Input.GetAxisRaw("Vertical");
        print (inputY);

        //moving the player character on the X axis
        rb.velocity = new Vector2(inputX * speed, rb.velocity.y);

        //moving the player on the Y axis
        rb.velocity = new Vector2(rb.velocity.x, inputY * speed);
    }
    
    //player colliding with coin
    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Coin")){
            SFXManager.instance.ShowCoinParticles(other.gameObject);
            AudioManager.instance.PlaySoundCoinPickup(other.gameObject);
            Destroy(other.gameObject);
            LevelManager.instance.IncrementCoinCount();
        }
        //player losing health
        else if(other.gameObject.layer == LayerMask.NameToLayer("Enemies")) {
            AudioManager.instance.PlaySoundHealthLoss(gameObject);
            LevelManager.instance.DecreaseHealth();
            IEnumerator Delay(){
            yield return new WaitForSeconds(waitTime);
        
        }
            if(healthValue <= 0) { 
                Camera.main.GetComponentInChildren<AudioSource>().mute=true;
                LevelManager.instance.SetTapeSpeed(0);
                AudioManager.instance.PlaySoundHealthLoss(gameObject);
                Destroy(gameObject);
            }
        
    }

    
} }


