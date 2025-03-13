using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HoopBall : MonoBehaviour
{
    // Start is called before the first frame update
    static string[] lvlNames =
    {
        "Colin/Lvl01",
        "Colin/Lvl00",
        "Colin/Fin",
    };
    private bool mInHoop = false;
    static int s_masterObjectID;
    static int done = 0;
    static int lvlId = 0;
    void Start()
    {
        mInHoop = false;
        s_masterObjectID = GetInstanceID();

        Dictionary<string, string> lvlScns = new Dictionary<string, string>()
        {
            { "scn0", "Colin/Lvl01" },
            { "scn1", "Colin/Lvl02" },
        };
    }

    // Update is called once per frame
    void Update()
    {
        if (GetInstanceID() == s_masterObjectID)
        {
            if (HoopStatus.Done())
            {
                SCENEManager.ChangeScene(lvlNames[lvlId++]);
                HoopStatus.Reset();
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
