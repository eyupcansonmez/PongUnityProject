using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;

    public float startingSpeed;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

        //Bu, Ball objesindeki Rigidbody2D bileşenini rb değişkenine atayacaktır. 
        //Böylece, rb.velocity gibi işlemleri hatasız bir şekilde gerçekleştirebilirsin.

        bool isRight = UnityEngine.Random.value >= 0.5;
        float xVelocity = -1f;
        if(isRight == true)
    {

        xVelocity = 1f;
    }

    float yVelocity = UnityEngine.Random.Range(-1, 1);
    rb.velocity = new Vector2(xVelocity * startingSpeed,yVelocity * startingSpeed);

    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
