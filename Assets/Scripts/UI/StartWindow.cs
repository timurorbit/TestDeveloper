using CookingPrototype.Controllers;
using TMPro;
using UnityEngine;

namespace CookingPrototype.UI {
	public class StartWindow : MonoBehaviour {
		
		[SerializeField]
		public TMP_Text ordersGoalText;

		public void Hide() {
			gameObject.SetActive(false);
		}

		public void Show() {
			var gc = GameplayController.Instance;
			gc.PauseGame();
			if ( ordersGoalText ) {
				ordersGoalText.text = $"{gc.OrdersTarget}";
			}

			gameObject.SetActive(true);
		}

		public void StartGame() {
			GameplayController.Instance.UnPauseGame();
			Hide();
		}
	}
}