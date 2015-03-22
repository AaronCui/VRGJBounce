using UnityEngine;
using System.Collections;

public class trigger : MonoBehaviour {

	private float TIMEMAX = 5.0f;
    private float DEGREE = 0.7f;
	private float dt;
	private bool seen;
	// Use this for initialization
	void Start () {

		seen = false;
	}

	void OnBecameVisible(){
		seen = true;
		Debug.Log("in");
	}

	void OnBecameInvisible() {
		seen = false;
		Debug.Log("out");
	}

	void outDegree(){

        Vector3 objToCam = transform.position - Camera.main.transform.position;
        Vector3 flatObjToCam = new Vector3(objToCam.x, 0 ,objToCam.z);
        
        Vector3 camForward = Camera.main.GetComponentInParent<Transform>().forward;
        Vector3 flatCamForward = new Vector3(camForward.x, 0, camForward.z);

        Vector3 crossp = Vector3.Cross(flatObjToCam.normalized, flatCamForward.normalized);
        float degree = Mathf.Asin(crossp.magnitude);

		Debug.Log (camForward);
        //Debug.Log(degree + ", " + crossp);
		if (degree >= DEGREE || camForward.z <= 0)
        {
            seen = false;
			Debug.Log ("out");
          
        }
        else
        {
			Debug.Log("in");
            seen = true;
        }

	}
	// Update is called once per frame
	void Update () {

	
        outDegree();
		if ( seen )
		{
			dt += Time.deltaTime;
			//Debug.Log(dt);
			if( dt >= TIMEMAX ){
				//trigger certain event
				Debug.Log ("hi");
				GetComponent<BallGenerator>().enabled = true;
				dt = 0.0f;
			}

		}
		else
		{
			dt = 0.0f;
		
		}

	}
}
