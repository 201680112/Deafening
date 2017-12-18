using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAttack : MonoBehaviour {
public GameObject shellPrefab;
    public KeyCode fireKey = KeyCode.Space;//默认空格键发射
    public float shellSpeed = 10;//子弹发射的速度
    public AudioClip shotAudio;
        
    private Transform firePosition;

	// Use this for initialization
	void Start () {
     
        firePosition =transform.Find("FirePosition");
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(fireKey)) {//如果按键按下发射
            AudioSource.PlayClipAtPoint(shotAudio, transform.position);
           GameObject go = GameObject.Instantiate(shellPrefab, firePosition.position, firePosition.rotation)as GameObject;
            go.GetComponent<Rigidbody>().velocity = go.transform.forward * shellSpeed;

        }
    }
}
