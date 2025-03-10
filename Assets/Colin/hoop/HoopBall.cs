using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HoopBall : MonoBehaviour
{
    // Start is called before the first frame update
    private bool mInHoop = false;
    static int s_masterObjectID;
    static int done = 0;
    void Start()
    {
        mInHoop = false;
        s_masterObjectID = GetInstanceID();
    }

    // Update is called once per frame
    void Update()
    {
        if (GetInstanceID() == s_masterObjectID)
        {
            if (HoopStatus.Done())
            {
                SCENEManager.ChangeScene("Colin/Lvl01");
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("HoopTarget") && !mInHoop)
        {
            Debug.Log("HOOP !!!!! " + (done+1));
            done++;
            mInHoop = true;
            HoopStatus.Ball();
        }
    }
}
