using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flip : MonoBehaviour
{
    public GameObject bullet;
    GameObject bulletClone;
    SpriteRenderer sprite;
    bool FaceRight = true;
    public float speed;
    public Transform leftspawn;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        flipplayer();
        Fire();
    }
    void flipplayer()
    {
        if (Input.GetKeyDown(KeyCode.D) && FaceRight == false)
        {
            sprite.flipX = false;
            FaceRight = true;

        }

        else if (Input.GetKeyDown(KeyCode.A) && FaceRight == true)
        {
            sprite.flipX = true;
            FaceRight = false;

        }
    }
    void Fire()
    {
        if (Input.GetMouseButtonDown(0) && FaceRight)
        {
            bulletClone = Instantiate(bullet, transform.position, transform.rotation);
            bulletClone.GetComponent<Rigidbody2D>().velocity = transform.right * speed;
            Destroy(bulletClone, 1.5f);
        }
        else if (Input.GetMouseButtonDown(0) && !FaceRight)
        {
            bulletClone = Instantiate(bullet, leftspawn.position, leftspawn.rotation);
            bulletClone.GetComponent<Rigidbody2D>().velocity = transform.right * -speed;
            Destroy(bulletClone, 1.5f);
        }
    }
}
