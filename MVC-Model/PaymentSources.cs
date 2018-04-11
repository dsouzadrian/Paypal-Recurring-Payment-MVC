﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;

namespace MVC_Model
{
    class PaymentSources
    {
        private IWebElement radioBt;
        private IWebElement paymentSourceName;
        //private RadioButton paySourceRdBt;

        public IWebElement RadioBt { get => radioBt; set => radioBt = value; }
        public IWebElement PaymentSourceName { get => paymentSourceName; set => paymentSourceName = value; }
        //public RadioButton PaySourceRdBt { get => paySourceRdBt; set => paySourceRdBt = value; }
    }
}
