using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class GameManager : MonoBehaviour
{

    ///////--------------------------------- BELÝRLÝ BÝR OBJEYLE KARE ÞEKÝL OLUÞTURMA MATRÝSÝ ----------------------------
   /* public List<GameObject> cubeList;
    public int value;
    public GameObject cube;
    void Start()
    {
        int shortEdge = Mathf.CeilToInt(Mathf.Sqrt(value));
        float dst = 1f;
        for (int i = 0; i < value; i++)
        {
            var a = Instantiate(cube, transform);
            a.transform.position = new Vector3((i % shortEdge) * dst, 0, (i / shortEdge) * dst) + new Vector3(-(shortEdge - 1) * dst * .5f, 0, -(value / shortEdge) * dst * .5f);
            a.name = "r" + i;
            Debug.Log(a.name);
        }

    }*/

    ////------------------------------------ DOTWEEN ÖRNEÐÝ ----------------------------------------------
    /*
    public List<Transform> cardList;
    public bool click;

    private Vector3 startPosition;
    private Vector3 endPosition;
    private Vector3 controlPoint;
    public float duration = 0.01f;

    public static GameManager Instance;

    private void Start()
    {

        // Ýlk pozisyonlarý belirleme iþlemini Start() fonksiyonunda yapabilirsiniz.
        for (int i = 0; i < cardList.Count; i++)
        {
            startPosition = cardList[i].position;
            endPosition = startPosition + new Vector3(2f, 0, 0f);
            controlPoint = cardList[i].position + new Vector3(1f, 1f, 0f);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(SendAcross());
        }
    }

    public IEnumerator SendAcross()
    {
        float offset = 0;
        for (int i = 0; i < cardList.Count; i++)
        {
            Vector3 scale = cardList[i].localScale;
            scale *= 2f;
            cardList[i].DOScale(scale, duration * 0.05f).OnComplete(() => cardList[i].DOScale(new Vector3(1, 0.1f, 1), duration * 0.05f));
            cardList[i].DOPath(new Vector3[] { startPosition, controlPoint, endPosition + new Vector3(0,offset-cardList[cardList.Count-1].transform.position.y,0) }, duration * 0.25f, PathType.CatmullRom).SetEase(Ease.OutQuad).OnComplete(OnCompleteMovement);
            cardList[i].DORotate(cardList[i].localRotation.eulerAngles + new Vector3(0, 0, -180), duration * 0.25f);
            yield return new WaitForSeconds(0.05f);
            offset += .15f;
        }
    }

    void OnCompleteMovement()
    {
        Debug.Log("Bezier eðrisi hareketi tamamlandý!");
    }
    */
    ///---------------------------------- INSTANTIATE ----------------------------------------------------------------

    /* public GameObject sphere;
     public List<GameObject> sphereList = new List<GameObject>();
     public int counter;
     public int newCounter;
     int sphereCount;

     private void Update()
     {
         Vector3 newPos = new Vector3(sphere.transform.position.x + counter, sphere.transform.position.y + counter, sphere.transform.position.z);
         if (sphereCount < 5)
         {
             if (Input.GetMouseButtonDown(0))
             {
                 var a = Instantiate(sphere, newPos, transform.rotation);
                 sphereList.Add(a);
                 sphereCount++;
                 counter++;
             }
         }
         Debug.Log(counter);
         if (sphereCount >= 5)
         {

             if (sphereCount < 10)
             {
                 Vector3 dirChange = new Vector3(sphereList[4].transform.position.x + newCounter, sphereList[4].transform.position.y - newCounter, sphereList[4].transform.position.z);
                 if (Input.GetMouseButtonDown(0))
                 {
                     Instantiate(sphere, dirChange, transform.rotation);
                     sphereCount++;
                     newCounter++;
                 }
             }

         }
     }*/

    /// --------------- HER CLICKTE DÝZÝDEN BÝR OBJEYÝ KAYBETME "DAHA FONKSÝYONEL YAZIMI"------------------- YESS!!
    /*
    public GameObject[] balls;
    public int counter = -1;
    float lerpValue, speed = .5f;
    bool click;

    private void Update()
    { 
        if (Input.GetMouseButtonDown(0))
        {    
            ++counter;  
            click = true;
        }

        if (counter < balls.Length && click)
        {
            balls[counter].transform.localScale =Vector3.Lerp(balls[counter].transform.localScale, Vector3.zero, lerpValue);
            lerpValue += Time.deltaTime * speed;

            if (balls[counter].transform.localScale == Vector3.zero)
            {
                Destroy(balls[counter]);
                lerpValue = 0;
                click = false;
            }
        }
    }*/

    ////---------------------------- HER CLICKTE BÝR ADET OBJE KAYBETME / LERP ILE KUCULTEREK KAYBETME ------------------------------------

    /*  public GameObject[] balls;
      public int counter;

      private void Update()
      {
          if (Input.GetMouseButtonDown(0))
          {
              if (counter < balls.Length)
              {
                  balls[counter].GetComponent<ObjectScript>().enabled = true;
                  // Destroy(balls[counter]);
                  counter++;
              }
          }

      }*/

}

