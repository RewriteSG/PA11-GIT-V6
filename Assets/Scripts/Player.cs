using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    Vector3 Top, Bottom;
    float offset;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Top = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, transform.position.z));
        Bottom = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, transform.position.z));
        offset = transform.lossyScale.y / 2;
    }

    // Update is called once per frame
    void Update()
    {

        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, Bottom.y + offset, Top.y - offset), transform.position.z);

        if (rb.IsSleeping())
        {
            rb.WakeUp();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (GameManager.instance.Spawnerscript.SpawnedObjects.Contains(collision.gameObject))
        {
            GameManager.instance.LoseGame();
        }
    }
}
