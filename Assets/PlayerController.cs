using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // ¶–îˆó‚ª‰Ÿ‚³‚ê‚½‚Æ‚«
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.01f, 0, 0); //¶‚É‚R“®‚©‚·
        }
    

        //‰E–îˆó‚ª‰Ÿ‚³‚ê‚½‚Æ‚«
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.01f, 0, 0); //‰E‚É‚R“®‚©‚·
        }
       

       
        
    }

    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0);
    }

    public void RButtonDown()
    {
        transform.Translate(3, 0, 0);
    }
}

