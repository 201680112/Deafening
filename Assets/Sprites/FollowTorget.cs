using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTorget : MonoBehaviour {

    public Transform player1;
    public Transform player2;

    private Vector3 offset;
    private Camera camera;

	// Use this for initialization
	void Start () {
        offset = transform.position - (player1.position + player2.position) / 2;//玩家一和玩家二中间位置
        camera = this.GetComponent<Camera>();
		
	}
	
	// Update is called once per frame
	void Update () {
        if (player1 == null || player2 == null) return;
        transform.position = (player1.position + player2.position) / 2 + offset;//相机的位置是中间位置加上偏移
        float distance = Vector3.Distance(player1.position, player2.position);
        float size = distance * 0.56f;//相机的位置在两玩家的正交比例
        camera.orthographicSize = size;
		
	}
}
