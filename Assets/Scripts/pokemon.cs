using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pokemon : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    private float speed = 60f;
    private float heightUp = 1000f;
    public int countStars = 0;
    public Text scoreText;

    // Start is called before the first frame updatea
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float right = Input.GetAxis("Horizontal");
        if(right != 0)
        {
            var position = transform.position;
            position += Vector3.right * right * Time.deltaTime * speed;
            rigidbody.MovePosition(position);
        }

        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            var position = transform.position;
            position += Vector3.up * Time.deltaTime * heightUp;
            rigidbody.MovePosition(position);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Star"))
        {
            Destroy(other.gameObject);
            countStars++;
            scoreText.text = "Count of stars: " + countStars;
        }
    }
}
