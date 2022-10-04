//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using Unity.LEGO.Game;
//using UnityEngine.UI;
//using UnityEngine.SceneManagement;

//public class UATS : MonoBehaviour
//{
//    public Button btn;

//    private void Awake()
//    {
//        //승리 이벤트를 청취
//        EventManager.AddListener<MyWinEvent>((evt) =>
//        {
//            //evt :
//            Debug.LogFormat("승리 -> score : {0}", evt.score);
//            SceneManager.LoadSceneAsync("TestWin").completed += (oper) =>
//            {
//                TestWin testWin = GameObject.FindObjectOfType<TestWin>();
//                testWin.Init(evt.score);
//                testWin.Play();

//                testWin.btnReplay.onClick.AddListener(() =>
//                {
//                    //인게임 씬 로드
//                    Debug.Log("인게임씬 로드");
//                });
//            };
//        });

//        this.btn.onClick.AddListener(() => {
//            Debug.Log("승리 이벤트 전달");
//            MyWinEvent evt = new MyWinEvent(1000);
//            EventManager.Broadcast(evt);
//            //EventManager.Broadcast();
//        });
//    }

//    // Start is called before the first frame update
//    void Start()
//    {
        
//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }
//}
