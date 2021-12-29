using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sc : MonoBehaviour
{
    public float healtKarakter, bulletSpeed;

    bool dead = false;

    Transform muzzle;

    public Transform bullet;

    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        muzzle = transform.GetChild(0);
        slider.maxValue = healtKarakter;
        slider.value = healtKarakter;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            ShootBullet();
        }
    }

    public void GetDamage(float damage)
    {
       
        if ((healtKarakter - damage) >= 0)
        {
            healtKarakter -= damage;
        }
        else
        {
            healtKarakter = 0;
        }
        slider.value = healtKarakter;
        AmIDead();
    }

    void AmIDead()
    {
        if (healtKarakter <= 0)
        {
            dead = true;
        }
    }

    void ShootBullet()
    {
        Transform tempBullet;
        tempBullet = Instantiate(bullet, muzzle.position, Quaternion.identity);
        tempBullet.GetComponent<Rigidbody2D>().AddForce(muzzle.forward * bulletSpeed);
    }
}

