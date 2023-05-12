using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cau_di_chuyen_doc : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject poinSprite;
    [Header("ping pong settings")]
    Vector2 startPos;
    public bool backAndForth;
    public float travelDistance;
    private bool reverse;
    private bool x;
    public bool y;


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
