using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody ball;
    public float BallForce;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text =  ball.position.z.ToString("0");
        ball.AddForce(0f, 0f, BallForce);

        if (Input.GetAxis("Horizontal") > 0)
        {
            ball.AddForce(BallForce, 0f, 0f);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            ball.AddForce(-BallForce, 0f, 0f);
        }
        if (ball.position.y < -3 || ball.position.z >500)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}