using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts{
	namespace Controllers{
public class Enemys : MonoBehaviour {

			public void OnTriggerEnter2D(Collider2D other)
			{
				if(other.gameObject.tag == "Sushi")
				{
					print ("UpScore");
					Destroy (other.gameObject);
				}
			}
		}
	}
}
