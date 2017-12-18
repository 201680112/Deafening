using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankHealth : MonoBehaviour {
    public int hp = 100; //坦克总血量为100
    public GameObject tankExplosion;
    public AudioClip tankExplosionAudio;

    public UnityEngine.UI.Slider hpSlider;
    private int hpTotal;

	// Use this for initialization
	void Start () {
        hpTotal = hp;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
        void TakeDamage(){
        if (hp <= 0) return;
        hp-= Random.Range(10,20);//收到攻击后坦克扣血量在十到二十之间
          hpSlider.value = (float)hp/hpTotal;//血条的计算
        if (hp <= 0) { //收到伤害之后 血量为0 控制死亡特效
            AudioSource.PlayClipAtPoint(tankExplosionAudio,transform.position);//坦克爆炸时的声音
            GameObject.Instantiate(tankExplosion, transform.position + Vector3.up, transform.rotation);
            GameObject.Destroy(this.gameObject);//当血量为0后将自身销毁
        }

    }
}
