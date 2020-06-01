using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public float Yincrement;
    public float speed;
    public float MaxHeight;
    public float MinHeight;
    public int health = 3;
    public GameObject effect;
    public Text healthdis;
    public GameObject gameOver;
    public GameObject movSound;


    void Update()
    {
        healthdis.text = health.ToString();
        if (health <= 0)
        {
            gameOver.SetActive(true);
            Destroy(gameObject);
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < MaxHeight)
        {
            Instantiate(movSound, transform.position, Quaternion.identity);
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);

            
        } else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > MinHeight )
        {
            Instantiate(movSound, transform.position, Quaternion.identity);
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            
        }

    }
}
