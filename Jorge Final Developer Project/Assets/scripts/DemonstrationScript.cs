using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonstrationScript : MonoBehaviour
{
    public float speed;
    public GameObject Espada;
    // Update is called once per frame
    void Update()
    {
        Move();
        Wepon();
    }
    void Move()
    {
        Vector3 movimento = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
        transform.position += movimento * Time.deltaTime * speed;
    }
    void Wepon()
    {
        if (Input.GetAxis("Vertical") < 0 && Input.GetAxis("Horizontal") == 0)
        {
            Espada.transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        if (Input.GetAxis("Horizontal") > 0 && Input.GetAxis("Vertical") == 0)
        {
            Espada.transform.eulerAngles = new Vector3(0f, 0f, 90f);
        }
        if (Input.GetAxis("Vertical") > 0 && Input.GetAxis("Horizontal") == 0)
        {
            Espada.transform.eulerAngles = new Vector3(0f, 0f, 180f);
        }
        if (Input.GetAxis("Horizontal") < 0 && Input.GetAxis("Vertical") == 0)
        {
            Espada.transform.eulerAngles = new Vector3(0f, 0f, 270f);
        }
        
        if (Input.GetButtonDown("Fire1"))
        {
            StartCoroutine("WeponButon");
        }
    }
    IEnumerator WeponButon()
    {
        Espada.SetActive(true);
        yield return new WaitForSeconds(0.45f);
        Espada.SetActive(false);
    }
}