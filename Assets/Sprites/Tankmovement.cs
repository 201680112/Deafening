using UnityEngine;
using System.Collections;


public class Tankmovement : MonoBehaviour {


    public float speed=5; //移动速度
    public float angularspeed = 30;//旋转速度
    public float number = 1;   //添加一个玩家的编号，通过编号不同区分不同的控制
    public AudioClip idleAudio;
    public AudioClip drivingAudio;
    private AudioSource audio;
    private Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
        rigidbody = this.GetComponent<Rigidbody>();
        audio = this.GetComponent<AudioSource>();
	}

    private void FixedUpdate(){

        float v = Input.GetAxis("VerticalPlayer" + number); //坦克的垂直移动操作设定 括号内是区分坦克一二的操作
        rigidbody.velocity = transform.forward * v * speed; //移动的代码公式


        float h = Input.GetAxis("HorizontalPlayer"+number); //坦克的水平移动操作设定 括号内是区分坦克一二的操作
        rigidbody.angularVelocity = transform.up * h * angularspeed; //旋转的代码公式

        if (Mathf.Abs(h) > 0.1 || Mathf.Abs(v) > 0.1){
            audio.clip = drivingAudio;//按键按下播放坦克运动音效
            if (audio.isPlaying==false)
            audio.Play();
        }
        else
        {
            audio.clip = idleAudio;
            if (audio.isPlaying == false)
                audio.Play();
        }
    }
}

