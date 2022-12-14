using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;
    private Rigidbody2D rig;
    public Vector2 resetPosition;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
    }

    public void ActivatePUSpeedUp (float magnitude)
    {
        rig.velocity *= magnitude;
    }
    // Update is called once per frame
    void Update()
    {
        //3 cara menagatur movement
        //transform.position = transform.position + (new Vector3(1f, 0, 0) * Time.deltaTime);
        //transform.Translate(new Vector3 (1f, 0, 0) * Time.deltaTime);
        //transform.Translate(speed * Time.deltaTime);

        
    }
}
