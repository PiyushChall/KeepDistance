using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DargThem : MonoBehaviour
{
    private bool AllowedMove;
    private Collider2D coll;
    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount> 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch.phase == TouchPhase.Began)
            {
                Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);
                if (coll = touchedCollider)
                {
                    AllowedMove = true;

                }
            }
            if(touch.phase == TouchPhase.Moved)
            {
                if (AllowedMove = true)
                {
                    transform.position = new Vector2(touchPosition.x, touchPosition.y);

                }
            }
            if(touch.phase == TouchPhase.Ended)
            {
                AllowedMove = false;
            }
        }
    }
}
