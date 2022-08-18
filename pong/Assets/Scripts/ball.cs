using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    public float speed;
    Rigidbody2D RB;
    public Text player2_text, player1_text;
    public int score = 0;
    public int increment = 1;
    void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.name == "Border_right")
        {
            score = score + increment;
            player1_text.text = score.ToString();
        }
        else if (trigger.name == "Border_left")
        {
            score = score + increment;
            player2_text.text = score.ToString();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        RB = this.GetComponent<Rigidbody2D>();
        Launch();
        void Update()
        {
        }

        void Launch()
        {
            float direction = Random.Range(0, 1);
            if (direction == 0f)
            {
                RB.velocity = new Vector2(-speed, 0);
            }
            else
            {
                RB.velocity = new Vector2(speed, 0);
            }
        }
    }
}
