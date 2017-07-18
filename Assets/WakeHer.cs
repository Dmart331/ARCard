using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WakeHer : MonoBehaviour {
    public GameObject Avatar;

	// Use this for initialization
	void Start () {
        Avatar.SetActive(false);
        StartCoroutine(Wake());
	}
	
    IEnumerator Wake()
    {
        yield return new WaitForSeconds(4);
        Avatar.SetActive(false);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
