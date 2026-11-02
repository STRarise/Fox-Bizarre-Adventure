using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform ShotPos;
    public GameObject Bullet;
    void Start()
    {

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            GameObject b = Instantiate(Bullet, ShotPos.position, Quaternion.identity);
            b.GetComponent<Bullet>().Launch(Mathf.Sign(transform.root.localScale.x));
        }
    }
}