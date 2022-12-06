using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Transform bullet;//Player bullet transform
    public float speed;//Bullet speed

    public GameManager gameManager;

    void Start()
    {
        bullet = GetComponent<Transform>();//Take the bullet transform
        gameManager = FindObjectOfType<GameManager>();
    }

    private void FixedUpdate() //To check every frame the bullet is running 
    {
        bullet.position += Vector3.up * speed; //Move the bullet up 

        if (bullet.position.y >= 10)//Destroy the bullet if pas the top limit
            Destroy(gameObject);//destoys it 
    }

    private void OnTriggerEnter2D(Collider2D other)//Collision function
    { if(other.tag == "Enemy_egg" )//What do if it collider with enemy egg
        {
            Destroy(other.gameObject);//Destroy the enemy
            Destroy(gameObject);//destroys the bullet
            gameManager.playerScore += 10;//Plsyer score ups
        }
    
    else if (other.tag == "Enemy_milk")//What do if it collider with enemy milk
        {
            Destroy(other.gameObject);//Destroy the enemy
            Destroy(gameObject);//destroys the bullet
            gameManager.playerScore += 30;//Plsyer score ups
        }
    else if (other.tag == "Enemy_flour")//What do if it collider with enemy flour
        {
            Destroy(other.gameObject);//Destroy the enemy
            Destroy(gameObject);//destroys the bullet
            gameManager.playerScore += 20;//Plsyer score ups
        }
        
        else if(other.tag == "Base")//Collision with base
        {
            Destroy(gameObject);//destroys the bullet 

        }

    }

}
