using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScenJump : MonoBehaviour
{


	void Start()
	{

	}


	void Update()
	{
		if (Input.GetMouseButtonDown(0))    // 左マウスボタンをクリックしたら
		{
			SceneManager.LoadScene("GameScene");    // GameSceneに移動
		}
	}
}
