using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyForTiome : MonoBehaviour {
    public float time;

	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, time);//经过一定时间子弹自动销毁
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
