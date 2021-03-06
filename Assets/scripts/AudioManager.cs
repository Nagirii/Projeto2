﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
   public static AudioManager instance;
   public AudioSFX audioSFX;

   void Awake()
   {
       if(instance == null){
           instance = this;
       }
   }

   public void PlaySoundCoinPickup(GameObject obj){
       AudioSource.PlayClipAtPoint(audioSFX.coinPickup, obj.transform.position);
   }

   public void PlaySoundHealthLoss(GameObject obj) {
       AudioSource.PlayClipAtPoint(audioSFX.oof, obj.transform.position);
   }

   public void PlaySoundComplete(GameObject obj) {
       AudioSource.PlayClipAtPoint(audioSFX.Complete, obj.transform.position);
   }
}
