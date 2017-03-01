using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Scripts{
	namespace Controllers{
public class Score : MonoBehaviour {

			public int ScoreUp = 0;
			public Text Scoreplayer;
			public SpawnSushi spawnsushi;

			void Start()
			{
				spawnsushi = GetComponent<SpawnSushi> ();
			}


			void Update()
			{
				
			}
			public void OnTriggerEnter2D(Collider2D other)
			{
				if(other.gameObject.tag == "Sushi")
				{
					print ("UpScore");
					ScoreUp++;
					Scoreplayer.text = ScoreUp.ToString ();
					Destroy (other.gameObject);
					ScoresUp ();
				}
			}

			public void ScoresUp()
			{
//				spawnsushi.SushiCont--;
			}
				
		}
	}
}