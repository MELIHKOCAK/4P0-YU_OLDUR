using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyManager : MonoBehaviour
{
    public float health;
    public bool dead = true;
    public float sawDamage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    private void OnTriggerEnter2D(Collider2D collision)     //gameobjemin colliderın içine girilince anda yapılacak işlemleri bu metot yardımı ile yapıyorum.
    {
        if (collision.tag=="Player")
        {
            SceneManager.LoadScene("deadScene");
        }
        
    }

}
