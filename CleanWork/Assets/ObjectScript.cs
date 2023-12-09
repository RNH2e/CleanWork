using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;


public class ObjectScript : MonoBehaviour
{

    private void Update()
    {

    }
    ///-------------------------------- NORMAL�ZED ------ WASD HAREKET� ------------------------------------

    /// NORMAL�ZED  B�R VECTOR�N UZUNLU�UNU KORURKEN Y�N�N� DE���T�R�R. 1'E ORANLAR.
    /*
    public float moveSpeed = 10f;
    private Vector3 moveDirection;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Hareket y�n�n� hesapla
        moveDirection = new Vector3(horizontalInput, 0, verticalInput).normalized;
        Debug.Log(moveDirection);

        // Hareket y�n�ne g�re karakteri hareket ettir
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }*/


    //--------------------------------- INVERSE LERP ----------------------------------------------------

    /* orta deger = Lerp( ba�lang�� de�eri, biti� de�eri, oran);
     * oran = InverseLerp(ba�lang�� de�eri, biti� de�eri , orta de�er)
     * 
     * Yani lerpdeki mant���n ters hali. Lerpteki Float de�erle atanan de�erin yer de�i�imi.
     * */

    /// ------------------------------ B�R OBJEY� BEL�RL� B�R EKSENDE BEL�RL� DE�ERLER BOYUNCA HAREKET ETT�RME -----------------------
    /*
    private bool isDragging = false;
    private float minX = -5f;
    private float maxX = 5f; 

    private void OnMouseDown()
    {
        isDragging = true;
    }

    private void OnMouseDrag()
    {
        if (isDragging)
        {
            Vector3 newPosition = new Vector3(Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f)).x , transform.position.y, transform.position.z);
            newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX); // X de�erlerini s�n�rla
            transform.position = newPosition;
        }
    }

    private void OnMouseUp()
    {
        isDragging = false;
    }*/

    // ------------------------ EN BAS�T INPUT DRAG KULLANIMI ------------------------------------------
    /*
    Vector3 offset;
    private void OnMouseDown()
    {
        offset = transform.position - MouseWorldPosition();
    }
    private void OnMouseDrag()
    {
        transform.position = MouseWorldPosition() + offset;
    }
    Vector3 MouseWorldPosition()
    {
        var mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = Camera.main.WorldToScreenPoint(transform.position).z; // D�NYA KOORD�NATLARINI EKRN KOORD�NATLARINA �EV�R
        return Camera.main.ScreenToWorldPoint(mouseScreenPos);
    }*/


    ////------------------------- EN BAS�T LERP KULLANIMI -----------------------------------
    /*  float lerpValue;
    float speed = .5f;

    private void Update()
    {
        ScaleObject();
    }
    public void ScaleObject()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, Vector3.zero, lerpValue);
        lerpValue += Time.deltaTime * speed;
    }*/

    //------------------------------------------------- DRAG AND DROP METHODS -------------------------------------------------------------------
    /*
    Vector3 offset;
    public string destinationTag = "DropArea";
    float speed = 3f;
    bool isPlace;
    RaycastHit hitInfo;
    public float lerpValue;
    public GameObject spawnPos;
    private void OnMouseDown()
    {
        offset = transform.position - MouseWorldPosition();
        transform.GetComponent<Collider>().enabled = false;

    }

    private void OnMouseDrag()
    {
        transform.position = MouseWorldPosition() + offset;
    }
    private void Update()
    {
        if (isPlace)
        {
            transform.position = Vector3.Lerp(transform.position, hitInfo.transform.position, lerpValue);
            lerpValue = Time.deltaTime * speed * 4;
        }
        else 
        {
            transform.position = Vector3.Lerp(transform.position,spawnPos.transform.position, lerpValue);
            lerpValue = Time.deltaTime * speed * 2;
        }

        Debug.Log(isPlace);
    }

    private void OnMouseUp()
    {
        var rayOrigin = Camera.main.transform.position;
        var rayDirection = MouseWorldPosition() - Camera.main.transform.position;

     
        if (Physics.BoxCast(rayOrigin,Vector3.one,rayDirection,out hitInfo))
        {
            var place = hitInfo.transform.tag == destinationTag;
            Debug.Log(place);
            if (hitInfo.transform.tag == destinationTag)
            {
                isPlace = true;
            }
            if (hitInfo.transform.tag != destinationTag)
            {
                isPlace = false;
            }
         
        }

        transform.GetComponent<Collider>().enabled = true;
    }

    Vector3 MouseWorldPosition()
    {
        var mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mouseScreenPos);
    }
    */

    //----------------------- LERP MECH --------------------------------------------------------------------
    /*
     * 
     *      //// MAIN METHOD : 
     *      //// transform.position = Vector3.Lerp(transform.position, hitInfo.transform.position, lerpValue);
            //// lerpValue = Time.deltaTime * speed * 4;

    public AnimationCurve curve;
    public float target, current, speed =.5f;
    public Vector3 goalPos;
    public Vector3 goalRot;
    public float goalScale=2;*/

    /*  public void LerpFunc()
      {
          if (Input.GetMouseButtonDown(0))
          {
              target = target == 0 ? 1 : 0;
          }
          current = Mathf.MoveTowards(current, target, Time.deltaTime);

          transform.position = Vector3.Lerp(Vector3.zero, goalPos, curve.Evaluate(current));
          transform.rotation = Quaternion.Lerp(Quaternion.Euler(Vector3.zero), Quaternion.Euler(goalRot), curve.Evaluate(current));
          transform.localScale = Vector3.Lerp(Vector3.one, Vector3.one * goalScale, curve.Evaluate(Mathf.PingPong(current, .5f) * 2));
      }*/
}
