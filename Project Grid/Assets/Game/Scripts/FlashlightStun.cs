using System.Collections;
using System.Collections.Generic;
using MoreMountains.Tools;
using UnityEngine;

namespace MoreMountains.TopDownEngine
{
	/// <summary>
	/// A stun zone will stun any character with a CharacterStun ability entering it
	/// </summary>
	public class FlashlightStun : MonoBehaviour
	{
		[Header("Stun Zone")]
		// the layers that will be stunned by this object
		[Tooltip("the layers that will be stunned by this object")]
		public LayerMask TargetLayerMask;

		public float StunDuration = 2f;

		protected Character _character;
		protected CharacterStun _characterStun;
        
		/// <summary>
		/// When colliding with a gameobject, we make sure it's a target, and if yes, we stun it
		/// </summary>
		/// <param name="collider"></param>
		protected virtual void Colliding(GameObject collider)
		{
			if (!MMLayers.LayerInLayerMask(collider.layer, TargetLayerMask))
			{
				return;
			}

			_character = collider.GetComponent<Character>();
			if (_character != null) { _characterStun = _character.FindAbility<CharacterStun>(); }

			if (_characterStun == null)
			{
				return;
			}
        
			_characterStun.Stun();
            
		}

		/// <param name="collider"></param>
		protected virtual void DeStun(GameObject collider)
		{
			if (!MMLayers.LayerInLayerMask(collider.layer, TargetLayerMask))
			{
				return;
			}

			_character = collider.GetComponent<Character>();
			if (_character != null) { _characterStun = _character.FindAbility<CharacterStun>(); }

			if (_characterStun == null)
			{
				return;
			}
        
			_characterStun.ExitStun();
		}
        
		/// <summary>
		/// When a collision with the player is triggered, we give damage to the player and knock it back
		/// </summary>
		/// <param name="collider">what's colliding with the object.</param>
		// public virtual void OnTriggerStay2D(Collider2D collider)
		// {
		//     Colliding(collider.gameObject);
		// }

		/// <summary>
		/// On trigger enter 2D, we call our colliding endpoint
		/// </summary>
		/// <param name="collider"></param>S
		public virtual void OnTriggerEnter2D(Collider2D collider)
		{
			Colliding(collider.gameObject);
		}

		public virtual void OnTriggerExit2D(Collider2D collider)
		{
			DeStun(collider.gameObject);
		}

		/// <summary>
		/// On trigger stay, we call our colliding endpoint
		/// </summary>
		/// <param name="collider"></param>
		// public virtual void OnTriggerStay(Collider collider)
		// {
		//     Colliding(collider.gameObject);
		// }

		/// <summary>
		/// On trigger enter, we call our colliding endpoint
		/// </summary>
		/// <param name="collider"></param>
		public virtual void OnTriggerEnter(Collider collider)
		{
			Colliding(collider.gameObject);
		}
	}    
}