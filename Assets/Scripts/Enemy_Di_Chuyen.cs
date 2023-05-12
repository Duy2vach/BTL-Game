using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Di_Chuyen : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject poinSprite;
    [Header("ping pong settings")]
    Vector2 startPos;
    public bool backAndForth;
    public float travelDistance;
    private bool reverse;
    public bool x;
    private bool y;


    void Start()
    {
        startPos = transform.position;

    }

    void Update()
    {
        if (backAndForth)
        {
            if (x)
                transform.position = new Vector2(startPos.x - Mathf.PingPong(Time.time, travelDistance), transform.position.y);
            if (y)
                transform.position = new Vector2(transform.position.x, startPos.y - Mathf.PingPong(Time.time, travelDistance));
        }
        else
        {
            if (x)
                transform.position = new Vector2(startPos.x + Mathf.PingPong(Time.time, travelDistance), transform.position.y);
            if (x)
                transform.position = new Vector2(transform.position.x, startPos.y + Mathf.PingPong(Time.time, travelDistance));
        }
    }
}
