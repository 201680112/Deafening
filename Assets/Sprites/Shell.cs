using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour {
    public GameObject shellExplosionPrefab;
    public AudioClip shellExplosionAudio;


    public void OnTriggerEnter(Collider collider){//跟那个碰撞器发生接触
        AudioSource.PlayClipAtPoint(shellExplosionAudio,transform.position);//子弹发射的声音
        GameObject.Instantiate(shellExplosionPrefab, transform.position, transform.rotation);//碰撞是触发子弹爆炸的特效
        GameObject.Destroy(this.gameObject);//把子弹自身销毁
        if(collider.tag=="Tank"){ //如果子弹碰撞的目标是坦克则坦克收到伤害
            collider.SendMessage("TakeDamage");
        }
}
}
