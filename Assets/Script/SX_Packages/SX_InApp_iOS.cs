////////////////////////////////////////////////////////////////////////////////
//  
// @module IOS Native Plugin for Unity3D 
// @author Osipov Stanislav (Stan's Assets) 
// @support stans.assets@gmail.com 
//
////////////////////////////////////////////////////////////////////////////////

using System;
using UnityEngine;
using SA.iOS.StoreKit;
using SA.iOS.Examples;


    public class SX_InApp_iOS : MonoBehaviour 
    {

        private static SX_BillingClient_iOS s_paymentManager;


        private void Start()
        {

#if UNITY_ANDROID
            GetComponent<SX_InApp_iOS>().enabled = false;
#endif

        if (s_paymentManager == null)
            {
                s_paymentManager = new SX_BillingClient_iOS();
            }


            s_paymentManager.init();
        }


        public void Purchase(string ProductId)
        {

            if (ProductId == "page_1")
                ProductId = "wfw_vip3_page_1";
            if (ProductId == "page_2")
                ProductId = "wfw_vip3_page_2";
            if (ProductId == "page_3")
                ProductId = "wfw_vip3_page_3";
            if (ProductId == "page_4") 
                ProductId = "wfw_vip3_page_4";


            if (ProductId == "wfw2_p1")
                ProductId = "wfw3vip_1000";
            if (ProductId == "wfw2_p2")
                ProductId = "wfw3vip_2200";
            if (ProductId == "wfw2_p3")
                ProductId = "wfw3vip_3600";
            if (ProductId == "wfw2_p4")
                ProductId = "wfw3vip_5200";
            if (ProductId == "wfw2_p5")
                ProductId = "wfw3vip_7000";

        ISN_SKPaymentQueue.AddPayment(ProductId);
        }

    }
