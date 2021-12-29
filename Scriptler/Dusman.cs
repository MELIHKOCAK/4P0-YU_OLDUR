using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dusman : MonoBehaviour
{
    public float health;
    public float damage;
    public Slider slider;
    bool colliderBusy = false;
    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = health;
        slider.value = health;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetDamages(float damage)
    {
        if ((health - damage) >= 0)
        {
            health -= damage;
        }
        else
        {
            health = 0;
        }
        slider.value = health;
        AmIDead();
    }

    void AmIDead()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && !colliderBusy)
        {
            colliderBusy = true;
            other.GetComponent<sc>().GetDamage(damage);
        }
        else if (other.gameObject.tag == "Bullet")
        {
            GetDamages(other.GetComponent<BulletManager>().bulletDamage);
            Destroy(other.gameObject);
        }
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            colliderBusy = false;

        }
    }

   
}
