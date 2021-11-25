using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Make_Pipe : MonoBehaviour
{
    public GameObject Pipe;
    float timer = 0;
    public float timeDiff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > timeDiff)
        {
            GameObject newpipe = Instantiate(Pipe);
            newpipe.transform.position = new Vector3(6, Random.Range(-1.7f, 4f), 0);
            timer = 0;
            Destroy(newpipe,15.0f);

            if (Score.score == 25)
            {
                timeDiff = timeDiff - 0.5f;
            }

            else if (Score.score == 50)
            {
                timeDiff = timeDiff - 0.5f;
            }
            else if (Score.score == 100)
            {
                timeDiff = timeDiff - 0.5f;
            }

            else if (Score.score == 150)
            {
                timeDiff = timeDiff - 0.5f;
            }

            else if (Score.score == 200)
            {
                timeDiff = timeDiff - 0.5f;
            }

            else if (Score.score == 500)
            {
                timeDiff = timeDiff - 0.5f;
            }
        }
    }
}
