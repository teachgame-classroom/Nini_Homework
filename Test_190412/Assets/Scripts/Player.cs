using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 8;

    private Transform shotPosTrans;

    public GameObject bullet;

    private GameObject explosionPrefab;

    public int hp = 1;

    // Start is called before the first frame update
    void Start()
    {
        explosionPrefab = Resources.Load<GameObject>("Prefabs/PlayerDieEffect");

        shotPosTrans = transform.Find("ShotPos");
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.position += (Vector3.right * h + Vector3.up * v) * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.J))
        {
            Shoot();
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            Hurt();
        }

    }

    void Shoot()
    {
        Instantiate(bullet, shotPosTrans.position, Quaternion.identity);
    }


    void Hurt()
    {
        if (hp <= 0)
        {
            Destroy(gameObject);

        }
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
