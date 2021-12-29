using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float healtkarakter;

    bool dead = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetDamage(float damage)
    {
        if ((healtkarakter-damage) >= 0)
        {
            healtkarakter -= damage;
        }
        else
        {
            healtkarakter = 0;
        }
        AmIDead();
    }

    void AmIDead()
    {
        if (healtkarakter <= 0)
        {
            dead = true;
        }
    }
}
