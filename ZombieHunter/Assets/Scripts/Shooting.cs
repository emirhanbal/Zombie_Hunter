using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Shooting : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    public Image healImage;
    private float ourHeal = 100f;
    Animator anim;
    void Start()
    {
        print("working");
        anim.GetComponent<Animator>();
    }
    //void Update()
    //{
        
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        //anim.SetTrigger("deneme");
    //        GetComponentInChildren<Animator>().Play("BowShot");
    //        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
    //        bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
    //    }
    //}

    public void buttonisWork()
    {
        GetComponentInChildren<Animator>().Play("BowShot");

        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
    }

    private void OnCollisionEnter(Collision c)
    {
        if (c.collider.gameObject.tag.Equals("enemy"))
        {
            Debug.Log("düsman saldýrýda");
            ourHeal -= 10f;
            float x = ourHeal / 100f;
            healImage.fillAmount = x;
            healImage.color = Color.Lerp(Color.red, Color.green, x);
            
            if (ourHeal == 0)
            {
                GetComponentInChildren<Animator>().Play("Death");
                Destroy(this.gameObject, 1.667f);
                SceneManager.LoadScene(2);
            }
        }
    }
}
