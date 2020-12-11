using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayCast_robot : MonoBehaviour
{
    Animator anim;
    //here
    public TextMesh obj_text_mesh_;
    public int atkPnt;
    public int hltPnt;

    float timeElapsed;
    // Start is called before the first frame update
    void Start()
    {
        //here
        obj_text_mesh_.text = "체력:" + hltPnt;
        anim = transform.GetComponent<Animator>();
        atkPnt = 1000;
        hltPnt = 5000;
    }

    // Update is called once per frame
    void Update()
    {
        obj_text_mesh_.text = "체력:" + hltPnt;

        //부딛치는 물체의 정보를 담는 변수 hit 선언
        RaycastHit hit;

        //forward 라는 이름의 방향변수 선언 및 대입
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 1000;

        //가상의 레이인 레이캐스트를 테스트 중에는 보일 수 있도록 함
        Debug.DrawRay(transform.position, forward, Color.green);

        //만약 레이케스트가 어떠한 물체에 맞는다면 hit라는 문구를 냄
        if (Physics.Raycast(transform.position, forward, out hit))
        {
            Debug.Log("hit");
            anim.SetBool("isHit", true);
            timeElapsed = timeElapsed + Time.deltaTime;
            if (timeElapsed >= 3) {
                hit.transform.GetComponent<rayCast_dragon>().hltPnt = hit.transform.GetComponent<rayCast_dragon>().hltPnt - atkPnt;
                timeElapsed = 0;
            }
        }
        else {
            anim.SetBool("isHit", false);

        }
        if (hltPnt <= 0)
        {
            anim.SetBool("isDead", true);
        }
    }
}
